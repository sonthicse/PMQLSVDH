namespace PMQLSVDH
{
    partial class UserControlLopHocAdmin
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
            label5 = new Label();
            buttonThem = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            MaLop = new DataGridViewTextBoxColumn();
            KhoaHoc = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            SoHS = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            buttonSua = new Button();
            buttonHuy = new Button();
            buttonXN = new Button();
            label7 = new Label();
            label6 = new Label();
            buttonThemMH = new Button();
            dataGridViewSV = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMaLop = new TextBox();
            textBoxTenLop = new TextBox();
            textBoxKhoaHoc = new TextBox();
            dataGridViewMH = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMH).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonThem);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 400);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(300, 19);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 5;
            label5.Text = "DANH SÁCH LỚP HỌC";
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
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLop, KhoaHoc, TenLop, SoHS });
            dataGridView.Location = new Point(300, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1024, 330);
            dataGridView.TabIndex = 0;
            // 
            // MaLop
            // 
            MaLop.HeaderText = "Mã Lớp";
            MaLop.Name = "MaLop";
            MaLop.ReadOnly = true;
            // 
            // KhoaHoc
            // 
            KhoaHoc.HeaderText = "Khóa học";
            KhoaHoc.Name = "KhoaHoc";
            KhoaHoc.ReadOnly = true;
            KhoaHoc.Visible = false;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(buttonSua);
            panel2.Controls.Add(buttonHuy);
            panel2.Controls.Add(buttonXN);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(buttonThemMH);
            panel2.Controls.Add(dataGridViewSV);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(dataGridViewMH);
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(20, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 400);
            panel2.TabIndex = 2;
            // 
            // buttonSua
            // 
            buttonSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSua.Location = new Point(260, 256);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(100, 30);
            buttonSua.TabIndex = 11;
            buttonSua.Text = "SỬA";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonHuy.Location = new Point(114, 256);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(120, 30);
            buttonHuy.TabIndex = 10;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Visible = false;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // buttonXN
            // 
            buttonXN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXN.Location = new Point(240, 256);
            buttonXN.Name = "buttonXN";
            buttonXN.Size = new Size(120, 30);
            buttonXN.TabIndex = 9;
            buttonXN.Text = "XÁC NHẬN";
            buttonXN.UseVisualStyleBackColor = true;
            buttonXN.Visible = false;
            buttonXN.Click += buttonXN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(875, 17);
            label7.Name = "label7";
            label7.Size = new Size(221, 21);
            label7.TabIndex = 8;
            label7.Text = "DANH SÁCH CÁC MÔN HỌC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(405, 17);
            label6.Name = "label6";
            label6.Size = new Size(189, 21);
            label6.TabIndex = 7;
            label6.Text = "DANH SÁCH SINH VIÊN";
            // 
            // buttonThemMH
            // 
            buttonThemMH.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonThemMH.Location = new Point(1249, 10);
            buttonThemMH.Name = "buttonThemMH";
            buttonThemMH.Size = new Size(75, 30);
            buttonThemMH.TabIndex = 6;
            buttonThemMH.Text = "THÊM";
            buttonThemMH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSV
            // 
            dataGridViewSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSV.Location = new Point(405, 50);
            dataGridViewSV.Name = "dataGridViewSV";
            dataGridViewSV.Size = new Size(450, 330);
            dataGridViewSV.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxMaLop, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxTenLop, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxKhoaHoc, 1, 2);
            tableLayoutPanel1.Location = new Point(20, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(340, 200);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 1;
            label3.Text = "Tên Lớp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 2;
            label4.Text = "Khóa học:";
            // 
            // textBoxMaLop
            // 
            textBoxMaLop.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaLop.Dock = DockStyle.Fill;
            textBoxMaLop.Enabled = false;
            textBoxMaLop.Font = new Font("Segoe UI", 12F);
            textBoxMaLop.Location = new Point(103, 3);
            textBoxMaLop.Name = "textBoxMaLop";
            textBoxMaLop.Size = new Size(234, 29);
            textBoxMaLop.TabIndex = 3;
            // 
            // textBoxTenLop
            // 
            textBoxTenLop.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenLop.Dock = DockStyle.Fill;
            textBoxTenLop.Enabled = false;
            textBoxTenLop.Font = new Font("Segoe UI", 12F);
            textBoxTenLop.Location = new Point(103, 69);
            textBoxTenLop.Name = "textBoxTenLop";
            textBoxTenLop.Size = new Size(234, 29);
            textBoxTenLop.TabIndex = 4;
            // 
            // textBoxKhoaHoc
            // 
            textBoxKhoaHoc.BorderStyle = BorderStyle.FixedSingle;
            textBoxKhoaHoc.Dock = DockStyle.Fill;
            textBoxKhoaHoc.Enabled = false;
            textBoxKhoaHoc.Font = new Font("Segoe UI", 12F);
            textBoxKhoaHoc.Location = new Point(103, 135);
            textBoxKhoaHoc.Name = "textBoxKhoaHoc";
            textBoxKhoaHoc.Size = new Size(234, 29);
            textBoxKhoaHoc.TabIndex = 5;
            // 
            // dataGridViewMH
            // 
            dataGridViewMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMH.Location = new Point(875, 50);
            dataGridViewMH.Name = "dataGridViewMH";
            dataGridViewMH.Size = new Size(450, 330);
            dataGridViewMH.TabIndex = 0;
            // 
            // UserControlLopHocAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlLopHocAdmin";
            Size = new Size(1384, 861);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMH).EndInit();
            ResumeLayout(false);
        }
        private void InitGridSinhVien()
        {
            // 1. Khai báo 2 cột – chỉ chạy 1 lần
            dataGridViewSV.AutoGenerateColumns = false;
            dataGridViewSV.Columns.Clear();

            dataGridViewSV.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSV",
                HeaderText = "Mã SV",
                DataPropertyName = "",      // gán sau trong DB helper
                Width = 100
            });
            dataGridViewSV.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSV",
                HeaderText = "Tên SV",
                DataPropertyName = "",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // 2. Nạp dữ liệu ban đầu (toàn bộ SV)
            //DatabaseHelper.LoadMaTenSV(dataGridViewSV);
        }

        #endregion
        private void InitGridMonHoc()
        {
            dataGridViewMH.AutoGenerateColumns = false;
            dataGridViewMH.Columns.Clear();

            dataGridViewMH.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaMH",
                HeaderText = "Mã MH",
                DataPropertyName = "",           // gán sau trong DB helper
                Width = 100
            });
            dataGridViewMH.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenMH",
                HeaderText = "Tên MH",
                DataPropertyName = "",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Nạp toàn bộ môn học ban đầu
            //DatabaseHelper.LoadMaTenMH(dataGridViewMH);
                
        }
        // dataGridView  = lưới Lớp
        



        private Panel panel1;
        private Button buttonThem;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label1;
        public DataGridView dataGridView;
        private Panel panel2;
        public DataGridView dataGridViewMH;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMaLop;
        private TextBox textBoxTenLop;
        private TextBox textBoxKhoaHoc;
        public DataGridView dataGridViewSV;
        private Button buttonThemMH;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn KhoaHoc;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn SoHS;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button buttonSua;
        private Button buttonHuy;
        private Button buttonXN;

    }
}
