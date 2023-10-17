namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINLAMSANG")]
    public partial class THONGTINLAMSANG
    {
        [Key]
        public int MALS { get; set; }

        [StringLength(200)]
        public string CHUANDOAN { get; set; }

        [StringLength(200)]
        public string NOIDUNGDIEUTRI { get; set; }

        public int? MABN { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
    }
}
