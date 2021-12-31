namespace QLXEMAY.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MAXE { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DONGIA { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual XEMAY XEMAY { get; set; }
    }
}
