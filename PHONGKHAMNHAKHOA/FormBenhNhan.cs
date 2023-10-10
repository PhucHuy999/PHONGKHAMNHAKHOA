using DevExpress.XtraEditors;
using PHONGKHAMNHAKHOA.DAL.Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHONGKHAMNHAKHOA.BLL;

namespace PHONGKHAMNHAKHOA.GUI
{
    public partial class FormBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        public FormBenhNhan()
        {
            InitializeComponent();
        }
        BenhNhan _benhnhan;
        List<THONGTINBENHNHAN> _lstbenhnhan;
        bool _them;
        int _id;
        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
            _them = false;
            _benhnhan = new BenhNhan();
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

            txtHoTen.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            dtNgayKhamDauTien.Enabled = !kt;
            txtLyDoDenKham.Enabled = !kt;
        }
        void loadData()
        {
            gcDanhSach.DataSource = _benhnhan.GetAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstbenhnhan = _benhnhan.GetAll();
        }

        void _reset()// reset lai các text khi sử dụng chức năng thêm
        {
            txtHoTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            chkGioiTinh.Checked = false;
            txtLyDoDenKham.Text = string.Empty;
            dtNgaySinh.Value = DateTime.Now;
            dtNgayKhamDauTien.Value = DateTime.Now;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _reset();
            _showHide(false);
            _them = true;
            //txtHoTen.Text = string.Empty;
            
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
                _benhnhan.Delete(_id);
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
                THONGTINBENHNHAN bn = new THONGTINBENHNHAN();
                bn.HOTEN = txtHoTen.Text;
                bn.NGAYSINH = dtNgaySinh.Value;
                bn.GIOITINH = chkGioiTinh.Checked;
                bn.DIENTHOAI = txtDienThoai.Text;
                bn.DIACHI = txtDiaChi.Text;
                bn.NGAYKHAMDAUTIEN = dtNgayKhamDauTien.Value;
                bn.LYDODENKHAM = txtLyDoDenKham.Text;

                _benhnhan.Add(bn);
            }
            else
            {
                var bn = _benhnhan.GetItem(_id);
                bn.HOTEN = txtHoTen.Text;
                bn.NGAYSINH = dtNgaySinh.Value;
                bn.GIOITINH = chkGioiTinh.Checked;
                bn.DIENTHOAI = txtDienThoai.Text;
                bn.DIACHI = txtDiaChi.Text;
                bn.NGAYKHAMDAUTIEN = dtNgayKhamDauTien.Value;
                bn.LYDODENKHAM = txtLyDoDenKham.Text;
                _benhnhan.Update(bn);
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MABN").ToString());
                var bn = _benhnhan.GetItem(_id);
                txtHoTen.Text = bn.HOTEN;
                chkGioiTinh.Checked = bn.GIOITINH.Value;                                 
                dtNgaySinh.Value = bn.NGAYSINH.Value;
                txtDienThoai.Text = bn.DIENTHOAI;
                txtDiaChi.Text = bn.DIACHI;
                dtNgayKhamDauTien.Value = bn.NGAYKHAMDAUTIEN.Value;
                txtLyDoDenKham.Text = bn.LYDODENKHAM;
            }
        }
    }
}