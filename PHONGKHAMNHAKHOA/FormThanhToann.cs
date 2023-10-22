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
    public partial class FormThanhToann : DevExpress.XtraEditors.XtraForm
    {
        BenhNhan _benhnhan;
        public FormThanhToann()
        {
            InitializeComponent();
        }

        private void FormThanhToann_Load(object sender, EventArgs e)
        {
            loadComBoBenhNhan();
        }
        void loadComBoBenhNhan()
        {
            slkBenhNhan.Properties.DataSource = _benhnhan.GetAll();
            slkBenhNhan.Properties.ValueMember = "MABN";
            slkBenhNhan.Properties.DisplayMember = "HOTEN";
        }
    }
}