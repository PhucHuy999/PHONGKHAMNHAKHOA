﻿using DevExpress.XtraEditors;
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
using PHONGKHAMNHAKHOA.GUI.Reports;
using DevExpress.XtraReports.UI;

namespace PHONGKHAMNHAKHOA.GUI
{
    public partial class FormDonThuoc : DevExpress.XtraEditors.XtraForm
    {
        DonThuoc _dt;
        BenhNhan _benhnhan;
        LoaiThuoc _loaithuoc;
        List<DONTHUOC_FULL> _lstdt;
        bool _them;
        int _id;
        int _idbn;
        public FormDonThuoc()
        {
            InitializeComponent();
        }

        private void FormDonThuoc_Load(object sender, EventArgs e)
        {
            _dt = new DonThuoc();
            _benhnhan = new BenhNhan();
            _loaithuoc = new LoaiThuoc();
            loadComBo();
            _them = false;
            _showHide(true);
            loadData();
        }
        void loadComBo()
        {
            slkBenhNhan.Properties.DataSource = _benhnhan.GetAll();
            slkBenhNhan.Properties.ValueMember = "MABN";
            slkBenhNhan.Properties.DisplayMember = "HOTEN";

            slkLoaiThuoc.Properties.DataSource = _loaithuoc.GetAll();
            slkLoaiThuoc.Properties.ValueMember = "MALOAITHUOC";
            slkLoaiThuoc.Properties.DisplayMember = "TENLOAITHUOC";
        }

        private void _reset()// reset lai trang text khi sử dụng chức năng thêm
        {
            txtDonViTinh.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            dtNgay.Text = string.Empty;
            txtCachDung.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            slkLoaiThuoc.Text = string.Empty;
            slkBenhNhan.Text = string.Empty;
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _dt.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstdt = _dt.GetListFull();
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
            slkLoaiThuoc.Enabled = !kt;
            txtDonViTinh.Enabled = !kt;
            txtSoLuong.Enabled = !kt;
            txtDonGia.Enabled = !kt;
            txtThanhTien.Enabled = !kt;
            dtNgay.Enabled = !kt;
            txtCachDung.Enabled = !kt;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            txtCachDung.Text = "Một ngày uống 2 lần, mỗi lần 1 viên.Sau khi ăn";
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
                _dt.Delete(_id);
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
            _lstdt = _dt.getItemFull(_idbn);
            rptInDonThuoc rpt = new rptInDonThuoc(_lstdt);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MADT").ToString());
                _idbn = int.Parse(gvDanhSach.GetFocusedRowCellValue("MABN").ToString());
                _lstdt = _dt.getItemFull(_idbn);
                
                var cddt = _dt.GetItem(_id);
                txtDonViTinh.Text = cddt.DONVITINHTHUOC;
                txtSoLuong.Text = cddt.SOLUONGTHUOC;
                txtDonGia.Text = cddt.DONGIATHUOC.ToString();
                txtThanhTien.Text = cddt.THANHTIENTHUOC.ToString();
                txtCachDung.Text = cddt.CACHDUNG;
                dtNgay.Value = cddt.NGAY.Value;

                slkLoaiThuoc.EditValue = cddt.MALOAITHUOC;
                slkBenhNhan.EditValue = cddt.MABN;

               

            }
        }
        private void SaveData()
        {
            if (_them)
            {
                DONTHUOC dt = new DONTHUOC();
                dt.DONVITINHTHUOC = txtDonViTinh.Text;
                dt.SOLUONGTHUOC = txtSoLuong.Text;
                dt.DONGIATHUOC = double.Parse(txtDonGia.EditValue.ToString());
                dt.THANHTIENTHUOC = double.Parse(txtThanhTien.EditValue.ToString());
                dt.NGAY = dtNgay.Value;
                dt.CACHDUNG = txtCachDung.Text;

                dt.MALOAITHUOC = int.Parse(slkLoaiThuoc.EditValue.ToString());
                dt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _dt.Add(dt);
            }
            else
            {
                var dt = _dt.GetItem(_id);
                dt.DONVITINHTHUOC = txtDonViTinh.Text;
                dt.SOLUONGTHUOC = txtSoLuong.Text;
                dt.DONGIATHUOC = double.Parse(txtDonGia.EditValue.ToString());
                dt.THANHTIENTHUOC = double.Parse(txtThanhTien.EditValue.ToString());
                dt.NGAY = dtNgay.Value;
                dt.CACHDUNG = txtCachDung.Text;

                dt.MALOAITHUOC = int.Parse(slkLoaiThuoc.EditValue.ToString());
                dt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _dt.Update(dt);
            }
        }
    }
}