namespace PMQLSVDH
{
    partial class UserControlLopHoc
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
            label12 = new Label();
            comboBoxLop = new ComboBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            LopHoc = new DataGridViewTextBoxColumn();
            MaSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Diem_CC = new DataGridViewTextBoxColumn();
            Diem_TX = new DataGridViewTextBoxColumn();
            Diem_THI = new DataGridViewTextBoxColumn();
            Diem_HP = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
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
            textBoxMaSV = new TextBox();
            textBoxTenSV = new TextBox();
            textBoxDiaChi = new TextBox();
            textBoxSDT = new TextBox();
            textBoxEmail = new TextBox();
            textBoxDiemCC = new TextBox();
            textBoxDiemTX = new TextBox();
            textBoxDiemTHI = new TextBox();
            textBoxDiemHP = new TextBox();
            buttonXoa = new Button();
            buttonSua = new Button();
            dateTimePickerNgaySinh = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboBoxLop);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 400);
            panel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(40, 50);
            label12.Name = "label12";
            label12.Size = new Size(40, 21);
            label12.TabIndex = 5;
            label12.Text = "Lớp:";
            // 
            // comboBoxLop
            // 
            comboBoxLop.Font = new Font("Segoe UI", 12F);
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(40, 80);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(230, 29);
            comboBoxLop.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F);
            buttonSearch.Location = new Point(170, 200);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 30);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "TIMKIEM";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(40, 160);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(230, 29);
            textBoxSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { LopHoc, MaSV, TenSV, NgaySinh, GioiTinh, Diem_CC, Diem_TX, Diem_THI, Diem_HP });
            dataGridView.Location = new Point(300, 20);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(1024, 360);
            dataGridView.TabIndex = 0;
            // 
            // LopHoc
            // 
            LopHoc.DataPropertyName = "LopHoc";
            LopHoc.HeaderText = "Lớp";
            LopHoc.Name = "LopHoc";
            LopHoc.ReadOnly = true;
            // 
            // MaSV
            // 
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "Mã SV";
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            // 
            // TenSV
            // 
            TenSV.DataPropertyName = "TenSV";
            TenSV.HeaderText = "Họ và tên";
            TenSV.Name = "TenSV";
            TenSV.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // Diem_CC
            // 
            Diem_CC.DataPropertyName = "Diem_CC";
            Diem_CC.HeaderText = "Điểm CC";
            Diem_CC.Name = "Diem_CC";
            Diem_CC.ReadOnly = true;
            // 
            // Diem_TX
            // 
            Diem_TX.DataPropertyName = "Diem_TX";
            Diem_TX.HeaderText = "Điểm TX";
            Diem_TX.Name = "Diem_TX";
            Diem_TX.ReadOnly = true;
            // 
            // Diem_THI
            // 
            Diem_THI.HeaderText = "Điểm THI";
            Diem_THI.Name = "Diem_THI";
            Diem_THI.ReadOnly = true;
            // 
            // Diem_HP
            // 
            Diem_HP.HeaderText = "Điểm HP";
            Diem_HP.Name = "Diem_HP";
            Diem_HP.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(tableLayoutPanel);
            panel2.Location = new Point(20, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 401);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
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
            tableLayoutPanel.Controls.Add(textBoxMaSV, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxTenSV, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxDiaChi, 3, 0);
            tableLayoutPanel.Controls.Add(textBoxSDT, 3, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 3, 2);
            tableLayoutPanel.Controls.Add(textBoxDiemCC, 5, 0);
            tableLayoutPanel.Controls.Add(textBoxDiemTX, 5, 1);
            tableLayoutPanel.Controls.Add(textBoxDiemTHI, 5, 2);
            tableLayoutPanel.Controls.Add(textBoxDiemHP, 5, 3);
            tableLayoutPanel.Controls.Add(buttonXoa, 5, 4);
            tableLayoutPanel.Controls.Add(buttonSua, 4, 4);
            tableLayoutPanel.Controls.Add(dateTimePickerNgaySinh, 1, 2);
            tableLayoutPanel.Location = new Point(20, 20);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1304, 361);
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
            label3.Location = new Point(436, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 1;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(839, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 2;
            label4.Text = "Điểm chuyên cần:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 72);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 3;
            label5.Text = "Họ và tên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(436, 72);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 4;
            label6.Text = "SĐT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(839, 72);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 5;
            label7.Text = "Điểm thường xuyên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 144);
            label8.Name = "label8";
            label8.Size = new Size(83, 21);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(436, 144);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 7;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(839, 144);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 8;
            label10.Text = "Điểm thi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(3, 216);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
            label11.TabIndex = 9;
            label11.Text = "Giới tính:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(839, 216);
            label13.Name = "label13";
            label13.Size = new Size(118, 21);
            label13.TabIndex = 11;
            label13.Text = "Điểm học phần:";
            // 
            // textBoxMaSV
            // 
            textBoxMaSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaSV.Dock = DockStyle.Fill;
            textBoxMaSV.Enabled = false;
            textBoxMaSV.Font = new Font("Segoe UI", 12F);
            textBoxMaSV.Location = new Point(133, 3);
            textBoxMaSV.Name = "textBoxMaSV";
            textBoxMaSV.Size = new Size(297, 29);
            textBoxMaSV.TabIndex = 12;
            // 
            // textBoxTenSV
            // 
            textBoxTenSV.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenSV.Dock = DockStyle.Fill;
            textBoxTenSV.Enabled = false;
            textBoxTenSV.Font = new Font("Segoe UI", 12F);
            textBoxTenSV.Location = new Point(133, 75);
            textBoxTenSV.Name = "textBoxTenSV";
            textBoxTenSV.Size = new Size(297, 29);
            textBoxTenSV.TabIndex = 13;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiaChi.Dock = DockStyle.Fill;
            textBoxDiaChi.Enabled = false;
            textBoxDiaChi.Font = new Font("Segoe UI", 12F);
            textBoxDiaChi.Location = new Point(536, 3);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(297, 29);
            textBoxDiaChi.TabIndex = 14;
            // 
            // textBoxSDT
            // 
            textBoxSDT.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDT.Dock = DockStyle.Fill;
            textBoxSDT.Enabled = false;
            textBoxSDT.Font = new Font("Segoe UI", 12F);
            textBoxSDT.Location = new Point(536, 75);
            textBoxSDT.Name = "textBoxSDT";
            textBoxSDT.Size = new Size(297, 29);
            textBoxSDT.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(536, 147);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(297, 29);
            textBoxEmail.TabIndex = 16;
            // 
            // textBoxDiemCC
            // 
            textBoxDiemCC.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemCC.Dock = DockStyle.Fill;
            textBoxDiemCC.Enabled = false;
            textBoxDiemCC.Font = new Font("Segoe UI", 12F);
            textBoxDiemCC.Location = new Point(1004, 3);
            textBoxDiemCC.Name = "textBoxDiemCC";
            textBoxDiemCC.Size = new Size(297, 29);
            textBoxDiemCC.TabIndex = 17;
            // 
            // textBoxDiemTX
            // 
            textBoxDiemTX.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemTX.Dock = DockStyle.Fill;
            textBoxDiemTX.Enabled = false;
            textBoxDiemTX.Font = new Font("Segoe UI", 12F);
            textBoxDiemTX.Location = new Point(1004, 75);
            textBoxDiemTX.Name = "textBoxDiemTX";
            textBoxDiemTX.Size = new Size(297, 29);
            textBoxDiemTX.TabIndex = 18;
            // 
            // textBoxDiemTHI
            // 
            textBoxDiemTHI.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemTHI.Dock = DockStyle.Fill;
            textBoxDiemTHI.Enabled = false;
            textBoxDiemTHI.Font = new Font("Segoe UI", 12F);
            textBoxDiemTHI.Location = new Point(1004, 147);
            textBoxDiemTHI.Name = "textBoxDiemTHI";
            textBoxDiemTHI.Size = new Size(297, 29);
            textBoxDiemTHI.TabIndex = 19;
            // 
            // textBoxDiemHP
            // 
            textBoxDiemHP.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiemHP.Dock = DockStyle.Fill;
            textBoxDiemHP.Enabled = false;
            textBoxDiemHP.Font = new Font("Segoe UI", 12F);
            textBoxDiemHP.Location = new Point(1004, 219);
            textBoxDiemHP.Name = "textBoxDiemHP";
            textBoxDiemHP.Size = new Size(297, 29);
            textBoxDiemHP.TabIndex = 20;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 12F);
            buttonXoa.Location = new Point(1004, 291);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(75, 30);
            buttonXoa.TabIndex = 21;
            buttonXoa.Text = "XÓA";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Font = new Font("Segoe UI", 12F);
            buttonSua.Location = new Point(839, 291);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(75, 30);
            buttonSua.TabIndex = 22;
            buttonSua.Text = "SỬA";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Dock = DockStyle.Fill;
            dateTimePickerNgaySinh.Enabled = false;
            dateTimePickerNgaySinh.Font = new Font("Segoe UI", 12F);
            dateTimePickerNgaySinh.Location = new Point(133, 147);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(297, 29);
            dateTimePickerNgaySinh.TabIndex = 23;
            // 
            // UserControlLopHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlLopHoc";
            Size = new Size(1384, 861);
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
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        public DataGridView dataGridView;
        private Panel panel2;
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
        private TextBox textBoxMaSV;
        private TextBox textBoxTenSV;
        private TextBox textBoxDiaChi;
        private TextBox textBoxSDT;
        private TextBox textBoxEmail;
        private TextBox textBoxDiemCC;
        private TextBox textBoxDiemTX;
        private TextBox textBoxDiemTHI;
        private TextBox textBoxDiemHP;
        private Button buttonXoa;
        private Button buttonSua;
        private DateTimePicker dateTimePickerNgaySinh;
        private Label label12;
        private ComboBox comboBoxLop;
        private DataGridViewTextBoxColumn LopHoc;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Diem_CC;
        private DataGridViewTextBoxColumn Diem_TX;
        private DataGridViewTextBoxColumn Diem_THI;
        private DataGridViewTextBoxColumn Diem_HP;
    }
}
