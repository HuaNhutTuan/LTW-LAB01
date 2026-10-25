using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab01_ThongTinCaNhan;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Sự kiện Form_Load: Khởi tạo danh sách Khoa/Lớp khi mở chương trình.
    /// Yêu cầu: ComboBox khoa/lớp có sẵn ít nhất 3 lựa chọn.
    /// </summary>
    private void Form1_Load(object sender, EventArgs e)
    {
        cboKhoa.Items.Clear();
        cboKhoa.Items.Add("Công nghệ thông tin");
        cboKhoa.Items.Add("Kỹ thuật phần mềm");
        cboKhoa.Items.Add("Hệ thống thông tin");
        cboKhoa.Items.Add("Khoa học máy tính");
        cboKhoa.Items.Add("An toàn thông tin");

        // Đặt trạng thái mặc định chưa chọn mục nào
        cboKhoa.SelectedIndex = -1;
    }

    /// <summary>
    /// Xử lý sự kiện nhấn nút Hiển thị:
    /// Kiểm tra tính hợp lệ của dữ liệu đầu vào và hiển thị kết quả tổng hợp.
    /// </summary>
    private void btnHienThi_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra Họ tên không được để trống
        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Họ tên không được để trống!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        // 2. Kiểm tra Năm sinh
        string strNamSinh = txtNamSinh.Text.Trim();
        if (string.IsNullOrWhiteSpace(strNamSinh))
        {
            MessageBox.Show("Năm sinh không được để trống!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNamSinh.Focus();
            return;
        }

        if (!int.TryParse(strNamSinh, out int namSinh))
        {
            MessageBox.Show("Năm sinh phải là số nguyên hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNamSinh.SelectAll();
            txtNamSinh.Focus();
            return;
        }

        int namHienTai = DateTime.Now.Year;
        if (namSinh < 1900 || namSinh > namHienTai)
        {
            MessageBox.Show($"Năm sinh phải nằm trong khoảng từ 1900 đến {namHienTai}!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNamSinh.SelectAll();
            txtNamSinh.Focus();
            return;
        }

        // 3. Kiểm tra Email
        string email = txtEmail.Text.Trim();
        if (string.IsNullOrWhiteSpace(email))
        {
            MessageBox.Show("Email không được để trống!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Focus();
            return;
        }

        // Kiểm tra định dạng Email hợp lệ cơ bản
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (!Regex.IsMatch(email, emailPattern))
        {
            MessageBox.Show("Email không đúng định dạng hợp lệ (Ví dụ: vana@example.com)!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.SelectAll();
            txtEmail.Focus();
            return;
        }

        // 4. Kiểm tra chọn Giới tính
        if (!radNam.Checked && !radNu.Checked)
        {
            MessageBox.Show("Vui lòng chọn giới tính (Nam hoặc Nữ)!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

        // 5. Kiểm tra chọn Khoa hoặc Lớp
        if (cboKhoa.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboKhoa.Text))
        {
            MessageBox.Show("Vui lòng chọn khoa hoặc lớp!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboKhoa.DroppedDown = true;
            cboKhoa.Focus();
            return;
        }
        string khoa = cboKhoa.Text;

        // Tính tuổi theo năm hiện tại
        int tuoi = namHienTai - namSinh;

        // Định dạng chuỗi kết quả theo đúng mẫu yêu cầu
        string ketQua = "THÔNG TIN SINH VIÊN" + Environment.NewLine
                      + $"Họ tên: {hoTen}" + Environment.NewLine
                      + $"Tuổi: {tuoi}" + Environment.NewLine
                      + $"Email: {email}" + Environment.NewLine
                      + $"Giới tính: {gioiTinh}" + Environment.NewLine
                      + $"Khoa/Lớp: {khoa}";

        // Hiển thị kết quả lên TextBox kết quả
        txtKetQua.Text = ketQua;
    }

    /// <summary>
    /// Xử lý sự kiện nhấn nút Xóa:
    /// Đưa các TextBox về rỗng, bỏ chọn giới tính, đưa ComboBox về chưa chọn.
    /// </summary>
    private void btnXoa_Click(object sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtNamSinh.Clear();
        txtEmail.Clear();
        radNam.Checked = false;
        radNu.Checked = false;
        cboKhoa.SelectedIndex = -1;
        txtKetQua.Clear();

        // Đưa con trỏ focus về ô nhập họ tên
        txtHoTen.Focus();
    }

    /// <summary>
    /// Xử lý sự kiện nhấn nút Thoát:
    /// Gọi lệnh đóng Form, sự kiện FormClosing sẽ hiển thị hộp thoại xác nhận.
    /// </summary>
    private void btnThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    /// <summary>
    /// Bắt sự kiện đóng form để hỏi xác nhận người dùng trước khi thoát chương trình.
    /// Hoạt động cho cả nút Thoát và nút [X] của cửa sổ.
    /// </summary>
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát chương trình?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
        {
            e.Cancel = true;
        }
    }
}
