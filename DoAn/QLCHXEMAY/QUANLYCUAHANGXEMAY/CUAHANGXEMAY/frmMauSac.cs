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
    public partial class frmMauSac : DevExpress.XtraEditors.XtraForm
    {
        public frmMauSac()
        {
            InitializeComponent();
        }
        BUS_MAUSAC _mausac;
        bool _them;
        int idmau;
        private void frmMauSac_Load(object sender, EventArgs e)
        {
            enable(false);
            _mausac = new BUS_MAUSAC();
            loadData();
            showHideButton(true);
        }
        void loadData()
        {
            gcMauSac.DataSource = _mausac.getAll();
            gvMauSac.OptionsBehavior.Editable = false;
        }
        void reset()
        {
            txtIDMau.Text = "";
            txtTenMau.Text = "";
        }
        void enable(bool en)
        {
            txtIDMau.Enabled = en;
            txtTenMau.Enabled = en;
        }
        void showHideButton(bool sh)
        {
            btnThem.Visible = sh;
            btnSua.Visible = sh;
            btnLuu.Visible = !sh;
            btnHuy.Visible = !sh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideButton(false);
            enable(true);
            txtIDMau.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(false);
            enable(true);
            reset();
            txtIDMau.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_MAUSAC mausac = new tb_MAUSAC();
                mausac.TENMAU = txtTenMau.Text;
                _mausac.them(mausac);
            }
            else
            {
                tb_MAUSAC mausac = _mausac.getItem(idmau);
                mausac.TENMAU = txtTenMau.Text;
                _mausac.capnhat(mausac);
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

        private void gvMauSac_Click(object sender, EventArgs e)
        {
            if (gvMauSac.RowCount > 0)
            {
                if (gvMauSac.GetFocusedRowCellValue("IDMAU") != null)
                {
                    idmau = int.Parse(gvMauSac.GetFocusedRowCellValue("IDMAU").ToString());
                    txtIDMau.Text = gvMauSac.GetFocusedRowCellValue("IDMAU").ToString();
                    txtTenMau.Text = gvMauSac.GetFocusedRowCellValue("TENMAU").ToString();
                }
            }
        }
    }
}