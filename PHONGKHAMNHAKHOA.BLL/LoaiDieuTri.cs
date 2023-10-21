using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class LoaiDieuTri
    {
        Model1 db = new Model1();

        public List<LOAIDIEUTRI> GetAll()
        {
            return db.LOAIDIEUTRI.ToList();
        }
        public LOAIDIEUTRI GetItem(int id)
        {
            return db.LOAIDIEUTRI.FirstOrDefault(x => x.MALOAIDC == id);
        }
        public LOAIDIEUTRI Add(LOAIDIEUTRI ldt)
        {
            try
            {
                db.LOAIDIEUTRI.Add(ldt);
                db.SaveChanges();
                return ldt;
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public LOAIDIEUTRI Update(LOAIDIEUTRI ldt)
        {
            try
            {
                var _ldt = db.LOAIDIEUTRI.FirstOrDefault(x => x.MALOAIDC == ldt.MALOAIDC);
                _ldt.TENDIEUTRI = ldt.TENDIEUTRI;
                
                db.SaveChanges();
                return ldt;
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
                var _ldt = db.LOAIDIEUTRI.FirstOrDefault(x => x.MALOAIDC == id);
                db.LOAIDIEUTRI.Remove(_ldt);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
    }
}
