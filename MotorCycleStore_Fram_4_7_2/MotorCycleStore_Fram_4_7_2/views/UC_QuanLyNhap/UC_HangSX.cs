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
    public partial class UC_HangSX : UserControl
    {
        private bool status;
        public UC_HangSX()
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
            dgv_Content.Columns[2].HeaderText = "chú thích";
            dgv_Content.Columns[3].HeaderText = "";
            dgv_Content.Columns[4].HeaderText = "";
        }

        private void RefeshForm()
        {
            dgv_Content.DataSource = Data_Entity.HangSX_Data.Get_HangSXList();
            edt_Ma.Text = "";
            edt_Ten.Text = "";
            edt_ChuThich.Text = "";
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
                        edt_ChuThich.Text = this.dgv_Content.Rows[e.RowIndex].Cells[4].Value.ToString();
                        this.status = false;
                        this.btn_Update.Enabled = this.btn_Cancel.Enabled = true;
                        break;
                    case 1:
                        DialogResult result = MessageBox.Show("Do you want to delete this?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Data_Entity.HangSX_Data.Delete_HangSX(this.dgv_Content.Rows[e.RowIndex].Cells[2].Value.ToString());
                            RefeshForm();
                        }
                        break;
                }
                var val = this.dgv_Content.Rows[e.RowIndex].Cells[2].Value.ToString() + "--" + e.ColumnIndex.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = Create_ID.Gennaral_ID(Data_Entity.HangSX_Data.Get_IdHangSX());
            edt_Ma.Text = id;
            edt_Ten.Text = "";
            edt_ChuThich.Text = "Trống";
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
            dgv_Content.DataSource = Data_Entity.HangSX_Data.Search_HangSXList(edt_Search.Text.Trim());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.status)
            {
                if (edt_Ten.Text.Trim() != "" && edt_ChuThich.Text.Trim() != "")
                {
                    Data_Entity.HangSX_Data.Add_HangSX(new Data_Entity.Hang_SX()
                    {
                        id_HangSX = edt_Ma.Text.Trim(),
                        name_HangSX = edt_Ten.Text,
                        descrip_HangSX = edt_ChuThich.Text
                    });
                    RefeshForm();
                }
            }
            else
            {
                if (edt_Ten.Text.Trim() != "" && edt_ChuThich.Text.Trim() != "")
                {
                    Data_Entity.HangSX_Data.Edit_HangSX(new Data_Entity.Hang_SX()
                    {
                        id_HangSX = edt_Ma.Text.Trim(),
                        name_HangSX = edt_Ten.Text,
                        descrip_HangSX = edt_ChuThich.Text
                    });
                    RefeshForm();
                }
            }
        }
    }
}
