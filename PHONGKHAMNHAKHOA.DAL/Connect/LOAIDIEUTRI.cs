namespace PHONGKHAMNHAKHOA.DAL.Connect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIDIEUTRI")]
    public partial class LOAIDIEUTRI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIDIEUTRI()
        {
            CHUANDOAN_DIEUTRI = new HashSet<CHUANDOAN_DIEUTRI>();
        }

        [Key]
        public int MALOAIDC { get; set; }

        [StringLength(50)]
        public string TENDIEUTRI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUANDOAN_DIEUTRI> CHUANDOAN_DIEUTRI { get; set; }
    }
}
