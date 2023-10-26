using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace PHONGKHAMNHAKHOA.GUI.Reports
{
    public partial class rptDanhSachLoaiDieuTri : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhSachLoaiDieuTri()
        {
            InitializeComponent();
        }
        List<LOAIDIEUTRI> _lstBN;
        public rptDanhSachLoaiDieuTri(List<LOAIDIEUTRI> _lstbenhnhan)
        {
            InitializeComponent();
            this._lstBN = _lstbenhnhan;
            this.DataSource = _lstBN;
            loadData();
        }
        void loadData()
        {
            lblMALOAIDC.DataBindings.Add("Text", DataSource, "MALOAIDC");
            lblTENDIEUTRI.DataBindings.Add("Text", DataSource, "TENDIEUTRI");

        }
    }
}
