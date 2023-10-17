using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class BenhNhan
    {
        Model1 db = new Model1();

        public List<THONGTINBENHNHAN> GetAll()
        {
            return db.THONGTINBENHNHAN.ToList();
        }
        public THONGTINBENHNHAN GetItem(int id)
        {
            return db.THONGTINBENHNHAN.FirstOrDefault(x => x.MABN == id);
        }
        public THONGTINBENHNHAN Add(THONGTINBENHNHAN bn)
        {
            try
            {
                db.THONGTINBENHNHAN.Add(bn);
                db.SaveChanges();
                return bn;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public THONGTINBENHNHAN Update(THONGTINBENHNHAN bn)
        {
            try
            {
                var _bn = db.THONGTINBENHNHAN.FirstOrDefault(x => x.MABN == bn.MABN);
                _bn.HOTEN = bn.HOTEN;
                _bn.GIOITINH = bn.GIOITINH;
                _bn.NGAYSINH = bn.NGAYSINH;
                _bn.DIENTHOAI = bn.DIENTHOAI;
                _bn.DIACHI = bn.DIACHI;
                _bn.NGAYKHAMDAUTIEN = bn.NGAYKHAMDAUTIEN;
                _bn.LYDODENKHAM = bn.LYDODENKHAM;
                db.SaveChanges();
                return bn;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _bn = db.THONGTINBENHNHAN.FirstOrDefault(x => x.MABN == id);
                db.THONGTINBENHNHAN.Remove(_bn);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
