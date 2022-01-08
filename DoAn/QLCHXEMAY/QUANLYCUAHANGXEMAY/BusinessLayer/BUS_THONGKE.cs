using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_THONGKE
    {
        Entities db;
        public BUS_THONGKE()
        {
            db = Entities.CreateEntities();
        }
        public List<BUS_OBJ_THONGKE> getAll()
        {
            BUS_OBJ_THONGKE objthongke;
            List<BUS_OBJ_THONGKE> listThongKe = new List<BUS_OBJ_THONGKE>();
            var lst = db.CHARTXE().ToList();
            foreach (var item in lst)
            {
                objthongke = new BUS_OBJ_THONGKE();
                objthongke.tenXe = item.TENXE;
                objthongke.soLuong = item.SOLUONG;
                listThongKe.Add(objthongke);
            }
            return listThongKe;
        }

    }
}
