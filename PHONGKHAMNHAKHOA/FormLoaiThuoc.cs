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
    public partial class FormLoaiThuoc : DevExpress.XtraEditors.XtraForm
    {
        LoaiThuoc _loaithuoc;
        List<LOAITHUOC> _lstloaithuoc;
        bool _them;
        int _id;
        public FormLoaiThuoc()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLoaiThuoc_Load(object sender, EventArgs e)
        {
            _them = false;
            _loaithuoc = new LoaiThuoc();
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

            txtTenThuoc.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _loaithuoc.GetAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstloaithuoc = _loaithuoc.GetAll();
        }

        void _reset()// reset lai các text khi sử dụng chức năng thêm
        {
            txtTenThuoc.Text = string.Empty;
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
                _loaithuoc.Delete(_id);
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

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                LOAITHUOC lt = new LOAITHUOC();
                lt.TENLOAITHUOC = txtTenThuoc.Text;

                _loaithuoc.Add(lt);
            }
            else
            {
                var lt = _loaithuoc.GetItem(_id);
                lt.TENLOAITHUOC = txtTenThuoc.Text;

                _loaithuoc.Update(lt);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MALOAITHUOC").ToString());
                var lt = _loaithuoc.GetItem(_id);
                txtTenThuoc.Text = lt.TENLOAITHUOC;

            }
        }
    }
}