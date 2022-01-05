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
    public partial class frmXeMay : DevExpress.XtraEditors.XtraForm
    {
        public frmXeMay()
        {
            InitializeComponent();
        }
        BUS_NHACUNGCAP _ncc;
        BUS_XEMAY _xemay;
        BUS_LOAIXE _loaixe;
        string _maxe;
        bool _them;
        void loadData()
        {
            gcXeMay.DataSource = _xemay.getAllFull();
            gvXeMay.OptionsBehavior.Editable = false;

            
            _ncc = new BUS_NHACUNGCAP();
            cbbNCC.DataSource = _ncc.getAll();
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";
            cbbNCC.Text = "Chọn nhà cung cấp";
            
            _loaixe = new BUS_LOAIXE();
            cbbLoaiXe.DataSource = _loaixe.getAll();
            cbbLoaiXe.DisplayMember = "TENLOAIXE";
            cbbLoaiXe.ValueMember = "MALOAI";
            cbbLoaiXe.Text = "Chọn loại xe";
        }


        private void frmXeMay_Load(object sender, EventArgs e)
        {
            _xemay = new BUS_XEMAY();
            loadData();
            showHideButton(true);
        }


        void showHideButton(bool sh)
        {
            btnThem.Visible = sh;
            btnSua.Visible = sh;
            btnXoa.Visible = sh;
            btnThoat.Visible = sh;
            btnLuu.Visible = !sh;
            btnHuy.Visible = !sh;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideButton(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_XEMAY xe = new tb_XEMAY();
                xe.MAXE = txtMaXe.Text;
                xe.TENXE = txtTenXe.Text;
                xe.MAUSAC = txtMauSac.Text;
                xe.DUNGTICH = txtDungTich.Text;
                xe.TINHTRANG = txtTinhTrang.Text;
                xe.GIABAN = decimal.Parse(txtGiaBan.Text);
                xe.MALOAI = cbbNCC.SelectedValue.ToString();
                xe.MANCC = cbbLoaiXe.SelectedValue.ToString();
                xe.DISABLE = cbDisable.Checked;
            }
            showHideButton(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvXeMay_Click(object sender, EventArgs e)
        {
            
            if (gvXeMay.RowCount > 0)
            {
                if (gvXeMay.GetFocusedRowCellValue("MAXE") != null)
                {
                    //Lấy mã xe ra "MAXE" trong bảng "XEMAY" đưa vào "_maxe"
                    _maxe = gvXeMay.GetFocusedRowCellValue("MAXE").ToString();
                    txtMaXe.Text = gvXeMay.GetFocusedRowCellValue("MAXE").ToString();
                    txtTenXe.Text = gvXeMay.GetFocusedRowCellValue("TENXE").ToString();
                    txtGiaBan.Text = gvXeMay.GetFocusedRowCellValue("GIABAN").ToString();
                    txtMauSac.Text = gvXeMay.GetFocusedRowCellValue("MAUSAC").ToString();
                    txtDungTich.Text = gvXeMay.GetFocusedRowCellValue("DUNGTICH").ToString();
                    txtTinhTrang.Text = gvXeMay.GetFocusedRowCellValue("TINHTRANG").ToString();
                    cbbNCC.Text = gvXeMay.GetFocusedRowCellValue("TENNCC").ToString();
                    cbbLoaiXe.Text = gvXeMay.GetFocusedRowCellValue("TENLOAI").ToString();
                    cbDisable.Checked = bool.Parse(gvXeMay.GetFocusedRowCellValue("DISABLE").ToString());
                }
            }
        }
    }
}