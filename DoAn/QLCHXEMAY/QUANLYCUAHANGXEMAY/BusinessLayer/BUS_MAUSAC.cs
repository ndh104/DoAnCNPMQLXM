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
    }
}
