namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUANDOAN_DIEUTRI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUANDOAN_DIEUTRI()
        {
            THANHTOAN = new HashSet<THANHTOAN>();
        }

        [Key]
        public int MACDDC { get; set; }

        public int? MALOAIDC { get; set; }

        [StringLength(50)]
        public string DONVITINH { get; set; }

        [StringLength(10)]
        public string SOLUONG { get; set; }

        public double? DONGIA { get; set; }

        public double? THANHTIEN { get; set; }

        public int? MABN { get; set; }

        public virtual LOAIDIEUTRI LOAIDIEUTRI { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTOAN> THANHTOAN { get; set; }
    }
}
