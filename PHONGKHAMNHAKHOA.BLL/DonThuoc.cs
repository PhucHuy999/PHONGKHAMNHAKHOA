using PHONGKHAMNHAKHOA.BLL.FULL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class DonThuoc
    {
        Model1 db = new Model1();

        public List<DONTHUOC> GetAll()
        {
            return db.DONTHUOC.ToList();
        }
        public DONTHUOC GetItem(int id)
        {
            return db.DONTHUOC.FirstOrDefault(x => x.MADT == id);
        }
        public List<DONTHUOC_FULL> GetListFull()
        {
            var AA = db.DONTHUOC.ToList();
            List<DONTHUOC_FULL> BB = new List<DONTHUOC_FULL>();
            DONTHUOC_FULL dtDTO;
            foreach (var item in AA)
            {
                dtDTO = new DONTHUOC_FULL();
                dtDTO.MADT = item.MADT;
                dtDTO.DONVITINH = item.DONVITINH;
                dtDTO.SOLUONG = item.SOLUONG;
                dtDTO.DONGIA = item.DONGIA;
                dtDTO.THANHTIEN = item.THANHTIEN;

                dtDTO.MALOAITHUOC = item.MALOAITHUOC;
                var dt = db.LOAITHUOC.FirstOrDefault(c => c.MALOAITHUOC == item.MALOAITHUOC);// để lấy được tên loại điều trị
                dtDTO.TENLOAITHUOC = dt.TENLOAITHUOC;

                dtDTO.MABN = item.MABN;
                var bn = db.THONGTINBENHNHAN.FirstOrDefault(n => n.MABN == item.MABN);// để lấy được tên bệnh nhân 
                dtDTO.HOTEN = bn.HOTEN;

                BB.Add(dtDTO);
            }
            return BB;
        }
        public DONTHUOC Add(DONTHUOC dt)
        {
            try
            {
                db.DONTHUOC.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public DONTHUOC Update(DONTHUOC dt)
        {
            try
            {
                var _dt = db.DONTHUOC.FirstOrDefault(x => x.MADT == dt.MADT);
                _dt.MALOAITHUOC = dt.MALOAITHUOC;
                _dt.DONVITINH = dt.DONVITINH;
                _dt.SOLUONG = dt.SOLUONG;
                _dt.DONGIA = dt.DONGIA;
                _dt.THANHTIEN = dt.THANHTIEN;
                _dt.MABN = dt.MABN;

                db.SaveChanges();
                return dt;
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
                var _dt = db.DONTHUOC.FirstOrDefault(x => x.MADT == id);
                db.DONTHUOC.Remove(_dt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
