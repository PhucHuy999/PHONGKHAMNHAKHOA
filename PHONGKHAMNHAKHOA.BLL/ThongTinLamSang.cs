using PHONGKHAMNHAKHOA.BLL.FULL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class ThongTinLamSang
    {
        Model1 db = new Model1();
        public THONGTINLAMSANG GetItem(int id)
        {
            return db.THONGTINLAMSANG.FirstOrDefault(x => x.MALS == id);
        }
        public List<THONGTINLAMSANG> GetAll()
        {
            return db.THONGTINLAMSANG.ToList();
        }
        public List<THONGTINLAMSANG_FULL> GetListFull()
        {
            var AA = db.THONGTINLAMSANG.ToList();
            List<THONGTINLAMSANG_FULL> BB = new List<THONGTINLAMSANG_FULL>();
            THONGTINLAMSANG_FULL bnDTO;
            foreach (var item in AA)
            {
                bnDTO = new THONGTINLAMSANG_FULL();
                bnDTO.MALS = item.MALS;
                bnDTO.CHUANDOAN = item.CHUANDOAN;
                bnDTO.NOIDUNGDIEUTRI = item.NOIDUNGDIEUTRI;
                bnDTO.MABN = item.MABN;
                var bn = db.THONGTINBENHNHAN.FirstOrDefault(n => n.MABN == item.MABN);// để lấy được tên bệnh nhân 
                bnDTO.HOTEN = bn.HOTEN;

                BB.Add(bnDTO);
            }
            return BB;
        }
        public THONGTINLAMSANG Add(THONGTINLAMSANG ls)
        {
            try
            {
                db.THONGTINLAMSANG.Add(ls);
                db.SaveChanges();
                return ls;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public THONGTINLAMSANG Update(THONGTINLAMSANG ls)
        {
            try
            {
                var _ls = db.THONGTINLAMSANG.FirstOrDefault(x => x.MALS == ls.MALS);
                _ls.CHUANDOAN = ls.CHUANDOAN;
                _ls.NOIDUNGDIEUTRI = ls.NOIDUNGDIEUTRI;
                _ls.MABN = ls.MABN;
                
                db.SaveChanges();
                return ls;
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
                var _ls = db.THONGTINLAMSANG.FirstOrDefault(x => x.MALS == id);
                db.THONGTINLAMSANG.Remove(_ls);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }

    }
}
