
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
            this.gcXeMay = new DevExpress.XtraGrid.GridControl();
            this.gvXeMay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcXeMay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeMay)).BeginInit();
            this.SuspendLayout();
            // 
            // gcXeMay
            // 
            this.gcXeMay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcXeMay.Location = new System.Drawing.Point(0, 93);
            this.gcXeMay.MainView = this.gvXeMay;
            this.gcXeMay.Name = "gcXeMay";
            this.gcXeMay.Size = new System.Drawing.Size(994, 315);
            this.gcXeMay.TabIndex = 0;
            this.gcXeMay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXeMay});
            // 
            // gvXeMay
            // 
            this.gvXeMay.GridControl = this.gcXeMay;
            this.gvXeMay.Name = "gvXeMay";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(830, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 35);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(830, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(915, 12);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(79, 35);
            this.Xoa.TabIndex = 4;
            this.Xoa.Text = "Xoá";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(915, 52);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 35);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 408);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gcXeMay);
            this.Name = "frmXeMay";
            this.Text = "frmXeMay";
            this.Load += new System.EventHandler(this.frmXeMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcXeMay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeMay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcXeMay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXeMay;
    }
}