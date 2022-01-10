﻿
namespace CUAHANGXEMAY
{
    partial class frmXeMay
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
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcXeMay = new DevExpress.XtraGrid.GridControl();
            this.gvXeMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DUNGTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuanLyMauSac = new DevExpress.XtraEditors.SimpleButton();
            this.cbDisable = new System.Windows.Forms.CheckBox();
            this.cbbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDungTich = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MAUSAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThoat,
            this.btnIn,
            this.btnXoa,
            this.btnSua,
            this.btnThem,
            this.btnLuu,
            this.btnHuy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1192, 54);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThoat
            // 
            this.btnThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThoat.AutoSize = false;
            this.btnThoat.Image = global::CUAHANGXEMAY.Properties.Resources.thoatcolor;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(50, 51);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnIn.AutoSize = false;
            this.btnIn.Image = global::CUAHANGXEMAY.Properties.Resources.printercolor;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(50, 51);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.AutoSize = false;
            this.btnXoa.Image = global::CUAHANGXEMAY.Properties.Resources.xoacolor1;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 51);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.AutoSize = false;
            this.btnSua.Image = global::CUAHANGXEMAY.Properties.Resources.suacolor;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 51);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.AutoSize = false;
            this.btnThem.Image = global::CUAHANGXEMAY.Properties.Resources.themcolor;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 51);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = false;
            this.btnLuu.Image = global::CUAHANGXEMAY.Properties.Resources.luucolor;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(50, 51);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::CUAHANGXEMAY.Properties.Resources.huycolor;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(50, 51);
            this.btnHuy.Text = "Huỷ bỏ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gcXeMay);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1192, 391);
            this.splitContainerControl1.SplitterPosition = 911;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // gcXeMay
            // 
            this.gcXeMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXeMay.Location = new System.Drawing.Point(0, 0);
            this.gcXeMay.MainView = this.gvXeMay;
            this.gcXeMay.Name = "gcXeMay";
            this.gcXeMay.Size = new System.Drawing.Size(911, 391);
            this.gcXeMay.TabIndex = 2;
            this.gcXeMay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXeMay});
            // 
            // gvXeMay
            // 
            this.gvXeMay.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvXeMay.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvXeMay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLE,
            this.TENNCC,
            this.MAXE,
            this.TENXE,
            this.TENLOAIXE,
            this.DUNGTICH,
            this.TINHTRANG,
            this.GIABAN});
            this.gvXeMay.GridControl = this.gcXeMay;
            this.gvXeMay.Name = "gvXeMay";
            this.gvXeMay.Click += new System.EventHandler(this.gvXeMay_Click);
            // 
            // DISABLE
            // 
            this.DISABLE.Caption = "DEL";
            this.DISABLE.FieldName = "DISABLE";
            this.DISABLE.Name = "DISABLE";
            this.DISABLE.Visible = true;
            this.DISABLE.VisibleIndex = 0;
            this.DISABLE.Width = 66;
            // 
            // TENNCC
            // 
            this.TENNCC.Caption = "Tên nhà cung cấp";
            this.TENNCC.FieldName = "TENNCC";
            this.TENNCC.MaxWidth = 150;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Visible = true;
            this.TENNCC.VisibleIndex = 1;
            this.TENNCC.Width = 145;
            // 
            // MAXE
            // 
            this.MAXE.Caption = "Mã xe";
            this.MAXE.FieldName = "MAXE";
            this.MAXE.Name = "MAXE";
            this.MAXE.Visible = true;
            this.MAXE.VisibleIndex = 2;
            this.MAXE.Width = 85;
            // 
            // TENXE
            // 
            this.TENXE.Caption = "Tên xe";
            this.TENXE.FieldName = "TENXE";
            this.TENXE.Name = "TENXE";
            this.TENXE.Visible = true;
            this.TENXE.VisibleIndex = 3;
            this.TENXE.Width = 147;
            // 
            // TENLOAIXE
            // 
            this.TENLOAIXE.Caption = "Loại xe";
            this.TENLOAIXE.FieldName = "TENLOAI";
            this.TENLOAIXE.Name = "TENLOAIXE";
            this.TENLOAIXE.Visible = true;
            this.TENLOAIXE.VisibleIndex = 4;
            this.TENLOAIXE.Width = 97;
            // 
            // DUNGTICH
            // 
            this.DUNGTICH.Caption = "Dung tích";
            this.DUNGTICH.FieldName = "DUNGTICH";
            this.DUNGTICH.Name = "DUNGTICH";
            this.DUNGTICH.Visible = true;
            this.DUNGTICH.VisibleIndex = 5;
            this.DUNGTICH.Width = 105;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Caption = "Tình trạng";
            this.TINHTRANG.FieldName = "TINHTRANG";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = true;
            this.TINHTRANG.VisibleIndex = 6;
            this.TINHTRANG.Width = 108;
            // 
            // GIABAN
            // 
            this.GIABAN.Caption = "Giá bán(vnd)";
            this.GIABAN.DisplayFormat.FormatString = "0,0.##";
            this.GIABAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIABAN.FieldName = "GIABAN";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Visible = true;
            this.GIABAN.VisibleIndex = 7;
            this.GIABAN.Width = 133;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnQuanLyMauSac);
            this.groupControl1.Controls.Add(this.cbDisable);
            this.groupControl1.Controls.Add(this.cbbLoaiXe);
            this.groupControl1.Controls.Add(this.cbbNCC);
            this.groupControl1.Controls.Add(this.txtGiaBan);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtTinhTrang);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtDungTich);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtTenXe);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtMaXe);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(271, 391);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // btnQuanLyMauSac
            // 
            this.btnQuanLyMauSac.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuanLyMauSac.Appearance.Options.UseForeColor = true;
            this.btnQuanLyMauSac.ImageOptions.Image = global::CUAHANGXEMAY.Properties.Resources.quanlymauxe;
            this.btnQuanLyMauSac.Location = new System.Drawing.Point(175, 346);
            this.btnQuanLyMauSac.Name = "btnQuanLyMauSac";
            this.btnQuanLyMauSac.Size = new System.Drawing.Size(91, 40);
            this.btnQuanLyMauSac.TabIndex = 19;
            this.btnQuanLyMauSac.Text = "simpleButton1";
            this.btnQuanLyMauSac.Click += new System.EventHandler(this.btnQuanLyMauSac_Click);
            // 
            // cbDisable
            // 
            this.cbDisable.AutoSize = true;
            this.cbDisable.Location = new System.Drawing.Point(102, 313);
            this.cbDisable.Name = "cbDisable";
            this.cbDisable.Size = new System.Drawing.Size(67, 17);
            this.cbDisable.TabIndex = 18;
            this.cbDisable.Text = "DISABLE";
            this.cbDisable.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiXe
            // 
            this.cbbLoaiXe.FormattingEnabled = true;
            this.cbbLoaiXe.Location = new System.Drawing.Point(102, 154);
            this.cbbLoaiXe.Name = "cbbLoaiXe";
            this.cbbLoaiXe.Size = new System.Drawing.Size(138, 21);
            this.cbbLoaiXe.TabIndex = 17;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(101, 36);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(138, 21);
            this.cbbNCC.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(101, 277);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(139, 21);
            this.txtGiaBan.TabIndex = 15;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá bán";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(101, 234);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(139, 21);
            this.txtTinhTrang.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tình trạng";
            // 
            // txtDungTich
            // 
            this.txtDungTich.Location = new System.Drawing.Point(101, 194);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Size = new System.Drawing.Size(139, 21);
            this.txtDungTich.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dung tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại xe";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(101, 111);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(139, 21);
            this.txtTenXe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên xe";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(101, 74);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(139, 21);
            this.txtMaXe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp";
            // 
            // MAUSAC
            // 
            this.MAUSAC.Caption = "Màu sắc";
            this.MAUSAC.FieldName = "MAUSAC";
            this.MAUSAC.Name = "MAUSAC";
            this.MAUSAC.Visible = true;
            this.MAUSAC.VisibleIndex = 5;
            this.MAUSAC.Width = 92;
            // 
            // frmXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 445);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmXeMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ XE MÁY";
            this.Load += new System.EventHandler(this.frmXeMay_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcXeMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXeMay;
        private DevExpress.XtraGrid.Columns.GridColumn TENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn MAXE;
        private DevExpress.XtraGrid.Columns.GridColumn TENXE;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIXE;
        private DevExpress.XtraGrid.Columns.GridColumn DUNGTICH;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn GIABAN;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDungTich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.ComboBox cbbLoaiXe;
        private System.Windows.Forms.CheckBox cbDisable;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLE;
        private DevExpress.XtraGrid.Columns.GridColumn MAUSAC;
        private System.Windows.Forms.ToolStripButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnQuanLyMauSac;
    }
}