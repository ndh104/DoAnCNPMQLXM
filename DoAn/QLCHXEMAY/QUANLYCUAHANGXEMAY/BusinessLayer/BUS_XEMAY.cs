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
        public tb_XEMAY getItem(string mx)
        {
            return db.tb_XEMAY.FirstOrDefault(x=>x.MAXE==mx);
        }
        public List<tb_XEMAY> getAll()
        {
            return db.tb_XEMAY.ToList();
        }
        public List<tb_XEMAY> getAll(string maxe)
        {
            return db.tb_XEMAY.Where(x => x.MAXE == maxe).ToList();
        }


        public List<BUS_OBJ_XEMAYFULL> getAllFull()
        {
            var listxemay = db.tb_XEMAY.ToList();

            List<BUS_OBJ_XEMAYFULL> listXeFull = new List<BUS_OBJ_XEMAYFULL>();
            BUS_OBJ_XEMAYFULL objxe;

            foreach (var item in listxemay)
            {
                objxe = new BUS_OBJ_XEMAYFULL();
                objxe.MAXE = item.MAXE;
                objxe.TENXE = item.TENXE;
                objxe.GIABAN = item.GIABAN;
                objxe.MAUSAC = item.MAUSAC;
                objxe.MALOAI = item.MALOAI;
                objxe.DUNGTICH = item.DUNGTICH;
                objxe.TINHTRANG = item.TINHTRANG;
                objxe.MANCC = item.MANCC;
                objxe.DISABLE = item.DISABLE;
                // lấy đối tượng loại xe từ bảng loại xe "tb_LOAIXE"
                var loaixeLX = db.tb_LOAIXE.FirstOrDefault(x=>x.MALOAI==item.MALOAI);
                objxe.TENLOAI = loaixeLX.TENLOAIXE;
                //lấy đối tượng nhà cung cấp từ bảng "tb_NHACUNGCAP"
                var nccNCC = db.tb_NHACUNGCAP.FirstOrDefault(x => x.MANCC == item.MANCC);
                objxe.TENNCC = nccNCC.TENNCC;
                listXeFull.Add(objxe);
            }
            return listXeFull.OrderBy(x => x.MAXE).ToList();
        }
        public void them(tb_XEMAY xe)
        {
            try
            {
                db.tb_XEMAY.Add(xe);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" +ex.Message);
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
            _xemay.MANCC = xe.MANCC;
            _xemay.MALOAI = xe.MALOAI; 
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" +ex.Message);
            }
        }
        public void del(string maxe)
        {
            tb_XEMAY _xe = db.tb_XEMAY.FirstOrDefault(x => x.MAXE == maxe);
            _xe.DISABLE = true;
            try 
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        
    }
}
