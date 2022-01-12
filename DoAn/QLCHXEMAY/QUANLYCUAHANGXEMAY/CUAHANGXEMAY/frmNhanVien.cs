using DataAccessLayer;
using BusinessLayer;
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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN _nhanvien;
        bool _them;
        string _manv;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _nhanvien = new BUS_NHANVIEN();
            loadData();
            txtMaNV.Enabled = false;
            showHideControl(true);
        }
        void loadData()
        {
            gcNhanVien.DataSource = _nhanvien.getAll();
        }
        void showHideControl(bool t)
        {
            btnTrangChu.Visible = t;
            btnThemNV.Visible = t;
            btnSuaNV.Visible = t;
            btnXoaNV.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }
        void clear()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtCMND.Clear();
            txtSoDT.Clear();
            cmbChucVu.Text = "Quản lý";
            cmbGioiTinh.Text = "Nam";
            dtpNgaySinh.Value = DateTime.Today;
            chkDisabled.Checked = false;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaNV.Enabled = true;
            showHideControl(false);
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaNV.Enabled = false;
            showHideControl(false);
            MessageBox.Show("Hãy chọn một nhân viên bạn muốn thay đổi thông tin", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.delete(_manv);
            }
            loadData();
            clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var ma = _nhanvien.Get_ItemMaNV(txtMaNV.Text);
            var sdt = _nhanvien.getItemSDT(txtSoDT.Text);
            if (_them)
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == ""
                    || txtCMND.Text == "" || txtSoDT.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (ma == null)
                    {
                        if(txtMaNV.Text.Length == 4)
                        {
                            if(sdt == null)
                            {
                                try
                                {
                                    tb_NHANVIEN nv = new tb_NHANVIEN();
                                    nv.MANV = txtMaNV.Text;
                                    nv.TENNV = txtTenNV.Text;
                                    nv.CHUCVU = cmbChucVu.Text;
                                    nv.NGAYSINH = dtpNgaySinh.Value;
                                    nv.GIOITINH = cmbGioiTinh.Text;
                                    nv.DIACHI = txtDiaChi.Text;
                                    nv.CMND = txtCMND.Text;
                                    nv.SDT = txtSoDT.Text;
                                    nv.DISABLE = chkDisabled.Checked;
                                    _nhanvien.add(nv);
                                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                }
                                catch
                                {
                                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại trùng!", "Thông báo!", MessageBoxButtons.OK);

                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Mã nhân viên phải có 4 kí tự!", "Thông báo!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không được trùng!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == ""
                    || txtCMND.Text == "" || txtSoDT.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (ma==null)
                    {
                        if(txtMaNV.Text.Length == 4)
                        {
                            if(sdt == null || txtSoDT.Text.Length==10)
                            {
                                try
                                {
                                    tb_NHANVIEN nv = _nhanvien.Get_ItemMaNV(_manv);
                                    nv.TENNV = txtTenNV.Text;
                                    nv.CHUCVU = cmbChucVu.Text;
                                    nv.NGAYSINH = dtpNgaySinh.Value;
                                    nv.GIOITINH = cmbGioiTinh.Text;
                                    nv.DIACHI = txtDiaChi.Text;
                                    nv.CMND = txtCMND.Text;
                                    nv.SDT = txtSoDT.Text;
                                    nv.DISABLE = chkDisabled.Checked;
                                    _nhanvien.update(nv);
                                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                                }
                                catch
                                {
                                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã nhân viên phải có 4 kí tự!", "Thông báo!", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không được trùng!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }
            }
            loadData();
            _them = false;
            showHideControl(true);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            this.Close();
            frmNhanVien frm_nhanvien = new frmNhanVien();
            frm_nhanvien.ShowDialog();
            txtMaNV.Enabled = false;
            showHideControl(true);
        }

        private void gvNhanVien_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.RowCount > 0)
            {
                _manv = gvNhanVien.GetFocusedRowCellValue("MANV").ToString();
                txtMaNV.Text = gvNhanVien.GetFocusedRowCellValue("MANV").ToString();
                txtTenNV.Text = gvNhanVien.GetFocusedRowCellValue("TENNV").ToString();
                cmbChucVu.Text = gvNhanVien.GetFocusedRowCellValue("CHUCVU").ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(gvNhanVien.GetFocusedRowCellValue("NGAYSINH").ToString());
                cmbGioiTinh.Text = gvNhanVien.GetFocusedRowCellValue("GIOITINH").ToString();
                txtDiaChi.Text = gvNhanVien.GetFocusedRowCellValue("DIACHI").ToString();
                txtCMND.Text = gvNhanVien.GetFocusedRowCellValue("CMND").ToString();
                txtSoDT.Text = gvNhanVien.GetFocusedRowCellValue("SDT").ToString();
                chkDisabled.Checked = bool.Parse(gvNhanVien.GetFocusedRowCellValue("DISABLE").ToString());
            }
        }

        private void gvNhanVien_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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