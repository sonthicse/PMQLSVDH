namespace PMQLSVDH
{
    partial class UserControlMH
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            buttonThem = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            MaMH = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            SoTinChi = new DataGridViewTextBoxColumn();
            MaKhoa = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridViewGV = new DataGridView();
            MaGV = new DataGridViewTextBoxColumn();
            TenGV = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            MonHoc = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            label8 = new Label();
            buttonSua = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxTinChi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxMaMH = new TextBox();
            textBoxTenMH = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxKhoa = new ComboBox();
            buttonXN = new Button();
            buttonXoa = new Button();
            buttonHuy = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(buttonThem);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 400);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(300, 15);
            label7.Name = "label7";
            label7.Size = new Size(186, 21);
            label7.TabIndex = 5;
            label7.Text = "DANH SÁCH MÔN HỌC";
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
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaMH, TenMH, SoTinChi, MaKhoa });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(300, 50);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1024, 330);
            dataGridView.TabIndex = 0;
            // 
            // MaMH
            // 
            MaMH.HeaderText = "Mã MH";
            MaMH.Name = "MaMH";
            MaMH.ReadOnly = true;
            // 
            // TenMH
            // 
            TenMH.HeaderText = "Tên MH";
            TenMH.Name = "TenMH";
            TenMH.ReadOnly = true;
            // 
            // SoTinChi
            // 
            SoTinChi.HeaderText = "Tín chỉ";
            SoTinChi.Name = "SoTinChi";
            SoTinChi.ReadOnly = true;
            // 
            // MaKhoa
            // 
            MaKhoa.HeaderText = "Khoa";
            MaKhoa.Name = "MaKhoa";
            MaKhoa.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(dataGridViewGV);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(buttonSua);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(buttonXN);
            panel2.Controls.Add(buttonXoa);
            panel2.Controls.Add(buttonHuy);
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(20, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 400);
            panel2.TabIndex = 4;
            // 
            // dataGridViewGV
            // 
            dataGridViewGV.AllowUserToAddRows = false;
            dataGridViewGV.AllowUserToDeleteRows = false;
            dataGridViewGV.AllowUserToOrderColumns = true;
            dataGridViewGV.AllowUserToResizeColumns = false;
            dataGridViewGV.AllowUserToResizeRows = false;
            dataGridViewGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGV.Columns.AddRange(new DataGridViewColumn[] { MaGV, TenGV, Email, MonHoc, Khoa });
            dataGridViewGV.Location = new Point(463, 50);
            dataGridViewGV.MultiSelect = false;
            dataGridViewGV.Name = "dataGridViewGV";
            dataGridViewGV.ReadOnly = true;
            dataGridViewGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGV.Size = new Size(861, 330);
            dataGridViewGV.TabIndex = 11;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(463, 19);
            label8.Name = "label8";
            label8.Size = new Size(226, 21);
            label8.TabIndex = 8;
            label8.Text = "DANH SÁCH GIÁO VIÊN DẠY";
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
            buttonSua.Click += buttonSua_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBoxTinChi, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxMaMH, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxTenMH, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBoxKhoa, 1, 3);
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(370, 288);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxTinChi
            // 
            textBoxTinChi.BorderStyle = BorderStyle.FixedSingle;
            textBoxTinChi.Dock = DockStyle.Fill;
            textBoxTinChi.Font = new Font("Segoe UI", 12F);
            textBoxTinChi.Location = new Point(123, 147);
            textBoxTinChi.Name = "textBoxTinChi";
            textBoxTinChi.Size = new Size(244, 29);
            textBoxTinChi.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 1;
            label3.Text = "Mã MH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 72);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 2;
            label4.Text = "Môn học:";
            // 
            // textBoxMaMH
            // 
            textBoxMaMH.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaMH.Dock = DockStyle.Fill;
            textBoxMaMH.Font = new Font("Segoe UI", 12F);
            textBoxMaMH.Location = new Point(123, 3);
            textBoxMaMH.Name = "textBoxMaMH";
            textBoxMaMH.Size = new Size(244, 29);
            textBoxMaMH.TabIndex = 4;
            // 
            // textBoxTenMH
            // 
            textBoxTenMH.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenMH.Dock = DockStyle.Fill;
            textBoxTenMH.Font = new Font("Segoe UI", 12F);
            textBoxTenMH.Location = new Point(123, 75);
            textBoxTenMH.Name = "textBoxTenMH";
            textBoxTenMH.Size = new Size(244, 29);
            textBoxTenMH.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 144);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 6;
            label5.Text = "Số tín chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 216);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 8;
            label6.Text = "Khoa:";
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.Dock = DockStyle.Fill;
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Location = new Point(123, 219);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(244, 29);
            comboBoxKhoa.TabIndex = 10;
            comboBoxKhoa.SelectedIndexChanged += comboBoxKhoa_SelectedIndexChanged;
            // 
            // buttonXN
            // 
            buttonXN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXN.Location = new Point(277, 324);
            buttonXN.Name = "buttonXN";
            buttonXN.Size = new Size(120, 30);
            buttonXN.TabIndex = 9;
            buttonXN.Text = "XÁC NHẬN";
            buttonXN.UseVisualStyleBackColor = true;
            buttonXN.Visible = false;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXoa.Location = new Point(171, 324);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(100, 30);
            buttonXoa.TabIndex = 12;
            buttonXoa.Text = "XÓA";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            buttonHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonHuy.Location = new Point(171, 324);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(100, 30);
            buttonHuy.TabIndex = 10;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Visible = false;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // UserControlMH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlMH";
            Size = new Size(1384, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button buttonThem;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        public DataGridView dataGridView;
        private Panel panel2;
        private Label label8;
        private Button buttonSua;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxKhoa;
        private Button buttonHuy;
        private Button buttonXN;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn SoTinChi;
        private DataGridViewTextBoxColumn MaKhoa;
        public DataGridView dataGridViewGV;
        private DataGridViewTextBoxColumn MaGV;
        private DataGridViewTextBoxColumn TenGV;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MonHoc;
        private DataGridViewTextBoxColumn Khoa;
        private Button buttonXoa;
        private TextBox textBoxTinChi;
        private Label label3;
        private Label label4;
        private TextBox textBoxMaMH;
        private TextBox textBoxTenMH;
    }
}
