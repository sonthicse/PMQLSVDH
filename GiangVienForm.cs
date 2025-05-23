using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PMQLSVDH
{
    public partial class GiangVienForm : Form
    {
        private readonly Color _def = Color.FromKnownColor(KnownColor.ControlLight);
        private readonly Color _sel = Color.FromKnownColor(KnownColor.ControlDark);
        private NavigationControl navCtrl;
        private NavigationButton navBtn;
        private UserControlTrangChu ucTrangChu;
        private UserControlLopHoc ucLopHoc;
        private UserControlCaiDat ucCaiDat;

        public GiangVienForm()
        {
            InitializeComponent();
            InitNavigation();
        }

        private void InitNavigation()
        {
            ucTrangChu = new UserControlTrangChu();
            ucLopHoc = new UserControlLopHoc();
            ucCaiDat = new UserControlCaiDat();

            navCtrl = new NavigationControl(new List<UserControl> { ucTrangChu, ucLopHoc, ucCaiDat }, panel);
            navBtn = new NavigationButton(new List<Button> { buttonTrangChu, buttonLopHoc, buttonCaiDat }, _def, _sel);
            navCtrl.Display(0);
            navBtn.Highlight(buttonTrangChu);
        }

        private void buttonTrangChu_Click(object sender, EventArgs e)
        {
            navCtrl.Display(0);
            navBtn.Highlight(buttonTrangChu);
        }

        private void buttonLopHoc_Click(object sender, EventArgs e)
        {
            navCtrl.Display(1);
            navBtn.Highlight(buttonLopHoc);
            ucLopHoc.InitForGiangVien("GV001"); // TODO: lấy MaGV theo đăng nhập
        }

        private void buttonCaiDat_Click(object sender, EventArgs e)
        {
            navCtrl.Display(2);
            navBtn.Highlight(buttonCaiDat);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e) => Close();
    }
}