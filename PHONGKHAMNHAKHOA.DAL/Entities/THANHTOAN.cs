namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANHTOAN")]
    public partial class THANHTOAN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MABN { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MACDDC { get; set; }

        public DateTime? NGAYTHANHTOAN { get; set; }

        public double? SOTIENDATHANHTOAN { get; set; }

        public double? SOTIENCONLAI { get; set; }

        [StringLength(100)]
        public string GHICHU { get; set; }
        public virtual CHUANDOAN_DIEUTRI CHUANDOAN_DIEUTRI { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
    }
}
