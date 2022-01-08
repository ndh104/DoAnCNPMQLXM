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
        public List<BUS_OBJ_HOADON> getAllFull()
        {
            var listhoadon = db.tb_HOADON.ToList();
            List<BUS_OBJ_HOADON> listHDFUll = new List<BUS_OBJ_HOADON>();
            BUS_OBJ_HOADON objhoadon;
            foreach (var item in listhoadon)
            {
                objhoadon = new BUS_OBJ_HOADON();
                objhoadon.MAHD = item.MAHD;
                objhoadon.NGAYLAP = item.NGAYLAP;
                objhoadon.MANV = item.MANV;
                objhoadon.MAKH = item.MAKH;
                //lấy đối tượng chi tiết hoá đơn từ bảng "tb_CHITIETHOADON"
                var cthd = db.tb_CHITIETHOADON.FirstOrDefault(x => x.MAHD == item.MAHD);
                //objhoadon.DONGIA = cthd.DONGIA;
                objhoadon.SOLUONG = cthd.SOLUONG;
                //lấy đối tượng nhân viên từ bảng "tb_NHANVIEN"
                var nhanvien = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                objhoadon.TENNV = nhanvien.TENNV;
                //lấy đối tượng khách hàng từ bảng "tb_KHACHANG"
                var khachhang = db.tb_KHACHHANG.FirstOrDefault(x => x.MAKH == item.MAKH);
                objhoadon.TENKH = khachhang.TENKH;
                //lấy đối tượng xe từ bảng "tb_XEMAY"
                //var xeXEMAY = db.tb_XEMAY.FirstOrDefault(x => x.MAXE == cthd.MAXE);
                //objhoadon.TENXE = xeXEMAY.TENXE;
                //objhoadon.MAUSAC = xeXEMAY.MAUSAC;
                //objhoadon.GIABAN = xeXEMAY.GIABAN;
                listHDFUll.Add(objhoadon);
            }
            return listHDFUll.OrderBy(x => x.NGAYLAP).ToList();
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
