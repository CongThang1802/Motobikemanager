using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorCycleStore_Fram_4_7_2.views
{
    public partial class Form_Menu_Main : Form
    {
        public Form_Menu_Main()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, this.PointToClient(MousePosition));
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            GunaAdvenceButton btn = sender as GunaAdvenceButton;
            switch (btn.Name)
            {
                case "btn_SanPham":
                    Set_Selected(btn_SanPham.Location.Y);
                    Set_Content(new UserControls.UC_QuanLyNhap());
                    break;
                case "btn_BanHang": 
                    Set_Selected(btn_BanHang.Location.Y);
                    Set_Content(new UserControls.UC_QuanLyBanHang());
                    break;
                case "btn_QuanLyKho": 
                    Set_Selected(btn_QuanLyKho.Location.Y);
                    Set_Content(new UserControls.UC_QuanLyKho());
                    break;
                case "btn_KhachHang": Set_Selected(btn_KhachHang.Location.Y); break;
                case "btn_ThongKe": Set_Selected(btn_ThongKe.Location.Y); break;
                case "btn_QuanTri":
                    Set_Selected(btn_QuanTri.Location.Y);
                    Set_Content(new UserControls.UC_QuanTaiKhoan());
                    break;
            }

        }

        private void Set_Content(UserControl userControl)
        {
            this.pnl_Content.Controls.Clear();
            this.pnl_Content.Controls.Add(userControl);
        }

        private void Set_Selected(int value_X)
        {
            this.panel4.Location = new System.Drawing.Point(0, value_X);
        }

    }
}
