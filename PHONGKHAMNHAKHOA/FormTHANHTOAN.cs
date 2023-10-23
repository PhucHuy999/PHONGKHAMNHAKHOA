using DevExpress.XtraEditors;
using PHONGKHAMNHAKHOA.BLL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONGKHAMNHAKHOA.GUI
{
    public partial class FormTHANHTOAN : DevExpress.XtraEditors.XtraForm
    {
        BenhNhan _benhnhan;

        public FormTHANHTOAN()
        {
            InitializeComponent();
        }

        private void FormTHANHTOAN_Load(object sender, EventArgs e)
        {
            _benhnhan = new BenhNhan();
            loadComBo();
        }
        void loadComBo()
        {
            slkBenhNhan.Properties.DataSource = _benhnhan.GetAll();
            slkBenhNhan.Properties.ValueMember = "MABN";
            slkBenhNhan.Properties.DisplayMember = "HOTEN";
        }
    }
}