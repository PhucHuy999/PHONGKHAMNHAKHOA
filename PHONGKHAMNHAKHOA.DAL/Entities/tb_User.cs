namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_User
    {
        [Key]
        public int IDUSER { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string FULLNAME { get; set; }

        [StringLength(100)]
        public string PASS { get; set; }

        [StringLength(50)]
        public string QUYEN { get; set; }

        [StringLength(50)]
        public string DIENTHOAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }
    }
}
