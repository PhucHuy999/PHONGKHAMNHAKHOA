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
    }
}
