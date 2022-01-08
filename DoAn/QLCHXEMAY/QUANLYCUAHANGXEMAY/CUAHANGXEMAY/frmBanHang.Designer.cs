
namespace CUAHANGXEMAY
{
    partial class frmBanHang
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcBanHang = new DevExpress.XtraGrid.GridControl();
            this.gvBanHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAHOADON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAPHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNVLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKHMUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENXEBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAUSACXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONGBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbMauSac = new System.Windows.Forms.ComboBox();
            this.cbbTenKH = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new DevExpress.XtraEditors.LabelControl();
            this.txtGiaBan = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenXe = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.duongNetXuat = new System.Windows.Forms.ToolStripSeparator();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXuatHD = new System.Windows.Forms.ToolStripButton();
            this.lblNhanVien = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1118, 442);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gcHoaDon);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1116, 417);
            this.xtraTabPage1.Text = "Thông tin hoá đơn";
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHoaDon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcHoaDon.Location = new System.Drawing.Point(0, 0);
            this.gcHoaDon.MainView = this.gvHoaDon;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(1116, 417);
            this.gcHoaDon.TabIndex = 9;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvHoaDon.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHD,
            this.NGAYLAP,
            this.TENNV,
            this.TENKH,
            this.TENXE,
            this.TENMAU,
            this.GIABAN,
            this.SOLUONG,
            this.TONGTIEN});
            this.gvHoaDon.GridControl = this.gcHoaDon;
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsView.ShowFooter = true;
            // 
            // MAHD
            // 
            this.MAHD.Caption = "Mã hoá đơn";
            this.MAHD.FieldName = "MAHD";
            this.MAHD.MaxWidth = 150;
            this.MAHD.Name = "MAHD";
            this.MAHD.Visible = true;
            this.MAHD.VisibleIndex = 0;
            this.MAHD.Width = 104;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Caption = "Ngày lập";
            this.NGAYLAP.FieldName = "NGAYLAP";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Visible = true;
            this.NGAYLAP.VisibleIndex = 1;
            this.NGAYLAP.Width = 87;
            // 
            // TENNV
            // 
            this.TENNV.Caption = "Tên nhân viên";
            this.TENNV.FieldName = "TENNV";
            this.TENNV.Name = "TENNV";
            this.TENNV.Visible = true;
            this.TENNV.VisibleIndex = 2;
            this.TENNV.Width = 124;
            // 
            // TENKH
            // 
            this.TENKH.Caption = "Tên khách hàng";
            this.TENKH.FieldName = "TENKH";
            this.TENKH.Name = "TENKH";
            this.TENKH.Visible = true;
            this.TENKH.VisibleIndex = 3;
            this.TENKH.Width = 153;
            // 
            // TENXE
            // 
            this.TENXE.Caption = "Tên xe";
            this.TENXE.FieldName = "TENXE";
            this.TENXE.Name = "TENXE";
            this.TENXE.Visible = true;
            this.TENXE.VisibleIndex = 4;
            this.TENXE.Width = 108;
            // 
            // TENMAU
            // 
            this.TENMAU.Caption = "Màu sắc";
            this.TENMAU.FieldName = "TENMAU";
            this.TENMAU.Name = "TENMAU";
            this.TENMAU.Visible = true;
            this.TENMAU.VisibleIndex = 5;
            this.TENMAU.Width = 99;
            // 
            // GIABAN
            // 
            this.GIABAN.Caption = "Giá bán(VND)";
            this.GIABAN.DisplayFormat.FormatString = "0,0";
            this.GIABAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIABAN.FieldName = "GIABAN";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Visible = true;
            this.GIABAN.VisibleIndex = 6;
            this.GIABAN.Width = 116;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "Số lượng";
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 7;
            this.SOLUONG.Width = 92;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.Caption = "Tổng tiền (VND)";
            this.TONGTIEN.DisplayFormat.FormatString = "0,0";
            this.TONGTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TONGTIEN.FieldName = "TONGTIEN";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TONGTIEN", "Tổng tiền={0:n0}")});
            this.TONGTIEN.Visible = true;
            this.TONGTIEN.VisibleIndex = 8;
            this.TONGTIEN.Width = 137;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gcBanHang);
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.Controls.Add(this.toolStrip1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1116, 417);
            this.xtraTabPage2.Text = "Bán hàng";
            // 
            // gcBanHang
            // 
            this.gcBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBanHang.Location = new System.Drawing.Point(0, 228);
            this.gcBanHang.MainView = this.gvBanHang;
            this.gcBanHang.Name = "gcBanHang";
            this.gcBanHang.Size = new System.Drawing.Size(1116, 189);
            this.gcBanHang.TabIndex = 12;
            this.gcBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBanHang});
            // 
            // gvBanHang
            // 
            this.gvBanHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHOADON,
            this.NGAYLAPHD,
            this.TENNVLAP,
            this.TENKHMUA,
            this.TENXEBAN,
            this.MAUSACXE,
            this.GIABANXE,
            this.SOLUONGBAN,
            this.THANHTIEN});
            this.gvBanHang.GridControl = this.gcBanHang;
            this.gvBanHang.Name = "gvBanHang";
            // 
            // MAHOADON
            // 
            this.MAHOADON.Caption = "Mã hoá đơn";
            this.MAHOADON.FieldName = "MAHD";
            this.MAHOADON.MaxWidth = 100;
            this.MAHOADON.Name = "MAHOADON";
            this.MAHOADON.Visible = true;
            this.MAHOADON.VisibleIndex = 0;
            this.MAHOADON.Width = 100;
            // 
            // NGAYLAPHD
            // 
            this.NGAYLAPHD.Caption = "Ngày lập";
            this.NGAYLAPHD.FieldName = "NGAYLAP";
            this.NGAYLAPHD.Name = "NGAYLAPHD";
            this.NGAYLAPHD.Visible = true;
            this.NGAYLAPHD.VisibleIndex = 1;
            this.NGAYLAPHD.Width = 112;
            // 
            // TENNVLAP
            // 
            this.TENNVLAP.Caption = "Tên nhân viên";
            this.TENNVLAP.FieldName = "TENNV";
            this.TENNVLAP.Name = "TENNVLAP";
            this.TENNVLAP.Visible = true;
            this.TENNVLAP.VisibleIndex = 2;
            this.TENNVLAP.Width = 128;
            // 
            // TENKHMUA
            // 
            this.TENKHMUA.Caption = "Tên khách hàng";
            this.TENKHMUA.FieldName = "TENKH";
            this.TENKHMUA.Name = "TENKHMUA";
            this.TENKHMUA.Visible = true;
            this.TENKHMUA.VisibleIndex = 3;
            this.TENKHMUA.Width = 159;
            // 
            // TENXEBAN
            // 
            this.TENXEBAN.Caption = "Tên xe";
            this.TENXEBAN.FieldName = "TENXE";
            this.TENXEBAN.Name = "TENXEBAN";
            this.TENXEBAN.Visible = true;
            this.TENXEBAN.VisibleIndex = 4;
            this.TENXEBAN.Width = 106;
            // 
            // MAUSACXE
            // 
            this.MAUSACXE.Caption = "Màu sắc";
            this.MAUSACXE.FieldName = "MAUSAC";
            this.MAUSACXE.Name = "MAUSACXE";
            this.MAUSACXE.Visible = true;
            this.MAUSACXE.VisibleIndex = 5;
            this.MAUSACXE.Width = 103;
            // 
            // GIABANXE
            // 
            this.GIABANXE.Caption = "Giá bán";
            this.GIABANXE.FieldName = "GIABAN";
            this.GIABANXE.Name = "GIABANXE";
            this.GIABANXE.Visible = true;
            this.GIABANXE.VisibleIndex = 6;
            this.GIABANXE.Width = 136;
            // 
            // SOLUONGBAN
            // 
            this.SOLUONGBAN.Caption = "Số lượng";
            this.SOLUONGBAN.FieldName = "SOLUONG";
            this.SOLUONGBAN.Name = "SOLUONGBAN";
            this.SOLUONGBAN.Visible = true;
            this.SOLUONGBAN.VisibleIndex = 7;
            this.SOLUONGBAN.Width = 95;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.Caption = "Thành tiền";
            this.THANHTIEN.FieldName = "TONGTIEN";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Visible = true;
            this.THANHTIEN.VisibleIndex = 8;
            this.THANHTIEN.Width = 152;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(200)))), ((int)(((byte)(234)))));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Appearance.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.Controls.Add(this.lblNhanVien);
            this.groupControl1.Controls.Add(this.cbbMauSac);
            this.groupControl1.Controls.Add(this.cbbTenKH);
            this.groupControl1.Controls.Add(this.txtThanhTien);
            this.groupControl1.Controls.Add(this.txtGiaBan);
            this.groupControl1.Controls.Add(this.cbbTenXe);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.separatorControl1);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.dtpNgayLap);
            this.groupControl1.Controls.Add(this.txtMaHD);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1116, 176);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin hoá đơn";
            // 
            // cbbMauSac
            // 
            this.cbbMauSac.FormattingEnabled = true;
            this.cbbMauSac.Location = new System.Drawing.Point(817, 68);
            this.cbbMauSac.Name = "cbbMauSac";
            this.cbbMauSac.Size = new System.Drawing.Size(167, 24);
            this.cbbMauSac.TabIndex = 25;
            // 
            // cbbTenKH
            // 
            this.cbbTenKH.FormattingEnabled = true;
            this.cbbTenKH.Location = new System.Drawing.Point(523, 68);
            this.cbbTenKH.Name = "cbbTenKH";
            this.cbbTenKH.Size = new System.Drawing.Size(167, 24);
            this.cbbTenKH.TabIndex = 24;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Appearance.Options.UseFont = true;
            this.txtThanhTien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtThanhTien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.txtThanhTien.Location = new System.Drawing.Point(817, 123);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(167, 23);
            this.txtThanhTien.TabIndex = 22;
            this.txtThanhTien.Text = "...";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Appearance.Options.UseFont = true;
            this.txtGiaBan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.txtGiaBan.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.txtGiaBan.Location = new System.Drawing.Point(187, 123);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(167, 23);
            this.txtGiaBan.TabIndex = 21;
            this.txtGiaBan.Text = "...";
            // 
            // cbbTenXe
            // 
            this.cbbTenXe.FormattingEnabled = true;
            this.cbbTenXe.Location = new System.Drawing.Point(817, 31);
            this.cbbTenXe.Name = "cbbTenXe";
            this.cbbTenXe.Size = new System.Drawing.Size(167, 24);
            this.cbbTenXe.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(755, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "*Tổng tiền đã bao gồm thuế VAT 10%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Giá bán";
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineColor = System.Drawing.Color.Blue;
            this.separatorControl1.LineThickness = 1;
            this.separatorControl1.Location = new System.Drawing.Point(0, 97);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(1113, 20);
            this.separatorControl1.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(523, 123);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(167, 23);
            this.txtSoLuong.TabIndex = 13;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(187, 66);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(167, 23);
            this.dtpNgayLap.TabIndex = 11;
            this.dtpNgayLap.Value = new System.DateTime(2022, 1, 7, 0, 0, 0, 0);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(187, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(167, 23);
            this.txtMaHD.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(756, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Màu sắc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(742, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemHoaDon,
            this.btnLuu,
            this.duongNetXuat,
            this.btnHuy,
            this.toolStripSeparator1,
            this.btnXuatHD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1116, 52);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.AutoSize = false;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.Image = global::CUAHANGXEMAY.Properties.Resources.laphoadoncolor;
            this.btnThemHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(52, 52);
            this.btnThemHoaDon.Text = "Thêm ";
            this.btnThemHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLuu.AutoSize = false;
            this.btnLuu.Image = global::CUAHANGXEMAY.Properties.Resources.luucolor;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 52);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // duongNetXuat
            // 
            this.duongNetXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.duongNetXuat.Name = "duongNetXuat";
            this.duongNetXuat.Size = new System.Drawing.Size(6, 52);
            // 
            // btnHuy
            // 
            this.btnHuy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHuy.AutoSize = false;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::CUAHANGXEMAY.Properties.Resources.huycolor;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(52, 52);
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXuatHD.AutoSize = false;
            this.btnXuatHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.Image = global::CUAHANGXEMAY.Properties.Resources.xuathdcolor1;
            this.btnXuatHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(52, 52);
            this.btnXuatHD.Text = "Xuất";
            this.btnXuatHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Appearance.Options.UseFont = true;
            this.lblNhanVien.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNhanVien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.lblNhanVien.Location = new System.Drawing.Point(523, 31);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(167, 23);
            this.lblNhanVien.TabIndex = 26;
            this.lblNhanVien.Text = "...";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 442);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmBanHang";
            this.Text = "BÁN HÀNG";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn MAHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn TENNV;
        private DevExpress.XtraGrid.Columns.GridColumn TENKH;
        private DevExpress.XtraGrid.Columns.GridColumn TENXE;
        private DevExpress.XtraGrid.Columns.GridColumn TENMAU;
        private DevExpress.XtraGrid.Columns.GridColumn GIABAN;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TONGTIEN;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemHoaDon;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripSeparator duongNetXuat;
        private System.Windows.Forms.ToolStripButton btnXuatHD;
        private DevExpress.XtraGrid.GridControl gcBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBanHang;
        private DevExpress.XtraGrid.Columns.GridColumn MAHOADON;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAPHD;
        private DevExpress.XtraGrid.Columns.GridColumn TENNVLAP;
        private DevExpress.XtraGrid.Columns.GridColumn TENKHMUA;
        private DevExpress.XtraGrid.Columns.GridColumn TENXEBAN;
        private DevExpress.XtraGrid.Columns.GridColumn MAUSACXE;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANXE;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONGBAN;
        private DevExpress.XtraGrid.Columns.GridColumn THANHTIEN;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbbTenXe;
        private DevExpress.XtraEditors.LabelControl txtThanhTien;
        private DevExpress.XtraEditors.LabelControl txtGiaBan;
        private System.Windows.Forms.ComboBox cbbMauSac;
        private System.Windows.Forms.ComboBox cbbTenKH;
        private DevExpress.XtraEditors.LabelControl lblNhanVien;
    }
}