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
    }
}
