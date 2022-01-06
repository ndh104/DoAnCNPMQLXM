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
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }






        void showHideButton(bool sh)
        {
            btnThemHoaDon.Visible = sh;
            btnXoa.Visible = sh;
            btnThoat.Visible = sh;
            btnXuatHD.Visible = !sh;
            btnHuy.Visible = !sh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}