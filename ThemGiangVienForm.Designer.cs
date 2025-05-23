namespace PMQLSVDH
{
    partial class ThemGiangVienForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqliteConnection1 = new Microsoft.Data.Sqlite.SqliteConnection();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            tableLayoutPanel = new TableLayoutPanel();
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
            buttonXN = new Button();
            buttonHuy = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sqliteConnection1
            // 
            sqliteConnection1.DefaultTimeout = 30;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(label2, 0, 0);
            tableLayoutPanel.Controls.Add(label3, 0, 1);
            tableLayoutPanel.Controls.Add(label4, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxMaGV, 1, 0);
            tableLayoutPanel.Controls.Add(textBoxTenGV, 1, 1);
            tableLayoutPanel.Controls.Add(textBoxEmail, 1, 2);
            tableLayoutPanel.Controls.Add(label5, 0, 3);
            tableLayoutPanel.Controls.Add(label6, 0, 4);
            tableLayoutPanel.Controls.Add(comboBoxMH, 1, 3);
            tableLayoutPanel.Controls.Add(comboBoxKhoa, 1, 4);
            tableLayoutPanel.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel.Location = new Point(20, 20);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Size = new Size(370, 288);
            tableLayoutPanel.TabIndex = 2;
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
            comboBoxMH.FormattingEnabled = true;
            comboBoxMH.Location = new Point(123, 174);
            comboBoxMH.Name = "comboBoxMH";
            comboBoxMH.Size = new Size(244, 29);
            comboBoxMH.TabIndex = 9;
            // 
            // comboBoxKhoa
            // 
            comboBoxKhoa.Dock = DockStyle.Fill;
            comboBoxKhoa.FormattingEnabled = true;
            comboBoxKhoa.Location = new Point(123, 231);
            comboBoxKhoa.Name = "comboBoxKhoa";
            comboBoxKhoa.Size = new Size(244, 29);
            comboBoxKhoa.TabIndex = 10;
            // 
            // buttonXN
            // 
            buttonXN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXN.Location = new Point(270, 319);
            buttonXN.Name = "buttonXN";
            buttonXN.Size = new Size(120, 30);
            buttonXN.TabIndex = 3;
            buttonXN.Text = "XÁC NHẬN";
            buttonXN.UseVisualStyleBackColor = true;
            buttonXN.Click += ButtonXN_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonHuy.Location = new Point(143, 319);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(100, 30);
            buttonHuy.TabIndex = 4;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // ThemGiangVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(buttonHuy);
            Controls.Add(buttonXN);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "ThemGiangVienForm";
            Text = "Thêm Giảng viên";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.Sqlite.SqliteConnection sqliteConnection1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private TableLayoutPanel tableLayoutPanel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMaGV;
        private TextBox textBoxTenGV;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxMH;
        private ComboBox comboBoxKhoa;
        private Button buttonXN;
        private Button buttonHuy;
    }
}