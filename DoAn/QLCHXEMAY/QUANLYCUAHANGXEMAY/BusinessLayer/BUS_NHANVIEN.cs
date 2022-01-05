using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_NHANVIEN
    {
        Entities db;
        public BUS_NHANVIEN()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_NHANVIEN> getAll()
        {
            return db.tb_NHANVIEN.ToList();
        }
        public tb_NHANVIEN getItem(string tk, string mk)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.USERNAME == tk && x.PASSWORD == mk);
        }
        public tb_NHANVIEN getItems(string tk, string manv, string hoten, DateTime ngaysinh, string cmnd, string sdt)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x=> x.USERNAME == tk && x.MANV == manv && x.TENNV == hoten 
                                                 && x.NGAYSINH == ngaysinh && x.CMND == cmnd && x.SDT == sdt);
        }
        public void capNhatMatKhau(string tk, string mk)
        {
            tb_NHANVIEN _nhanvien = db.tb_NHANVIEN.FirstOrDefault(x => x.USERNAME == tk); //lấy ra nhân viên có "USERNAME" = "tk"
            _nhanvien.PASSWORD = mk;//gán mật khẩu mới trong "mk" vào "PASSWORD" ở trong bảng "tb_NHANVIEN"
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}
