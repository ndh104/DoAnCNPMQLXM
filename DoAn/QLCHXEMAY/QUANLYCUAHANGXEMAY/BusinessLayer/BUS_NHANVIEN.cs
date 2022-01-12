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
        public tb_NHANVIEN getItemNV(string tk)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.USERNAME == tk);
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
        public tb_NHANVIEN Get_Item(string manv)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == manv);
        }
        public void doiMatKhau(string tk, string mkm)
        {

            tb_NHANVIEN _nhanvien = db.tb_NHANVIEN.FirstOrDefault(x => x.USERNAME == tk);
            _nhanvien.PASSWORD = mkm;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void add(tb_NHANVIEN nv)
        {
            try
            {
                db.tb_NHANVIEN.Add(nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lý." + ex.Message);
            }
        }

        public void update(tb_NHANVIEN nv)
        {
            tb_NHANVIEN _nv = new tb_NHANVIEN();
            _nv.MANV = nv.MANV;
            _nv.TENNV = nv.TENNV;
            _nv.CHUCVU = nv.CHUCVU;
            _nv.NGAYSINH = nv.NGAYSINH;
            _nv.GIOITINH = nv.GIOITINH;
            _nv.DIACHI = nv.DIACHI;
            _nv.CMND = nv.CMND;
            _nv.SDT = nv.SDT;
            _nv.DISABLE = nv.DISABLE;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lý." + ex.Message);
            }
        }

        public void delete(string manv)
        {
            tb_NHANVIEN nv = db.tb_NHANVIEN.FirstOrDefault(x => x.MANV == manv);
            nv.DISABLE = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lý." + ex.Message);
            }
        }
    }
}
