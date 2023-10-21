using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class LoaiThuoc
    {
        Model1 db = new Model1();

        public List<LOAITHUOC> GetAll()
        {
            return db.LOAITHUOC.ToList();
        }
        public LOAITHUOC GetItem(int id)
        {
            return db.LOAITHUOC.FirstOrDefault(x => x.MALOAITHUOC == id);
        }
        public LOAITHUOC Add(LOAITHUOC lt)
        {
            try
            {
                db.LOAITHUOC.Add(lt);
                db.SaveChanges();
                return lt;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public LOAITHUOC Update(LOAITHUOC lt)
        {
            try
            {
                var _lt = db.LOAITHUOC.FirstOrDefault(x => x.MALOAITHUOC == lt.MALOAITHUOC);
                _lt.TENLOAITHUOC = lt.TENLOAITHUOC;

                db.SaveChanges();
                return lt;
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
                var _lt = db.LOAITHUOC.FirstOrDefault(x => x.MALOAITHUOC == id);
                db.LOAITHUOC.Remove(_lt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
