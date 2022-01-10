
namespace CUAHANGXEMAY
{
    partial class frmChiTietMauXe
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
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuanLyMauSac = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDChiTietXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenXe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMauSac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcChiTietMauXe = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietMauXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCHITETXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietMauXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietMauXe)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::CUAHANGXEMAY.Properties.Resources.themcolor;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 52);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::CUAHANGXEMAY.Properties.Resources.suacolor;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 52);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnQuanLyMauSac);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.txtIDChiTietXe);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cbbTenXe);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cbbMauSac);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(406, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(221, 358);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin chi tiết màu xe";
            // 
            // btnQuanLyMauSac
            // 
            this.btnQuanLyMauSac.ImageOptions.Image = global::CUAHANGXEMAY.Properties.Resources.quanlymausac;
            this.btnQuanLyMauSac.Location = new System.Drawing.Point(125, 313);
            this.btnQuanLyMauSac.Name = "btnQuanLyMauSac";
            this.btnQuanLyMauSac.Size = new System.Drawing.Size(91, 40);
            this.btnQuanLyMauSac.TabIndex = 9;
            this.btnQuanLyMauSac.Click += new System.EventHandler(this.btnQuanLyMauSac_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.ImageOptions.Image = global::CUAHANGXEMAY.Properties.Resources.hủy;
            this.btnHuy.ImageOptions.ImageIndex = 1;
            this.btnHuy.Location = new System.Drawing.Point(123, 221);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 40);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.ImageOptions.Image = global::CUAHANGXEMAY.Properties.Resources.Lưu1;
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnLuu.Location = new System.Drawing.Point(9, 221);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 40);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtIDChiTietXe
            // 
            this.txtIDChiTietXe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDChiTietXe.Location = new System.Drawing.Point(93, 50);
            this.txtIDChiTietXe.Name = "txtIDChiTietXe";
            this.txtIDChiTietXe.Size = new System.Drawing.Size(121, 23);
            this.txtIDChiTietXe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên xe";
            // 
            // cbbTenXe
            // 
            this.cbbTenXe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenXe.FormattingEnabled = true;
            this.cbbTenXe.Location = new System.Drawing.Point(93, 105);
            this.cbbTenXe.Name = "cbbTenXe";
            this.cbbTenXe.Size = new System.Drawing.Size(121, 24);
            this.cbbTenXe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Màu sắc";
            // 
            // cbbMauSac
            // 
            this.cbbMauSac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMauSac.FormattingEnabled = true;
            this.cbbMauSac.Location = new System.Drawing.Point(93, 164);
            this.cbbMauSac.Name = "cbbMauSac";
            this.cbbMauSac.Size = new System.Drawing.Size(121, 24);
            this.cbbMauSac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Chi tiết xe";
            // 
            // gcChiTietMauXe
            // 
            this.gcChiTietMauXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietMauXe.Location = new System.Drawing.Point(0, 55);
            this.gcChiTietMauXe.MainView = this.gvChiTietMauXe;
            this.gcChiTietMauXe.Name = "gcChiTietMauXe";
            this.gcChiTietMauXe.Size = new System.Drawing.Size(406, 358);
            this.gcChiTietMauXe.TabIndex = 2;
            this.gcChiTietMauXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietMauXe});
            // 
            // gvChiTietMauXe
            // 
            this.gvChiTietMauXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCHITETXE,
            this.TENXE,
            this.TENMAU});
            this.gvChiTietMauXe.GridControl = this.gcChiTietMauXe;
            this.gvChiTietMauXe.Name = "gvChiTietMauXe";
            this.gvChiTietMauXe.Click += new System.EventHandler(this.gvChiTietMauXe_Click);
            // 
            // IDCHITETXE
            // 
            this.IDCHITETXE.Caption = "ID Chi tiết xe";
            this.IDCHITETXE.FieldName = "IDCHITIETXE";
            this.IDCHITETXE.Name = "IDCHITETXE";
            this.IDCHITETXE.Visible = true;
            this.IDCHITETXE.VisibleIndex = 0;
            this.IDCHITETXE.Width = 116;
            // 
            // TENXE
            // 
            this.TENXE.Caption = "Tên xe";
            this.TENXE.FieldName = "TENXE";
            this.TENXE.Name = "TENXE";
            this.TENXE.Visible = true;
            this.TENXE.VisibleIndex = 1;
            this.TENXE.Width = 156;
            // 
            // TENMAU
            // 
            this.TENMAU.Caption = "Màu sắc";
            this.TENMAU.FieldName = "TENMAU";
            this.TENMAU.Name = "TENMAU";
            this.TENMAU.Visible = true;
            this.TENMAU.VisibleIndex = 2;
            this.TENMAU.Width = 130;
            // 
            // frmChiTietMauXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 413);
            this.Controls.Add(this.gcChiTietMauXe);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChiTietMauXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT MÀU XE";
            this.Load += new System.EventHandler(this.frmChiTietMauXe_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietMauXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietMauXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtIDChiTietXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMauSac;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcChiTietMauXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietMauXe;
        private DevExpress.XtraGrid.Columns.GridColumn IDCHITETXE;
        private DevExpress.XtraGrid.Columns.GridColumn TENXE;
        private DevExpress.XtraGrid.Columns.GridColumn TENMAU;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnQuanLyMauSac;
    }
}