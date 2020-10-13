using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Entity;
using Guna.UI.WinForms;
using MotorCycleStore_Fram_4_7_2.views.Dialogs;
using MotorCycleStore_Fram_4_7_2.models;

namespace MotorCycleStore_Fram_4_7_2.views.UC_QuanLyNhap
{
    public partial class UC_DanhMuc : UserControl
    {
        private string id;

        public UC_DanhMuc()
        {
            InitializeComponent();

        }
        private void UC_DanhMuc_Load(object sender, EventArgs e)
        {
            Load_AllSanPham();
        }

        private void Load_AllSanPham()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DanhMuc item in Data_Entity.DanhMuc_Data.Get_DanhMucList())
            {
                views.UC_Item.UC_ItemDanhMuc item_DanhMuc = new views.UC_Item.UC_ItemDanhMuc()
                {
                    id_DanhMuc = item.id_DanhMuc,
                    name_DanhMuc = item.name_DanhMuc,
                    price_DanhMuc = (int)item.price_DanhMuc,
                    total_DanhMuc = (int)item.total_DanhMuc,
                    img_DanhMuc = ImageConvert.ConvertBinaryToImage(item.image_DanhMuc),
                };
                item_DanhMuc.Get_BtnDetail().Click += new System.EventHandler(this.btn_Detail_Click);
                flowLayoutPanel1.Controls.Add(item_DanhMuc);
            }
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            GunaButton btn = sender as GunaButton;
            Show_Detail(btn.Name);
        }

        private void Show_Detail(string id)
        {
            this.btn_Update.Enabled = this.btn_Delete.Enabled = true;
            Get_DanhMucCustom_Result danhMuc = DanhMuc_Data.Get_DanhMucItem(id);
            this.id = id;
            lbl_IdSP.Text = "Ma: " + danhMuc.id_DanhMuc;
            lbl_TenSP.Text = "Ten: " + danhMuc.name_DanhMuc;
            lbl_SizeSP.Text = "Kich thuoc: " + danhMuc.size_DanhMuc;
            lbl_PriceSP.Text = "Gia: " + danhMuc.price_DanhMuc + " VND";
            lbl_TorqueSP.Text = "Momen xoan: " + danhMuc.torque_DanhMuc;
            lbl_TotalSP.Text = "So luong: " + danhMuc.total_DanhMuc;
            lbl_WieghtSP.Text = "Trong luong: " + danhMuc.weight_DanhMuc + " KG";
            lbl_VolumeSP.Text = "Dung tich: " + danhMuc.volume_DanhMuc + "";
            lbl_FontBreakSP.Text = "Phanh truoc: " + danhMuc.breakfont_DanhMuc;
            lbl_EndBreakSP.Text = "Phanh sau: " + danhMuc.breakend_DanhMuc;
            lbl_EngineSP.Text = "Dong co: " + danhMuc.engine_DanhMuc;
            lbl_TireSP.Text = "Lop" + danhMuc.tire_DanhMuc;
            lbl_HangSP.Text = "Hang SX: " + danhMuc.name_HangSX;
            lbl_LoaiSP.Text = "Loai xe: " + danhMuc.name_LoaiSP;
            lbl_BaoHanhSP.Text = "Bao hanh: " + danhMuc.lim_BaoHanh;
            ptb_HinhAnh.Image = ImageConvert.ConvertBinaryToImage(danhMuc.image_DanhMuc);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add_DanhMuc danhMuc = new Add_DanhMuc();
            danhMuc.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DanhMuc item in Data_Entity.DanhMuc_Data.Search_DanhMucList(edt_Search.Text.Trim()))
            {
                views.UC_Item.UC_ItemDanhMuc item_DanhMuc = new views.UC_Item.UC_ItemDanhMuc()
                {
                    id_DanhMuc = item.id_DanhMuc,
                    name_DanhMuc = item.name_DanhMuc,
                    price_DanhMuc = (int)item.price_DanhMuc,
                    total_DanhMuc = (int)item.total_DanhMuc,
                    img_DanhMuc = ImageConvert.ConvertBinaryToImage(item.image_DanhMuc),
                };
                item_DanhMuc.Get_BtnDetail().Click += new System.EventHandler(this.btn_Detail_Click);
                flowLayoutPanel1.Controls.Add(item_DanhMuc);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Load_AllSanPham();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Edit_DanhMuc danhMuc = new Edit_DanhMuc() { id = this.id };
            danhMuc.ShowDialog();
            Load_AllSanPham();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DanhMuc_Data.Delete_DanhMuc(this.id);
            MessageBox.Show("The object is Deleted!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_AllSanPham();
        }
    }
}
