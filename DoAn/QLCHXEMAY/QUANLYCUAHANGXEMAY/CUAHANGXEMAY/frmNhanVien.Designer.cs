﻿
namespace CUAHANGXEMAY
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUC_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOI_TINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SO_CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTrangChu = new System.Windows.Forms.ToolStripButton();
            this.btnThemNV = new System.Windows.Forms.ToolStripButton();
            this.btnSuaNV = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNV = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkDisabled);
            this.groupControl1.Controls.Add(this.cmbChucVu);
            this.groupControl1.Controls.Add(this.dtpNgaySinh);
            this.groupControl1.Controls.Add(this.cmbGioiTinh);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtSoDT);
            this.groupControl1.Controls.Add(this.txtCMND);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.txtTenNV);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 360);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1165, 188);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisabled.Location = new System.Drawing.Point(685, 140);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(102, 26);
            this.chkDisabled.TabIndex = 21;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Bán hàng",
            "Tư vấn",
            "Thu ngân"});
            this.cmbChucVu.Location = new System.Drawing.Point(913, 137);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(208, 30);
            this.cmbChucVu.TabIndex = 20;
            this.cmbChucVu.Text = "Quản lý";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(423, 94);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(364, 29);
            this.dtpNgaySinh.TabIndex = 19;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(166, 96);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 30);
            this.cmbGioiTinh.TabIndex = 18;
            this.cmbGioiTinh.Text = "Nam";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(166, 138);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(496, 29);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(913, 96);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(208, 29);
            this.txtSoDT.TabIndex = 14;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(913, 55);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(208, 29);
            this.txtCMND.TabIndex = 15;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(166, 55);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(122, 29);
            this.txtMaNV.TabIndex = 16;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(423, 55);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(367, 29);
            this.txtTenNV.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(793, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(822, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(832, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã nhân viên";
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 50);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1165, 498);
            this.gcNhanVien.TabIndex = 6;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NV,
            this.TEN_NV,
            this.CHUC_VU,
            this.NGAY_SINH,
            this.GIOI_TINH,
            this.DIA_CHI,
            this.SO_DT,
            this.SO_CMND,
            this.DISABLED});
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvNhanVien_CustomDrawCell);
            this.gvNhanVien.Click += new System.EventHandler(this.gvNhanVien_Click);
            // 
            // MA_NV
            // 
            this.MA_NV.Caption = "Mã nhân viên";
            this.MA_NV.FieldName = "MANV";
            this.MA_NV.MaxWidth = 150;
            this.MA_NV.MinWidth = 30;
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.OptionsColumn.AllowEdit = false;
            this.MA_NV.Visible = true;
            this.MA_NV.VisibleIndex = 0;
            this.MA_NV.Width = 108;
            // 
            // TEN_NV
            // 
            this.TEN_NV.Caption = "Tên nhân viên";
            this.TEN_NV.FieldName = "TENNV";
            this.TEN_NV.MinWidth = 30;
            this.TEN_NV.Name = "TEN_NV";
            this.TEN_NV.OptionsColumn.AllowEdit = false;
            this.TEN_NV.Visible = true;
            this.TEN_NV.VisibleIndex = 1;
            this.TEN_NV.Width = 178;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.Caption = "Chức vụ";
            this.CHUC_VU.FieldName = "CHUCVU";
            this.CHUC_VU.MinWidth = 30;
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.OptionsColumn.AllowEdit = false;
            this.CHUC_VU.Visible = true;
            this.CHUC_VU.VisibleIndex = 2;
            this.CHUC_VU.Width = 89;
            // 
            // NGAY_SINH
            // 
            this.NGAY_SINH.Caption = "Ngày sinh";
            this.NGAY_SINH.FieldName = "NGAYSINH";
            this.NGAY_SINH.MinWidth = 30;
            this.NGAY_SINH.Name = "NGAY_SINH";
            this.NGAY_SINH.OptionsColumn.AllowEdit = false;
            this.NGAY_SINH.Visible = true;
            this.NGAY_SINH.VisibleIndex = 3;
            this.NGAY_SINH.Width = 107;
            // 
            // GIOI_TINH
            // 
            this.GIOI_TINH.Caption = "Giới tính";
            this.GIOI_TINH.FieldName = "GIOITINH";
            this.GIOI_TINH.MinWidth = 30;
            this.GIOI_TINH.Name = "GIOI_TINH";
            this.GIOI_TINH.OptionsColumn.AllowEdit = false;
            this.GIOI_TINH.Visible = true;
            this.GIOI_TINH.VisibleIndex = 4;
            this.GIOI_TINH.Width = 77;
            // 
            // DIA_CHI
            // 
            this.DIA_CHI.Caption = "Địa chỉ";
            this.DIA_CHI.FieldName = "DIACHI";
            this.DIA_CHI.MinWidth = 30;
            this.DIA_CHI.Name = "DIA_CHI";
            this.DIA_CHI.OptionsColumn.AllowEdit = false;
            this.DIA_CHI.Visible = true;
            this.DIA_CHI.VisibleIndex = 5;
            this.DIA_CHI.Width = 219;
            // 
            // SO_DT
            // 
            this.SO_DT.Caption = "Số điện thoại";
            this.SO_DT.FieldName = "SDT";
            this.SO_DT.MinWidth = 30;
            this.SO_DT.Name = "SO_DT";
            this.SO_DT.OptionsColumn.AllowEdit = false;
            this.SO_DT.Visible = true;
            this.SO_DT.VisibleIndex = 7;
            this.SO_DT.Width = 124;
            // 
            // SO_CMND
            // 
            this.SO_CMND.Caption = "Số CMND";
            this.SO_CMND.FieldName = "CMND";
            this.SO_CMND.MinWidth = 30;
            this.SO_CMND.Name = "SO_CMND";
            this.SO_CMND.OptionsColumn.AllowEdit = false;
            this.SO_CMND.Visible = true;
            this.SO_CMND.VisibleIndex = 6;
            this.SO_CMND.Width = 139;
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "Disabled";
            this.DISABLED.FieldName = "DISABLE";
            this.DISABLED.MinWidth = 30;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.OptionsColumn.AllowEdit = false;
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 8;
            this.DISABLED.Width = 88;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Bisque;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrangChu,
            this.btnThemNV,
            this.btnSuaNV,
            this.btnXoaNV,
            this.btnLuu,
            this.btnBoQua,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1165, 50);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.AutoSize = false;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(150, 45);
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(165, 45);
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.AutoSize = false;
            this.btnSuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.Image")));
            this.btnSuaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(150, 45);
            this.btnSuaNV.Text = "Sửa thông tin";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.AutoSize = false;
            this.btnXoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.Image")));
            this.btnXoaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(100, 45);
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = false;
            this.btnLuu.Image = global::CUAHANGXEMAY.Properties.Resources._7005829;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 45);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(96, 45);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 45);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 548);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmNhanVien.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NV;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NV;
        private DevExpress.XtraGrid.Columns.GridColumn CHUC_VU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_SINH;
        private DevExpress.XtraGrid.Columns.GridColumn GIOI_TINH;
        private DevExpress.XtraGrid.Columns.GridColumn DIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn SO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn SO_CMND;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTrangChu;
        private System.Windows.Forms.ToolStripButton btnThemNV;
        private System.Windows.Forms.ToolStripButton btnSuaNV;
        private System.Windows.Forms.ToolStripButton btnXoaNV;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.CheckBox chkDisabled;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
    }
}