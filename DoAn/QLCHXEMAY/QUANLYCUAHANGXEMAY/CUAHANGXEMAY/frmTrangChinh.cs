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
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            xuatReportDS("ReportDSHD", "DANH SÁCH HÓA ĐƠN");
        }
        private void xuatReportDS(string _tenReport, string _title)
        {
            Form frm = new Form();
            CrystalReportViewer Crv = new CrystalReportViewer();
            Crv.ShowGroupTreeButton = false;
            Crv.ShowParameterPanelButton = false;
            Crv.ToolPanelView = ToolPanelViewType.None;
            TableLogOnInfo Thongtin;
            ReportDocument doc = new ReportDocument();
            doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _tenReport + @".rpt");
            Thongtin = doc.Database.Tables[0].LogOnInfo;
            Thongtin.ConnectionInfo.ServerName = Connection._svname;
            Thongtin.ConnectionInfo.UserID = Connection._usname;
            Thongtin.ConnectionInfo.Password = Connection._pwrd;
            Thongtin.ConnectionInfo.DatabaseName = Connection._dtbase;
            doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
            try
            {
                Crv.Dock = DockStyle.Fill;
                Crv.ReportSource = doc;
                frm.Controls.Add(Crv);
                Crv.Refresh();
                frm.Text = _title;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.ShowDialog();
        }

        private void btnLoaiXe_Click(object sender, EventArgs e)
        {
            frmLoaiXe frm = new frmLoaiXe();
            frm.ShowDialog();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMK frm = new frmDoiMK();
            frm.ShowDialog();
        }
    }
}