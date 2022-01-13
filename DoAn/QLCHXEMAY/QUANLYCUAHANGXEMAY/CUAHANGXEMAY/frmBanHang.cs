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
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace CUAHANGXEMAY
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        BUS_CHITIETHOADON _cthoadon;
        BUS_HOADON _hoadon;
        BUS_XEMAY _xemay;
        BUS_KHACHHANG _khachhang;
        BUS_NHANVIEN _nhanvien;
        BUS_CHITIETMAUXE _ctmauxe;
        string maxe;
        bool _them;
        string _mahd;

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            _hoadon = new BUS_HOADON();
            _cthoadon = new BUS_CHITIETHOADON();
            _ctmauxe = new BUS_CHITIETMAUXE();
            loadData();
            showHideButton(true);
            enable(false);
            cbbTenXe.SelectedValueChanged += CbbTenXe_SelectedValueChanged;
            txtSoLuong.TextChanged += TxtSoLuong_TextChanged;
            dtpNgayLap.Value = DateTime.Now.Date;
            gcBanHang.DataSource = _cthoadon.getAllFullTheoNgay(dtpNgayLap.Value);
            gvBanHang.OptionsBehavior.Editable = false;
        }

        private void TxtSoLuong_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text) * 1.1).ToString();
            try
            {
                if (txtThanhTien.Text.Length > 0)
                {
                    double a = double.Parse(txtThanhTien.Text);
                    txtThanhTien.Text = a.ToString("N0");
                    txtThanhTien.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CbbTenXe_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbMauSac.DataSource = _cthoadon.fnn(cbbTenXe.SelectedValue.ToString());
            cbbMauSac.DisplayMember = "TENMAU";
            cbbMauSac.ValueMember = "IDMAU";
            cbbMauSac.Text = "Chọn màu";
            txtGiaBan.Text = _xemay.getItem(cbbTenXe.SelectedValue.ToString()).GIABAN.ToString();
            txtThanhTien.Text = (double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text) * 1.1).ToString();
        }

        void reset()
        {
            cbbTenXe.Text = "";
            txtMaHD.Text = "";
            cbbMauSac.Text = "";
            dtpNgayLap.Value = DateTime.Now.Date;
            lblNhanVien.Text = "";
            cbbTenKH.Text = "";
            txtGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }
        void enable(bool en)
        {
            cbbTenXe.Enabled = en;
            txtMaHD.Enabled = en;
            txtGiaBan.Enabled = en;
            cbbMauSac.Enabled = en;
            lblNhanVien.Enabled = en;
            cbbTenKH.Enabled = en;
            txtGiaBan.Enabled = en;
            txtSoLuong.Enabled = en;
            txtThanhTien.Enabled = en;
        }
        void showHideButton(bool sh)
        {
            btnThemHoaDon.Visible = sh;
            btnLuu.Visible = !sh;
            btnXuatHD.Visible = !sh;
            btnHuy.Visible = !sh;
        }

        frmDangNhap frm = (frmDangNhap)Application.OpenForms["frmDangNhap"];
        void loadData()
        {
            _cthoadon = new BUS_CHITIETHOADON();
            gcHoaDon.DataSource = _cthoadon.getAllFull();
            gvHoaDon.OptionsBehavior.Editable = false;

            

            _nhanvien = new BUS_NHANVIEN();
            var nv = _nhanvien.getItemNV(frm._tk);
            lblNhanVien.Text = nv.TENNV;

            _xemay = new BUS_XEMAY();
            cbbTenXe.DataSource = _xemay.getAll().Where(x => x.DISABLE == false).ToList();
            cbbTenXe.DisplayMember = "TENXE";
            cbbTenXe.ValueMember = "MAXE";
            cbbTenXe.Text = "Chọn xe";

            _khachhang = new BUS_KHACHHANG();
            cbbTenKH.DataSource = _khachhang.getAll().Where(x => x.DISABLE == false).ToList();
            cbbTenKH.DisplayMember = "TENKH";
            cbbTenKH.ValueMember = "MAKH";
            cbbTenKH.Text = "Chọn khách hàng";

            cbbMauSac.DataSource = _cthoadon.fnn(cbbTenXe.SelectedValue.ToString());
            cbbMauSac.DisplayMember = "TENMAU";
            cbbMauSac.ValueMember = "IDMAU";
            cbbMauSac.Text = "Chọn màu";

            txtGiaBan.Text = _xemay.getItem(cbbTenXe.SelectedValue.ToString()).GIABAN.ToString();
            txtThanhTien.Text = (double.Parse(txtGiaBan.Text) * double.Parse(txtSoLuong.Text) * 1.1).ToString();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(true);
            enable(false);
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            xuatReport("ReportHDXEMAY", "HÓA ĐƠN BÁN HÀNG");
        }
        private void xuatReport(string _tenReport, string _title)
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
                doc.SetParameterValue("@MAHD", _mahd);
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
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideButton(false);
            enable(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tb_CHITIETHOADON cthd = new tb_CHITIETHOADON();
            tb_HOADON hd = new tb_HOADON();
            hd.MAHD = txtMaHD.Text;
            hd.NGAYLAP = DateTime.Now;
            hd.MAKH = cbbTenKH.SelectedValue.ToString();
            var nv = _nhanvien.getItemNV(frm._tk);
            hd.MANV = nv.MANV;
            cthd.MAHD = txtMaHD.Text;
            cthd.SOLUONG = int.Parse(txtSoLuong.Text);
            cthd.TONGTIEN = decimal.Parse(txtThanhTien.Text);
            var ctmauxe = _ctmauxe.getItem(cbbTenXe.SelectedValue.ToString(), int.Parse(cbbMauSac.SelectedValue.ToString()));
            cthd.IDCHITIETXE = ctmauxe.IDCHITIETXE;
            _hoadon.themHD(hd);
            _cthoadon.themCTHD(cthd);
            dtpNgayLap_ValueChanged(sender,e);
            _them = false;
            loadData();
            showHideButton(true);
            enable(false);
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiaBan.Text.Length > 0)
                {
                    double a = double.Parse(txtGiaBan.Text);
                    txtGiaBan.Text = a.ToString("N0");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtThanhTien.Text.Length > 0)
                {
                    double a = double.Parse(txtThanhTien.Text);
                    txtThanhTien.Text = a.ToString("N0");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            gcBanHang.DataSource = _cthoadon.getAllFullTheoNgay(dtpNgayLap.Value);
            gvBanHang.OptionsBehavior.Editable = false;
        }

        private void gvBanHang_Click(object sender, EventArgs e)
        {
            if (gvBanHang.RowCount > 0)
            {
                if (gvBanHang.GetFocusedRowCellValue("MAHD")!=null)
                {
                    _mahd = gvBanHang.GetFocusedRowCellValue("MAHD").ToString();
                }
            }
        }
    }
}