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
    public partial class UC_QuanLyKho : UserControl
    {
        public UC_QuanLyKho()
        {
            InitializeComponent();
            Check_Tab();
        }
        private void Check_Tab()
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    views.UC_QuanLySanPham.UC_NhapSP uC_NhapSP = new UC_QuanLySanPham.UC_NhapSP();
                    this.tab_NhapSP.Controls.Add(uC_NhapSP);
                    break;
                case 1:
                    views.UC_QuanLyNhap.UC_HangSX uC_HangSX = new views.UC_QuanLyNhap.UC_HangSX();
                    //this.tab_HangSX.Controls.Add(uC_HangSX);
                    break;
                case 2:
                    views.UC_QuanLyNhap.UC_LoaiSP uC_LoaiSP = new views.UC_QuanLyNhap.UC_LoaiSP();
                    //this.tab_LoaiSP.Controls.Add(uC_LoaiSP);
                    break;
                case 3:
                    views.UC_QuanLyNhap.UC_BaoHanh uC_BaoHanh = new views.UC_QuanLyNhap.UC_BaoHanh();
                    //this.tab_BaoHanh.Controls.Add(uC_BaoHanh);
                    break;
                case 4:
                    views.UC_QuanLyNhap.UC_NhaCC uC_NhaCC = new views.UC_QuanLyNhap.UC_NhaCC();
                    //this.tab_NhaCC.Controls.Add(uC_NhaCC);
                    break;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Check_Tab();
        }
    }
}
