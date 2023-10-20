using PHONGKHAMNHAKHOA.BLL.FULL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class ChuanDoanDieuTri
    {
        Model1 db = new Model1();
        public CHUANDOAN_DIEUTRI GetItem(int id)
        {
            return db.CHUANDOAN_DIEUTRI.FirstOrDefault(x => x.MACDDC == id);
        }
        public List<CHUANDOAN_DIEUTRI> GetAll()
        {
            return db.CHUANDOAN_DIEUTRI.ToList();
        }
        public List<CHUANDOANDIEUTRI_FULL> GetListFull()
        {
            var AA = db.CHUANDOAN_DIEUTRI.ToList();
            List<CHUANDOANDIEUTRI_FULL> BB = new List<CHUANDOANDIEUTRI_FULL>();
            CHUANDOANDIEUTRI_FULL ccdtDTO;
            foreach (var item in AA)
            {
                ccdtDTO = new CHUANDOANDIEUTRI_FULL();
                ccdtDTO.MACDDC = item.MACDDC;
                ccdtDTO.DONVITINH = item.DONVITINH;
                ccdtDTO.SOLUONG = item.SOLUONG;
                ccdtDTO.DONGIA = item.DONGIA;
                ccdtDTO.THANHTIEN = item.THANHTIEN;

                ccdtDTO.MALOAIDC = item.MALOAIDC;
                var dt = db.LOAIDIEUTRI.FirstOrDefault(n => n.MALOAIDC == item.MALOAIDC);// để lấy được tên loại điều trị
                ccdtDTO.TENDIEUTRI = dt.TENDIEUTRI;

                ccdtDTO.MABN = item.MABN;
                var bn = db.THONGTINBENHNHAN.FirstOrDefault(n => n.MABN == item.MABN);// để lấy được tên bệnh nhân 
                ccdtDTO.HOTEN = bn.HOTEN;

                BB.Add(ccdtDTO);
            }
            return BB;
        }
        public CHUANDOAN_DIEUTRI Add(CHUANDOAN_DIEUTRI cddt)
        {
            try
            {
                db.CHUANDOAN_DIEUTRI.Add(cddt);
                db.SaveChanges();
                return cddt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public CHUANDOAN_DIEUTRI Update(CHUANDOAN_DIEUTRI cddt)
        {
            try
            {
                var _cddt = db.CHUANDOAN_DIEUTRI.FirstOrDefault(x => x.MACDDC == cddt.MACDDC);
                _cddt.MALOAIDC = cddt.MALOAIDC;
                _cddt.DONVITINH = cddt.DONVITINH;
                _cddt.SOLUONG = cddt.SOLUONG;
                _cddt.DONGIA = cddt.DONGIA;
                _cddt.THANHTIEN = cddt.THANHTIEN;
                _cddt.MABN = cddt.MABN;
                

                db.SaveChanges();
                return cddt;
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
                var _cddt = db.CHUANDOAN_DIEUTRI.FirstOrDefault(x => x.MACDDC == id);
                db.CHUANDOAN_DIEUTRI.Remove(_cddt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
