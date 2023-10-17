using PHONGKHAMNHAKHOA.BLL.DTO;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class ThongTinCanLamSang
    {
        Model1 db = new Model1();
        public THONGTINCANLAMSANG GetItem(int id)
        {
            return db.THONGTINCANLAMSANG.FirstOrDefault(x => x.MATTCLS == id);
        }
        public List<THONGTINCANLAMSANG> GetAll()
        {
            return db.THONGTINCANLAMSANG.ToList();
        }
        //public List<THONGTINLAMSANG_FULL> GetListFull()
        //{
        //    var AA = db.THONGTINLAMSANG.ToList();
        //    List<THONGTINLAMSANG_FULL> BB = new List<THONGTINLAMSANG_FULL>();
        //    THONGTINLAMSANG_FULL bnDTO;
        //    foreach (var item in AA)
        //    {
        //        bnDTO = new THONGTINLAMSANG_FULL();
        //        bnDTO.MALS = item.MALS;
        //        bnDTO.CHUANDOAN = item.CHUANDOAN;
        //        bnDTO.NOIDUNGDIEUTRI = item.NOIDUNGDIEUTRI;
        //        bnDTO.MABN = item.MABN;
        //        var bn = db.THONGTINBENHNHAN.FirstOrDefault(n => n.MABN == item.MABN);// để lấy được tên bệnh nhân 
        //        bnDTO.HOTEN = bn.HOTEN;

        //        BB.Add(bnDTO);
        //    }
        //    return BB;
        //}
        public THONGTINCANLAMSANG Add(THONGTINCANLAMSANG cls)
        {
            try
            {
                db.THONGTINCANLAMSANG.Add(cls);
                db.SaveChanges();
                return cls;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public THONGTINCANLAMSANG Update(THONGTINCANLAMSANG cls)
        {
            try
            {
                var _cls = db.THONGTINCANLAMSANG.FirstOrDefault(x => x.MATTCLS == cls.MATTCLS);
                _cls.HUYETAPMACH = cls.HUYETAPMACH;
                _cls.DUONGHUYET = cls.DUONGHUYET;
                _cls.MAUKHODONG = cls.MAUKHODONG;
                _cls.BENHTIMBAMSINH = cls.BENHTIMBAMSINH;
                _cls.THIEUNANGTRITUE = cls.THIEUNANGTRITUE;
                _cls.PHIMXQUANG = cls.PHIMXQUANG;
                _cls.THONGTINBAOHANH = cls.THONGTINBAOHANH;
                _cls.KHAC = cls.KHAC;
                _cls.MABN = cls.MABN;

                db.SaveChanges();
                return cls;
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
                var _cls = db.THONGTINCANLAMSANG.FirstOrDefault(x => x.MATTCLS == id);
                db.THONGTINCANLAMSANG.Remove(_cls);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }

    }
}
