using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public class OBJLOAIXE
    {
        Entities db;
        public OBJLOAIXE()
        {
            db = Entities.CreateEntities();
        }

        public List<LOAIXE> layThongTin()
        {
            return db.LOAIXEs.ToList();
        }
    }
}
