# 📒 WinForms Contact Manager

Ứng dụng **Quản lý danh bạ** viết bằng **C# WinForms**.  
Dự án này là một phần học tập và thực hành WinForms, quản lý dữ liệu cơ bản bằng JSON/CSV.

---

## 🚀 Chức năng chính

- Thêm, sửa, xóa liên hệ (Name, Phone, Email, Address).
- Hiển thị danh sách liên hệ bằng **DataGridView**.
- Tìm kiếm liên hệ theo **tên hoặc số điện thoại**.
- Lưu trữ dữ liệu vào **JSON** (`data.json`).
- Xuất dữ liệu ra **CSV** (`contacts.csv`).
- Nhập dữ liệu từ **CSV** trở lại ứng dụng.
- Nút **Clear** để xóa nhanh form nhập liệu.

---

## 🛠 Công nghệ sử dụng

- **C# .NET WinForms** (Visual Studio 2022)
- **System.Text.Json** để lưu dữ liệu JSON
- **CSV thủ công** để import/export
- **.NET 6/7** (có thể chạy trên Windows)

---

## 📂 Cấu trúc thư mục

```
WinFormsContactManager/
│── Contact.cs
│── ContactService.cs
│── MainForm.cs
│── MainForm.Designer.cs
│── Program.cs
│── data.json
│── contacts.csv
│── WinFormsContactManager.csproj
```

---

## ▶️ Cách chạy

1. Clone project về máy:
   ```bash
   git clone https://github.com/<your-username>/WinFormsContactManager.git
   ```
2. Mở bằng **Visual Studio 2022**.
3. Chọn **Build → Run (F5)** để chạy chương trình.
4. Dữ liệu sẽ được lưu tại:
   - `data.json`
   - `contacts.csv`

---

## 📊 Hướng dẫn Import/Export CSV bằng Excel

- **Export CSV**:  
  Khi nhấn nút **Export**, ứng dụng sẽ tạo file `contacts.csv` cùng thư mục chạy chương trình.  
  File này có thể mở trực tiếp bằng **Microsoft Excel** hoặc **Google Sheets**.

- **Import CSV**:  
  - Đặt file `contacts.csv` vào cùng thư mục chạy chương trình.
  - Nhấn nút **Import** trong ứng dụng để nạp dữ liệu trở lại.

⚠️ **Lưu ý**: File CSV sử dụng **UTF-8** để đảm bảo hiển thị đúng tiếng Việt.

---

## 📌 Ghi chú

- Đây là project học tập, dữ liệu chỉ lưu **cục bộ** (không có database).
- Có thể mở rộng thêm:
  - Kết nối **SQL Server / SQLite**
  - Hỗ trợ **Excel trực tiếp**
  - Thêm tính năng **phân trang, lọc nâng cao**

---
