using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;

namespace BusinessLayer
{
    public class BUS_CHITIETHOADON
    {
        Entities db;
        public BUS_CHITIETHOADON()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_CHITIETHOADON> getAll()
        {
            return db.tb_CHITIETHOADON.ToList();
        }
        public List<tb_CHITIETMAUXE>getAllMauXe(string maxe)
        {
            return db.tb_CHITIETMAUXE.Where(x => x.MAXE == maxe).ToList();
        }
        public List<BUS_OBJ_CHITIETMAUXE> getAllMauXeFull()
        {
            var listmausac = db.tb_CHITIETMAUXE.ToList();
            List<BUS_OBJ_CHITIETMAUXE> listMauSacFull = new List<BUS_OBJ_CHITIETMAUXE>();
            BUS_OBJ_CHITIETMAUXE objmausac;
            foreach (var item in listmausac)
            {
                objmausac = new BUS_OBJ_CHITIETMAUXE();
                objmausac.IDMAU = item.IDMAU;
                objmausac.MAXE = item.MAXE;
                objmausac.IDCHITIETXE = item.IDCHITIETXE;
                var mausac = db.tb_MAUSAC.FirstOrDefault(x => x.IDMAU == item.IDMAU);
                objmausac.TENMAU = mausac.TENMAU;
                var xe = db.tb_XEMAY.FirstOrDefault(x => x.MAXE == item.MAXE);
                objmausac.TENXE = xe.TENXE;
                listMauSacFull.Add(objmausac);
            }
            return listMauSacFull.ToList();
        }
        public List<BUS_OBJ_BANHANG> getAllFull()
        {
            var listcthd = db.tb_CHITIETHOADON.ToList();
            List<BUS_OBJ_BANHANG> listCTHDFUll = new List<BUS_OBJ_BANHANG>();
            BUS_OBJ_BANHANG objbanhang;
            foreach (var item in listcthd)
            {
                objbanhang = new BUS_OBJ_BANHANG();
                objbanhang.MAHD = item.MAHD;
                objbanhang.SOLUONG = item.SOLUONG;
                objbanhang.TONGTIEN = item.TONGTIEN;
                //lấy đối tượng hoá đơn từ bảng "tb_HOADON"
                var hoadon = db.tb_HOADON.FirstOrDefault(x => x.MAHD == item.MAHD);
                objbanhang.NGAYLAP = hoadon.NGAYLAP;
                //lấy đối tượng nhân viên từ bảng "tb_NHANVIEN"
                var nhanvien = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == hoadon.MANV);
                objbanhang.TENNV = nhanvien.TENNV;
                //lấy đối tượng khách hàng từ bảng "tb_KHACHANG"
                var khachhang = db.tb_KHACHHANG.FirstOrDefault(x => x.MAKH == hoadon.MAKH);
                objbanhang.TENKH = khachhang.TENKH;
                //Lấy đối tượng từ bảng "tb_CHITIETMAUSAC"
                var xeCTMAUXE = db.tb_CHITIETMAUXE.FirstOrDefault(x => x.IDCHITIETXE == item.IDCHITIETXE);
                //Lấy đối tượng từ bảng "tb_MAUSAC"
                var xeMAUSAC = db.tb_MAUSAC.FirstOrDefault(x => x.IDMAU == xeCTMAUXE.IDMAU);
                objbanhang.TENMAU = xeMAUSAC.TENMAU;
                //lấy đối tượng xe từ bảng "tb_XEMAY"
                var xeXEMAY = db.tb_XEMAY.FirstOrDefault(x => x.MAXE == xeCTMAUXE.MAXE);
                objbanhang.TENXE = xeXEMAY.TENXE;
                objbanhang.GIABAN = xeXEMAY.GIABAN;
                listCTHDFUll.Add(objbanhang);
            }
            return listCTHDFUll.OrderBy(x => x.NGAYLAP).ToList();
        }
        public void themCTHD(tb_CHITIETHOADON cthd)
        {
            try
            {
                db.tb_CHITIETHOADON.Add(cthd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu!" + ex.Message);
            }
        }
    }
}
