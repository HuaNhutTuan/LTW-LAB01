# COMP1019 - Lập trình trên Windows | Lab 01: Ứng dụng Thông tin Cá nhân

Dự án bài tập thực hành Lab 01 môn **Lập trình trên Windows (COMP1019)** được xây dựng bằng **C#** và **Windows Forms App (.NET 8.0)** trên **Visual Studio 2022**.

---

## 📌 1. Giới thiệu & Mục tiêu
- Xây dựng ứng dụng Windows Forms cho phép nhập thông tin cá nhân của sinh viên và hiển thị kết quả tổng hợp.
- Làm quen với các control cơ bản: `Label`, `TextBox`, `RadioButton`, `ComboBox`, `Button`, `GroupBox`.
- Kiểm tra dữ liệu đầu vào (Validation) trước khi xử lý.
- Xử lý các sự kiện click nút và hộp thoại thông báo (`MessageBox`).

---

## 🛠️ 2. Các Control trong Form (Đúng chuẩn đề bài)
| STT | Control | Tên Control | Chức năng |
| :---: | :--- | :--- | :--- |
| 1 | Label | `lblTitle` | Tiêu đề chương trình |
| 2 | TextBox | `txtHoTen` | Nhập họ tên sinh viên |
| 3 | TextBox | `txtNamSinh` | Nhập năm sinh |
| 4 | TextBox | `txtEmail` | Nhập email |
| 5 | RadioButton | `radNam`, `radNu` | Chọn giới tính (đặt trong `grpGioiTinh`) |
| 6 | ComboBox | `cboKhoa` | Chọn khoa hoặc lớp |
| 7 | Button | `btnHienThi` | Kiểm tra dữ liệu và hiển thị thông tin |
| 8 | Button | `btnXoa` | Xóa dữ liệu đã nhập, reset form |
| 9 | Button | `btnThoat` | Thoát chương trình (có hộp thoại xác nhận) |
| 10 | TextBox | `txtKetQua` | Hiển thị kết quả tổng hợp thông tin sinh viên |

---

## ⚙️ 3. Yêu cầu Chức năng & Kiểm tra Dữ liệu (Validation)
1. **Khởi động ứng dụng**: `cboKhoa` được nạp sẵn ít nhất 3 lựa chọn (CNTT, KTPM, HTTT, KHMT, ATTT).
2. **Kiểm tra dữ liệu**:
   - Họ tên không được để trống.
   - Năm sinh không được để trống, phải là số nguyên và nằm trong khoảng từ `1900` đến năm hiện tại (`DateTime.Now.Year`).
   - Email không được để trống, đúng định dạng cơ bản (`user@domain`).
   - Phải chọn giới tính (Nam / Nữ).
   - Phải chọn Khoa/Lớp.
3. **Nút Hiển thị (`btnHienThi`)**:
   - Tính tuổi: `Tuổi = Năm hiện tại - Năm sinh`.
   - Xuất thông tin theo đúng định dạng đề bài yêu cầu:
     ```text
     THÔNG TIN SINH VIÊN
     Họ tên: Nguyễn Văn A
     Tuổi: 21
     Email: vana@example.com
     Giới tính: Nam
     Khoa/Lớp: Công nghệ thông tin
     ```
4. **Nút Xóa (`btnXoa`)**: Làm rỗng các trường nhập liệu, bỏ chọn radio button, reset combobox và focus vào `txtHoTen`.
5. **Nút Thoát (`btnThoat`) & Sự kiện đóng Form**: Hiển thị hộp thoại `MessageBox` hỏi xác nhận trước khi thoát.

---

## 🚀 4. Hướng dẫn chạy chương trình

### Cách 1: Sử dụng Visual Studio 2022
1. Mở file solution `Lab01_ThongTinCaNhan.sln`.
2. Nhấn `F5` hoặc nút `Start` để biên dịch và chạy chương trình.

### Cách 2: Sử dụng .NET CLI
```bash
# Di chuyển vào thư mục dự án
cd Lab01_ThongTinCaNhan

# Chạy ứng dụng
dotnet run
```
