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
    }
}
