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
    }
}
