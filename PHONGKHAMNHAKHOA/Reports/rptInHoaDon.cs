using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.BLL.FULL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace PHONGKHAMNHAKHOA.GUI.Reports
{
    public partial class rptInHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInHoaDon()
        {
            InitializeComponent();
        }
        List<THANHTOAN_FULL> _lstTT;

        public rptInHoaDon(List<THANHTOAN_FULL> lsttt)
        {
            InitializeComponent();
            this._lstTT = lsttt;
            this.DataSource = _lstTT;
            loadData();
        }
        void loadData()
        {

            lblLOAIDIEUTRI.DataBindings.Add("Text", DataSource, "TENDIEUTRI");
            lblDONVI.DataBindings.Add("Text", DataSource, "DONVITINH");
            lblSOLUONG.DataBindings.Add("Text", DataSource, "SOLUONG");
            lblDONGIA.DataBindings.Add("Text", DataSource, "DONGIA");
            lblTHANHTIEN.DataBindings.Add("Text", DataSource, "THANHTIEN");

            lblLOAITHUOC.DataBindings.Add("Text", DataSource, "TENLOAITHUOC");
            lblDONVITHUOC.DataBindings.Add("Text", DataSource, "DONVITINHTHUOC");
            lblSOLUONGTHUOC.DataBindings.Add("Text", DataSource, "SOLUONGTHUOC");
            lblDONGIATHUOC.DataBindings.Add("Text", DataSource, "DONGIATHUOC");
            lblTHANHTIENTHUOC.DataBindings.Add("Text", DataSource, "THANHTIENTHUOC");

            lblTONGPHAITHANHTOAN.DataBindings.Add("Text", DataSource, "TONGPHAITHANHTOAN");
            lblSOTIENDATHANHTOAN.DataBindings.Add("Text", DataSource, "SOTIENDATHANHTOAN");
            lblSOTIENCONLAI.DataBindings.Add("Text", DataSource, "SOTIENCONLAI");


        }
    }
}
