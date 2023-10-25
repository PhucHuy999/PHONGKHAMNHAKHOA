using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL.FULL
{
    public class THANHTOAN_FULL
    {
        public int MATHANHTOAN { get; set; }
        public string NGAYTHANHTOAN { get; set; }
        public double? TONGPHAITHANHTOAN { get; set; }
        public double? SOTIENDATHANHTOAN { get; set; }
        public double? SOTIENCONLAI { set; get; }
        public string GHICHU { set; get; }
        public Nullable<bool> GIOITINH { get; set; }
        public string NGAYSINH { set; get; }
        public string NGAYKHAMDAUTIEN { set; get; }
        public string DIENTHOAI { set; get; }
        public string DIACHI { set; get; }
        //public string LYDODENKHAM { set; get; }
        
        public Nullable<int> MACDDC { set; get; }
        public Nullable<int> MALOAIDC { get; set; }
        public string TENDIEUTRI { get; set; }
        public string DONVITINH { get; set; }
        public string SOLUONG { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<double> THANHTIEN { get; set; }

        public Nullable<int> MABN { get; set; }
        public string HOTEN { get; set; }
        public Nullable<int> MALOAITHUOC { get; set; }
        public string TENLOAITHUOC { get; set; }
        public string DONVITINHTHUOC { get; set; }
        public string SOLUONGTHUOC { get; set; }
        public Nullable<double> DONGIATHUOC { get; set; }
        public Nullable<double> THANHTIENTHUOC { get; set; }


        public virtual THONGTINBENHNHAN THONGTINBENHNHAN { get; set; }
        public virtual LOAIDIEUTRI LOAIDIEUTRI { get; set; }
        public virtual CHUANDOAN_DIEUTRI CHUANDOAN_DIEUTRI { get; set; }
        public virtual DONTHUOC DONTHUOC { get; set; }
        public virtual LOAITHUOC LOAITHUOC { get; set; }



    }
}
