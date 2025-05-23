namespace PMQLSVDH
{
    partial class UserControlGiangVien
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
            MaGV = new DataGridViewTextBoxColumn();
            TenGV = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MonHoc = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            buttonSua = new Button();
            buttonThemLH = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMaGV = new TextBox();
            textBoxTenGV = new TextBox();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxMH = new ComboBox();
            comboBoxKhoa = new ComboBox();
            dataGridViewLopHoc = new DataGridView();
            MaLop = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            SoHS = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLopHoc).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonThem.Location = new Point(1250, 10);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(75, 30);
            buttonThem.TabIndex = 4;
            buttonThem.Text = "THÊM";
            buttonThem.UseVisualStyleBackColor = true;
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
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaGV, TenGV, Email, MonHoc, Khoa });
            dataGridView.Location = new Point(300, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1024, 330);
            dataGridView.TabIndex = 0;
            // 
            // MaGV
            // 
            MaGV.HeaderText = "Mã GV";
            MaGV.Name = "MaGV";
            MaGV.ReadOnly = true;
            // 
            // TenGV
            // 
            TenGV.HeaderText = "Họ và tên";
            TenGV.Name = "TenGV";
            TenGV.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // MonHoc
            // 
            MonHoc.HeaderText = "Môn học";
            MonHoc.Name = "MonHoc";
            MonHoc.ReadOnly = true;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(buttonSua);
            panel2.Controls.Add(buttonThemLH);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(dataGridViewLopHoc);
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(20, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 400);
            panel2.TabIndex = 3;
            // 
            // buttonSua
            // 
            buttonSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSua.Location = new Point(297, 324);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(100, 30);
            buttonSua.TabIndex = 7;
            buttonSua.Text = "SỬA";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThemLH
            // 
            buttonThemLH.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonThemLH.Location = new Point(1249, 10);
            buttonThemLH.Name = "buttonThemLH";
            buttonThemLH.Size = new Size(75, 30);
            buttonThemLH.TabIndex = 6;
            buttonThemLH.Text = "THÊM";
            buttonThemLH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxMaGV, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxTenGV, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(comboBoxMH, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBoxKhoa, 1, 4);
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(370, 288);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Giảng viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // textBoxMaGV
            // 
            textBoxMaGV.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaGV.Dock = DockStyle.Fill;
            textBoxMaGV.Enabled = false;
            textBoxMaGV.Font = new Font("Segoe UI", 12F);
            textBoxMaGV.Location = new Point(123, 3);
            textBoxMaGV.Name = "textBoxMaGV";
            textBoxMaGV.Size = new Size(244, 29);
            textBoxMaGV.TabIndex = 3;
            // 
            // textBoxTenGV
            // 
            textBoxTenGV.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenGV.Dock = DockStyle.Fill;
            textBoxTenGV.Enabled = false;
            textBoxTenGV.Font = new Font("Segoe UI", 12F);
            textBoxTenGV.Location = new Point(123, 60);
            textBoxTenGV.Name = "textBoxTenGV";
            textBoxTenGV.Size = new Size(244, 29);
            textBoxTenGV.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(123, 117);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(244, 29);
            textBoxEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 171);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 6;
            label5.Text = "Môn học:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 228);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 8;
            label6.Text = "Khoa:";
            // 
            // comboBoxMH
            // 
            comboBoxMH.Dock = DockStyle.Fill;
            comboBoxMH.Enabled = false;
            comboBoxMH.FormattingEnabled = true;
            comboBoxMH.Location = new Point(123, 174);
            comboBoxMH.Name = "comboBoxMH";
            comboBoxMH.Size = new Size(244, 29);
            comboBoxMH.TabIndex = 9;
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.Dock = DockStyle.Fill;
            comboBoxKhoa.Enabled = false;
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Location = new Point(123, 231);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(244, 29);
            comboBoxKhoa.TabIndex = 10;
            // 
            // dataGridViewLopHoc
            // 
            dataGridViewLopHoc.AllowUserToAddRows = false;
            dataGridViewLopHoc.AllowUserToDeleteRows = false;
            dataGridViewLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLopHoc.Columns.AddRange(new DataGridViewColumn[] { MaLop, TenLop, SoHS });
            dataGridViewLopHoc.Location = new Point(463, 50);
            dataGridViewLopHoc.Name = "dataGridViewLopHoc";
            dataGridViewLopHoc.ReadOnly = true;
            dataGridViewLopHoc.Size = new Size(861, 330);
            dataGridViewLopHoc.TabIndex = 0;
            // 
            // MaLop
            // 
            MaLop.HeaderText = "Mã Lớp";
            MaLop.Name = "MaLop";
            MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            TenLop.HeaderText = "Tên Lớp";
            TenLop.Name = "TenLop";
            TenLop.ReadOnly = true;
            // 
            // SoHS
            // 
            SoHS.HeaderText = "Tổng số học sinh";
            SoHS.Name = "SoHS";
            SoHS.ReadOnly = true;
            // 
            // UserControlGiangVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlGiangVien";
            Size = new Size(1384, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLopHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonThem;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private Panel panel2;
        private Button buttonThemLH;
        private Button buttonThemMH;
        private Button buttonThemSV;
        private DataGridView dataGridViewSinhVien;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMaGV;
        private TextBox textBoxTenGV;
        private TextBox textBoxEmail;
        private DataGridView dataGridViewLopHoc;
        private Label label5;
        private DataGridViewTextBoxColumn MaGV;
        private DataGridViewTextBoxColumn TenGV;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MonHoc;
        private DataGridViewTextBoxColumn Khoa;
        public DataGridView dataGridView;
        private Button buttonSua;
        private Label label6;
        private ComboBox comboBoxMH;
        private ComboBox comboBoxKhoa;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn SoHS;
    }
}
