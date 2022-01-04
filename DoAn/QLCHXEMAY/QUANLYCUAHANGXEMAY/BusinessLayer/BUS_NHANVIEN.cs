using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_NHANVIEN
    {
        Entities db;
        public BUS_NHANVIEN()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_NHANVIEN> getAll()
        {
            return db.tb_NHANVIEN.ToList();
        }
        public tb_NHANVIEN getItem(string tk, string mk)
        {
            return db.tb_NHANVIEN.FirstOrDefault(x => x.USERNAME == tk && x.PASSWORD == mk);
        }
    }
}
