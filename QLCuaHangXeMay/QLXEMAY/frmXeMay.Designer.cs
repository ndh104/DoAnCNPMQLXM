
namespace QLXEMAY
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
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcXeMay = new DevExpress.XtraGrid.GridControl();
            this.gvXeMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DUNGTICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAUSAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcThongTin = new DevExpress.XtraEditors.GroupControl();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDungTich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).BeginInit();
            this.gcThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThoat,
            this.btnXoa,
            this.btnSua,
            this.btnThem,
            this.btnLuu,
            this.btnHuy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThoat
            // 
            this.btnThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThoat.Image = global::QLXEMAY.Properties.Resources.thoat;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 52);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::QLXEMAY.Properties.Resources.xoa;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(36, 52);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::QLXEMAY.Properties.Resources.sua;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(36, 52);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.AutoToolTip = false;
            this.btnThem.Image = global::QLXEMAY.Properties.Resources.them;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 52);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLXEMAY.Properties.Resources.luu;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(36, 52);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QLXEMAY.Properties.Resources.huybo;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(50, 52);
            this.btnHuy.Text = "Huỷ bỏ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 55);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gcXeMay);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcThongTin);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(982, 355);
            this.splitContainerControl1.SplitterPosition = 699;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // gcXeMay
            // 
            this.gcXeMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXeMay.Location = new System.Drawing.Point(0, 0);
            this.gcXeMay.MainView = this.gvXeMay;
            this.gcXeMay.Name = "gcXeMay";
            this.gcXeMay.Size = new System.Drawing.Size(699, 355);
            this.gcXeMay.TabIndex = 1;
            this.gcXeMay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXeMay,
            this.gridView1});
            this.gcXeMay.Click += new System.EventHandler(this.gcXeMay_Click);
            // 
            // gvXeMay
            // 
            this.gvXeMay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TENNCC,
            this.MAXE,
            this.TENXE,
            this.TINHTRANG,
            this.DUNGTICH,
            this.MAUSAC,
            this.GIABAN});
            this.gvXeMay.GridControl = this.gcXeMay;
            this.gvXeMay.Name = "gvXeMay";
            // 
            // TENNCC
            // 
            this.TENNCC.Caption = "Tên nhà cung cấp";
            this.TENNCC.FieldName = "TENNCC";
            this.TENNCC.MaxWidth = 200;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Visible = true;
            this.TENNCC.VisibleIndex = 0;
            this.TENNCC.Width = 100;
            // 
            // MAXE
            // 
            this.MAXE.Caption = "Mã xe";
            this.MAXE.FieldName = "MAXE";
            this.MAXE.Name = "MAXE";
            this.MAXE.Visible = true;
            this.MAXE.VisibleIndex = 1;
            this.MAXE.Width = 56;
            // 
            // TENXE
            // 
            this.TENXE.Caption = "Tên xe";
            this.TENXE.FieldName = "TENXE";
            this.TENXE.Name = "TENXE";
            this.TENXE.Visible = true;
            this.TENXE.VisibleIndex = 2;
            this.TENXE.Width = 153;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Caption = "Tình trạng";
            this.TINHTRANG.FieldName = "TINHTRANG";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = true;
            this.TINHTRANG.VisibleIndex = 5;
            this.TINHTRANG.Width = 71;
            // 
            // DUNGTICH
            // 
            this.DUNGTICH.Caption = "Dung tích";
            this.DUNGTICH.FieldName = "DUNGTICH";
            this.DUNGTICH.Name = "DUNGTICH";
            this.DUNGTICH.Visible = true;
            this.DUNGTICH.VisibleIndex = 3;
            this.DUNGTICH.Width = 59;
            // 
            // MAUSAC
            // 
            this.MAUSAC.Caption = "Màu sắc";
            this.MAUSAC.FieldName = "MAUSAC";
            this.MAUSAC.Name = "MAUSAC";
            this.MAUSAC.Visible = true;
            this.MAUSAC.VisibleIndex = 4;
            this.MAUSAC.Width = 113;
            // 
            // GIABAN
            // 
            this.GIABAN.Caption = "Giá bán";
            this.GIABAN.FieldName = "GIABAN";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Visible = true;
            this.GIABAN.VisibleIndex = 6;
            this.GIABAN.Width = 122;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcXeMay;
            this.gridView1.Name = "gridView1";
            // 
            // gcThongTin
            // 
            this.gcThongTin.Controls.Add(this.cmbTinhTrang);
            this.gcThongTin.Controls.Add(this.cmbNhaCungCap);
            this.gcThongTin.Controls.Add(this.label7);
            this.gcThongTin.Controls.Add(this.txtGiaBan);
            this.gcThongTin.Controls.Add(this.label6);
            this.gcThongTin.Controls.Add(this.txtMauSac);
            this.gcThongTin.Controls.Add(this.label5);
            this.gcThongTin.Controls.Add(this.txtDungTich);
            this.gcThongTin.Controls.Add(this.label4);
            this.gcThongTin.Controls.Add(this.txtTen);
            this.gcThongTin.Controls.Add(this.label3);
            this.gcThongTin.Controls.Add(this.txtMa);
            this.gcThongTin.Controls.Add(this.label2);
            this.gcThongTin.Controls.Add(this.label1);
            this.gcThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTin.Location = new System.Drawing.Point(0, 0);
            this.gcThongTin.Name = "gcThongTin";
            this.gcThongTin.Size = new System.Drawing.Size(273, 355);
            this.gcThongTin.TabIndex = 0;
            this.gcThongTin.Text = "Thông tin";
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(102, 220);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(144, 24);
            this.cmbTinhTrang.TabIndex = 15;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(102, 30);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(144, 24);
            this.cmbNhaCungCap.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtGiaBan.Location = new System.Drawing.Point(102, 260);
            this.txtGiaBan.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(144, 23);
            this.txtGiaBan.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tình trạng";
            // 
            // txtMauSac
            // 
            this.txtMauSac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauSac.Location = new System.Drawing.Point(102, 179);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(144, 23);
            this.txtMauSac.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Màu sắc";
            // 
            // txtDungTich
            // 
            this.txtDungTich.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDungTich.Location = new System.Drawing.Point(102, 143);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Size = new System.Drawing.Size(144, 23);
            this.txtDungTich.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dung tích";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(102, 106);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(144, 23);
            this.txtTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên xe";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(102, 67);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(144, 23);
            this.txtMa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà cung cấp";
            // 
            // frmXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 410);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTin)).EndInit();
            this.gcThongTin.ResumeLayout(false);
            this.gcThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcXeMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXeMay;
        private DevExpress.XtraGrid.Columns.GridColumn TENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn MAXE;
        private DevExpress.XtraGrid.Columns.GridColumn TENXE;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn DUNGTICH;
        private DevExpress.XtraGrid.Columns.GridColumn MAUSAC;
        private DevExpress.XtraGrid.Columns.GridColumn GIABAN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl gcThongTin;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDungTich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
    }
}