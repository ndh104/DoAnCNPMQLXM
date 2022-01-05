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
using DevExpress.XtraCharts;

namespace CUAHANGXEMAY
{
    public partial class frmTrangChinh : DevExpress.XtraEditors.XtraForm
    {
        public frmTrangChinh()
        {
            InitializeComponent();
        }
        public bool isClose = true;
        BUS_THONGKE _thongke;
        Series sr = new Series("", ViewType.Bar);
        private void btnXeMay_Click(object sender, EventArgs e)
        {
            frmXeMay frm = new frmXeMay();
            frm.ShowDialog();
        }
        private void frmTrangChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose == true)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isClose = false;
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void frmTrangChinh_Load(object sender, EventArgs e)
        {
            _thongke = new BUS_THONGKE();
            List<BUS_OBJ_THONGKE> lst;
            lst = new List<BUS_OBJ_THONGKE>();
            lst = _thongke.getAll();
            foreach (var item in lst)
            {
                sr.Points.Add(new SeriesPoint(item.tenXe, item.soLuong));
            }
            chartControl1.Series.Add(sr);

        }
    }
}