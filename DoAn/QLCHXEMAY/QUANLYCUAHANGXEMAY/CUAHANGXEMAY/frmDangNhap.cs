using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;

namespace CUAHANGXEMAY
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN _nhanvien;
        public string _tk;

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            _nhanvien = new BUS_NHANVIEN();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            _tk = txtTK.Text;
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            var nv = _nhanvien.getItem(tk, mk);
            if (nv==null)
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmTrangChinh frm = new frmTrangChinh();
                frm.Show();
                this.Hide();
            }
        }
        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            frmQuenMatKhau frm = new frmQuenMatKhau();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        { 
        }
    }
}