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
        string maxe;
        bool _them;
        string _mahd;

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            _hoadon = new BUS_HOADON();
            _cthoadon = new BUS_CHITIETHOADON();
            loadData();
            showHideButton(true);
            cbbTenXe.SelectedValueChanged += CbbTenXe_SelectedValueChanged;
        }

        private void CbbTenXe_SelectedValueChanged(object sender, EventArgs e)
        {
            _cthoadon = new BUS_CHITIETHOADON();
            cbbMauSac.DataSource = _cthoadon.getAllMauXeFull();
            cbbMauSac.DisplayMember = "TENMAU";
            cbbMauSac.ValueMember = "IDMAU";
            cbbMauSac.Text = "Chọn màu";
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
            dtpNgayLap.Enabled = en;
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
            cbbTenXe.DataSource = _xemay.getAll();
            cbbTenXe.DisplayMember = "TENXE";
            cbbTenXe.ValueMember = "MAXE";
            cbbTenXe.Text = "Chọn xe";

            _khachhang = new BUS_KHACHHANG();
            cbbTenKH.DataSource = _khachhang.getAll();
            cbbTenKH.DisplayMember = "TENKH";
            cbbTenKH.ValueMember = "MAKH";
            cbbTenKH.Text = "Chọn khách hàng";

            cbbMauSac.DataSource = _cthoadon.getAllMauXeFull();
            cbbMauSac.DisplayMember = "TENMAU";
            cbbMauSac.ValueMember = "IDMAU";
            cbbMauSac.Text = "Chọn màu";

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(true);
            enable(false);
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            
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
            cthd.MAHD = txtMaHD.Text;
            hd.NGAYLAP = DateTime.Now;
            hd.MANV = "NV04";
            hd.MAKH = "KH03";
            //cthd.MAXE = cbbTenXe.SelectedValue.ToString();
            //cthd.MAUSAC = txtMauSac.Text;
            cthd.SOLUONG = int.Parse(txtSoLuong.Text);
            //cthd.DONGIA = decimal.Parse(txtGiaBan.Text) * int.Parse(txtSoLuong.Text) *(11/10);
            _cthoadon.themCTHD(cthd);
            _them = false;
            loadData();
            showHideButton(true);
            enable(false);
        }
    }
}