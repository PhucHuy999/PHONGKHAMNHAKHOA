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
    }
}
