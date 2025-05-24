namespace PMQLSVDH
{
    partial class ThemLopHocForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMaLop = new TextBox();
            textBoxTenLop = new TextBox();
            textBoxKhoaHoc = new TextBox();
            buttonXN = new Button();
            buttonHuy = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxMaLop, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxTenLop, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxKhoaHoc, 1, 2);
            tableLayoutPanel1.Location = new Point(205, 80);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(437, 280);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(4, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 1;
            label3.Text = "Tên Lớp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(4, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 2;
            label4.Text = "Khóa học:";
            // 
            // textBoxMaLop
            // 
            textBoxMaLop.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaLop.Dock = DockStyle.Fill;
            textBoxMaLop.Font = new Font("Segoe UI", 12F);
            textBoxMaLop.Location = new Point(133, 4);
            textBoxMaLop.Margin = new Padding(4);
            textBoxMaLop.Name = "textBoxMaLop";
            textBoxMaLop.Size = new Size(300, 29);
            textBoxMaLop.TabIndex = 3;
            // 
            // textBoxTenLop
            // 
            textBoxTenLop.BorderStyle = BorderStyle.FixedSingle;
            textBoxTenLop.Dock = DockStyle.Fill;
            textBoxTenLop.Font = new Font("Segoe UI", 12F);
            textBoxTenLop.Location = new Point(133, 97);
            textBoxTenLop.Margin = new Padding(4);
            textBoxTenLop.Name = "textBoxTenLop";
            textBoxTenLop.Size = new Size(300, 29);
            textBoxTenLop.TabIndex = 4;
            // 
            // textBoxKhoaHoc
            // 
            textBoxKhoaHoc.BorderStyle = BorderStyle.FixedSingle;
            textBoxKhoaHoc.Dock = DockStyle.Fill;
            textBoxKhoaHoc.Font = new Font("Segoe UI", 12F);
            textBoxKhoaHoc.Location = new Point(133, 190);
            textBoxKhoaHoc.Margin = new Padding(4);
            textBoxKhoaHoc.Name = "textBoxKhoaHoc";
            textBoxKhoaHoc.Size = new Size(300, 29);
            textBoxKhoaHoc.TabIndex = 5;
            // 
            // buttonXN
            // 
            buttonXN.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonXN.Location = new Point(450, 403);
            buttonXN.Margin = new Padding(4);
            buttonXN.Name = "buttonXN";
            buttonXN.Size = new Size(120, 30);
            buttonXN.TabIndex = 3;
            buttonXN.Text = "XÁC NHẬN";
            buttonXN.UseVisualStyleBackColor = true;
            buttonXN.Click += buttonXN_Click;
            // 
            // buttonHuy
            // 
            buttonHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonHuy.Location = new Point(245, 403);
            buttonHuy.Margin = new Padding(4);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(100, 30);
            buttonHuy.TabIndex = 4;
            buttonHuy.Text = "HỦY";
            buttonHuy.UseVisualStyleBackColor = true;
            buttonHuy.Click += buttonHuy_Click;
            // 
            // ThemLopHocForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 512);
            Controls.Add(buttonHuy);
            Controls.Add(buttonXN);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "ThemLopHocForm";
            Text = "ThemLopHocForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMaLop;
        private TextBox textBoxTenLop;
        private TextBox textBoxKhoaHoc;
        private Button buttonXN;
        private Button buttonHuy;
    }
}