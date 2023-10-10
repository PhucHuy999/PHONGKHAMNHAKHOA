namespace PHONGKHAMNHAKHOA.DAL.Connect
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINBENHNHAN")]
    public partial class THONGTINBENHNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTINBENHNHAN()
        {
            CHUANDOAN_DIEUTRI = new HashSet<CHUANDOAN_DIEUTRI>();
            DONTHUOC = new HashSet<DONTHUOC>();
            THANHTOAN = new HashSet<THANHTOAN>();
        }

        [Key]
        public int MABN { get; set; }

        [StringLength(200)]
        public string HOTEN { get; set; }

        public bool? GIOITINH { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(12)]
        public string DIENTHOAI { get; set; }

        [StringLength(200)]
        public string DIACHI { get; set; }

        public DateTime? NGAYKHAMDAUTIEN { get; set; }

        [StringLength(200)]
        public string LYDODENKHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUANDOAN_DIEUTRI> CHUANDOAN_DIEUTRI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONTHUOC> DONTHUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTOAN> THANHTOAN { get; set; }
    }
}
