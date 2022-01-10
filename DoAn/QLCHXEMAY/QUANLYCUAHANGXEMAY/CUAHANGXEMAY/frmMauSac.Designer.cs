
namespace CUAHANGXEMAY
{
    partial class frmMauSac
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcMauSac = new DevExpress.XtraGrid.GridControl();
            this.gvMauSac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDMAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTenMau = new System.Windows.Forms.TextBox();
            this.txtIDMau = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcMauSac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMauSac)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(449, 129);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(226, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "QUẢN LÝ MÀU SẮC";
            // 
            // gcMauSac
            // 
            this.gcMauSac.Location = new System.Drawing.Point(206, 117);
            this.gcMauSac.MainView = this.gvMauSac;
            this.gcMauSac.Name = "gcMauSac";
            this.gcMauSac.Size = new System.Drawing.Size(225, 366);
            this.gcMauSac.TabIndex = 1;
            this.gcMauSac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMauSac});
            // 
            // gvMauSac
            // 
            this.gvMauSac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDMAU,
            this.TENMAU});
            this.gvMauSac.GridControl = this.gcMauSac;
            this.gvMauSac.Name = "gvMauSac";
            this.gvMauSac.Click += new System.EventHandler(this.gvMauSac_Click);
            // 
            // IDMAU
            // 
            this.IDMAU.Caption = "ID Màu";
            this.IDMAU.FieldName = "IDMAU";
            this.IDMAU.Name = "IDMAU";
            this.IDMAU.Visible = true;
            this.IDMAU.VisibleIndex = 0;
            this.IDMAU.Width = 83;
            // 
            // TENMAU
            // 
            this.TENMAU.Caption = "Tên màu";
            this.TENMAU.FieldName = "TENMAU";
            this.TENMAU.Name = "TENMAU";
            this.TENMAU.Visible = true;
            this.TENMAU.VisibleIndex = 1;
            this.TENMAU.Width = 114;
            // 
            // txtTenMau
            // 
            this.txtTenMau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMau.Location = new System.Drawing.Point(480, 271);
            this.txtTenMau.Name = "txtTenMau";
            this.txtTenMau.Size = new System.Drawing.Size(164, 27);
            this.txtTenMau.TabIndex = 2;
            // 
            // txtIDMau
            // 
            this.txtIDMau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMau.Location = new System.Drawing.Point(520, 216);
            this.txtIDMau.Name = "txtIDMau";
            this.txtIDMau.Size = new System.Drawing.Size(85, 27);
            this.txtIDMau.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ImageOptions.Image = global::CUAHANGXEMAY.Properties.Resources.pwo;
            this.btnThoat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(654, 443);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(537, 194);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ID Màu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(531, 249);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tên màu";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.BackgroundImage = global::CUAHANGXEMAY.Properties.Resources.themmau;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThem.Location = new System.Drawing.Point(462, 315);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(572, 315);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(462, 361);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 40);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(572, 361);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 40);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmMauSac
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::CUAHANGXEMAY.Properties.Resources.bgmausac;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtIDMau);
            this.Controls.Add(this.txtTenMau);
            this.Controls.Add(this.gcMauSac);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMauSac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ MÀU SẮC";
            this.Load += new System.EventHandler(this.frmMauSac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcMauSac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMauSac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcMauSac;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMauSac;
        private DevExpress.XtraGrid.Columns.GridColumn IDMAU;
        private DevExpress.XtraGrid.Columns.GridColumn TENMAU;
        private System.Windows.Forms.TextBox txtTenMau;
        private System.Windows.Forms.TextBox txtIDMau;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}