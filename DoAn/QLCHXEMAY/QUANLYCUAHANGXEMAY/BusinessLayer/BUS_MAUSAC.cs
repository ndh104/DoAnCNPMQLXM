using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;

namespace BusinessLayer
{
    public class BUS_MAUSAC
    {
        Entities db;
        public BUS_MAUSAC()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_MAUSAC> getAll()
        {
            return db.tb_MAUSAC.ToList();
        }
        public tb_MAUSAC getItem(int idmau)
        {
            return db.tb_MAUSAC.FirstOrDefault(x => x.IDMAU == idmau);
        }
        public void them(tb_MAUSAC mau)
        {
            try
            {
                db.tb_MAUSAC.Add(mau);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xử lí." + ex.Message);
            }
        }
        public void capnhat(tb_MAUSAC mau)
        {
            tb_MAUSAC _mau = new tb_MAUSAC();
            _mau.IDMAU = mau.IDMAU;
            _mau.TENMAU = mau.TENMAU;
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
