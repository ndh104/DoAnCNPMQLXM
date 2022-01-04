using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_XEMAY
    {
        Entities db;
        public BUS_XEMAY()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_XEMAY> getAll()
        {
            return db.tb_XEMAY.ToList();
        }
        public void them(tb_XEMAY xe)
        {
            try
            {
                db.tb_XEMAY.Add(xe);
                db.SaveChanges();
            }
            catch(Exception)
            {
                Console.WriteLine("Có lỗi xảy ra trong quá trình xử lý dữ liệu");
            }
        }
        public void capnhat(tb_XEMAY xe)
        {
            tb_XEMAY _xemay = db.tb_XEMAY.FirstOrDefault(x=>x.MAXE==xe.MAXE);
            _xemay.TENXE = xe.TENXE;
            _xemay.MAUSAC = xe.MAUSAC;
            _xemay.TINHTRANG = xe.TINHTRANG;
            _xemay.MANCC = xe.MANCC;
            _xemay.MALOAI = xe.MALOAI;
            _xemay.GIABAN = xe.GIABAN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                Console.WriteLine("Có lỗi xảy ra trong quá trình xử lý dữ liệu");
            }
        }
        public void xoa(string maxe)
        {
            tb_XEMAY xe = db.tb_XEMAY.FirstOrDefault(x=>x.MAXE==maxe);
        }
        
    }
}
