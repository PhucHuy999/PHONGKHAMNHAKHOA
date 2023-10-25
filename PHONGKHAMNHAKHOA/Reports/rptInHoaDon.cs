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

            lblLOAIDIEUTRI.DataBindings.Add("Text", _lstTT, "TENDIEUTRI");
            lblDONVI.DataBindings.Add("Text", _lstTT, "DONVITINH");
            lblSOLUONG.DataBindings.Add("Text", _lstTT, "SOLUONG");
            lblDONGIA.DataBindings.Add("Text", _lstTT, "DONGIA");
            lblTHANHTIEN.DataBindings.Add("Text", _lstTT, "THANHTIEN");

            lblLOAITHUOC.DataBindings.Add("Text", _lstTT, "TENLOAITHUOC");
            lblDONVITHUOC.DataBindings.Add("Text", _lstTT, "DONVITINHTHUOC");
            lblSOLUONGTHUOC.DataBindings.Add("Text", _lstTT, "SOLUONGTHUOC");
            lblDONGIATHUOC.DataBindings.Add("Text", _lstTT, "DONGIATHUOC");
            lblTHANHTIENTHUOC.DataBindings.Add("Text", _lstTT, "THANHTIENTHUOC");

            lblTONGPHAITHANHTOAN.DataBindings.Add("Text", _lstTT, "TONGPHAITHANHTOAN");
            lblSOTIENDATHANHTOAN.DataBindings.Add("Text", _lstTT, "SOTIENDATHANHTOAN");
            lblSOTIENCONLAI.DataBindings.Add("Text", _lstTT, "SOTIENCONLAI");


        }
    }
}
