namespace QLXEMAY.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(4)]
        public string MANV { get; set; }

        [StringLength(30)]
        public string TENNV { get; set; }

        [StringLength(3)]
        public string GIOITINH { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string CHUCVU { get; set; }

        [StringLength(15)]
        public string USERNAME { get; set; }

        [StringLength(10)]
        public string PASSWORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
