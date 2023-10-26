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
    public partial class FormLoaiDieuTri : DevExpress.XtraEditors.XtraForm
    {
        LoaiDieuTri _loaidieutri;
        List<LOAIDIEUTRI> _lstloaidieutri;
        bool _them;
        int _id;
        public FormLoaiDieuTri()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLoaiDieuTri_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaidieutri = new LoaiDieuTri();
            _showHide(true);
            loadData();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;//// mới chạy thì lưu và hủy cho nó mờ đi
            btnHuy.Enabled = !kt;////
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;

            txtTenDieuTri.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _loaidieutri.GetAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstloaidieutri = _loaidieutri.GetAll();
        }

        void _reset()// reset lai các text khi sử dụng chức năng thêm
        {
            txtTenDieuTri.Text = string.Empty;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _reset();
            _showHide(false);
            _them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _loaidieutri.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                SaveData();
                loadData();
                _showHide(true);
                _them = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhSachLoaiDieuTri rpt = new rptDanhSachLoaiDieuTri(_lstloaidieutri);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                LOAIDIEUTRI ldt = new LOAIDIEUTRI();
                ldt.TENDIEUTRI = txtTenDieuTri.Text;
                
                _loaidieutri.Add(ldt);
            }
            else
            {
                var ldt = _loaidieutri.GetItem(_id);
                ldt.TENDIEUTRI = txtTenDieuTri.Text;
                
                _loaidieutri.Update(ldt);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MALOAIDC").ToString());
                var bn = _loaidieutri.GetItem(_id);
                txtTenDieuTri.Text = bn.TENDIEUTRI;
                
            }
        }
    }
}