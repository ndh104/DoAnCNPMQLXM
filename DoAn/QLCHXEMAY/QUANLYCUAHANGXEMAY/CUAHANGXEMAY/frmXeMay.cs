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

        private void frmXeMay_Load(object sender, EventArgs e)
        {
            BUS_XEMAY _xemay = new BUS_XEMAY();
            gcXeMay.DataSource = _xemay.getAll();
            //BUS_LOAIXE _loaixe = new BUS_LOAIXE();
            //gcXeMay.DataSource = _loaixe.getItem(tenloaixe);
            //BUS_NHACUNGCAP _nhacungcap = new BUS_NHACUNGCAP();
            //gcXeMay.DataSource = _nhacungcap.getAll();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}