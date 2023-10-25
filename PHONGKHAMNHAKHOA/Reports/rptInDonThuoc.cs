using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.BLL.FULL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace PHONGKHAMNHAKHOA.GUI.Reports
{
    public partial class rptInDonThuoc : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInDonThuoc()
        {
            InitializeComponent();
            
        }
        List<DONTHUOC_FULL> _lstdt;
        public rptInDonThuoc(List<DONTHUOC_FULL> lstDT)
        {
            InitializeComponent();
            this._lstdt = lstDT;
            this.DataSource = _lstdt;
            loadData();
        }
        void loadData()
        {
            lblTENLOAITHUOC.DataBindings.Add("Text", _lstdt, "TENLOAITHUOC");
            lblDONVITHUOC.DataBindings.Add("Text", _lstdt, "DONVITINHTHUOC");
            lblSOLUONGTHUOC.DataBindings.Add("Text", _lstdt, "SOLUONGTHUOC");
            lblCACHDUNG.DataBindings.Add("Text", _lstdt, "CACHDUNG");

        }
    }
}
