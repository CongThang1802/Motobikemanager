using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotorCycleStore_Fram_4_7_2.models;
using Data_Entity;

namespace MotorCycleStore_Fram_4_7_2.views.UC_QuanLyTaiKhoan
{
    public partial class UC_TaiKhoan : UserControl
    {
        private bool status;
        private string pass_Default = "5C14B26";
        public UC_TaiKhoan()
        {
            InitializeComponent();

            RefeshForm();

            DataGridViewImageColumn btn_Edit = new DataGridViewImageColumn();
            Image img_edit = Properties.Resources.edit_icon;
            btn_Edit.Image = img_edit;
            btn_Edit.Width = 50;
            btn_Edit.Name = "btn_Edit";
            dgv_Content.Columns.Add(btn_Edit);

            DataGridViewImageColumn btn_Delete = new DataGridViewImageColumn();
            Image img_dele = Properties.Resources.delete_icon;
            btn_Delete.Image = img_dele;
            btn_Delete.Width = 50;
            btn_Delete.Name = "btn_Dele";
            dgv_Content.Columns.Add(btn_Delete);


            dgv_Content.Columns[0].HeaderText = "tài khoản";
            dgv_Content.Columns[1].HeaderText = "người dùng";
            dgv_Content.Columns[2].HeaderText = "email";
            dgv_Content.Columns[3].HeaderText = "điện thoại";
            dgv_Content.Columns[4].HeaderText = "địa chỉ";
            dgv_Content.Columns[5].HeaderText = "";
            dgv_Content.Columns[6].HeaderText = "";
        }

        private void RefeshForm()
        {
            dgv_Content.DataSource = Data_Entity.TaiKhoan_Data.Get_TtTaiKhoanList();
            edt_Ma.Text = "";
            edt_Ten.Text = "";
            edt_DiaChi.Text = "";
            edt_Dienthoai.Text = "";
            edt_Mail.Text = "";

            edt_Ma.Enabled = edt_Ten.Enabled = edt_DiaChi.Enabled = edt_Dienthoai.Enabled = edt_Mail.Enabled
                = cbb_LoaiTK.Enabled = swh_Status.Enabled = false;
            this.btn_Update.Enabled = this.btn_Cancel.Enabled = btn_ResetPass.Enabled = false;

            Load_LoaiTK();
            cbb_LoaiTK.SelectedIndex = -1;
        }

        private void Load_LoaiTK()
        {
            cbb_LoaiTK.DataSource = Data_Entity.TaiKhoan_Data.Get_LoaiTkList();
            cbb_LoaiTK.DisplayMember = "name_LoaiTK";
            cbb_LoaiTK.ValueMember = "id_LoaiTK";
        }

        private void dgv_Content_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        edt_Ten.Enabled = edt_DiaChi.Enabled = edt_Dienthoai.Enabled = edt_Mail.Enabled
                            = cbb_LoaiTK.Enabled = swh_Status.Enabled = true;
                        this.btn_Update.Enabled = this.btn_Cancel.Enabled = btn_ResetPass.Enabled = true;
                        Set_EditAccount(TaiKhoan_Data.Get_TaiKhoan(dgv_Content.Rows[e.RowIndex].Cells[2].Value.ToString()));
                        break;
                    case 1:
                        DialogResult result = MessageBox.Show("Do you want to delete this?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Data_Entity.NhaCC_Data.Delete_NhaCc(this.dgv_Content.Rows[e.RowIndex].Cells[2].Value.ToString());
                            RefeshForm();
                        }
                        break;
                }
            }
        }

        private void Set_EditAccount(Get_TaiKhoan_Result obj)
        {
            edt_Ma.Text = obj.user_Acc.Trim();
            edt_Ten.Text = obj.name_User;
            edt_Mail.Text = obj.email_User.Trim();
            edt_Dienthoai.Text = obj.phone_User.Trim();
            edt_DiaChi.Text = obj.address_User;

            cbb_LoaiTK.SelectedValue = obj.id_LoaiTK;
            swh_Status.Checked = (bool)obj.status;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            edt_Ma.Enabled = edt_Ten.Enabled = edt_DiaChi.Enabled = edt_Dienthoai.Enabled = edt_Mail.Enabled
                = cbb_LoaiTK.Enabled = swh_Status.Enabled = true;

            //string id = Create_ID.Gennaral_ID(Data_Entity.NhaCC_Data.Get_IdNhaCc());
            edt_Ma.Text = "Tên người dùng";
            edt_Ten.Text = "";
            edt_Dienthoai.Text = edt_DiaChi.Text = edt_Mail.Text = "Trống";
            this.status = true;
            this.btn_Update.Enabled = this.btn_Cancel.Enabled = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefeshForm();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            RefeshForm();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Content.DataSource = Data_Entity.TaiKhoan_Data.Search_TtTaiKhoanList(edt_Search.Text.Trim());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.status)
            {
                if (edt_Ten.Text.Trim() != "" && edt_Dienthoai.Text.Trim() != ""
                    && edt_DiaChi.Text.Trim() != "" && edt_Mail.Text.Trim() != "" && edt_Ma.Text != "")
                {
                    Data_Entity.TaiKhoan_Data.Add_TaiKhoan(
                            new TaiKhoan
                            {
                                user_Acc = this.edt_Ma.Text.Trim(),
                                pass_Acc = MD5_Hash.MD5Hash(this.pass_Default),
                                status = this.swh_Status.Checked,
                                id_LoaiTK = this.cbb_LoaiTK.SelectedValue.ToString()
                            },
                            new TT_TaiKhoan
                            {
                                user_Acc = this.edt_Ma.Text.Trim(),
                                name_User = this.edt_Ten.Text,
                                email_User = this.edt_Mail.Text,
                                phone_User = this.edt_Dienthoai.Text,
                                address_User = this.edt_DiaChi.Text
                            }
                        );
                    MessageBox.Show("Add is success with the password: " + this.pass_Default + "!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefeshForm();
                }
                else MessageBox.Show("The values of the columns is'nt NULL", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (edt_Ten.Text.Trim() != "" && edt_Dienthoai.Text.Trim() != ""
                    && edt_DiaChi.Text.Trim() != "" && edt_Mail.Text.Trim() != "" && edt_Ma.Text != "")
                {
                    Data_Entity.TaiKhoan_Data.Edit_TaiKhoan(
                            new TaiKhoan
                            {
                                user_Acc = this.edt_Ma.Text.Trim(),
                                status = this.swh_Status.Checked,
                                id_LoaiTK = this.cbb_LoaiTK.SelectedValue.ToString()
                            },
                            new TT_TaiKhoan
                            {
                                user_Acc = this.edt_Ma.Text.Trim(),
                                name_User = this.edt_Ten.Text,
                                email_User = this.edt_Mail.Text,
                                phone_User = this.edt_Dienthoai.Text,
                                address_User = this.edt_DiaChi.Text
                            }
                        );
                    MessageBox.Show("Edit is success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefeshForm();
                }
                else MessageBox.Show("The values of the columns is'nt NULL", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            TaiKhoan_Data.Update_TaiKhoanPass(edt_Ma.Text.Trim(), MD5_Hash.MD5Hash(this.pass_Default));
            MessageBox.Show("The password is reseted to " + this.pass_Default + "!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}