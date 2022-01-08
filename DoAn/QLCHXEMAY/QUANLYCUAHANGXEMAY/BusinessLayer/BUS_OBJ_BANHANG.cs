using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_OBJ_BANHANG
    {
        public string MAHD { get; set; }
        public string MAXE { get; set; }
        public int? SOLUONG { get; set; }
        public decimal? TONGTIEN { get; set; }
        public DateTime? NGAYLAP { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public string TENKH { get; set; }
        public string TENNV { get; set; }
        public string TENXE { get; set; }
        public decimal? GIABAN { get; set; }
        public int IDCHITIETMAU { get; set; }
        public string TENMAU { get; set; }
    }
}
