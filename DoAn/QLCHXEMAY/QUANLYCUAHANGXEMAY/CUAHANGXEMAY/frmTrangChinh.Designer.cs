﻿
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
            this.btnXeMay = new System.Windows.Forms.ToolStripButton();
            this.btnKhachHang = new System.Windows.Forms.ToolStripButton();
            this.btnNhanVien = new System.Windows.Forms.ToolStripButton();
            this.btnBanHang = new System.Windows.Forms.ToolStripButton();
            this.btnBaoCao = new System.Windows.Forms.ToolStripButton();
            this.btnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXeMay,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnBanHang,
            this.btnBaoCao,
            this.btnDangXuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1035, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnXeMay
            // 
            this.btnXeMay.Image = global::CUAHANGXEMAY.Properties.Resources.motobike;
            this.btnXeMay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXeMay.Name = "btnXeMay";
            this.btnXeMay.Size = new System.Drawing.Size(75, 93);
            this.btnXeMay.Text = "Xe máy";
            this.btnXeMay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXeMay.Click += new System.EventHandler(this.btnXeMay_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Image = global::CUAHANGXEMAY.Properties.Resources.customer;
            this.btnKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(108, 72);
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::CUAHANGXEMAY.Properties.Resources.nv;
            this.btnNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(95, 72);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Image = global::CUAHANGXEMAY.Properties.Resources.hoadon;
            this.btnBanHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(90, 93);
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = global::CUAHANGXEMAY.Properties.Resources.thongke;
            this.btnBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(79, 93);
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDangXuat.Image = global::CUAHANGXEMAY.Properties.Resources.logout;
            this.btnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(97, 93);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 463);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CỬA HÀNG XE MÁY";
            this.Load += new System.EventHandler(this.frmTrangChinh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnXeMay;
        private System.Windows.Forms.ToolStripButton btnKhachHang;
        private System.Windows.Forms.ToolStripButton btnNhanVien;
        private System.Windows.Forms.ToolStripButton btnBanHang;
        private System.Windows.Forms.ToolStripButton btnBaoCao;
        private System.Windows.Forms.ToolStripButton btnDangXuat;
    }
}