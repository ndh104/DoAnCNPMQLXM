using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_NHACUNGCAP
    {
        Entities db;
        public BUS_NHACUNGCAP()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_NHACUNGCAP> getAll()
        {
            return db.tb_NHACUNGCAP.ToList();
        }
        public tb_NHACUNGCAP getItem(string mancc)
        {
            return db.tb_NHACUNGCAP.FirstOrDefault(x => x.MANCC == mancc);
        }

        public void them(tb_NHACUNGCAP NCC)
        {
            try
            {
                db.tb_NHACUNGCAP.Add(NCC);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình tải dữ liệu" + ex.Message);
            }
        }

        public void capnhat(tb_NHACUNGCAP NCC)
        {
            tb_NHACUNGCAP _NCC = new tb_NHACUNGCAP();
            _NCC.MANCC = NCC.MANCC;
            _NCC.TENNCC = NCC.TENNCC;
            _NCC.DIACHI = NCC.DIACHI;
            _NCC.SDT = NCC.SDT;
            _NCC.DISABLE = NCC.DISABLE;
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình tải dữ liệu" + ex.Message);
            }

        }
        public void xoa(string mancc)
        {
            tb_NHACUNGCAP _ncc = db.tb_NHACUNGCAP.FirstOrDefault(x => x.MANCC == mancc);
            _ncc.DISABLE = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình tải dữ liệu" + ex.Message);
            }
        }
    }
}
