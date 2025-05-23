using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class AdminForm : Form
    {
        private UserControlTrangChu trangChu = new UserControlTrangChu();
        private UserControlSinhVien sinhVien = new UserControlSinhVien();
        private UserControlGiangVien giangVien = new UserControlGiangVien();
        private UserControlLopHocAdmin lopHoc = new UserControlLopHocAdmin();
        private UserControlKhoa khoa = new UserControlKhoa();
        private UserControlTaiKhoan taiKhoan = new UserControlTaiKhoan();

        private NavigationButton navigationButton;
        private NavigationControl navigationControl;

        private Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        private Color btnSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);
        public DataGridView dataGridView;
        public AdminForm()
        {
            InitializeComponent();
            InitializeNavigationButton();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() { trangChu, sinhVien, giangVien, lopHoc, khoa, taiKhoan };
            navigationControl = new NavigationControl(userControls, panel);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>() { buttonTrangChu, buttonSinhVien, buttonGiangVien, buttonLopHoc, buttonKhoa, buttonTaiKhoan };
            navigationButton = new NavigationButton(buttons, btnDefaultColor, btnSelectedColor);
            navigationButton.Highlight(buttonTrangChu);
        }

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButton.Highlight(buttonTrangChu);
        }

        private void buttonSinhVien_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButton.Highlight(buttonSinhVien);
            DatabaseHelper.LoadDataSV(sinhVien.dataGridView);
        }

        private void buttonGiangVien_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButton.Highlight(buttonGiangVien);
        }

        private void buttonLopHoc_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButton.Highlight(buttonLopHoc);
        }

        private void buttonKhoa_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButton.Highlight(buttonKhoa);
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            navigationControl.Display(5);
            navigationButton.Highlight(buttonTaiKhoan);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
