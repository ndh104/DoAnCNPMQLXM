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
        public tb_LOAIXE getItem(string maloaixe)
        {
            return db.tb_LOAIXE.FirstOrDefault(x=>x.MALOAI==maloaixe);
        }
        public List<tb_LOAIXE> getAll()
        {
            return db.tb_LOAIXE.ToList();
        }

        public void them(tb_LOAIXE LoaiXe)
        {
            try
            {
                db.tb_LOAIXE.Add(LoaiXe);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình tải dữ liệu" + ex.Message);
            }
        }

        public void capnhat(tb_LOAIXE LoaiXe)
        {
            tb_LOAIXE _NCC = db.tb_LOAIXE.FirstOrDefault(x => x.MALOAI == LoaiXe.MALOAI);
            _NCC.TENLOAIXE = LoaiXe.TENLOAIXE;
            _NCC.DISABLE = LoaiXe.DISABLE;
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình tải dữ liệu" + ex.Message);
            }

        }
        public void xoa(string maloaixe)
        {
            tb_LOAIXE LoaiXe = db.tb_LOAIXE.FirstOrDefault(x => x.MALOAI == maloaixe);
            LoaiXe.DISABLE = true;
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình tải dữ liệu" + ex.Message);
            }
        }
    }
}
