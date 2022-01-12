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
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN _nhanvien;
        frmDangNhap frm = (frmDangNhap)Application.OpenForms["frmDangNhap"];
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            _nhanvien = new BUS_NHANVIEN();
            string tk = frm._tk;
            string mk = txtMK.Text;
            string mkm = txtMKM.Text;
            string xnmkm = txtXacNhanMKM.Text;
            var nv = _nhanvien.getItem(tk, mk);
            if (mk != frm._mk)
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(mkm == xnmkm)
                {
                    _nhanvien.doiMatKhau(frm._tk, mkm);
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp với nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}