
namespace QLXEMAY
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTrangChu = new System.Windows.Forms.ToolStripButton();
            this.btnXeMay = new System.Windows.Forms.ToolStripButton();
            this.btnNhanVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrangChu,
            this.btnXeMay,
            this.btnNhanVien,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(995, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.AutoSize = false;
            this.btnTrangChu.Image = global::QLXEMAY.Properties.Resources.homepagepromax;
            this.btnTrangChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(63, 52);
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnXeMay
            // 
            this.btnXeMay.Image = global::QLXEMAY.Properties.Resources.motobike;
            this.btnXeMay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXeMay.Name = "btnXeMay";
            this.btnXeMay.Size = new System.Drawing.Size(50, 52);
            this.btnXeMay.Text = "Xe máy";
            this.btnXeMay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXeMay.Click += new System.EventHandler(this.btnXeMay_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::QLXEMAY.Properties.Resources.nv;
            this.btnNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(65, 52);
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(114, 52);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(114, 52);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 389);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "CỬA HÀNG XE MÁY DUY MẠNH";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTrangChu;
        private System.Windows.Forms.ToolStripButton btnXeMay;
        private System.Windows.Forms.ToolStripButton btnNhanVien;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}