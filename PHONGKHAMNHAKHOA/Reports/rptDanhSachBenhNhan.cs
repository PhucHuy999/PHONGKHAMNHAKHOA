using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace PHONGKHAMNHAKHOA.GUI.Reports
{
    public partial class rptDanhSachBenhNhan : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachBenhNhan()
        {
            InitializeComponent();
        }
        List<THONGTINBENHNHAN> _lstLDT;
        public rptDanhSachBenhNhan(List<THONGTINBENHNHAN> _lstloaidieutri)
        {
            InitializeComponent();
            this._lstLDT = _lstloaidieutri;
            this.DataSource = _lstLDT;
            loadData();
        }
        void loadData()
        {
            lblMABN.DataBindings.Add("Text", DataSource, "MABN");
            lblHOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            lblGIOITINH.DataBindings.Add("Text", DataSource, "GIOITINH");
            lblNGAYSINH.DataBindings.Add("Text", DataSource, "NGAYSINH");
            lblDIENTHOAI.DataBindings.Add("Text", DataSource, "DIENTHOAI");
            lblDIACHI.DataBindings.Add("Text", DataSource, "DIACHI");
            lblNGAYKHAMDAUTIEN.DataBindings.Add("Text", DataSource, "NGAYKHAMDAUTIEN");
            lblLYDODENKHAM.DataBindings.Add("Text", DataSource, "LYDODENKHAM");

        }
    }
}
