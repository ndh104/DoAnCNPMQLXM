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
using System.Data.SqlClient;
using QLXEMAY.Model;

namespace QLXEMAY
{
    public partial class frmXeMay : DevExpress.XtraEditors.XtraForm
    {
        public frmXeMay()
        {
            InitializeComponent();
        }

        private void frmXeMay_Load(object sender, EventArgs e)
        {
            gcXeMay.DataSource = myClass.getData("select MAXE, TENXE, GIABAN, MAUSAC, DUNGTICH, TINHTRANG from XEMAY");
        }
    }
}