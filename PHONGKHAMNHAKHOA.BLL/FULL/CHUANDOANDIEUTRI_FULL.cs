using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL.FULL
{
    public class CHUANDOANDIEUTRI_FULL
    {
        public int MACDDC { get; set; }

        public string DONVITINH { get; set; }
        public string SOLUONG { get; set; }
        public double? DONGIA { get; set; }
        public double? THANHTIEN { set; get; }



        public Nullable<int> MALOAIDC { get; set; }
        public string TENDIEUTRI { get; set; }
        public Nullable<int> MABN { get; set; }
        public string HOTEN { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
        public virtual LOAIDIEUTRI LOAIDIEUTRI { get; set; }
    }
}
