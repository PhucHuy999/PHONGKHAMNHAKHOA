namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAPXUAT_DCVLNK
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(200)]
        public string TENDCVL { get; set; }

        [StringLength(50)]
        public string DONVITINH { get; set; }

        [StringLength(10)]
        public string SOLUONG { get; set; }

        public double? DONGIA { get; set; }

        public double? THANHTIEN { get; set; }

        public int? LOAI { get; set; }

        public DateTime? NGAY { get; set; }

        [StringLength(200)]
        public string NOIDUNG { get; set; }
    }
}
