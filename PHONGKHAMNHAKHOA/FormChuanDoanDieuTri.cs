using DevExpress.XtraEditors;
using PHONGKHAMNHAKHOA.BLL.FULL;
using PHONGKHAMNHAKHOA.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHONGKHAMNHAKHOA.DAL.Entities;

namespace PHONGKHAMNHAKHOA.GUI
{
    public partial class FormChuanDoanDieuTri : DevExpress.XtraEditors.XtraForm
    {
        ChuanDoanDieuTri _cddt;
        BenhNhan _benhnhan;
        LoaiDieuTri _loaidieutri;
        List<CHUANDOANDIEUTRI_FULL> _lstcddt;
        bool _them;
        int _id;
        public FormChuanDoanDieuTri()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormChuanDoanDieuTri_Load(object sender, EventArgs e)
        {
            _cddt = new ChuanDoanDieuTri();
            _benhnhan = new BenhNhan();
            _loaidieutri = new LoaiDieuTri();
            loadBenhNhan();
            loadLoaiDieuTri();
            _them = false;
            _showHide(true);
            loadData();
        }
        void loadBenhNhan()
        {
            slkBenhNhan.Properties.DataSource = _benhnhan.GetAll();
            slkBenhNhan.Properties.ValueMember = "MABN";
            slkBenhNhan.Properties.DisplayMember = "HOTEN";
        }
        void loadLoaiDieuTri()
        {
            slkLoaiDieuTri.Properties.DataSource = _loaidieutri.GetAll();
            slkLoaiDieuTri.Properties.ValueMember = "MALOAIDC";
            slkLoaiDieuTri.Properties.DisplayMember = "TENDIEUTRI";
        }
        private void _reset()// reset lai trang text khi sử dụng chức năng thêm
        {
            txtDonViTinh.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            slkLoaiDieuTri.Text = string.Empty;
            slkBenhNhan.Text = string.Empty;
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _cddt.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstcddt = _cddt.GetListFull();
        }
        private void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;//// mới chạy thì lưu và hủy cho nó mờ đi
            btnHuy.Enabled = !kt;////
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            gcDanhSach.Enabled = kt;

            slkBenhNhan.Enabled = !kt;
            slkLoaiDieuTri.Enabled = !kt;
            txtDonViTinh.Enabled = !kt;
            txtSoLuong.Enabled = !kt;
            txtDonGia.Enabled = !kt;
            txtThanhTien.Enabled = !kt;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
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
                _cddt.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _showHide(true);
            _them = false;
            _reset();
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

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MACDDC").ToString());
                var cddt = _cddt.GetItem(_id);
                txtDonViTinh.Text = cddt.DONVITINH;
                txtSoLuong.Text = cddt.SOLUONG;
                txtDonGia.Text = cddt.DONGIA.ToString();
                txtThanhTien.Text = cddt.THANHTIEN.ToString();

                slkLoaiDieuTri.EditValue = cddt.MACDDC;
                slkBenhNhan.EditValue = cddt.MABN;
            }
        }
        private void SaveData()
        {
            if (_them)
            {
                CHUANDOAN_DIEUTRI cddt = new CHUANDOAN_DIEUTRI();
                cddt.DONVITINH = txtDonViTinh.Text;
                cddt.SOLUONG = txtSoLuong.Text;
                cddt.DONGIA = double.Parse(txtDonGia.EditValue.ToString());
                cddt.THANHTIEN = double.Parse(txtThanhTien.EditValue.ToString());

                cddt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());
                cddt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _cddt.Add(cddt);
            }
            else
            {
                var cddt = _cddt.GetItem(_id);
                cddt.DONVITINH = txtDonViTinh.Text;
                cddt.SOLUONG = txtSoLuong.Text;
                cddt.DONGIA = double.Parse(txtDonGia.EditValue.ToString());
                cddt.THANHTIEN = double.Parse(txtThanhTien.EditValue.ToString());

                cddt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());
                cddt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _cddt.Update(cddt);
            }
        }
    }
}