namespace Lab01_ThongTinCaNhan;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitle = new Label();
        grpThongTin = new GroupBox();
        cboKhoa = new ComboBox();
        lblKhoa = new Label();
        grpGioiTinh = new GroupBox();
        radNu = new RadioButton();
        radNam = new RadioButton();
        txtEmail = new TextBox();
        lblEmail = new Label();
        txtNamSinh = new TextBox();
        lblNamSinh = new Label();
        txtHoTen = new TextBox();
        lblHoTen = new Label();
        btnHienThi = new Button();
        btnXoa = new Button();
        btnThoat = new Button();
        grpKetQua = new GroupBox();
        txtKetQua = new TextBox();
        grpThongTin.SuspendLayout();
        grpGioiTinh.SuspendLayout();
        grpKetQua.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.DarkBlue;
        lblTitle.Location = new Point(12, 12);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(596, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "ỨNG DỤNG THÔNG TIN CÁ NHÂN";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(cboKhoa);
        grpThongTin.Controls.Add(lblKhoa);
        grpThongTin.Controls.Add(grpGioiTinh);
        grpThongTin.Controls.Add(txtEmail);
        grpThongTin.Controls.Add(lblEmail);
        grpThongTin.Controls.Add(txtNamSinh);
        grpThongTin.Controls.Add(lblNamSinh);
        grpThongTin.Controls.Add(txtHoTen);
        grpThongTin.Controls.Add(lblHoTen);
        grpThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        grpThongTin.Location = new Point(20, 55);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new Size(580, 240);
        grpThongTin.TabIndex = 1;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin nhập liệu";
        // 
        // cboKhoa
        // 
        cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKhoa.FormattingEnabled = true;
        cboKhoa.Location = new Point(130, 195);
        cboKhoa.Name = "cboKhoa";
        cboKhoa.Size = new Size(425, 25);
        cboKhoa.TabIndex = 8;
        // 
        // lblKhoa
        // 
        lblKhoa.AutoSize = true;
        lblKhoa.Location = new Point(25, 198);
        lblKhoa.Name = "lblKhoa";
        lblKhoa.Size = new Size(76, 17);
        lblKhoa.TabIndex = 7;
        lblKhoa.Text = "Khoa / Lớp:";
        // 
        // grpGioiTinh
        // 
        grpGioiTinh.Controls.Add(radNu);
        grpGioiTinh.Controls.Add(radNam);
        grpGioiTinh.Location = new Point(130, 138);
        grpGioiTinh.Name = "grpGioiTinh";
        grpGioiTinh.Size = new Size(425, 48);
        grpGioiTinh.TabIndex = 6;
        grpGioiTinh.TabStop = false;
        grpGioiTinh.Text = "Giới tính";
        // 
        // radNu
        // 
        radNu.AutoSize = true;
        radNu.Location = new Point(160, 20);
        radNu.Name = "radNu";
        radNu.Size = new Size(44, 21);
        radNu.TabIndex = 1;
        radNu.TabStop = true;
        radNu.Text = "Nữ";
        radNu.UseVisualStyleBackColor = true;
        // 
        // radNam
        // 
        radNam.AutoSize = true;
        radNam.Location = new Point(35, 20);
        radNam.Name = "radNam";
        radNam.Size = new Size(54, 21);
        radNam.TabIndex = 0;
        radNam.TabStop = true;
        radNam.Text = "Nam";
        radNam.UseVisualStyleBackColor = true;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(130, 103);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(425, 25);
        txtEmail.TabIndex = 5;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(25, 106);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(42, 17);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email:";
        // 
        // txtNamSinh
        // 
        txtNamSinh.Location = new Point(130, 65);
        txtNamSinh.Name = "txtNamSinh";
        txtNamSinh.Size = new Size(200, 25);
        txtNamSinh.TabIndex = 3;
        // 
        // lblNamSinh
        // 
        lblNamSinh.AutoSize = true;
        lblNamSinh.Location = new Point(25, 68);
        lblNamSinh.Name = "lblNamSinh";
        lblNamSinh.Size = new Size(66, 17);
        lblNamSinh.TabIndex = 2;
        lblNamSinh.Text = "Năm sinh:";
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(130, 27);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(425, 25);
        txtHoTen.TabIndex = 1;
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(25, 30);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(67, 17);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và tên:";
        // 
        // btnHienThi
        // 
        btnHienThi.BackColor = Color.FromArgb(0, 122, 204);
        btnHienThi.Cursor = Cursors.Hand;
        btnHienThi.FlatStyle = FlatStyle.Flat;
        btnHienThi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        btnHienThi.ForeColor = Color.White;
        btnHienThi.Location = new Point(80, 305);
        btnHienThi.Name = "btnHienThi";
        btnHienThi.Size = new Size(130, 36);
        btnHienThi.TabIndex = 2;
        btnHienThi.Text = "Hiển thị";
        btnHienThi.UseVisualStyleBackColor = false;
        btnHienThi.Click += btnHienThi_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = Color.FromArgb(108, 117, 125);
        btnXoa.Cursor = Cursors.Hand;
        btnXoa.FlatStyle = FlatStyle.Flat;
        btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(245, 305);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(130, 36);
        btnXoa.TabIndex = 3;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnThoat
        // 
        btnThoat.BackColor = Color.FromArgb(220, 53, 69);
        btnThoat.Cursor = Cursors.Hand;
        btnThoat.FlatStyle = FlatStyle.Flat;
        btnThoat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        btnThoat.ForeColor = Color.White;
        btnThoat.Location = new Point(410, 305);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(130, 36);
        btnThoat.TabIndex = 4;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = false;
        btnThoat.Click += btnThoat_Click;
        // 
        // grpKetQua
        // 
        grpKetQua.Controls.Add(txtKetQua);
        grpKetQua.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        grpKetQua.Location = new Point(20, 355);
        grpKetQua.Name = "grpKetQua";
        grpKetQua.Size = new Size(580, 220);
        grpKetQua.TabIndex = 5;
        grpKetQua.TabStop = false;
        grpKetQua.Text = "Kết quả tổng hợp";
        // 
        // txtKetQua
        // 
        txtKetQua.BackColor = Color.White;
        txtKetQua.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtKetQua.Location = new Point(20, 25);
        txtKetQua.Multiline = true;
        txtKetQua.Name = "txtKetQua";
        txtKetQua.ReadOnly = true;
        txtKetQua.ScrollBars = ScrollBars.Vertical;
        txtKetQua.Size = new Size(535, 175);
        txtKetQua.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(620, 595);
        Controls.Add(grpKetQua);
        Controls.Add(btnThoat);
        Controls.Add(btnXoa);
        Controls.Add(btnHienThi);
        Controls.Add(grpThongTin);
        Controls.Add(lblTitle);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ứng dụng Thông tin Cá nhân - Lab01";
        FormClosing += Form1_FormClosing;
        Load += Form1_Load;
        grpThongTin.ResumeLayout(false);
        grpThongTin.PerformLayout();
        grpGioiTinh.ResumeLayout(false);
        grpGioiTinh.PerformLayout();
        grpKetQua.ResumeLayout(false);
        grpKetQua.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private GroupBox grpThongTin;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblNamSinh;
    private TextBox txtNamSinh;
    private Label lblEmail;
    private TextBox txtEmail;
    private GroupBox grpGioiTinh;
    private RadioButton radNam;
    private RadioButton radNu;
    private Label lblKhoa;
    private ComboBox cboKhoa;
    private Button btnHienThi;
    private Button btnXoa;
    private Button btnThoat;
    private GroupBox grpKetQua;
    private TextBox txtKetQua;
}
