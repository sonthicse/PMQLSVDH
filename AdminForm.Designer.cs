namespace PMQLSVDH
{
    partial class AdminForm
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
            panelMenu = new Panel();
            pictureBoxLogo = new PictureBox();
            buttonDangXuat = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            buttonTrangChu = new Button();
            buttonSinhVien = new Button();
            buttonGiangVien = new Button();
            buttonLopHoc = new Button();
            buttonKhoa = new Button();
            buttonMH = new Button();
            panel = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDark;
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Controls.Add(buttonDangXuat);
            panelMenu.Controls.Add(tableLayoutPanel);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 861);
            panelMenu.TabIndex = 1;
            panelMenu.TabStop = true;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = SystemColors.Control;
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonDangXuat
            // 
            buttonDangXuat.Dock = DockStyle.Bottom;
            buttonDangXuat.Location = new Point(0, 816);
            buttonDangXuat.Name = "buttonDangXuat";
            buttonDangXuat.Size = new Size(200, 45);
            buttonDangXuat.TabIndex = 1;
            buttonDangXuat.Text = "DangXuat";
            buttonDangXuat.UseVisualStyleBackColor = true;
            buttonDangXuat.Click += buttonDangXuat_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Controls.Add(buttonTrangChu, 0, 0);
            tableLayoutPanel.Controls.Add(buttonSinhVien, 0, 1);
            tableLayoutPanel.Controls.Add(buttonGiangVien, 0, 2);
            tableLayoutPanel.Controls.Add(buttonLopHoc, 0, 3);
            tableLayoutPanel.Controls.Add(buttonKhoa, 0, 4);
            tableLayoutPanel.Controls.Add(buttonMH, 0, 5);
            tableLayoutPanel.Location = new Point(0, 200);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel.Size = new Size(200, 391);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonTrangChu
            // 
            buttonTrangChu.Dock = DockStyle.Fill;
            buttonTrangChu.Location = new Point(3, 3);
            buttonTrangChu.Name = "buttonTrangChu";
            buttonTrangChu.Size = new Size(194, 59);
            buttonTrangChu.TabIndex = 0;
            buttonTrangChu.Text = "TrangChu";
            buttonTrangChu.UseVisualStyleBackColor = true;
            buttonTrangChu.Click += buttonTrangChu_Click;
            // 
            // buttonSinhVien
            // 
            buttonSinhVien.Dock = DockStyle.Fill;
            buttonSinhVien.Location = new Point(3, 68);
            buttonSinhVien.Name = "buttonSinhVien";
            buttonSinhVien.Size = new Size(194, 59);
            buttonSinhVien.TabIndex = 1;
            buttonSinhVien.Text = "SinhVien";
            buttonSinhVien.UseVisualStyleBackColor = true;
            buttonSinhVien.Click += buttonSinhVien_Click;
            // 
            // buttonGiangVien
            // 
            buttonGiangVien.Dock = DockStyle.Fill;
            buttonGiangVien.Location = new Point(3, 133);
            buttonGiangVien.Name = "buttonGiangVien";
            buttonGiangVien.Size = new Size(194, 59);
            buttonGiangVien.TabIndex = 2;
            buttonGiangVien.Text = "GiangVien";
            buttonGiangVien.UseVisualStyleBackColor = true;
            buttonGiangVien.Click += buttonGiangVien_Click;
            // 
            // buttonLopHoc
            // 
            buttonLopHoc.Dock = DockStyle.Fill;
            buttonLopHoc.Location = new Point(3, 198);
            buttonLopHoc.Name = "buttonLopHoc";
            buttonLopHoc.Size = new Size(194, 59);
            buttonLopHoc.TabIndex = 3;
            buttonLopHoc.Text = "LopHoc";
            buttonLopHoc.UseVisualStyleBackColor = true;
            buttonLopHoc.Click += buttonLopHoc_Click;
            // 
            // buttonKhoa
            // 
            buttonKhoa.Dock = DockStyle.Fill;
            buttonKhoa.Location = new Point(3, 263);
            buttonKhoa.Name = "buttonKhoa";
            buttonKhoa.Size = new Size(194, 59);
            buttonKhoa.TabIndex = 4;
            buttonKhoa.Text = "Khoa";
            buttonKhoa.UseVisualStyleBackColor = true;
            buttonKhoa.Click += buttonKhoa_Click;
            // 
            // buttonMH
            // 
            buttonMH.Dock = DockStyle.Fill;
            buttonMH.Location = new Point(3, 328);
            buttonMH.Name = "buttonMH";
            buttonMH.Size = new Size(194, 60);
            buttonMH.TabIndex = 5;
            buttonMH.Text = "MÔN HỌC";
            buttonMH.UseVisualStyleBackColor = true;
            buttonMH.Click += buttonTaiKhoan_Click;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ControlLight;
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(200, 0);
            panel.Name = "panel";
            panel.Size = new Size(1384, 861);
            panel.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panel);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBoxLogo;
        private Button buttonDangXuat;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonTrangChu;
        private Button buttonSinhVien;
        private Button buttonGiangVien;
        private Button buttonLopHoc;
        private Button buttonKhoa;
        private Button buttonMH;
        private Panel panel;
    }
}