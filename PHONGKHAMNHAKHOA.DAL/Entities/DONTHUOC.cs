namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONTHUOC")]
    public partial class DONTHUOC
    {
        [Key]
        public int MADT { get; set; }

        public int? MALOAITHUOC { get; set; }

        [StringLength(50)]
        public string DONVITINHTHUOC { get; set; }

        [StringLength(10)]
        public string SOLUONGTHUOC { get; set; }

        public double? DONGIATHUOC { get; set; }

        public double? THANHTIENTHUOC { get; set; }

        public int? MABN { get; set; }

        public virtual LOAITHUOC LOAITHUOC { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
    }
}
