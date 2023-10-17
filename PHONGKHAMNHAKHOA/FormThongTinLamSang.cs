using DevExpress.XtraEditors;
using PHONGKHAMNHAKHOA.BLL;
using PHONGKHAMNHAKHOA.BLL.DTO;
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
    public partial class FormThongTinLamSang : DevExpress.XtraEditors.XtraForm
    {
        ThongTinLamSang _ttls;
        BenhNhan _benhnhan;
        List<THONGTINLAMSANG_FULL> _lstttls;
        bool _them;
        int _id;
        public FormThongTinLamSang()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThongTinLamSang_Load(object sender, EventArgs e)
        {
            _ttls = new ThongTinLamSang();
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
            txtChuanDoan.Text = string.Empty;
            txtNoiDungDieuTri.Text = string.Empty;
            slkBenhNhan.Text = string.Empty;
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _ttls.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstttls = _ttls.GetListFull();
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
            txtChuanDoan.Enabled = !kt;
            txtNoiDungDieuTri.Enabled = !kt;


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
                _ttls.Delete(_id);// chưa xây dựng chức năng đăng nhập nên truyền thẳng manv==1 vào tạm
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
                THONGTINLAMSANG ls = new THONGTINLAMSANG();
                ls.CHUANDOAN = txtChuanDoan.Text;
                ls.NOIDUNGDIEUTRI = txtNoiDungDieuTri.Text;
                ls.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _ttls.Add(ls);
            }
            else
            {
                var ls = _ttls.GetItem(_id);
                ls.CHUANDOAN = txtChuanDoan.Text;
                ls.NOIDUNGDIEUTRI = txtNoiDungDieuTri.Text;
                ls.MABN = int.Parse(slkBenhNhan.EditValue.ToString());

                _ttls.Update(ls);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MALS").ToString());
                var ls = _ttls.GetItem(_id);
                txtChuanDoan.Text = ls.CHUANDOAN;
                txtNoiDungDieuTri.Text = ls.NOIDUNGDIEUTRI;
                slkBenhNhan.EditValue = ls.MABN;
            }
        }
    }
}