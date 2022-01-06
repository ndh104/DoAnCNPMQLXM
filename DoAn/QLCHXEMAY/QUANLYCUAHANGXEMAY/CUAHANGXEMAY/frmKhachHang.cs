using BusinessLayer;
using DataAccessLayer;
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

namespace CUAHANGXEMAY
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BUS_KHACHHANG _khachhang;
        bool _them;
        string _makh;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new BUS_KHACHHANG();
            loadData();
            txtMaKH.Enabled = false;
            showHideControl(true);
        }
        void loadData()
        {
            gcKhachHang.DataSource = _khachhang.getAll();
        }
        #region Show hide control
        void showHideControl(bool t)
        {
            btnTrangChu.Visible = t;
            btnThemKH.Visible = t;
            btnSuaKH.Visible = t;
            btnXoaKH.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
            btnThoat.Visible = t;
        }
        #endregion
        #region Clear
        void clear()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            chkDisabled.Checked = false;
        }
        #endregion

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaKH.Enabled = true;
            showHideControl(false);
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaKH.Enabled = false;
            showHideControl(false);
            MessageBox.Show("Hãy chọn một khách hàng cần thay đổi thông tin", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _khachhang.delete(_makh);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        tb_KHACHHANG kh = new tb_KHACHHANG();
                        kh.MAKH = txtMaKH.Text;
                        kh.TENKH = txtTenKH.Text;
                        kh.DIACHI = txtDiaChi.Text;
                        kh.SDT = txtSoDienThoai.Text;
                        kh.DISABLE = chkDisabled.Checked;
                        _khachhang.add(kh);
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        tb_KHACHHANG kh = _khachhang.getItem(_makh);
                        kh.MAKH = txtMaKH.Text;
                        kh.TENKH = txtTenKH.Text;
                        kh.DIACHI = txtDiaChi.Text;
                        kh.SDT = txtSoDienThoai.Text;
                        kh.DISABLE = chkDisabled.Checked;
                        _khachhang.update(kh);
                        MessageBox.Show("Sửa thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            loadData();
            clear();
            _them = false;
            showHideControl(true);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            this.Close();
            frmKhachHang frm_khachhang = new frmKhachHang();
            frm_khachhang.ShowDialog();
            txtMaKH.Enabled = false;
            showHideControl(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gvKhachHang_Click(object sender, EventArgs e)
        {
            if (gvKhachHang.RowCount > 0)
            {
                _makh = gvKhachHang.GetFocusedRowCellValue("MAKH").ToString();
                txtMaKH.Text = gvKhachHang.GetFocusedRowCellValue("MAKH").ToString();
                txtTenKH.Text = gvKhachHang.GetFocusedRowCellValue("TENKH").ToString();
                txtDiaChi.Text = gvKhachHang.GetFocusedRowCellValue("DIACHI").ToString();
                txtSoDienThoai.Text = gvKhachHang.GetFocusedRowCellValue("SDT").ToString();
                chkDisabled.Checked = bool.Parse(gvKhachHang.GetFocusedRowCellValue("DISABLE").ToString());
            }
        }

        private void gvKhachHang_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DISABLED" && bool.Parse(e.CellValue.ToString()) == true)
            {
                Image img = Properties.Resources.delete_icon;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}