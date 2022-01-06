using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;

namespace BusinessLayer
{
    public class BUS_KHACHHANG
    {
        Entities db;
        public BUS_KHACHHANG()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_KHACHHANG> getAll()
        {
            return db.tb_KHACHHANG.ToList();
        }
        public tb_KHACHHANG getItem(string makh)
        {
            return db.tb_KHACHHANG.FirstOrDefault(x => x.MAKH == makh);
        }

        public void add(tb_KHACHHANG kh)
        {
            try
            {
                db.tb_KHACHHANG.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lí." + ex.Message);
            }
        }

        public void update(tb_KHACHHANG kh)
        {
            tb_KHACHHANG _kh = new tb_KHACHHANG();
            _kh.MAKH = kh.MAKH;
            _kh.TENKH = kh.TENKH;
            _kh.DIACHI = kh.DIACHI;
            _kh.SDT = kh.SDT;
            _kh.DISABLE = kh.DISABLE;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lý." + ex.Message);
            }
        }

        public void delete(string makh)
        {
            tb_KHACHHANG kh = db.tb_KHACHHANG.FirstOrDefault(x => x.MAKH == makh);
            kh.DISABLE = true;
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
