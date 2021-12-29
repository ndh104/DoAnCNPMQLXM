namespace QLXEMAY.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIXE")]
    public partial class LOAIXE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIXE()
        {
            XEMAYs = new HashSet<XEMAY>();
        }

        [Key]
        [StringLength(5)]
        public string MALOAI { get; set; }

        [StringLength(15)]
        public string TENLOAIXE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XEMAY> XEMAYs { get; set; }
    }
}
