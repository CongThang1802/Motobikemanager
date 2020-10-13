using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorCycleStore_Fram_4_7_2.views.UserControls
{
    public partial class UC_QuanTaiKhoan : UserControl
    {
        public UC_QuanTaiKhoan()
        {
            InitializeComponent();
            Check_Tab();
        }

        private void Check_Tab()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    views.UC_QuanLyTaiKhoan.UC_TaiKhoan uC_TaiKhoan = new UC_QuanLyTaiKhoan.UC_TaiKhoan();
                    this.tab_TaiKhoan.Controls.Add(uC_TaiKhoan);
                    break;
                case 1:
                    views.UC_QuanLyTaiKhoan.UC_LoaiTK uC_LoaiTK = new UC_QuanLyTaiKhoan.UC_LoaiTK();
                    this.tab_LoaiTK.Controls.Add(uC_LoaiTK);
                    break;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Check_Tab();
        }
    }
}
