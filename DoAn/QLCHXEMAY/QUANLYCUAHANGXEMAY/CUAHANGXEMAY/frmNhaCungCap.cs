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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        BUS_NHACUNGCAP _NCC;
        bool _them;
        string _mancc;

        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }
        void clear()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtSDTNCC.Clear();
            CheckboxNCC.Checked = false;
        }
        void loadData()
        {
            gcNhaCungCap.DataSource = _NCC.getAll();
            gvNhaCungCap.OptionsBehavior.Editable = false;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            _NCC = new BUS_NHACUNGCAP();
            loadData();
            showHideControl(true);
            txtMaNCC.Enabled = false;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaNCC.Enabled = true;
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaNCC.Enabled = false;
            showHideControl(false);
            MessageBox.Show("Hãy chọn nhà cung cấp cần thay đổi thông tin", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _NCC.xoa(_mancc);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSDTNCC.Text == "" || txtDiaChiNCC.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        tb_NHACUNGCAP NCC = new tb_NHACUNGCAP();
                        NCC.MANCC = txtMaNCC.Text;
                        NCC.TENNCC = txtTenNCC.Text;
                        NCC.DIACHI = txtDiaChiNCC.Text;
                        NCC.SDT = txtSDTNCC.Text;
                        NCC.DISABLE = CheckboxNCC.Checked;
                        _NCC.them(NCC);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    }

                }

            }
            else
            {
                if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSDTNCC.Text == "" || txtDiaChiNCC.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        tb_NHACUNGCAP NCC = _NCC.getItem(_mancc);
                        NCC.MANCC = txtMaNCC.Text;
                        NCC.TENNCC = txtTenNCC.Text;
                        NCC.SDT = txtSDTNCC.Text;
                        NCC.DIACHI = txtDiaChiNCC.Text;
                        NCC.DISABLE = CheckboxNCC.Checked;
                        _NCC.capnhat(NCC);
                        MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);

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
            txtMaNCC.Enabled = false;
            showHideControl(true);
        }

        private void gvNhaCungCap_Click(object sender, EventArgs e)
        {
            if (gvNhaCungCap.RowCount > 0)
            {
                _mancc = gvNhaCungCap.GetFocusedRowCellValue("MANCC").ToString();
                txtMaNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("MANCC").ToString();
                txtTenNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("TENNCC").ToString();
                txtDiaChiNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("DIACHI").ToString();
                txtSDTNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("SDT").ToString();
                CheckboxNCC.Checked = bool.Parse(gvNhaCungCap.GetFocusedRowCellValue("DISABLE").ToString());

            }
        }
    }
}
