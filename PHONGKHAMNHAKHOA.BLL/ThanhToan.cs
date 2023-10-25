using PHONGKHAMNHAKHOA.BLL.FULL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class ThanhToan
    {
        Model1 db = new Model1();
        public THANHTOAN GetItem(int id )
        {
            return db.THANHTOAN.FirstOrDefault(x =>  x.MATHANHTOAN == id);
        }
        public List<THANHTOAN> GetAll()
        {
            return db.THANHTOAN.ToList();
        }
        public List<THANHTOAN_FULL> GetListFull()
        {
            var AA = db.THANHTOAN.ToList();
            List<THANHTOAN_FULL> BB = new List<THANHTOAN_FULL>();
            THANHTOAN_FULL ttDTO;
            foreach (var item in AA)
            {
                ttDTO = new THANHTOAN_FULL();
                ttDTO.MATHANHTOAN = item.MATHANHTOAN;
                ttDTO.NGAYTHANHTOAN = item.NGAYTHANHTOAN.Value.ToString("dd/MM/yyyy");
                ttDTO.SOTIENDATHANHTOAN = item.SOTIENDATHANHTOAN;
                ttDTO.SOTIENCONLAI = item.SOTIENCONLAI;
                ttDTO.GHICHU = item.GHICHU;
                ttDTO.TONGPHAITHANHTOAN = item.TONGPHAITHANHTOAN;

              
                // lấy tên loại điều trị
                ttDTO.MACDDC = item.MACDDC;
                var dt = db.CHUANDOAN_DIEUTRI
                    .Where(c => c.MACDDC == item.MACDDC)
                    .Select(c => c.LOAIDIEUTRI.TENDIEUTRI)
                    .FirstOrDefault();

                if (dt != null)
                {
                    ttDTO.TENDIEUTRI = dt;
                }
                //lấy tên thuốc
                ttDTO.MABN = item.MABN;
                var dtt = db.DONTHUOC
                    .Where(c => c.MABN == item.MABN )
                    .Select(c => c.LOAITHUOC.TENLOAITHUOC)
                    .FirstOrDefault();

                if (dtt != null)
                {
                    ttDTO.TENLOAITHUOC = dtt;
                }


                //////////
                ttDTO.MABN = item.MABN;
                var bn = db.THONGTINBENHNHAN.FirstOrDefault(n => n.MABN == item.MABN);// để lấy được tên bệnh nhân 
                ttDTO.HOTEN = bn.HOTEN;

                BB.Add(ttDTO);
            }
            return BB;
        }
        
        public THANHTOAN Add(THANHTOAN tt)
        {
            try
            {
                db.THANHTOAN.Add(tt);
                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public THANHTOAN Update(THANHTOAN tt)
        {
            try
            {
                var _tt = db.THANHTOAN.FirstOrDefault(x => x.MATHANHTOAN == tt.MATHANHTOAN );
                _tt.NGAYTHANHTOAN = tt.NGAYTHANHTOAN;
                _tt.SOTIENDATHANHTOAN = tt.SOTIENDATHANHTOAN;
                _tt.SOTIENCONLAI = tt.SOTIENCONLAI;
                _tt.GHICHU = tt.GHICHU;
                _tt.TONGPHAITHANHTOAN = tt.TONGPHAITHANHTOAN;

                db.SaveChanges();
                return tt;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public void Delete( int id)
        {
            try
            {
                var _tt = db.THANHTOAN.FirstOrDefault(x => x.MATHANHTOAN == id);
                db.THANHTOAN.Remove(_tt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }

        //public decimal TinhSoTienDaThanhToan(int maBenhNhan)
        //{
        //    // Tính tổng số tiền đã thanh toán cho bệnh nhân với mã là maBenhNhan
        //    decimal soTienDaThanhToan = (decimal)(db.THANHTOAN
        //        .Where(x => x.MABN == maBenhNhan)
        //        .Sum(x => (decimal?)x.SOTIENDATHANHTOAN) ?? 0);

        //    return soTienDaThanhToan;
        //}
        public decimal TinhSoTienDaThanhToan(int maBenhNhan)
        {
            // Truy xuất dữ liệu từ cơ sở dữ liệu trước
            var thanhToans = db.THANHTOAN.Where(x => x.MABN == maBenhNhan).ToList();

            // Tính tổng số tiền đã thanh toán sau khi đã truy xuất dữ liệu từ cơ sở dữ liệu
            decimal soTienDaThanhToan = (decimal)(thanhToans.Sum(x => x.SOTIENDATHANHTOAN) ?? 0.0);

            return soTienDaThanhToan;
        }
        public List<THANHTOAN_FULL> getItemFull(int id) // đưa về list 1 phần tử mới rpt mới nhận đậu xanh :v
        {
            List<THANHTOAN> lsttt = db.THANHTOAN.Where(x => x.MABN == id).ToList();
            List<THANHTOAN_FULL> lstTT = new List<THANHTOAN_FULL>();
            THANHTOAN_FULL tt;
            foreach (var item in lsttt)
            {
                tt = new THANHTOAN_FULL();
                tt.MABN = item.MABN;
                tt.MATHANHTOAN = item.MATHANHTOAN;
                tt.MACDDC = item.MACDDC;
                tt.NGAYTHANHTOAN = item.NGAYTHANHTOAN.Value.ToString("dd/MM/yyyy");
                tt.SOTIENDATHANHTOAN = item.SOTIENDATHANHTOAN;
                tt.SOTIENCONLAI = item.SOTIENCONLAI;
                tt.GHICHU = item.GHICHU;
                tt.TONGPHAITHANHTOAN = item.TONGPHAITHANHTOAN;

                tt.HOTEN = item.THONGTINBENHNHAN.HOTEN;
                tt.GIOITINH = item.THONGTINBENHNHAN.GIOITINH;
                tt.NGAYSINH = item.THONGTINBENHNHAN.NGAYSINH.Value.ToString("dd/MM/yyyy");
                tt.NGAYKHAMDAUTIEN = item.THONGTINBENHNHAN.NGAYKHAMDAUTIEN.Value.ToString("dd/MM/yyyy");
                tt.DIENTHOAI = item.THONGTINBENHNHAN.DIENTHOAI;
                tt.DIACHI = item.THONGTINBENHNHAN.DIACHI;


                //var nv = db.THONGTINBENHNHAN.FirstOrDefault(bn => bn.MABN == item.MABN);
                //tt.HOTEN = nv.HOTEN;
                //tt.GIOITINH = nv.GIOITINH;
                //tt.NGAYSINH = nv.NGAYSINH.Value.ToString("dd/MM/yyyy");
                //tt.NGAYKHAMDAUTIEN = nv.NGAYKHAMDAUTIEN.Value.ToString("dd/MM/yyyy");
                //tt.DIENTHOAI = nv.DIENTHOAI;
                //tt.DIACHI = nv.DIACHI;


                var cddttInfoList = db.CHUANDOAN_DIEUTRI
                  .Where(a => a.MABN == item.MABN)
                  .Select(a => new
                  {
                      TENDIEUTRI = a.LOAIDIEUTRI.TENDIEUTRI,
                      DONVITINH = a.DONVITINH,
                      SOLUONG = a.SOLUONG,
                      DONGIA = a.DONGIA,
                      THANHTIEN = a.THANHTIEN
                  })
                  .ToList();

                if (cddttInfoList.Count > 0)
                {
                    // Lấy thông tin từ danh sách
                    var cddttInfo = cddttInfoList[0];

                    tt.TENDIEUTRI = cddttInfo.TENDIEUTRI;
                    tt.DONVITINH = cddttInfo.DONVITINH;
                    tt.SOLUONG = cddttInfo.SOLUONG;
                    tt.DONGIA = cddttInfo.DONGIA;
                    tt.THANHTIEN = cddttInfo.THANHTIEN;

                }
                else
                {
                    tt.TENDIEUTRI = "Không điều trị";
                    tt.DONVITINH = "0";
                    tt.SOLUONG = "0";
                    tt.DONGIA = 0;
                    tt.THANHTIEN = 0;
                }



                var InfoListThuoc = db.DONTHUOC
                  .Where(a => a.MABN == item.MABN)
                  .Select(a => new
                  {
                      TENLOAITHUOC = a.LOAITHUOC.TENLOAITHUOC,
                      DONVITINHTHUOC = a.DONVITINHTHUOC,
                      SOLUONGTHUOC = a.SOLUONGTHUOC,
                      DONGIATHUOC = a.DONGIATHUOC,
                      THANHTIENTHUOC = a.THANHTIENTHUOC
                  })
                  .ToList();

                if (InfoListThuoc.Count > 0)
                {
                    // Lấy thông tin từ danh sách
                    var cddttInfo = InfoListThuoc[0];
                    tt.TENLOAITHUOC = cddttInfo.TENLOAITHUOC;
                    tt.DONVITINHTHUOC = cddttInfo.DONVITINHTHUOC;
                    tt.SOLUONGTHUOC = cddttInfo.SOLUONGTHUOC;
                    tt.DONGIATHUOC = cddttInfo.DONGIATHUOC;
                    tt.THANHTIENTHUOC = cddttInfo.THANHTIENTHUOC;
                }
                else
                {
                    tt.TENLOAITHUOC = "Không dùng thuốc";
                    tt.DONVITINHTHUOC = "0";
                    tt.SOLUONGTHUOC = "0";
                    tt.DONGIATHUOC = 0;
                    tt.THANHTIENTHUOC = 0;
                }

                lstTT.Add(tt);
            }
            return lstTT;
        }
    }
}
