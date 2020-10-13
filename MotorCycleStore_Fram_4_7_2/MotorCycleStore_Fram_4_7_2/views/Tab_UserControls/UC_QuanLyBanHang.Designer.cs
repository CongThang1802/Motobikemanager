namespace MotorCycleStore_Fram_4_7_2.views.UserControls
{
    partial class UC_QuanLyBanHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_TaiKhoan = new System.Windows.Forms.TabPage();
            this.tab_LoaiTK = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_TaiKhoan);
            this.tabControl1.Controls.Add(this.tab_LoaiTK);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 549);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_TaiKhoan
            // 
            this.tab_TaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.tab_TaiKhoan.ImageKey = "iconfinder_User_Yuppie_1_1218732.png";
            this.tab_TaiKhoan.Location = new System.Drawing.Point(4, 34);
            this.tab_TaiKhoan.Name = "tab_TaiKhoan";
            this.tab_TaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TaiKhoan.Size = new System.Drawing.Size(750, 511);
            this.tab_TaiKhoan.TabIndex = 0;
            this.tab_TaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // tab_LoaiTK
            // 
            this.tab_LoaiTK.BackColor = System.Drawing.SystemColors.Control;
            this.tab_LoaiTK.ImageKey = "iconfinder_lock_safe_password_2992204.png";
            this.tab_LoaiTK.Location = new System.Drawing.Point(4, 34);
            this.tab_LoaiTK.Name = "tab_LoaiTK";
            this.tab_LoaiTK.Padding = new System.Windows.Forms.Padding(3);
            this.tab_LoaiTK.Size = new System.Drawing.Size(750, 511);
            this.tab_LoaiTK.TabIndex = 1;
            this.tab_LoaiTK.Text = "Loại Tài Khoản";
            // 
            // UC_QuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_QuanLyBanHang";
            this.Size = new System.Drawing.Size(750, 545);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_TaiKhoan;
        private System.Windows.Forms.TabPage tab_LoaiTK;
    }
}
