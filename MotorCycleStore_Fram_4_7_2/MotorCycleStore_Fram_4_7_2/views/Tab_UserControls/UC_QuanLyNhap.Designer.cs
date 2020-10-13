namespace MotorCycleStore_Fram_4_7_2.views.UserControls
{
    partial class UC_QuanLyNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QuanLyNhap));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_DanhMuc = new System.Windows.Forms.TabPage();
            this.tab_HangSX = new System.Windows.Forms.TabPage();
            this.tab_LoaiSP = new System.Windows.Forms.TabPage();
            this.tab_BaoHanh = new System.Windows.Forms.TabPage();
            this.tab_NhaCC = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_DanhMuc);
            this.tabControl1.Controls.Add(this.tab_HangSX);
            this.tabControl1.Controls.Add(this.tab_LoaiSP);
            this.tabControl1.Controls.Add(this.tab_BaoHanh);
            this.tabControl1.Controls.Add(this.tab_NhaCC);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 549);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_DanhMuc
            // 
            this.tab_DanhMuc.BackColor = System.Drawing.SystemColors.Control;
            this.tab_DanhMuc.ImageKey = "1.png";
            this.tab_DanhMuc.Location = new System.Drawing.Point(4, 34);
            this.tab_DanhMuc.Name = "tab_DanhMuc";
            this.tab_DanhMuc.Size = new System.Drawing.Size(750, 511);
            this.tab_DanhMuc.TabIndex = 4;
            this.tab_DanhMuc.Text = "Danh Mục Sản Phẩm";
            // 
            // tab_HangSX
            // 
            this.tab_HangSX.BackColor = System.Drawing.SystemColors.Control;
            this.tab_HangSX.ImageKey = "3.png";
            this.tab_HangSX.Location = new System.Drawing.Point(4, 34);
            this.tab_HangSX.Name = "tab_HangSX";
            this.tab_HangSX.Padding = new System.Windows.Forms.Padding(3);
            this.tab_HangSX.Size = new System.Drawing.Size(750, 511);
            this.tab_HangSX.TabIndex = 1;
            this.tab_HangSX.Text = "Hãng Sản Xuất";
            // 
            // tab_LoaiSP
            // 
            this.tab_LoaiSP.BackColor = System.Drawing.SystemColors.Control;
            this.tab_LoaiSP.ImageKey = "2.png";
            this.tab_LoaiSP.Location = new System.Drawing.Point(4, 34);
            this.tab_LoaiSP.Name = "tab_LoaiSP";
            this.tab_LoaiSP.Padding = new System.Windows.Forms.Padding(3);
            this.tab_LoaiSP.Size = new System.Drawing.Size(750, 511);
            this.tab_LoaiSP.TabIndex = 0;
            this.tab_LoaiSP.Text = "Loại Sản Phẩm";
            // 
            // tab_BaoHanh
            // 
            this.tab_BaoHanh.BackColor = System.Drawing.SystemColors.Control;
            this.tab_BaoHanh.ImageKey = "4.png";
            this.tab_BaoHanh.Location = new System.Drawing.Point(4, 34);
            this.tab_BaoHanh.Name = "tab_BaoHanh";
            this.tab_BaoHanh.Padding = new System.Windows.Forms.Padding(3);
            this.tab_BaoHanh.Size = new System.Drawing.Size(750, 511);
            this.tab_BaoHanh.TabIndex = 2;
            this.tab_BaoHanh.Text = "Bảo Hành";
            // 
            // tab_NhaCC
            // 
            this.tab_NhaCC.BackColor = System.Drawing.SystemColors.Control;
            this.tab_NhaCC.ImageKey = "5.png";
            this.tab_NhaCC.Location = new System.Drawing.Point(4, 34);
            this.tab_NhaCC.Name = "tab_NhaCC";
            this.tab_NhaCC.Size = new System.Drawing.Size(750, 511);
            this.tab_NhaCC.TabIndex = 3;
            this.tab_NhaCC.Text = "Nhà Cung Cấp";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(750, 545);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_LoaiSP;
        private System.Windows.Forms.TabPage tab_HangSX;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tab_BaoHanh;
        private System.Windows.Forms.TabPage tab_DanhMuc;
        private System.Windows.Forms.TabPage tab_NhaCC;
    }
}
