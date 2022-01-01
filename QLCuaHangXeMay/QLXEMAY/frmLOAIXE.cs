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
using DataLayer;
using BusinessLayer;

namespace QLXEMAY
{
    public partial class frmLOAIXE : DevExpress.XtraEditors.XtraForm
    {
        public frmLOAIXE()
        {
            InitializeComponent();
        }

        OBJLOAIXE loaiXe;

        private void frmLOAIXE_Load(object sender, EventArgs e)
        {
            loaiXe = new OBJLOAIXE();
            gridControl1.DataSource = loaiXe.layThongTin();
        }
    }
}