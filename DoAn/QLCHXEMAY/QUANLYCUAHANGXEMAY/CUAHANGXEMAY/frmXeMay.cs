﻿using DevExpress.XtraEditors;
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
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace CUAHANGXEMAY
{
    public partial class frmXeMay : DevExpress.XtraEditors.XtraForm
    {
        public frmXeMay()
        {
            InitializeComponent();
        }
        BUS_NHACUNGCAP _ncc;
        BUS_XEMAY _xemay;
        BUS_LOAIXE _loaixe;
        string _maxe;
        bool _them;
        void loadData()
        {
            gcXeMay.DataSource = _xemay.getAllFull();
            gvXeMay.OptionsBehavior.Editable = false;

            _ncc = new BUS_NHACUNGCAP();
            cbbNCC.DataSource = _ncc.getAll();
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";
            cbbNCC.Text = "Chọn nhà cung cấp";
            
            _loaixe = new BUS_LOAIXE();
            cbbLoaiXe.DataSource = _loaixe.getAll();
            cbbLoaiXe.DisplayMember = "TENLOAIXE";
            cbbLoaiXe.ValueMember = "MALOAI";
            cbbLoaiXe.Text = "Chọn loại xe";
        }


        private void frmXeMay_Load(object sender, EventArgs e)
        {
            enable(false);
            _xemay = new BUS_XEMAY();
            loadData();
            showHideButton(true);
        }

        void reset()
        {
            txtTenXe.Text = "";
            txtGiaBan.Text = "";
            txtTinhTrang.Text = "";
            txtDungTich.Text = "";
            cbbLoaiXe.Text = "";
            cbbNCC.Text = "";
            cbDisable.Checked = false;
        }
        void enable(bool en)
        {
            txtTenXe.Enabled = en;
            txtMaXe.Enabled = en;
            txtGiaBan.Enabled = en;
            txtTinhTrang.Enabled = en;
            txtDungTich.Enabled = en;
            cbbLoaiXe.Enabled = en;
            cbbNCC.Enabled = en;
            cbDisable.Enabled = false;
        }
        void showHideButton(bool sh)
        {
            btnThem.Visible = sh;
            btnSua.Visible = sh;
            btnXoa.Visible = sh;
            btnThoat.Visible = sh;
            btnLuu.Visible = !sh;
            btnHuy.Visible = !sh;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideButton(false);
            enable(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideButton(false);
            enable(true);
            reset();
            cbDisable.Enabled = true;
            txtMaXe.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _xemay.del(_maxe);
            }
            reset();
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {

                tb_XEMAY xe = new tb_XEMAY();
                xe.MAXE = txtMaXe.Text;
                xe.TENXE = txtTenXe.Text;
                xe.DUNGTICH = txtDungTich.Text;
                xe.TINHTRANG = txtTinhTrang.Text;
                xe.GIABAN = decimal.Parse(txtGiaBan.Text);
                xe.MALOAI = cbbLoaiXe.SelectedValue.ToString();
                xe.MANCC = cbbNCC.SelectedValue.ToString();
                xe.DISABLE = cbDisable.Checked;
                _xemay.them(xe);
            }
            else
            {
                tb_XEMAY xe = _xemay.getItem(_maxe);
                xe.TENXE = txtTenXe.Text;
                xe.DUNGTICH = txtDungTich.Text;
                xe.TINHTRANG = txtTinhTrang.Text;
                xe.GIABAN = decimal.Parse(txtGiaBan.Text);
                xe.MALOAI = cbbLoaiXe.SelectedValue.ToString();
                xe.MANCC = cbbNCC.SelectedValue.ToString();
                xe.DISABLE = cbDisable.Checked;
                _xemay.capnhat(xe);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvXeMay_Click(object sender, EventArgs e)
        {
            
            if (gvXeMay.RowCount > 0)
            {
                if (gvXeMay.GetFocusedRowCellValue("MAXE") != null)
                {
                    //Lấy mã xe ra "MAXE" trong bảng "XEMAY" đưa vào "_maxe"
                    _maxe = gvXeMay.GetFocusedRowCellValue("MAXE").ToString();
                    txtMaXe.Text = gvXeMay.GetFocusedRowCellValue("MAXE").ToString();
                    txtTenXe.Text = gvXeMay.GetFocusedRowCellValue("TENXE").ToString();
                    txtGiaBan.Text = gvXeMay.GetFocusedRowCellValue("GIABAN").ToString();
                    txtDungTich.Text = gvXeMay.GetFocusedRowCellValue("DUNGTICH").ToString();
                    txtTinhTrang.Text = gvXeMay.GetFocusedRowCellValue("TINHTRANG").ToString();
                    cbbNCC.Text = gvXeMay.GetFocusedRowCellValue("TENNCC").ToString();
                    cbbLoaiXe.Text = gvXeMay.GetFocusedRowCellValue("TENLOAI").ToString();
                    cbDisable.Checked = bool.Parse(gvXeMay.GetFocusedRowCellValue("DISABLE").ToString());
                }
            }
        }
        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiaBan.Text.Length>0)
                {
                    double a = double.Parse(txtGiaBan.Text);
                    txtGiaBan.Text = a.ToString("N0");
                    txtGiaBan.Focus();
                    txtGiaBan.SelectionStart = txtGiaBan.Text.Length;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        private void btnIn_Click(object sender, EventArgs e)
        {
            xuatReport("ReportDSXEMAY","DANH SÁCH XE MÁY");
        }

        private void btnQuanLyMauSac_Click(object sender, EventArgs e)
        {
            frmChiTietMauXe frm = new frmChiTietMauXe();
            frm.ShowDialog();
        }
    }
}