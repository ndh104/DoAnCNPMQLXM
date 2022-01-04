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
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            _nhanvien = new BUS_NHANVIEN();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            var nv = _nhanvien.getItem(tk, mk);
            if (nv==null)
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTrangChinh frm = new frmTrangChinh();
                frm.Show();
                this.Hide();
            }
            //if (nv.USERNAME.Equals(txtTK.Text) && nv.PASSWORD.Equals(txtMK.Text))
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    frmTrangChinh frm = new frmTrangChinh();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}