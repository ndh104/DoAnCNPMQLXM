
namespace CUAHANGXEMAY
{
    partial class frmNhaCungCap
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
            this.btnTrangChu = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckboxNCC = new System.Windows.Forms.CheckBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gvNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrangChu,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnBoQua});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 42);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Image = global::CUAHANGXEMAY.Properties.Resources.trangchucolor;
            this.btnTrangChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(98, 39);
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::CUAHANGXEMAY.Properties.Resources.themcolor;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 39);
            this.btnThem.Text = "Thêm nhà cung cấp";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::CUAHANGXEMAY.Properties.Resources.suacolor;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 39);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::CUAHANGXEMAY.Properties.Resources.xoacolor1;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 39);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::CUAHANGXEMAY.Properties.Resources.luucolor;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 39);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::CUAHANGXEMAY.Properties.Resources.huycolor;
            this.btnBoQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(83, 39);
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckboxNCC);
            this.panel1.Controls.Add(this.txtSDTNCC);
            this.panel1.Controls.Add(this.txtDiaChiNCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenNCC);
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 319);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 103);
            this.panel1.TabIndex = 4;
            // 
            // CheckboxNCC
            // 
            this.CheckboxNCC.AutoSize = true;
            this.CheckboxNCC.Location = new System.Drawing.Point(590, 76);
            this.CheckboxNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckboxNCC.Name = "CheckboxNCC";
            this.CheckboxNCC.Size = new System.Drawing.Size(60, 17);
            this.CheckboxNCC.TabIndex = 8;
            this.CheckboxNCC.Text = "Disable";
            this.CheckboxNCC.UseVisualStyleBackColor = true;
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(435, 50);
            this.txtSDTNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(217, 21);
            this.txtSDTNCC.TabIndex = 7;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(126, 77);
            this.txtDiaChiNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(444, 21);
            this.txtDiaChiNCC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(126, 20);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(526, 21);
            this.txtTenNCC.TabIndex = 3;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(126, 50);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(190, 21);
            this.txtMaNCC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // gcNhaCungCap
            // 
            this.gcNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhaCungCap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNhaCungCap.Location = new System.Drawing.Point(0, 42);
            this.gcNhaCungCap.MainView = this.gvNhaCungCap;
            this.gcNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcNhaCungCap.Name = "gcNhaCungCap";
            this.gcNhaCungCap.Size = new System.Drawing.Size(790, 277);
            this.gcNhaCungCap.TabIndex = 6;
            this.gcNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhaCungCap});
            // 
            // gvNhaCungCap
            // 
            this.gvNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANCC,
            this.TENNCC,
            this.DIACHI,
            this.SDT,
            this.DISABLE});
            this.gvNhaCungCap.DetailHeight = 284;
            this.gvNhaCungCap.GridControl = this.gcNhaCungCap;
            this.gvNhaCungCap.Name = "gvNhaCungCap";
            this.gvNhaCungCap.OptionsView.ShowGroupPanel = false;
            this.gvNhaCungCap.Click += new System.EventHandler(this.gvNhaCungCap_Click);
            // 
            // MANCC
            // 
            this.MANCC.Caption = "Mã nhà cung cấp";
            this.MANCC.FieldName = "MANCC";
            this.MANCC.MinWidth = 21;
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = true;
            this.MANCC.VisibleIndex = 0;
            this.MANCC.Width = 128;
            // 
            // TENNCC
            // 
            this.TENNCC.Caption = "Tên nhà cung cấp";
            this.TENNCC.FieldName = "TENNCC";
            this.TENNCC.MinWidth = 21;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Visible = true;
            this.TENNCC.VisibleIndex = 1;
            this.TENNCC.Width = 175;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MinWidth = 21;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 2;
            this.DIACHI.Width = 200;
            // 
            // SDT
            // 
            this.SDT.Caption = "Số điện thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.MinWidth = 21;
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 3;
            this.SDT.Width = 156;
            // 
            // DISABLE
            // 
            this.DISABLE.Caption = "Disable";
            this.DISABLE.FieldName = "DISABLE";
            this.DISABLE.MinWidth = 21;
            this.DISABLE.Name = "DISABLE";
            this.DISABLE.Visible = true;
            this.DISABLE.VisibleIndex = 4;
            this.DISABLE.Width = 106;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 422);
            this.Controls.Add(this.gcNhaCungCap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhaCungCap";
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTrangChu;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckboxNCC;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn MANCC;
        private DevExpress.XtraGrid.Columns.GridColumn TENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLE;
    }
}