using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_CHITIETMAUXE
    {
        Entities db;
        public BUS_CHITIETMAUXE()
        {
            db = Entities.CreateEntities();
        }
        public tb_CHITIETMAUXE getItem(string maxe, int idmau)
        {
            return db.tb_CHITIETMAUXE.FirstOrDefault(x => x.MAXE == maxe && x.IDMAU == idmau);
        }
    }
}
