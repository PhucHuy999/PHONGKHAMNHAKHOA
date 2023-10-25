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
    public partial class FormNhapDungCuVatLieu : DevExpress.XtraEditors.XtraForm
    {
        NhapXuatDungCuVatLieu _nhapDCVL;
        List<NHAPXUAT_DCVLNK> _lstnhapDCVL;
        bool _them;
        string _id;
        public FormNhapDungCuVatLieu()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhapDungCuVatLieu_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhapDCVL = new NhapXuatDungCuVatLieu();
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

            txtTenDCVL.Enabled = !kt;
            dtNgay.Enabled = !kt;
            txtDonViTinh.Enabled = !kt;
            txtSoLuong.Enabled = !kt;
            txtDonGia.Enabled = !kt;
            txtThanhTien.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nhapDCVL.getList(1);//1 là nhập 2 là xuất
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstnhapDCVL = _nhapDCVL.getList(1);
        }

        void _reset()// reset lai các text khi sử dụng chức năng thêm
        {
            txtTenDCVL.Text = string.Empty;
            dtNgay.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
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
                _nhapDCVL.Delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KiemTraThongTinNhap())
            {
                SaveData();
                loadData();
                _showHide(true);
                _them = false;
            }
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
                //mã nhập có dạng: 00001/2023/Nhap
                var maxId = _nhapDCVL.MaxSoQuyetDinh(1); //loại "1" là nhập dcvl
                int iD = int.Parse(maxId.Substring(0, 5)) + 1;
                NHAPXUAT_DCVLNK nx = new NHAPXUAT_DCVLNK();
                nx.ID = iD.ToString("00000") + @"/2023/Nhap";
                nx.TENDCVL = txtTenDCVL.Text;
                nx.DONVITINH = txtDonViTinh.Text;
                nx.SOLUONG = txtSoLuong.Text;
                nx.DONGIA = double.Parse(txtDonGia.EditValue.ToString());
                nx.THANHTIEN = double.Parse(txtThanhTien.EditValue.ToString());
                nx.NGAY = dtNgay.Value;
                nx.NOIDUNG = txtNoiDung.Text;
                nx.LOAI = 1;


                _nhapDCVL.Add(nx);
            }
            else
            {
                var nx = _nhapDCVL.getItem(_id);

                nx.TENDCVL = txtTenDCVL.Text;
                nx.DONVITINH = txtDonViTinh.Text;
                nx.SOLUONG = txtSoLuong.Text;
                nx.DONGIA = int.Parse(txtDonGia.Text);
                nx.THANHTIEN = int.Parse(txtThanhTien.Text);
                nx.NGAY = dtNgay.Value;
                nx.NOIDUNG = txtNoiDung.Text;

                _nhapDCVL.Update(nx);
            }
        }
        bool KiemTraThongTinNhap()
        {
            if (txtTenDCVL.Text == "")
            {
                MessageBox.Show("Hãy nhập tên DCVL", "Thông Báo");
                txtTenDCVL.Focus();
                return false;
            }
            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Hãy nhập đơn vị tính", "Thông Báo");
                txtDonViTinh.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Hãy nhập số lượng", "Thông Báo");
                txtSoLuong.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đơn giá", "Thông Báo");
                txtDonGia.Focus();
                return false;
            }
            if (txtThanhTien.Text == "")
            {
                MessageBox.Show("Hãy nhập thành tiền", "Thông Báo");
                txtThanhTien.Focus();
                return false;
            }


            return true;

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = gvDanhSach.GetFocusedRowCellValue("ID").ToString();
                var nx = _nhapDCVL.getItem(_id);

                txtTenDCVL.Text = nx.TENDCVL;
                dtNgay.Value = nx.NGAY.Value;
                txtDonViTinh.Text = nx.DONVITINH;
                txtSoLuong.Text = nx.SOLUONG;
                txtDonGia.Text = nx.DONGIA.ToString();
                txtThanhTien.Text = nx.THANHTIEN.ToString();
                txtNoiDung.Text = nx.NOIDUNG;
            }
        }
    }
}