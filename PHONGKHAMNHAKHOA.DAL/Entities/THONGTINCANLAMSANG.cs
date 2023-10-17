namespace PHONGKHAMNHAKHOA.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINCANLAMSANG")]
    public partial class THONGTINCANLAMSANG
    {
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

        public int? MABN { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
    }
}
