using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;

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
    }
}
