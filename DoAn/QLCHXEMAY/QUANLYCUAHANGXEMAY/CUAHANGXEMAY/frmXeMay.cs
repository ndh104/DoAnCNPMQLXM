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
        BUS_XEMAY _xemay;
        //BUS_LOAIXE _loaixe;
        //BUS_NHACUNGCAP _ncc;
        bool _them;
        void loadData()
        {
            gcXeMay.DataSource = _xemay.getAll();
            gvXeMay.OptionsBehavior.Editable = false;
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
            }
            showHideButton(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showHideButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}