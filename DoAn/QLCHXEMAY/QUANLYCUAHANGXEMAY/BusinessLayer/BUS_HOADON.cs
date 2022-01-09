using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataAccessLayer;

namespace BusinessLayer
{
     
    public class BUS_HOADON
    {
        Entities db;
        public BUS_HOADON()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_HOADON> getAll()
        {
            return db.tb_HOADON.ToList();
        }
        public void themHD(tb_HOADON hd)
        {
            try
            {
                db.tb_HOADON.Add(hd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu!" + ex.Message);
            }
        }
    }
}
