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
                dtDTO.DONVITINHTHUOC = item.DONVITINHTHUOC;
                dtDTO.SOLUONGTHUOC = item.SOLUONGTHUOC;
                dtDTO.DONGIATHUOC = item.DONGIATHUOC;
                dtDTO.THANHTIENTHUOC = item.THANHTIENTHUOC;
                dtDTO.CACHDUNG = item.CACHDUNG;
                dtDTO.NGAY = item.NGAY.Value.ToString("dd/MM/yyyy");

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
        public List<DONTHUOC_FULL> getItemFull(int id) // đưa về list 1 phần tử mới rpt mới nhận đậu xanh :v
        {
            List<DONTHUOC> lstDT = db.DONTHUOC.Where(x => x.MABN == id).ToList();
            List<DONTHUOC_FULL> lstDTO = new List<DONTHUOC_FULL>();
            DONTHUOC_FULL dt;
            foreach (var item in lstDT)
            {
                dt = new DONTHUOC_FULL();
                dt.MADT = item.MADT;
                dt.NGAY = item.NGAY.Value.ToString("dd/MM/yyyy");
                dt.MALOAITHUOC = item.MALOAITHUOC;
                dt.DONVITINHTHUOC = item.DONVITINHTHUOC;
                dt.SOLUONGTHUOC = item.SOLUONGTHUOC;
                dt.DONGIATHUOC = item.DONGIATHUOC;
                dt.THANHTIENTHUOC = item.THANHTIENTHUOC;
                dt.CACHDUNG = item.CACHDUNG;
                dt.TENLOAITHUOC = item.LOAITHUOC.TENLOAITHUOC;
                dt.MABN = item.MABN;

                //var nv = db.THONGTINBENHNHAN.FirstOrDefault(bn => bn.MABN == item.MABN);
                dt.HOTEN = item.THONGTINBENHNHAN.HOTEN;
                dt.GIOITINH = item.THONGTINBENHNHAN.GIOITINH;
                dt.NGAYSINH = item.THONGTINBENHNHAN.NGAYSINH.Value.ToString("dd/MM/yyyy");
                dt.NGAYKHAMDAUTIEN = item.THONGTINBENHNHAN.NGAYKHAMDAUTIEN.Value.ToString("dd/MM/yyyy");
                dt.DIENTHOAI = item.THONGTINBENHNHAN.DIENTHOAI;
                dt.DIACHI = item.THONGTINBENHNHAN.DIACHI;

                

                lstDTO.Add(dt);

            }
            return lstDTO;
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
                _dt.DONVITINHTHUOC = dt.DONVITINHTHUOC;
                _dt.SOLUONGTHUOC = dt.SOLUONGTHUOC;
                _dt.DONGIATHUOC = dt.DONGIATHUOC;
                _dt.THANHTIENTHUOC = dt.THANHTIENTHUOC;
                _dt.NGAY = dt.NGAY;
                _dt.CACHDUNG = dt.CACHDUNG;

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
