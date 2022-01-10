using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

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
        public tb_LOAIXE getItemMa(string maloaixe)
        {
            return db.tb_LOAIXE.FirstOrDefault(x => x.MALOAI == maloaixe);
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

        public void capnhat(tb_LOAIXE loaixe)
        {
            tb_LOAIXE _loai = new tb_LOAIXE();
            _loai.MALOAI = loaixe.MALOAI;
            _loai.TENLOAIXE = loaixe.TENLOAIXE;
            _loai.DISABLE = loaixe.DISABLE;
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
            tb_LOAIXE _loaixe = db.tb_LOAIXE.FirstOrDefault(x => x.MALOAI == maloaixe);
            _loaixe.DISABLE = true;
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
