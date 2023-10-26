using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace PHONGKHAMNHAKHOA.GUI.Reports
{
    public partial class rptThongKeNhapXuatDCVL : DevExpress.XtraReports.UI.XtraReport
    {
        public rptThongKeNhapXuatDCVL()
        {
            InitializeComponent();
        }
        List<NHAPXUAT_DCVLNK> _lst;
        int _namky;
        public rptThongKeNhapXuatDCVL(List<NHAPXUAT_DCVLNK> _lstnhapxuat, int namky)
        {
            InitializeComponent();
            this._lst = _lstnhapxuat;
            this._namky = namky;
            lblThangNam.Text = "Tháng " + _namky.ToString().Substring(4) + " Năm " + _namky.ToString().Substring(0, 4);// cắt chuỗi lấy tháng năm ra
            this.DataSource = _lst;
            loadData();
        }
        void loadData()
        {
            lblID.DataBindings.Add("Text", DataSource, "ID");
            lblTENDCVL.DataBindings.Add("Text", DataSource, "TENDCVL");
            lblDONVI.DataBindings.Add("Text", DataSource, "DONVITINH");
            lblSOLUONG.DataBindings.Add("Text", DataSource, "SOLUONG");
            lblDONGIA.DataBindings.Add("Text", DataSource, "DONGIA");
            lblTHANHTIEN.DataBindings.Add("Text", DataSource, "THANHTIEN");
            lblLOAI.DataBindings.Add("Text", DataSource, "LOAI");
            lblNGAY.DataBindings.Add("Text", DataSource, "NGAY");
            lblNOIDUNG.DataBindings.Add("Text", DataSource, "NOIDUNG");

        }
    }
}
