using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL.FULL
{
    public class DONTHUOC_FULL
    {
        public int MADT { get; set; }

        public string DONVITINHTHUOC { get; set; }
        public string SOLUONGTHUOC { get; set; }
        public double? DONGIATHUOC { get; set; }
        public double? THANHTIENTHUOC { set; get; }



        public Nullable<int> MALOAITHUOC { get; set; }
        public string TENLOAITHUOC { get; set; }
        public string NGAY { get; set; }
        public string CACHDUNG { get; set; }

        public Nullable<int> MABN { get; set; }
        public string HOTEN { get; set; }
        public string NGAYSINH { set; get; }
        public string NGAYKHAMDAUTIEN { set; get; }
        public string DIENTHOAI { set; get; }
        public string DIACHI { set; get; }
        public Nullable<bool> GIOITINH { get; set; }

        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
        public virtual LOAITHUOC LOAITHUOC { get; set; }
    }
}
