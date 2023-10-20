using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL.FULL
{
    public class THONGTINLAMSANG_FULL
    {
        public int MALS {  get; set; }

        public string CHUANDOAN { get; set; }
        public string NOIDUNGDIEUTRI {  get; set; }
        public Nullable<int>  MABN {  get; set; }
        public string HOTEN { get; set; }

        public virtual  THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }

    }
}
