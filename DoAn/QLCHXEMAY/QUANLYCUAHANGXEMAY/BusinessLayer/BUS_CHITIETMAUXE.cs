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
        public List<tb_CHITIETMAUXE> getAll()
        {
            return db.tb_CHITIETMAUXE.ToList();
        }
        public List<tb_CHITIETMAUXE> getAll(int idchitietxe)
        {
            return db.tb_CHITIETMAUXE.Where(x => x.IDCHITIETXE == idchitietxe).ToList();
        }
        public tb_CHITIETMAUXE getItem(int idctxe)
        {
            return db.tb_CHITIETMAUXE.FirstOrDefault(x => x.IDCHITIETXE == idctxe);
        }
        public tb_CHITIETMAUXE getItem(string maxe, int idmau)
        {
            return db.tb_CHITIETMAUXE.FirstOrDefault(x => x.MAXE == maxe && x.IDMAU == idmau);
        }
        public List<BUS_OBJ_CHITIETMAUXE> getAllFull()
        {
            var chiTietXe = db.tb_CHITIETMAUXE.ToList();
            List<BUS_OBJ_CHITIETMAUXE> listChiTietMauXe = new List<BUS_OBJ_CHITIETMAUXE>();
            BUS_OBJ_CHITIETMAUXE objchitietxe;
            foreach (var item in chiTietXe)
            {
                objchitietxe = new BUS_OBJ_CHITIETMAUXE();
                objchitietxe.IDCHITIETXE = item.IDCHITIETXE;
                objchitietxe.IDMAU = item.IDMAU;
                objchitietxe.MAXE = item.MAXE;
                // lấy đối tượng xe từ bảng loại xe "tb_XEMAY"
                var xeXEMAY = db.tb_XEMAY.FirstOrDefault(x => x.MAXE == item.MAXE);
                objchitietxe.TENXE = xeXEMAY.TENXE;
                //lấy đối tượng màu sắc từ bảng "tb_MAUSAC"
                var mauMAUSAC = db.tb_MAUSAC.FirstOrDefault(x => x.IDMAU == item.IDMAU);
                objchitietxe.TENMAU = mauMAUSAC.TENMAU;
                listChiTietMauXe.Add(objchitietxe);
            }
            return listChiTietMauXe.OrderBy(x => x.IDCHITIETXE).ToList();
        }
        public void them(tb_CHITIETMAUXE ctxe)
        {
            try
            {
                db.tb_CHITIETMAUXE.Add(ctxe);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu!" + ex.Message);
            }
        }
        public void capnhat(tb_CHITIETMAUXE ctxe)
        {
            tb_CHITIETMAUXE _ctxe = db.tb_CHITIETMAUXE.FirstOrDefault(x => x.IDCHITIETXE == ctxe.IDCHITIETXE);
            _ctxe.IDCHITIETXE = ctxe.IDCHITIETXE;
            _ctxe.IDMAU = ctxe.IDMAU;
            _ctxe.MAXE = ctxe.MAXE;
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
