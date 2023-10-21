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
    public partial class FormThongTinCanLamSang : DevExpress.XtraEditors.XtraForm
    {
        ThongTinCanLamSang _ttcls;
        BenhNhan _benhnhan;
        List<THONGTINCANLAMSANG_FULL> _lstttcls;
        bool _them;
        int _id;
        public FormThongTinCanLamSang()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThongTinCanLamSang_Load(object sender, EventArgs e)
        {
            _ttcls = new ThongTinCanLamSang();
            _benhnhan = new BenhNhan();
            loadBenhNhan();

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
        private void _reset()// reset lai trang text khi sử dụng chức năng thêm
        {
            txtHuyetAp.Text = string.Empty;
            txtDuongHuyet.Text = string.Empty;
            txtMauKhoDong.Text = string.Empty;
            txtBenhTimBamSinh.Text = string.Empty;
            txtThieuNangTriTue.Text = string.Empty;
            txtXQuang.Text = string.Empty;
            txtThongTinBaoHanh.Text = string.Empty;
            txtKhac.Text = string.Empty;

            slkBenhNhan.Text = string.Empty;
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _ttcls.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstttcls = _ttcls.GetListFull();
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
            txtHuyetAp.Enabled = !kt;
            txtDuongHuyet.Enabled = !kt;
            txtMauKhoDong.Enabled = !kt;
            txtBenhTimBamSinh.Enabled = !kt;
            txtThieuNangTriTue.Enabled = !kt;
            txtXQuang.Enabled = !kt;
            txtThongTinBaoHanh.Enabled = !kt;
            txtKhac.Enabled = !kt;

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
                _ttcls.Delete(_id);
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
        private void SaveData()
        {
            if (_them)
            {
                THONGTINCANLAMSANG cls = new THONGTINCANLAMSANG();
                cls.HUYETAPMACH = txtHuyetAp.Text;
                cls.DUONGHUYET = txtDuongHuyet.Text;
                cls.MAUKHODONG = txtMauKhoDong.Text;
                cls.BENHTIMBAMSINH = txtBenhTimBamSinh.Text;
                cls.THIEUNANGTRITUE = txtThieuNangTriTue.Text;
                cls.PHIMXQUANG = txtXQuang.Text;
                cls.THONGTINBAOHANH = txtThongTinBaoHanh.Text;
                cls.KHAC = txtKhac.Text;

                cls.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _ttcls.Add(cls);
            }
            else
            {
                var cls = _ttcls.GetItem(_id);
                cls.HUYETAPMACH = txtHuyetAp.Text;
                cls.DUONGHUYET = txtDuongHuyet.Text;
                cls.MAUKHODONG = txtMauKhoDong.Text;
                cls.BENHTIMBAMSINH = txtBenhTimBamSinh.Text;
                cls.THIEUNANGTRITUE = txtThieuNangTriTue.Text;
                cls.PHIMXQUANG = txtXQuang.Text;
                cls.THONGTINBAOHANH = txtThongTinBaoHanh.Text;
                cls.KHAC = txtKhac.Text;

                cls.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _ttcls.Update(cls);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MATTCLS").ToString());
                var cls = _ttcls.GetItem(_id);
                txtHuyetAp.Text = cls.HUYETAPMACH;
                txtDuongHuyet.Text = cls.DUONGHUYET;
                txtMauKhoDong.Text = cls.MAUKHODONG;
                txtBenhTimBamSinh.Text = cls.BENHTIMBAMSINH;
                txtThieuNangTriTue.Text = cls.THIEUNANGTRITUE;
                txtXQuang.Text = cls.PHIMXQUANG;
                txtThongTinBaoHanh.Text = cls.THONGTINBAOHANH;
                txtKhac.Text = cls.KHAC;

                slkBenhNhan.EditValue = cls.MABN;
            }
        }

        
    }
}