namespace PHONGKHAMNHAKHOA.DAL.Connect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINCANLAMSANG")]
    public partial class THONGTINCANLAMSANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTINCANLAMSANG()
        {
            CHUANDOAN_DIEUTRI = new HashSet<CHUANDOAN_DIEUTRI>();
        }

        [Key]
        public int MATTCLS { get; set; }

        [StringLength(50)]
        public string HUYETAPMACH { get; set; }

        [StringLength(50)]
        public string DUONGHUYET { get; set; }

        [StringLength(50)]
        public string MAUKHODONG { get; set; }

        [StringLength(50)]
        public string BENHTIMBAMSINH { get; set; }

        [StringLength(50)]
        public string THIEUNANGTRITUE { get; set; }

        [StringLength(50)]
        public string PHIMXQUANG { get; set; }

        [StringLength(250)]
        public string THONGTINBAOHANH { get; set; }

        [StringLength(100)]
        public string KHAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUANDOAN_DIEUTRI> CHUANDOAN_DIEUTRI { get; set; }
    }
}
