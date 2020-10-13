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
    public partial class Edit_DanhMuc : Form
    {
        public string id { get; set; }

        public Edit_DanhMuc()
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
            }

            dialog.Dispose();
        }

        private void Edit_DanhMuc_Load(object sender, EventArgs e)
        {
            Set_UI();
        }

        private void Set_UI()
        {
            cbb_Loai.DataSource = LoaiSP_Data.Get_LoaiSpList();
            cbb_Loai.ValueMember = "id_LoaiSP";
            cbb_Loai.DisplayMember = "name_LoaiSP";

            cbb_BaoHanh.DataSource = BaoHanh_Data.Get_BaoHanhList();
            cbb_BaoHanh.DisplayMember = "lim_BaoHanh";
            cbb_BaoHanh.ValueMember = "id_BaoHanh";

            cbb_Hang.DataSource = HangSX_Data.Get_HangSXList();
            cbb_Hang.ValueMember = "id_HangSX";
            cbb_Hang.DisplayMember = "name_HangSX";

            DanhMuc danhMuc = DanhMuc_Data.Get_DanhMuc(this.id);

            edt_Ma.Text = danhMuc.id_DanhMuc;
            edt_Ten.Text = danhMuc.name_DanhMuc;
            edt_PhanhSau.Text = danhMuc.breakend_DanhMuc;
            edt_PhanhTruoc.Text = danhMuc.breakfont_DanhMuc;
            edt_DongCo.Text = danhMuc.engine_DanhMuc;
            edt_KichThuoc.Text = danhMuc.size_DanhMuc;
            edt_Gia.Text = danhMuc.price_DanhMuc.ToString();
            edt_DungTich.Text = danhMuc.volume_DanhMuc;
            edt_LoaiLop.Text = danhMuc.tire_DanhMuc;
            edt_Momen.Text = danhMuc.torque_DanhMuc;
            edt_KhoiLuong.Text = danhMuc.weight_DanhMuc.ToString();
            ptb_HinhAnh.Image = ImageConvert.ConvertBinaryToImage(danhMuc.image_DanhMuc);
            cbb_Loai.SelectedValue = danhMuc.id_LoaiSP;
            cbb_Hang.SelectedValue = danhMuc.id_HangSX;
            cbb_BaoHanh.SelectedValue = danhMuc.id_BaoHanh;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (edt_Ten.Text.Trim() != "" && edt_LoaiLop.Text.Trim() != "" && edt_DongCo.Text.Trim() != ""
                && edt_DungTich.Text.Trim() != "" && edt_Gia.Text.Trim() != "" && edt_KichThuoc.Text.Trim() != ""
                && edt_PhanhSau.Text.Trim() != "" && edt_PhanhTruoc.Text.Trim() != "" && edt_KhoiLuong.Text.Trim() != ""
                && edt_Momen.Text.Trim() != "")
            {
                Data_Entity.DanhMuc_Data.Edit_DanhMuc(new DanhMuc()
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
                    weight_DanhMuc = int.Parse(edt_KhoiLuong.Text),
                    id_BaoHanh = cbb_BaoHanh.SelectedValue.ToString(),
                    id_HangSX = cbb_Hang.SelectedValue.ToString(),
                    id_LoaiSP = cbb_Loai.SelectedValue.ToString(),
                    image_DanhMuc = ImageConvert.ConvertImageToBinary(this.ptb_HinhAnh.Image)
                });
                MessageBox.Show("The object is Updated!", "Note", MessageBoxButtons.OK);
                this.edt_Ma.Text = Create_ID.Gennaral_ID(Data_Entity.DanhMuc_Data.Get_IdDanhMuc());
            }
            else MessageBox.Show("The fields is not Null!", "Note", MessageBoxButtons.OK);
        }
    }
}
