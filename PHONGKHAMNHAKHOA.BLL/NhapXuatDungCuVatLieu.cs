using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONGKHAMNHAKHOA.BLL
{
    public class NhapXuatDungCuVatLieu
    {
        Model1 db = new Model1();


        public NHAPXUAT_DCVLNK getItem(string id)
        {
            return db.NHAPXUAT_DCVLNK.FirstOrDefault(x => x.ID == id);
        }
        public List<NHAPXUAT_DCVLNK> getList(int loai)
        {
            return db.NHAPXUAT_DCVLNK.Where(x => x.LOAI == loai).ToList();
        }
        public List<NHAPXUAT_DCVLNK> GetAll()
        {
            return db.NHAPXUAT_DCVLNK.ToList();
        }
        public List<NHAPXUAT_DCVLNK> GetAll(int year, int month)
        {
            return db.NHAPXUAT_DCVLNK
                .Where(x => x.NGAY.HasValue && x.NGAY.Value.Year == year && x.NGAY.Value.Month == month)
                .ToList();
        }

        public NHAPXUAT_DCVLNK Add(NHAPXUAT_DCVLNK nx)
        {
            try
            {
                db.NHAPXUAT_DCVLNK.Add(nx);
                db.SaveChanges();
                return nx;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }
        }

        public NHAPXUAT_DCVLNK Update(NHAPXUAT_DCVLNK nx)
        {
            try
            {
                NHAPXUAT_DCVLNK _nx = db.NHAPXUAT_DCVLNK.FirstOrDefault(x => x.ID == nx.ID);
                _nx.TENDCVL = nx.TENDCVL;
                _nx.DONVITINH = nx.DONVITINH;
                _nx.SOLUONG = nx.SOLUONG;
                _nx.DONGIA = nx.DONGIA;
                //_nx.LOAI = nx.LOAI;
                _nx.THANHTIEN = nx.THANHTIEN;
                _nx.NGAY = nx.NGAY;
                _nx.NOIDUNG = nx.NOIDUNG;

                db.SaveChanges();
                return nx;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);

            }
        }


        public void Delete(string id)
        {
            try
            {
                var _nx = db.NHAPXUAT_DCVLNK.FirstOrDefault(x => x.ID == id);
                db.NHAPXUAT_DCVLNK.Remove(_nx);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _nx = db.NHAPXUAT_DCVLNK.Where(x => x.LOAI == loai).OrderByDescending(x => x.NGAY).FirstOrDefault();
            if (_nx != null)
            {
                return _nx.ID;
            }
            else
                return "00000";
        }


    }
}
