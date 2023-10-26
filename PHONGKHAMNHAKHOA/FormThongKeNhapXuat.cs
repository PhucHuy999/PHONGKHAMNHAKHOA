using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.BLL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using PHONGKHAMNHAKHOA.GUI.Reports;
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
    public partial class FormThongKeNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        NhapXuatDungCuVatLieu _nhapxuat;
        List<NHAPXUAT_DCVLNK> _lstnhapxuat;
        int _namky;
        public FormThongKeNhapXuat()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThongKeNhapXuat_Load(object sender, EventArgs e)
        {
            _nhapxuat = new NhapXuatDungCuVatLieu();
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
            loadData();
            _namky = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
        }
        
        void loadData()
        {
            gcDanhSach.DataSource = _nhapxuat.GetAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstnhapxuat = _nhapxuat.GetAll();
        }
        
        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptThongKeNhapXuatDCVL rpt = new rptThongKeNhapXuatDCVL(_lstnhapxuat, _namky);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "LOAI") 
            {
                if (e.Value != null)
                {
                    int value = Convert.ToInt32(e.Value);
                    if (value == 1)
                    {
                        e.DisplayText = "Nhập";
                    }
                    else if (value == 2)
                    {
                        e.DisplayText = "Xuất";
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị năm và tháng từ các ComboBox
            int year = int.Parse(cboNam.Text);
            int month = int.Parse(cboThang.Text);

            // Lọc dữ liệu theo năm và tháng
            _lstnhapxuat = _nhapxuat.GetAll(year, month);

            // Cập nhật dữ liệu trên GridControl
            gcDanhSach.DataSource = _lstnhapxuat;
        }
    }
}