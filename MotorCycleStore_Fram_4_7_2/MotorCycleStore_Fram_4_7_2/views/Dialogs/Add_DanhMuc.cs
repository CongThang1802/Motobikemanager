using Data_Entity;
using MotorCycleStore_Fram_4_7_2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorCycleStore_Fram_4_7_2.views.Dialogs
{
    public partial class Add_DanhMuc : Form
    {
        private string url_Image;
        public Add_DanhMuc()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|PNG Image|*.png|All Files|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var PictureBox1 = new PictureBox();
                ptb_HinhAnh.Image = new Bitmap(dialog.FileName);
                this.url_Image = dialog.FileName;
            }

            dialog.Dispose();
        }

        private void Add_DanhMuc_Load(object sender, EventArgs e)
        {
            this.edt_Ma.Text = Create_ID.Gennaral_ID(Data_Entity.DanhMuc_Data.Get_IdDanhMuc());

            cbb_Loai.DataSource = LoaiSP_Data.Get_LoaiSpList();
            cbb_Loai.ValueMember = "id_LoaiSP";
            cbb_Loai.DisplayMember = "name_LoaiSP";

            cbb_BaoHanh.DataSource = BaoHanh_Data.Get_BaoHanhList();
            cbb_BaoHanh.DisplayMember = "lim_BaoHanh";
            cbb_BaoHanh.ValueMember = "id_BaoHanh";

            cbb_Hang.DataSource = HangSX_Data.Get_HangSXList();
            cbb_Hang.ValueMember = "id_HangSX";
            cbb_Hang.DisplayMember = "name_HangSX";

            cbb_BaoHanh.SelectedIndex = cbb_Hang.SelectedIndex = cbb_Loai.SelectedIndex = 0;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedValue.ToString()+"---"+cbb_MaHang.SelectedValue.ToString());
            //string id_Loai = LoaiSP_Data.Get_IdWithName(cbb_MaLoai.Text).id_LoaiSP;
            //string id_Hang = HangSX_Data.Get_IdWithName(cbb_MaHang.Text).id_HangSX;
            //string id_BaoHanh = BaoHanh_Data.Get_IdWithName(cbb_MaBaoHanh.Text).id_BaoHanh;

            if (edt_Ten.Text.Trim() != "" && edt_LoaiLop.Text.Trim() != "" && edt_DongCo.Text.Trim() != ""
                && edt_DungTich.Text.Trim() != "" && edt_Gia.Text.Trim() != "" && edt_KichThuoc.Text.Trim() != ""
                && edt_PhanhSau.Text.Trim() != "" && edt_PhanhTruoc.Text.Trim() != "" && edt_KhoiLuong.Text.Trim() != ""
                && edt_Momen.Text.Trim() != "")
            {
                Data_Entity.DanhMuc_Data.Add_DanhMuc(new DanhMuc()
                {
                    id_DanhMuc = edt_Ma.Text,
                    name_DanhMuc = edt_Ten.Text,
                    breakend_DanhMuc = edt_PhanhSau.Text,
                    breakfont_DanhMuc = edt_PhanhTruoc.Text,
                    engine_DanhMuc = edt_DongCo.Text,
                    size_DanhMuc = edt_KichThuoc.Text,
                    price_DanhMuc = int.Parse(edt_Gia.Text),
                    volume_DanhMuc = edt_DungTich.Text,
                    tire_DanhMuc = edt_LoaiLop.Text,
                    torque_DanhMuc = edt_Momen.Text,
                    total_DanhMuc = 0,
                    weight_DanhMuc = int.Parse(edt_KhoiLuong.Text),
                    id_BaoHanh = cbb_BaoHanh.SelectedValue.ToString(),
                    id_HangSX = cbb_Hang.SelectedValue.ToString(),
                    id_LoaiSP = cbb_Loai.SelectedValue.ToString(),
                    image_DanhMuc = ImageConvert.ConvertImageToBinary(this.ptb_HinhAnh.Image)
                });
                MessageBox.Show("The object is Added!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.edt_Ma.Text = Create_ID.Gennaral_ID(Data_Entity.DanhMuc_Data.Get_IdDanhMuc());
            }
            else MessageBox.Show("The fields is not Null!", "Note", MessageBoxButtons.OK);
        }
    }
}
