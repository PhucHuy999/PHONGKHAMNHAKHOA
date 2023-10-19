using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL.DTO
{
    public class THONGTINCANLAMSANG_FULL
    {
        public int MATTCLS { get; set; }

        public string HUYETAPMACH { get; set; }
        public string DUONGHUYET { get; set; }
        public string MAUKHODONG { get; set; }
        public string BENHTIMBAMSINH { get; set; }
        public string THIEUNANGTRITUE { get; set; }
        public string PHIMXQUANG { get; set; }
        public string THONGTINBAOHANH { get; set; }
        public string KHAC { get; set; }
        public Nullable<int> MABN { get; set; }
        public string HOTEN { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }

    }
}
