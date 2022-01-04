
namespace CUAHANGXEMAY
{
    partial class frmTrangChinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtXeMay = new System.Windows.Forms.ToolStripButton();
            this.txtKhachHang = new System.Windows.Forms.ToolStripButton();
            this.txtNhanVien = new System.Windows.Forms.ToolStripButton();
            this.txtBanHang = new System.Windows.Forms.ToolStripButton();
            this.txtBaoCao = new System.Windows.Forms.ToolStripButton();
            this.txtDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtXeMay,
            this.txtKhachHang,
            this.txtNhanVien,
            this.txtBanHang,
            this.txtBaoCao,
            this.txtDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(985, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtXeMay
            // 
            this.txtXeMay.Image = global::CUAHANGXEMAY.Properties.Resources.motobike;
            this.txtXeMay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtXeMay.Name = "txtXeMay";
            this.txtXeMay.Size = new System.Drawing.Size(50, 64);
            this.txtXeMay.Text = "Xe máy";
            this.txtXeMay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Image = global::CUAHANGXEMAY.Properties.Resources.customer;
            this.txtKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(74, 64);
            this.txtKhachHang.Text = "Khách hàng";
            this.txtKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Image = global::CUAHANGXEMAY.Properties.Resources.nv;
            this.txtNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(65, 64);
            this.txtNhanVien.Text = "Nhân viên";
            this.txtNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtBanHang
            // 
            this.txtBanHang.Image = global::CUAHANGXEMAY.Properties.Resources.hoadon;
            this.txtBanHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtBanHang.Name = "txtBanHang";
            this.txtBanHang.Size = new System.Drawing.Size(61, 64);
            this.txtBanHang.Text = "Bán hàng";
            this.txtBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtBaoCao
            // 
            this.txtBaoCao.Image = global::CUAHANGXEMAY.Properties.Resources.thongke;
            this.txtBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtBaoCao.Name = "txtBaoCao";
            this.txtBaoCao.Size = new System.Drawing.Size(53, 64);
            this.txtBaoCao.Text = "Báo cáo";
            this.txtBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtDangXuat
            // 
            this.txtDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtDangXuat.Image = global::CUAHANGXEMAY.Properties.Resources.logout;
            this.txtDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtDangXuat.Name = "txtDangXuat";
            this.txtDangXuat.Size = new System.Drawing.Size(65, 64);
            this.txtDangXuat.Text = "Đăng xuất";
            this.txtDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 430);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTrangChinh";
            this.Text = "QUẢN LÝ CỬA HÀNG XE MÁY";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton txtXeMay;
        private System.Windows.Forms.ToolStripButton txtKhachHang;
        private System.Windows.Forms.ToolStripButton txtNhanVien;
        private System.Windows.Forms.ToolStripButton txtBanHang;
        private System.Windows.Forms.ToolStripButton txtBaoCao;
        private System.Windows.Forms.ToolStripButton txtDangXuat;
    }
}