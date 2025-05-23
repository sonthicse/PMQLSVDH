using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PMQLSVDH
{
    partial class UserControlSinhVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonThem = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            LopHoc = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            buttonXoa = new Button();
            buttonHuy = new Button();
            buttonSua = new Button();
            buttonXacNhan = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxMaSV = new TextBox();
            textBoxTenSV = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            comboBoxLop = new ComboBox();
            tableLayoutPanelGioiTinh = new TableLayoutPanel();
            radioButtonNu = new RadioButton();
            radioButtonNam = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanelGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(buttonThem);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 400);
            panel1.TabIndex = 0;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonThem.Location = new Point(1221, 14);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(100, 30);
            buttonThem.TabIndex = 4;
            buttonThem.Text = "THÊM";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSearch.Location = new Point(170, 120);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 30);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "TÌM KIẾM";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(40, 80);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(230, 29);
            textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaSV, TenSV, DiaChi, SDT, NgaySinh, Email, GioiTinh, LopHoc });
            dataGridView.Location = new Point(300, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1024, 330);
            dataGridView.TabIndex = 0;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "Mã Sinh viên";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            MaSV.Width = 125;
            // 
            // TenSV
            // 
            TenSV.HeaderText = "Họ và tên";
            TenSV.MinimumWidth = 6;
            TenSV.Name = "TenSV";
            TenSV.ReadOnly = true;
            TenSV.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 125;
            // 
            // SDT
            // 
            SDT.HeaderText = "SĐT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            SDT.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            NgaySinh.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 125;
            // 
            // LopHoc
            // 
            LopHoc.HeaderText = "Lớp";
            LopHoc.MinimumWidth = 6;
            LopHoc.Name = "LopHoc";
            LopHoc.ReadOnly = true;
            LopHoc.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(buttonXoa);
            panel2.Controls.Add(buttonHuy);
            panel2.Controls.Add(buttonSua);
            panel2.Controls.Add(buttonXacNhan);
            panel2.Controls.Add(tableLayoutPanel);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel2.Location = new Point(20, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 401);
            panel2.TabIndex = 1;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXoa.Location = new Point(1005, 343);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 30);
            buttonXoa.TabIndex = 1;
            buttonXoa.Text = "XÓA";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            buttonHuy.Enabled = false;
            buttonHuy.Location = new Point(1005, 343);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(100, 30);
            buttonHuy.TabIndex = 4;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Visible = false;
            // 
            // buttonSua
            // 
            buttonSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSua.Location = new Point(1221, 343);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(100, 30);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "SỬA";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXacNhan
            // 
            buttonXacNhan.Enabled = false;
            buttonXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXacNhan.Location = new Point(1201, 343);
            buttonXacNhan.Name = "buttonXacNhan";
            buttonXacNhan.Size = new Size(120, 30);
            buttonXacNhan.TabIndex = 3;
            buttonXacNhan.Text = "XÁC NHẬN";
            buttonXacNhan.UseVisualStyleBackColor = true;
            buttonXacNhan.Visible = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Controls.Add(label2, 0, 0);
            tableLayoutPanel.Controls.Add(label3, 2, 0);
            tableLayoutPanel.Controls.Add(label5, 0, 1);
            tableLayoutPanel.Controls.Add(label6, 2, 1);
            tableLayoutPanel.Controls.Add(label8, 0, 2);
            tableLayoutPanel.Controls.Add(label9, 2, 2);
            tableLayoutPanel.Controls.Add(label11, 0, 3);
            tableLayoutPanel.Controls.Add(label12, 2, 3);
            tableLayoutPanel.Controls.Add(textBoxMaSV, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxTenSV, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxDiaChi, 3, 0);
            tableLayoutPanel.Controls.Add(textBoxSDT, 3, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 3, 2);
            tableLayoutPanel.Controls.Add(dateTimePickerNgaySinh, 1, 2);
            tableLayoutPanel.Controls.Add(comboBoxLop, 3, 3);
            tableLayoutPanel.Controls.Add(tableLayoutPanelGioiTinh, 1, 3);
            tableLayoutPanel.Location = new Point(20, 20);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1304, 300);
            tableLayoutPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(670, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 75);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 3;
            label5.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(670, 75);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 4;
            label6.Text = "SĐT:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 149);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(670, 149);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 7;
            label9.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(3, 223);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
            label11.TabIndex = 9;
            label11.Text = "Giới tính:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(670, 223);
            label12.Name = "label12";
            label12.Size = new Size(40, 21);
            label12.TabIndex = 10;
            label12.Text = "Lớp:";
            // 
            // textBoxMaSV
            // 
            textBoxMaSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaSV.Dock = DockStyle.Fill;
            textBoxMaSV.Enabled = false;
            textBoxMaSV.Font = new Font("Segoe UI", 12F);
            textBoxMaSV.Location = new Point(133, 3);
            textBoxMaSV.Name = "textBoxMaSV";
            textBoxMaSV.Size = new Size(531, 29);
            textBoxMaSV.TabIndex = 12;
            // 
            // textBoxTenSV
            // 
            textBoxTenSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenSV.Dock = DockStyle.Fill;
            textBoxTenSV.Enabled = false;
            textBoxTenSV.Font = new Font("Segoe UI", 12F);
            textBoxTenSV.Location = new Point(133, 78);
            textBoxTenSV.Name = "textBoxTenSV";
            textBoxTenSV.Size = new Size(531, 29);
            textBoxTenSV.TabIndex = 13;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Dock = DockStyle.Fill;
            textBoxDiaChi.Enabled = false;
            textBoxDiaChi.Font = new Font("Segoe UI", 12F);
            textBoxDiaChi.Location = new Point(770, 3);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(531, 29);
            textBoxDiaChi.TabIndex = 14;
            // 
            // textBoxSDT
            // 
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Enabled = false;
            textBoxSDT.Font = new Font("Segoe UI", 12F);
            textBoxSDT.Location = new Point(770, 78);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(531, 29);
            textBoxSDT.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(770, 152);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(531, 29);
            textBoxEmail.TabIndex = 16;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Dock = DockStyle.Fill;
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Font = new Font("Segoe UI", 12F);
            dateTimePickerNgaySinh.Location = new Point(133, 152);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(531, 29);
            dateTimePickerNgaySinh.TabIndex = 23;
            // 
            // comboBoxLop
            // 
            comboBoxLop.Dock = DockStyle.Fill;
            comboBoxLop.Enabled = false;
            comboBoxLop.Font = new Font("Segoe UI", 12F);
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(770, 226);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(531, 29);
            comboBoxLop.TabIndex = 24;
            // 
            // tableLayoutPanelGioiTinh
            // 
            tableLayoutPanelGioiTinh.ColumnCount = 2;
            tableLayoutPanelGioiTinh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelGioiTinh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelGioiTinh.Controls.Add(radioButtonNu, 1, 0);
            tableLayoutPanelGioiTinh.Controls.Add(radioButtonNam, 0, 0);
            tableLayoutPanelGioiTinh.Dock = DockStyle.Fill;
            tableLayoutPanelGioiTinh.Location = new Point(133, 226);
            tableLayoutPanelGioiTinh.Name = "tableLayoutPanelGioiTinh";
            tableLayoutPanelGioiTinh.RowCount = 1;
            tableLayoutPanelGioiTinh.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelGioiTinh.Size = new Size(531, 71);
            tableLayoutPanelGioiTinh.TabIndex = 25;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Enabled = false;
            radioButtonNu.Font = new Font("Segoe UI", 12F);
            radioButtonNu.Location = new Point(268, 3);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(49, 25);
            radioButtonNu.TabIndex = 1;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Enabled = false;
            radioButtonNam.Font = new Font("Segoe UI", 12F);
            radioButtonNam.Location = new Point(3, 3);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(62, 25);
            radioButtonNam.TabIndex = 0;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // UserControlSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlSinhVien";
            Size = new Size(1384, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutPanelGioiTinh.ResumeLayout(false);
            tableLayoutPanelGioiTinh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonThem;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        public DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private TextBox textBoxMaSV;
        private TextBox textBoxTenSV;
        private TextBox textBoxDiaChi;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickerNgaySinh;
        private ComboBox comboBoxLop;
        private Button buttonSua;
        private Button buttonXacNhan;
        private Button buttonXoa;
        private Button buttonHuy;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn LopHoc;
        private TableLayoutPanel tableLayoutPanelGioiTinh;
        private RadioButton radioButtonNu;
        private RadioButton radioButtonNam;
    }
}
