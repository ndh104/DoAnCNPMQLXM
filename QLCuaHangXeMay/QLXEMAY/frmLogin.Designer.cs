
namespace QLXEMAY
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThoat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.Color.White;
            this.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(41, 12);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(266, 20);
            this.txtTK.TabIndex = 2;
            this.txtTK.Text = "Tài khoản";
            this.txtTK.Click += new System.EventHandler(this.txtTK_Click);
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.White;
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(41, 11);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(226, 20);
            this.txtMK.TabIndex = 3;
            this.txtMK.Text = "Mật khẩu";
            this.txtMK.Click += new System.EventHandler(this.txtMK_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.Transparent;
            this.btnDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(87, 195);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(310, 40);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quên mật khẩu?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.Transparent;
            this.lblThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.Location = new System.Drawing.Point(422, 275);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(50, 19);
            this.lblThoat.TabIndex = 8;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.svgImageBox1);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Location = new System.Drawing.Point(87, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 40);
            this.panel1.TabIndex = 9;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(3, 5);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(32, 30);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 10;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.svgImageBox2);
            this.panel2.Controls.Add(this.txtMK);
            this.panel2.Location = new System.Drawing.Point(87, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 40);
            this.panel2.TabIndex = 10;
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.Location = new System.Drawing.Point(3, 5);
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(32, 30);
            this.svgImageBox2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox2.SvgImage")));
            this.svgImageBox2.TabIndex = 10;
            this.svgImageBox2.Text = "svgImageBox2";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDN);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
    }
}

