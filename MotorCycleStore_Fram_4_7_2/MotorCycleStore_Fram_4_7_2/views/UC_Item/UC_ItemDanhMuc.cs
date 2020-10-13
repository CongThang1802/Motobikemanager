using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MotorCycleStore_Fram_4_7_2.models;

namespace MotorCycleStore_Fram_4_7_2.views.UC_Item
{
    public partial class UC_ItemDanhMuc : UserControl
    {
        public string id_DanhMuc { get; set; }
        public string name_DanhMuc { get; set; }
        public int price_DanhMuc { get; set; }
        public int total_DanhMuc { get; set; }
        public Image img_DanhMuc { get; set; }

        public UC_ItemDanhMuc()
        {
            InitializeComponent();
            
            Set_UI();
        }

        private void Set_UI()
        {
            this.lbl_Name.Text = this.name_DanhMuc;
            this.lbl_Price.Text = "Giá: " + this.price_DanhMuc.ToString() + " VNĐ";
            this.lbl_Total.Text = "Số lượng: " + this.total_DanhMuc.ToString();
            this.pictureBox1.Image = this.img_DanhMuc;
            this.gunaButton1.Name = this.id_DanhMuc;
        }

        public GunaButton Get_BtnDetail()
        {
            return this.gunaButton1;
        }

        private void UC_ItemDanhMuc_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void UC_ItemDanhMuc_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Control;
        }

        private void UC_ItemDanhMuc_Load(object sender, EventArgs e)
        {
            Set_UI();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
