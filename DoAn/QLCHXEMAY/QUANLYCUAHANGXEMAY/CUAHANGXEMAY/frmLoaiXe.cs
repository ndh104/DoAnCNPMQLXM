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
    public partial class frmLoaiXe : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiXe()
        {
            InitializeComponent();
        }
        BUS_LOAIXE _LoaiXe;
        bool _them;
        string _maloaixe;


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
            txtMaLoai.Clear();
            txtTenLoaiXe.Clear();
            CheckboxLoaiXe.Checked = false;
        }
        void loadData()
        {
            gcLoaiXe.DataSource = _LoaiXe.getAll();
            gvLoaiXe.OptionsBehavior.Editable = false;
        }
        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            _LoaiXe = new BUS_LOAIXE();
            loadData();
            showHideControl(true);
            txtMaLoai.Enabled = false;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaLoai.Enabled = true;
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaLoai.Enabled = false;
            showHideControl(false);
            MessageBox.Show("Hãy chọn loại xe cần thay đổi thông tin", "Thông báo", MessageBoxButtons.OK);
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
                        tb_LOAIXE loaixe = _LoaiXe.getItemMa(_maloaixe);
                        loaixe.MALOAI = txtMaLoai.Text;
                        loaixe.TENLOAIXE = txtTenLoaiXe.Text;
                        loaixe.DISABLE = CheckboxLoaiXe.Checked;
                        _LoaiXe.capnhat(loaixe);
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
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
            txtMaLoai.Enabled = false;
            showHideControl(true);
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