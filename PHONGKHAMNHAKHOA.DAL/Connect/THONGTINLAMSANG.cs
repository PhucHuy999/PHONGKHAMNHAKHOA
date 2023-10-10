namespace PHONGKHAMNHAKHOA.DAL.Connect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINLAMSANG")]
    public partial class THONGTINLAMSANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTINLAMSANG()
        {
            CHUANDOAN_DIEUTRI = new HashSet<CHUANDOAN_DIEUTRI>();
        }

        [Key]
        public int MALS { get; set; }

        [StringLength(200)]
        public string CHUANDOAN { get; set; }

        [StringLength(200)]
        public string NOIDUNGDIEUTRI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUANDOAN_DIEUTRI> CHUANDOAN_DIEUTRI { get; set; }
    }
}
