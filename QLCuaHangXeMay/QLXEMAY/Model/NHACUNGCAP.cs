namespace QLXEMAY.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            XEMAYs = new HashSet<XEMAY>();
        }

        [Key]
        [StringLength(5)]
        public string MANCC { get; set; }

        [StringLength(30)]
        public string TENNCC { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XEMAY> XEMAYs { get; set; }
    }
}
