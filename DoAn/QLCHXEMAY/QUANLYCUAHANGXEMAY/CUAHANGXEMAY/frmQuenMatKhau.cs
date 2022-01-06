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
    public partial class frmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN _nhanvien;
        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            _nhanvien = new BUS_NHANVIEN();
            btnKiemTra.Enabled = true;
            btnXacNhan.Enabled = false;
        }
        public string tk;
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            tk = txtTaiKhoan.Text;
            string manv = txtMaNV.Text;
            string hoten = txtHoTen.Text;
            DateTime ngaysinh = dtpNgaySinh.Value.Date;
            string cmnd = txtCMND.Text;
            string sdt = txtSDT.Text;
            var nv = _nhanvien.getItems(tk, manv, hoten, ngaysinh, cmnd, sdt);
            if (nv == null)
            {
                MessageBox.Show("Sai thông tin cá nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xác nhận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnXacNhan.Enabled = true;
                btnKiemTra.Enabled = false;
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}