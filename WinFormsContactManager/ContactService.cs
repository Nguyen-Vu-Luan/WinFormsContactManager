using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace WinFormsContactManager
{
    public class ContactService
    {
        private readonly string jsonPath = "data.json";
        private readonly string csvPath = "contacts.csv";

        public List<Contact> Load()
        {
            if (!File.Exists(jsonPath)) return new List<Contact>();
            var json = File.ReadAllText(jsonPath, Encoding.UTF8);
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }

        public void Save(List<Contact> contacts)
        {
            var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonPath, json, Encoding.UTF8);
        }

        public void ExportCsv(List<Contact> contacts)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Name,Phone,Email,Address");
            foreach (var c in contacts)
                sb.AppendLine(E(c.Name) + "," + E(c.Phone) + "," + E(c.Email) + "," + E(c.Address));

            File.WriteAllText(csvPath, sb.ToString(), Encoding.UTF8);

            System.Windows.Forms.MessageBox.Show("Đã xuất file CSV: " + csvPath);
        }


        public List<Contact> ImportCsv()
        {
            if (!File.Exists(csvPath)) return new List<Contact>();
            var lines = File.ReadAllLines(csvPath, Encoding.UTF8);
            var list = new List<Contact>();
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = ParseCsvLine(lines[i]);
                if (parts.Count >= 4)
                    list.Add(new Contact { Name = parts[0], Phone = parts[1], Email = parts[2], Address = parts[3] });
            }
            return list;
        }

        private static string E(string s)
        {
            if (s.Contains(",") || s.Contains("\"") || s.Contains("\n"))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private static List<string> ParseCsvLine(string line)
        {
            var res = new List<string>();
            var cur = new StringBuilder();
            bool q = false;
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (ch == '"')
                {
                    if (q && i + 1 < line.Length && line[i + 1] == '"') { cur.Append('"'); i++; }
                    else q = !q;
                }
                else if (ch == ',' && !q)
                {
                    res.Add(cur.ToString()); cur.Clear();
                }
                else cur.Append(ch);
            }
            res.Add(cur.ToString());
            return res;
        }
    }
}
