namespace QLXEMAY.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XEMAY")]
    public partial class XEMAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XEMAY()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        [StringLength(5)]
        public string MAXE { get; set; }

        [StringLength(20)]
        public string TENXE { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIABAN { get; set; }

        [StringLength(15)]
        public string MAUSAC { get; set; }

        [StringLength(6)]
        public string DUNGTICH { get; set; }

        [StringLength(3)]
        public string TINHTRANG { get; set; }

        [Required]
        [StringLength(5)]
        public string MALOAI { get; set; }

        [Required]
        [StringLength(5)]
        public string MANCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual LOAIXE LOAIXE { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
