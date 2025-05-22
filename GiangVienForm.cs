using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class GiangVienForm : Form
    {
        private NavigationControl navigationControl;
        private NavigationButton navigationButton;
        private UserControlTrangChu trangChu;
        private UserControlLopHoc lopHoc;
        private UserControlCaiDat caiDat;
        private GiangVien giangVien;

        private readonly Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        private readonly Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);

        public GiangVienForm()
        {
            giangVien = DatabaseHelper.LoadGiangVienTree("GV001");
            InitializeComponent();
            InitializeNavigationButton();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            trangChu = new UserControlTrangChu();
            lopHoc = new UserControlLopHoc();
            caiDat = new UserControlCaiDat();

            var controls = new List<UserControl> { trangChu, lopHoc, caiDat };
            navigationControl = new NavigationControl(controls, panel);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButton()
        {
            var buttons = new List<Button> { buttonTrangChu, buttonLopHoc, buttonCaiDat };
            navigationButton = new NavigationButton(buttons, btnDefaultColor, btnSelectedColor);
            navigationButton.Highlight(buttonTrangChu);
        }

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.Highlight(buttonTrangChu);
        }

        private void buttonLopHoc_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.Highlight(buttonLopHoc);
            UserControlLopHoc.LoadAllStudents(lopHoc.dataGridView, giangVien); // bỏ lọc cứng "L001"
        }

        private void buttonCaiDat_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.Highlight(buttonCaiDat);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e) => Close();
    }
}