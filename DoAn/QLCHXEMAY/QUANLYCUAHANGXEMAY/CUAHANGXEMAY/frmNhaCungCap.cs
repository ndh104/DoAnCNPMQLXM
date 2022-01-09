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

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            _NCC = new BUS_NHACUNGCAP();
            loadData();
            showHideControl(true);
            txtMaNCC.Enabled = false;
            _enable(false);
        }

        void showHideControl( bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }

        void _enable(bool t)
        {
            txtTenNCC.Enabled = t;
            txtSDTNCC.Enabled = t;
            txtDiaChiNCC.Enabled = t;
            CheckboxNCC.Enabled = t;
        }
        void _reset()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text ="";
            txtSDTNCC.Text ="";
            txtDiaChiNCC.Text ="";
            CheckboxNCC.Checked = false;
        }
        void loadData()
        {
            gcNhaCungCap.DataSource = _NCC.getAll();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _enable(true);
            _reset();
            txtMaNCC.Enabled = true;
            _them = true;
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _enable(true);
            txtMaNCC.Enabled = false;
            _them = false;
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
                if(txtMaNCC.Text =="" || txtTenNCC.Text ==""|| txtSDTNCC.Text == ""|| txtDiaChiNCC.Text=="")
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
            _them = false;
            loadData();
            showHideControl(true);

        }

        private void btnBoQua_Click(object sender, EventArgs e)
            
        {
            _enable(false);
            txtMaNCC.Enabled = false;
            showHideControl(true);
            _them = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gvNhaCungCap_Click(object sender, EventArgs e)
        {
            if(gvNhaCungCap.RowCount > 0)
            {
                _mancc = gvNhaCungCap.GetFocusedRowCellValue("MANCC").ToString();
                txtTenNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("TENNCC").ToString();
                txtMaNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("MANCC").ToString();
                txtSDTNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("SDT").ToString();
                txtDiaChiNCC.Text = gvNhaCungCap.GetFocusedRowCellValue("DIACHI").ToString();
                CheckboxNCC.Checked = bool.Parse(gvNhaCungCap.GetFocusedRowCellValue("DISABLE").ToString());

            }
        }
    }
}