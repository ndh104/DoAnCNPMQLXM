
namespace CUAHANGXEMAY
{
    partial class frmLoaiXe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckboxLoaiXe = new System.Windows.Forms.CheckBox();
            this.txtTenLoaiXe = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTrangChu = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoQua = new System.Windows.Forms.ToolStripButton();
            this.gcLoaiXe = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIXE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DISABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckboxLoaiXe);
            this.panel1.Controls.Add(this.txtTenLoaiXe);
            this.panel1.Controls.Add(this.txtMaLoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 91);
            this.panel1.TabIndex = 8;
            // 
            // CheckboxLoaiXe
            // 
            this.CheckboxLoaiXe.AutoSize = true;
            this.CheckboxLoaiXe.Location = new System.Drawing.Point(566, 50);
            this.CheckboxLoaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckboxLoaiXe.Name = "CheckboxLoaiXe";
            this.CheckboxLoaiXe.Size = new System.Drawing.Size(60, 17);
            this.CheckboxLoaiXe.TabIndex = 8;
            this.CheckboxLoaiXe.Text = "Disable";
            this.CheckboxLoaiXe.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiXe
            // 
            this.txtTenLoaiXe.Location = new System.Drawing.Point(126, 20);
            this.txtTenLoaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiXe.Name = "txtTenLoaiXe";
            this.txtTenLoaiXe.Size = new System.Drawing.Size(526, 21);
            this.txtTenLoaiXe.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(126, 50);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(406, 21);
            this.txtMaLoai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại";
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
            this.toolStrip1.Size = new System.Drawing.Size(708, 42);
            this.toolStrip1.TabIndex = 6;
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
            this.btnThem.Size = new System.Drawing.Size(113, 39);
            this.btnThem.Text = "Thêm loại xe";
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
            // gcLoaiXe
            // 
            this.gcLoaiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiXe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcLoaiXe.Location = new System.Drawing.Point(0, 42);
            this.gcLoaiXe.MainView = this.gvLoaiXe;
            this.gcLoaiXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcLoaiXe.Name = "gcLoaiXe";
            this.gcLoaiXe.Size = new System.Drawing.Size(708, 241);
            this.gcLoaiXe.TabIndex = 9;
            this.gcLoaiXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiXe});
            // 
            // gvLoaiXe
            // 
            this.gvLoaiXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MALOAI,
            this.TENLOAIXE,
            this.DISABLE});
            this.gvLoaiXe.DetailHeight = 284;
            this.gvLoaiXe.GridControl = this.gcLoaiXe;
            this.gvLoaiXe.Name = "gvLoaiXe";
            this.gvLoaiXe.OptionsView.ShowGroupPanel = false;
            this.gvLoaiXe.Click += new System.EventHandler(this.gvLoaiXe_Click);
            // 
            // MALOAI
            // 
            this.MALOAI.Caption = "Mã loại";
            this.MALOAI.FieldName = "MALOAI";
            this.MALOAI.MinWidth = 21;
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.Visible = true;
            this.MALOAI.VisibleIndex = 0;
            this.MALOAI.Width = 81;
            // 
            // TENLOAIXE
            // 
            this.TENLOAIXE.Caption = "Tên loại xe";
            this.TENLOAIXE.FieldName = "TENLOAIXE";
            this.TENLOAIXE.MinWidth = 21;
            this.TENLOAIXE.Name = "TENLOAIXE";
            this.TENLOAIXE.Visible = true;
            this.TENLOAIXE.VisibleIndex = 1;
            this.TENLOAIXE.Width = 81;
            // 
            // DISABLE
            // 
            this.DISABLE.Caption = "Disable";
            this.DISABLE.FieldName = "DISABLE";
            this.DISABLE.MinWidth = 21;
            this.DISABLE.Name = "DISABLE";
            this.DISABLE.Visible = true;
            this.DISABLE.VisibleIndex = 2;
            this.DISABLE.Width = 81;
            // 
            // frmLoaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 374);
            this.Controls.Add(this.gcLoaiXe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoaiXe";
            this.Text = "QUẢN LÝ LOẠI XE MÁY";
            this.Load += new System.EventHandler(this.frmLoaiXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckboxLoaiXe;
        private System.Windows.Forms.TextBox txtTenLoaiXe;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTrangChu;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoQua;
        private DevExpress.XtraGrid.GridControl gcLoaiXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn MALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIXE;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLE;
    }
}