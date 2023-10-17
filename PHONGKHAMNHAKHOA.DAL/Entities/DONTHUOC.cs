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
        public string DONVITINH { get; set; }

        [StringLength(10)]
        public string SOLUONG { get; set; }

        public double? DONGIA { get; set; }

        public double? THANHTIEN { get; set; }

        public int? MABN { get; set; }

        public virtual LOAITHUOC LOAITHUOC { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
    }
}
