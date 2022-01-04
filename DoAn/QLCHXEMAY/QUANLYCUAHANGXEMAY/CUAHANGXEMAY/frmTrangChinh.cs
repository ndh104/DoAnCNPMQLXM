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
    public partial class frmTrangChinh : DevExpress.XtraEditors.XtraForm
    {
        public frmTrangChinh()
        {
            InitializeComponent();
        }

        private void btnXeMay_Click(object sender, EventArgs e)
        {
            frmXeMay frm = new frmXeMay();
            frm.ShowDialog();
        }
    }
}