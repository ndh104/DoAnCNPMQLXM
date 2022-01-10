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
    public partial class frmChiTietMauXe : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietMauXe()
        {
            InitializeComponent();
        }
        BUS_CHITIETMAUXE _ctmauxe;
        BUS_MAUSAC _mausac;
        BUS_XEMAY _xemay;
        bool _them;
        int idctxe;
        void loadData()
        {
            gcChiTietMauXe.DataSource = _ctmauxe.getAllFull();
            gvChiTietMauXe.OptionsBehavior.Editable = false;

            _mausac = new BUS_MAUSAC();
            cbbMauSac.DataSource = _mausac.getAll();
            cbbMauSac.DisplayMember = "TENMAU";
            cbbMauSac.ValueMember = "IDMAU";
            cbbMauSac.Text = "Chọn màu";

            _xemay = new BUS_XEMAY();
            cbbTenXe.DataSource = _xemay.getAll();
            cbbTenXe.DisplayMember = "TENXE";
            cbbTenXe.ValueMember = "MAXE";
            cbbTenXe.Text = "Chọn xe";
        }
        void reset()
        {
            cbbMauSac.Text = "";
            cbbTenXe.Text = "";
        }
        void enable(bool en)
        {
            txtIDChiTietXe.Enabled = en;
            cbbMauSac.Enabled = en;
            cbbTenXe.Enabled = en;
        }
        void showHideButton(bool sh)
        {
            btnThem.Visible = sh;
            btnSua.Visible = sh;
            btnLuu.Visible = !sh;
            btnHuy.Visible = !sh;
        }

        private void frmChiTietMauXe_Load(object sender, EventArgs e)
        {
            enable(false);
            _ctmauxe = new BUS_CHITIETMAUXE();
            loadData();
            showHideButton(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideButton(false);
            enable(true);
            txtIDChiTietXe.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(false);
            enable(true);
            reset();
            txtIDChiTietXe.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {

                tb_CHITIETMAUXE ctxe = new tb_CHITIETMAUXE();
                ctxe.IDCHITIETXE = int.Parse(txtIDChiTietXe.Text);
                ctxe.IDMAU = int.Parse(cbbMauSac.SelectedValue.ToString());
                ctxe.MAXE = cbbTenXe.SelectedValue.ToString();
                _ctmauxe.them(ctxe);
            }
            else
            {
                tb_CHITIETMAUXE ctxe = _ctmauxe.getItem(idctxe);
                ctxe.IDMAU = int.Parse(cbbMauSac.Text);
                ctxe.MAXE = cbbTenXe.SelectedValue.ToString();
                _ctmauxe.capnhat(ctxe);
            }
            _them = false;
            loadData();
            enable(false);
            showHideButton(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(true);
            enable(false);
        }

        private void gvChiTietMauXe_Click(object sender, EventArgs e)
        {
            if (gvChiTietMauXe.RowCount > 0)
            {
                if (gvChiTietMauXe.GetFocusedRowCellValue("IDCHITIETXE") != null)
                {
                    //Lấy "IDCHITIETXE" trong bảng "tb_CHITIETMAUXE" đưa vào "_idctxe"
                    idctxe = int.Parse(gvChiTietMauXe.GetFocusedRowCellValue("IDCHITIETXE").ToString());
                    txtIDChiTietXe.Text = gvChiTietMauXe.GetFocusedRowCellValue("IDCHITIETXE").ToString();
                    cbbMauSac.Text = gvChiTietMauXe.GetFocusedRowCellValue("TENMAU").ToString();
                    cbbTenXe.Text = gvChiTietMauXe.GetFocusedRowCellValue("TENXE").ToString();
                }
            }
        }

        private void btnQuanLyMauSac_Click(object sender, EventArgs e)
        {
            frmMauSac frm = new frmMauSac();
            frm.ShowDialog();
        }
    }
}