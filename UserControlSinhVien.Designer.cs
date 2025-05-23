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
            buttonHuy = new Button();
            buttonSua = new Button();
            buttonXacNhan = new Button();
            buttonXoa = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label12 = new Label();
            textBoxMaSV = new TextBox();
            textBoxTenSV = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            textBoxDiemCC = new TextBox();
            textBoxDiemTX = new TextBox();
            textBoxDiemTHI = new TextBox();
            textBoxDiemHP = new TextBox();
            dateTimePickerNgaySinh = new DateTimePicker();
            comboBoxLop = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
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
            panel1.Location = new Point(23, 27);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 533);
            panel1.TabIndex = 0;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonThem.Location = new Point(1429, 13);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(86, 40);
            buttonThem.TabIndex = 4;
            buttonThem.Text = "THÊM";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSearch.Location = new Point(194, 160);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(114, 40);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "TIMKIEM";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(46, 107);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(263, 34);
            textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(46, 67);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaSV, TenSV, DiaChi, SDT, NgaySinh, Email, GioiTinh, LopHoc });
            dataGridView.Location = new Point(343, 67);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1170, 440);
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
            panel2.Controls.Add(buttonHuy);
            panel2.Controls.Add(buttonSua);
            panel2.Controls.Add(buttonXacNhan);
            panel2.Controls.Add(buttonXoa);
            panel2.Controls.Add(tableLayoutPanel);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panel2.Location = new Point(23, 587);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1536, 535);
            panel2.TabIndex = 1;
            // 
            // buttonHuy
            // 
            buttonHuy.Location = new Point(1424, 457);
            buttonHuy.Margin = new Padding(3, 4, 3, 4);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(86, 40);
            buttonHuy.TabIndex = 4;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Visible = false;
            // 
            // buttonSua
            // 
            buttonSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSua.Location = new Point(1279, 457);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(86, 40);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "SỬA";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXacNhan
            // 
            buttonXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXacNhan.Location = new Point(1237, 457);
            buttonXacNhan.Margin = new Padding(3, 4, 3, 4);
            buttonXacNhan.Name = "buttonXacNhan";
            buttonXacNhan.Size = new Size(128, 40);
            buttonXacNhan.TabIndex = 3;
            buttonXacNhan.Text = "XÁC NHẬN";
            buttonXacNhan.UseVisualStyleBackColor = true;
            buttonXacNhan.Visible = false;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXoa.Location = new Point(1424, 457);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(86, 40);
            buttonXoa.TabIndex = 1;
            buttonXoa.Text = "XÓA";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Controls.Add(label2, 0, 0);
            tableLayoutPanel.Controls.Add(label3, 2, 0);
            tableLayoutPanel.Controls.Add(label4, 4, 0);
            tableLayoutPanel.Controls.Add(label5, 0, 1);
            tableLayoutPanel.Controls.Add(label6, 2, 1);
            tableLayoutPanel.Controls.Add(label7, 4, 1);
            tableLayoutPanel.Controls.Add(label8, 0, 2);
            tableLayoutPanel.Controls.Add(label9, 2, 2);
            tableLayoutPanel.Controls.Add(label10, 4, 2);
            tableLayoutPanel.Controls.Add(label11, 0, 3);
            tableLayoutPanel.Controls.Add(label13, 4, 3);
            tableLayoutPanel.Controls.Add(label12, 2, 3);
            tableLayoutPanel.Controls.Add(textBoxMaSV, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxTenSV, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxDiaChi, 3, 0);
            tableLayoutPanel.Controls.Add(textBoxSDT, 3, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 3, 2);
            tableLayoutPanel.Controls.Add(textBoxDiemCC, 5, 0);
            tableLayoutPanel.Controls.Add(textBoxDiemTX, 5, 1);
            tableLayoutPanel.Controls.Add(textBoxDiemTHI, 5, 2);
            tableLayoutPanel.Controls.Add(textBoxDiemHP, 5, 3);
            tableLayoutPanel.Controls.Add(dateTimePickerNgaySinh, 1, 2);
            tableLayoutPanel.Controls.Add(comboBoxLop, 3, 3);
            tableLayoutPanel.Location = new Point(23, 27);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel.Size = new Size(1490, 400);
            tableLayoutPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(498, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(958, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 2;
            label4.Text = "Điểm chuyên cần:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 100);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 3;
            label5.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(498, 100);
            label6.Name = "label6";
            label6.Size = new Size(51, 28);
            label6.TabIndex = 4;
            label6.Text = "SĐT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(958, 100);
            label7.Name = "label7";
            label7.Size = new Size(133, 56);
            label7.TabIndex = 5;
            label7.Text = "Điểm thường xuyên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 199);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(498, 199);
            label9.Name = "label9";
            label9.Size = new Size(63, 28);
            label9.TabIndex = 7;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(958, 199);
            label10.Name = "label10";
            label10.Size = new Size(90, 28);
            label10.TabIndex = 8;
            label10.Text = "Điểm thi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(3, 298);
            label11.Name = "label11";
            label11.Size = new Size(91, 28);
            label11.TabIndex = 9;
            label11.Text = "Giới tính:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(958, 298);
            label13.Name = "label13";
            label13.Size = new Size(148, 28);
            label13.TabIndex = 11;
            label13.Text = "Điểm học phần:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(498, 298);
            label12.Name = "label12";
            label12.Size = new Size(49, 28);
            label12.TabIndex = 10;
            label12.Text = "Lớp:";
            // 
            // textBoxMaSV
            // 
            textBoxMaSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaSV.Dock = DockStyle.Fill;
            textBoxMaSV.Enabled = false;
            textBoxMaSV.Font = new Font("Segoe UI", 12F);
            textBoxMaSV.Location = new Point(152, 4);
            textBoxMaSV.Margin = new Padding(3, 4, 3, 4);
            textBoxMaSV.Name = "textBoxMaSV";
            textBoxMaSV.Size = new Size(340, 34);
            textBoxMaSV.TabIndex = 12;
            // 
            // textBoxTenSV
            // 
            textBoxTenSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenSV.Dock = DockStyle.Fill;
            textBoxTenSV.Enabled = false;
            textBoxTenSV.Font = new Font("Segoe UI", 12F);
            textBoxTenSV.Location = new Point(152, 104);
            textBoxTenSV.Margin = new Padding(3, 4, 3, 4);
            textBoxTenSV.Name = "textBoxTenSV";
            textBoxTenSV.Size = new Size(340, 34);
            textBoxTenSV.TabIndex = 13;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Dock = DockStyle.Fill;
            textBoxDiaChi.Enabled = false;
            textBoxDiaChi.Font = new Font("Segoe UI", 12F);
            textBoxDiaChi.Location = new Point(612, 4);
            textBoxDiaChi.Margin = new Padding(3, 4, 3, 4);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(340, 34);
            textBoxDiaChi.TabIndex = 14;
            // 
            // textBoxSDT
            // 
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Enabled = false;
            textBoxSDT.Font = new Font("Segoe UI", 12F);
            textBoxSDT.Location = new Point(612, 104);
            textBoxSDT.Margin = new Padding(3, 4, 3, 4);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(340, 34);
            textBoxSDT.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(612, 203);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(340, 34);
            textBoxEmail.TabIndex = 16;
            // 
            // textBoxDiemCC
            // 
            textBoxDiemCC.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemCC.Dock = DockStyle.Fill;
            textBoxDiemCC.Enabled = false;
            textBoxDiemCC.Font = new Font("Segoe UI", 12F);
            textBoxDiemCC.Location = new Point(1147, 4);
            textBoxDiemCC.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemCC.Name = "textBoxDiemCC";
            textBoxDiemCC.Size = new Size(340, 34);
            textBoxDiemCC.TabIndex = 17;
            // 
            // textBoxDiemTX
            // 
            textBoxDiemTX.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemTX.Dock = DockStyle.Fill;
            textBoxDiemTX.Enabled = false;
            textBoxDiemTX.Font = new Font("Segoe UI", 12F);
            textBoxDiemTX.Location = new Point(1147, 104);
            textBoxDiemTX.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemTX.Name = "textBoxDiemTX";
            textBoxDiemTX.Size = new Size(340, 34);
            textBoxDiemTX.TabIndex = 18;
            // 
            // textBoxDiemTHI
            // 
            textBoxDiemTHI.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemTHI.Dock = DockStyle.Fill;
            textBoxDiemTHI.Enabled = false;
            textBoxDiemTHI.Font = new Font("Segoe UI", 12F);
            textBoxDiemTHI.Location = new Point(1147, 203);
            textBoxDiemTHI.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemTHI.Name = "textBoxDiemTHI";
            textBoxDiemTHI.Size = new Size(340, 34);
            textBoxDiemTHI.TabIndex = 19;
            // 
            // textBoxDiemHP
            // 
            textBoxDiemHP.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemHP.Dock = DockStyle.Fill;
            textBoxDiemHP.Enabled = false;
            textBoxDiemHP.Font = new Font("Segoe UI", 12F);
            textBoxDiemHP.Location = new Point(1147, 302);
            textBoxDiemHP.Margin = new Padding(3, 4, 3, 4);
            textBoxDiemHP.Name = "textBoxDiemHP";
            textBoxDiemHP.Size = new Size(340, 34);
            textBoxDiemHP.TabIndex = 20;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Dock = DockStyle.Fill;
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Font = new Font("Segoe UI", 12F);
            dateTimePickerNgaySinh.Location = new Point(152, 203);
            dateTimePickerNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(340, 34);
            dateTimePickerNgaySinh.TabIndex = 23;
            // 
            // comboBoxLop
            // 
            comboBoxLop.Dock = DockStyle.Fill;
            comboBoxLop.Enabled = false;
            comboBoxLop.Font = new Font("Segoe UI", 12F);
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(612, 302);
            comboBoxLop.Margin = new Padding(3, 4, 3, 4);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(340, 36);
            comboBoxLop.TabIndex = 24;
            // 
            // UserControlSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlSinhVien";
            Size = new Size(1582, 1148);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label12;
        private TextBox textBoxMaSV;
        private TextBox textBoxTenSV;
        private TextBox textBoxDiaChi;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private TextBox textBoxDiemCC;
        private TextBox textBoxDiemTX;
        private TextBox textBoxDiemTHI;
        private TextBox textBoxDiemHP;
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


    }
}
