
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnThemHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.btnXuatHD = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAUSAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DUNGTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIn,
            this.btnThemHoaDon,
            this.btnXoa,
            this.btnHuy,
            this.btnXuatHD,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1006, 52);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnIn
            // 
            this.btnIn.AutoSize = false;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::CUAHANGXEMAY.Properties.Resources.printer1;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(52, 52);
            this.btnIn.Text = "Print";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.AutoSize = false;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.Image = global::CUAHANGXEMAY.Properties.Resources.hoadon;
            this.btnThemHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(52, 52);
            this.btnThemHoaDon.Text = "Thêm ";
            this.btnThemHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::CUAHANGXEMAY.Properties.Resources.xoa;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 52);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnHuy
            // 
            this.btnHuy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHuy.AutoSize = false;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::CUAHANGXEMAY.Properties.Resources.huybo;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(52, 52);
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXuatHD.AutoSize = false;
            this.btnXuatHD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.Image = global::CUAHANGXEMAY.Properties.Resources.xuathd;
            this.btnXuatHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(52, 52);
            this.btnXuatHD.Text = "Xuất";
            this.btnXuatHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::CUAHANGXEMAY.Properties.Resources.thoat;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 52);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcHoaDon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcHoaDon.Location = new System.Drawing.Point(0, 170);
            this.gcHoaDon.MainView = this.gvHoaDon;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(1006, 308);
            this.gcHoaDon.TabIndex = 6;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENNCC,
            this.MAHD,
            this.NGAYLAP,
            this.TENNV,
            this.TENKH,
            this.TENXE,
            this.MAUSAC,
            this.DUNGTICH,
            this.TINHTRANG,
            this.SOLUONG,
            this.DONGIA});
            this.gvHoaDon.GridControl = this.gcHoaDon;
            this.gvHoaDon.Name = "gvHoaDon";
            // 
            // TENNCC
            // 
            this.TENNCC.Caption = "Nhà cung cấp";
            this.TENNCC.FieldName = "TENNCC";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Visible = true;
            this.TENNCC.VisibleIndex = 5;
            this.TENNCC.Width = 92;
            // 
            // MAHD
            // 
            this.MAHD.Caption = "Mã hoá đơn";
            this.MAHD.FieldName = "MAHD";
            this.MAHD.MaxWidth = 100;
            this.MAHD.Name = "MAHD";
            this.MAHD.Visible = true;
            this.MAHD.VisibleIndex = 0;
            this.MAHD.Width = 81;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Caption = "Ngày lập";
            this.NGAYLAP.FieldName = "NGAYLAP";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Visible = true;
            this.NGAYLAP.VisibleIndex = 1;
            this.NGAYLAP.Width = 92;
            // 
            // TENNV
            // 
            this.TENNV.Caption = "Tên nhân viên";
            this.TENNV.FieldName = "TENNV";
            this.TENNV.Name = "TENNV";
            this.TENNV.Visible = true;
            this.TENNV.VisibleIndex = 2;
            this.TENNV.Width = 100;
            // 
            // TENKH
            // 
            this.TENKH.Caption = "Tên khách hàng";
            this.TENKH.FieldName = "TENKH";
            this.TENKH.Name = "TENKH";
            this.TENKH.Visible = true;
            this.TENKH.VisibleIndex = 3;
            this.TENKH.Width = 110;
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
            // MAUSAC
            // 
            this.MAUSAC.Caption = "Màu sắc";
            this.MAUSAC.FieldName = "MAUSAC";
            this.MAUSAC.Name = "MAUSAC";
            this.MAUSAC.Visible = true;
            this.MAUSAC.VisibleIndex = 6;
            this.MAUSAC.Width = 90;
            // 
            // DUNGTICH
            // 
            this.DUNGTICH.Caption = "Dung tích";
            this.DUNGTICH.FieldName = "DUNGTICH";
            this.DUNGTICH.Name = "DUNGTICH";
            this.DUNGTICH.Visible = true;
            this.DUNGTICH.VisibleIndex = 7;
            this.DUNGTICH.Width = 77;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Caption = "Tình trạng";
            this.TINHTRANG.FieldName = "TINHTRANG";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = true;
            this.TINHTRANG.VisibleIndex = 8;
            this.TINHTRANG.Width = 91;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "Số lượng";
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 9;
            this.SOLUONG.Width = 74;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "Tổng tiền";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 10;
            this.DONGIA.Width = 106;
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1006, 118);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin hoá đơn";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 478);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcHoaDon);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBanHang";
            this.Text = "BÁN HÀNG";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnThemHoaDon;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripButton btnXuatHD;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn TENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn MAHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn TENNV;
        private DevExpress.XtraGrid.Columns.GridColumn TENKH;
        private DevExpress.XtraGrid.Columns.GridColumn TENXE;
        private DevExpress.XtraGrid.Columns.GridColumn MAUSAC;
        private DevExpress.XtraGrid.Columns.GridColumn DUNGTICH;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}