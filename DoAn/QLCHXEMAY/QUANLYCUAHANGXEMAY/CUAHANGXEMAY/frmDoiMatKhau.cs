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
using DataAccessLayer;
using BusinessLayer;

namespace CUAHANGXEMAY
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN _nhanvien;
        // Gọi lại form Quên mật khẩu với điều kiện form quên mật khẩu chưa close
        frmQuenMatKhau qmk = (frmQuenMatKhau)Application.OpenForms["frmQuenMatKhau"];
        private void btnXacNhanMK_Click(object sender, EventArgs e)
        {
            string mk = txtMKMoi.Text;
            string xnm = txtXacNhanMK.Text;
            if (mk==xnm)
            {
                _nhanvien.capNhatMatKhau(qmk.tk, mk);
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            qmk.Close();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            _nhanvien = new BUS_NHANVIEN();
        }
    }
}