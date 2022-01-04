using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;

namespace BusinessLayer
{
    public class BUS_LOAIXE
    {
        Entities db;
        public BUS_LOAIXE()
        {
            db = Entities.CreateEntities();
        }
        public tb_LOAIXE getItem(string tenloaixe)
        {
            return db.tb_LOAIXE.FirstOrDefault(x=>x.TENLOAIXE==tenloaixe);
        }
        public List<tb_LOAIXE> getAll()
        {
            return db.tb_LOAIXE.ToList();
        }
    }
}
