using MotorCycleStore_Fram_4_7_2.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorCycleStore_Fram_4_7_2
{
    public partial class Form_Login_Main : Form
    {
        public Form_Login_Main()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Menu_Main form_Menu_Main = new Form_Menu_Main();
            form_Menu_Main.ShowDialog();
            this.Visible = true;

        }
    }
}
