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
    public partial class frmLoaiXe : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiXe()
        {
            InitializeComponent();
        }
        BUS_LOAIXE _LoaiXe;
        bool _them;
        string _maloaixe;

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            _LoaiXe = new BUS_LOAIXE();
            loadData();
            showHideControl(true);
            txtMaLoai.Enabled = false;
            _enable(false);
        }
        void showHideControl(bool t)
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
            txtTenLoaiXe.Enabled = t;
            CheckboxLoaiXe.Enabled = t;
        }

        void _reset()
        {
            txtMaLoai.Text = "";
            txtTenLoaiXe.Text = "";
            CheckboxLoaiXe.Checked = false;
        }
        void loadData()
        {
            gcLoaiXe.DataSource = _LoaiXe.getAll();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _enable(true);
            _reset();
            txtMaLoai.Enabled = true;
            _them = true;
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _enable(true);
            txtMaLoai.Enabled = false;
            _them = false;
            showHideControl(false);
            MessageBox.Show("Hãy chọn nhà cung cấp cần thay đổi thông tin", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _LoaiXe.xoa(_maloaixe);
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                if (txtMaLoai.Text == "" || txtTenLoaiXe.Text == "" )
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        tb_LOAIXE loaixe = new tb_LOAIXE();
                        loaixe.MALOAI = txtMaLoai.Text;
                        loaixe.TENLOAIXE = txtTenLoaiXe.Text;
                        loaixe.DISABLE = CheckboxLoaiXe.Checked;
                        _LoaiXe.them(loaixe);
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
                if (txtMaLoai.Text == "" || txtTenLoaiXe.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        tb_LOAIXE loaixe = new tb_LOAIXE();
                        loaixe.MALOAI = txtMaLoai.Text;
                        loaixe.TENLOAIXE = txtTenLoaiXe.Text;
                        loaixe.DISABLE = CheckboxLoaiXe.Checked;
                        _LoaiXe.capnhat(loaixe);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
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
            txtMaLoai.Enabled = false;
            showHideControl(true);
            _them = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gcLoaiXe_Click(object sender, EventArgs e)
        {

        }

        private void gvLoaiXe_Click(object sender, EventArgs e)
        {
            if (gvLoaiXe.RowCount > 0)
            {
                _maloaixe = gvLoaiXe.GetFocusedRowCellValue("MALOAI").ToString();
                txtTenLoaiXe.Text = gvLoaiXe.GetFocusedRowCellValue("TENLOAIXE").ToString();
                txtMaLoai.Text = gvLoaiXe.GetFocusedRowCellValue("MALOAI").ToString();
                CheckboxLoaiXe.Checked = bool.Parse(gvLoaiXe.GetFocusedRowCellValue("DISABLE").ToString());

            }
        }
    }
}