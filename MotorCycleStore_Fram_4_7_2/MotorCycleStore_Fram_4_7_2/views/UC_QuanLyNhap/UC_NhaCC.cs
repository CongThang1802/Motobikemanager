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

namespace MotorCycleStore_Fram_4_7_2.views.UC_QuanLyNhap
{
    public partial class UC_NhaCC : UserControl
    {
        private bool status;
        public UC_NhaCC()
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


            dgv_Content.Columns[0].HeaderText = "mã hãng";
            dgv_Content.Columns[1].HeaderText = "tên hãng";
            dgv_Content.Columns[2].HeaderText = "điện thoại";
            dgv_Content.Columns[3].HeaderText = "email";
            dgv_Content.Columns[4].HeaderText = "địa chỉ";
            dgv_Content.Columns[5].HeaderText = "";
            dgv_Content.Columns[6].HeaderText = "";
        }

        private void RefeshForm()
        {
            dgv_Content.DataSource = Data_Entity.NhaCC_Data.Get_NhaCcList();
            edt_Ma.Text = "";
            edt_Ten.Text = "";
            edt_DiaChi.Text = "";
            edt_Dienthoai.Text = "";
            edt_Mail.Text = "";
            this.btn_Update.Enabled = this.btn_Cancel.Enabled = false;
        }

        private void dgv_Content_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        edt_Ma.Text = this.dgv_Content.Rows[e.RowIndex].Cells[2].Value.ToString();
                        edt_Ten.Text = this.dgv_Content.Rows[e.RowIndex].Cells[3].Value.ToString();
                        edt_Dienthoai.Text = this.dgv_Content.Rows[e.RowIndex].Cells[4].Value.ToString();
                        edt_Mail.Text = this.dgv_Content.Rows[e.RowIndex].Cells[5].Value.ToString();
                        edt_DiaChi.Text = this.dgv_Content.Rows[e.RowIndex].Cells[6].Value.ToString();

                        this.status = false;
                        this.btn_Update.Enabled = this.btn_Cancel.Enabled = true;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = Create_ID.Gennaral_ID(Data_Entity.NhaCC_Data.Get_IdNhaCc());
            edt_Ma.Text = id;
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
            dgv_Content.DataSource = Data_Entity.NhaCC_Data.Search_NhaCcList(edt_Search.Text.Trim());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.status)
            {
                if (edt_Ten.Text.Trim() != "" && edt_Dienthoai.Text.Trim() != ""
                    && edt_DiaChi.Text.Trim() != "" && edt_Mail.Text.Trim() != "")
                {
                    Data_Entity.NhaCC_Data.Add_NhaCc(new Data_Entity.NhaCungCap()
                    {
                        id_NhaCC = edt_Ma.Text.Trim(),
                        name_NhaCC = edt_Ten.Text,
                        phone_NhaCC = edt_Dienthoai.Text,
                        email_NhaCC = edt_Mail.Text,
                        address_NhaCC = edt_DiaChi.Text
                    });
                    RefeshForm();
                }
                else MessageBox.Show("The values of the columns is'nt NULL", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (edt_Ten.Text.Trim() != "" && edt_Dienthoai.Text.Trim() != ""
                    && edt_DiaChi.Text.Trim() != "" && edt_Mail.Text.Trim() != "")
                {
                    Data_Entity.NhaCC_Data.Edit_NhaCc(new Data_Entity.NhaCungCap()
                    {
                        id_NhaCC = edt_Ma.Text.Trim(),
                        name_NhaCC = edt_Ten.Text,
                        phone_NhaCC = edt_Dienthoai.Text.Trim(),
                        email_NhaCC = edt_Mail.Text.Trim(),
                        address_NhaCC = edt_DiaChi.Text
                    });
                    RefeshForm();
                }
                else MessageBox.Show("The values of the columns is'nt NULL", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}