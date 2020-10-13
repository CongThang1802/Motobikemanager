using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorCycleStore_Fram_4_7_2.views.UC_QuanLySanPham
{
    public partial class UC_NhapSP : UserControl
    {
        public UC_NhapSP()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int a = (gunaDataGridView1.Rows.Count -1 );
            this.gunaDataGridView1.Rows.Insert(a, "", "", "");
        }
    }
}
