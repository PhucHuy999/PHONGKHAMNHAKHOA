using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using PHONGKHAMNHAKHOA.BLL;
using PHONGKHAMNHAKHOA.BLL.FULL;
using PHONGKHAMNHAKHOA.DAL.Entities;
using PHONGKHAMNHAKHOA.GUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONGKHAMNHAKHOA.GUI
{
    public partial class FormTHANHTOAN : DevExpress.XtraEditors.XtraForm
    {
        BenhNhan _benhnhan;
        ChuanDoanDieuTri _cddt;
        DonThuoc _dt;

        ThanhToan _thanhtoan;
        List<THANHTOAN_FULL> _lstTT;
        bool _them;
        int _id;
        int _idbn;

        public FormTHANHTOAN()
        {
            InitializeComponent();
        }

        private void FormTHANHTOAN_Load(object sender, EventArgs e)
        {
            _benhnhan = new BenhNhan();
            _cddt = new ChuanDoanDieuTri();
            _dt = new DonThuoc();
            _thanhtoan = new ThanhToan();
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
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void _reset()// reset lai trang text khi sử dụng chức năng thêm
        {
            txtTongPhaiThanhToan.Text = string.Empty;
            txtSoTienDaThanhToan.Text = string.Empty;
            txtSoTienConLai.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            slkBenhNhan.Text = string.Empty;
            dtNgayThanhToan.Text = string.Empty;

            // Làm sạch dgvLoaiDieuTri,dgvDonThuoc bằng cách gán DataSource thành một danh sách rỗng
            dgvLoaiDieuTri.DataSource = new List<object>(); 
            dgvDonThuoc.DataSource = new List<object>();
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _thanhtoan.GetListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstTT = _thanhtoan.GetListFull();
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
            dtNgayThanhToan.Enabled = !kt;
            txtTongPhaiThanhToan.Enabled = !kt;
            txtSoTienDaThanhToan.Enabled = !kt;
            txtSoTienConLai.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            txtMaCDDT.Enabled = !kt;
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
                _thanhtoan.Delete(_id);
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
                _reset();
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            _reset();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lstTT = _thanhtoan.getItemFull(_idbn);
            rptInHoaDon rpt = new rptInHoaDon(_lstTT);
            rpt.ShowPreviewDialog();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void slkBenhNhan_EditValueChanged(object sender, EventArgs e)
        {
            if (slkBenhNhan.EditValue != null)
            {

                if (int.TryParse(slkBenhNhan.EditValue.ToString(), out int idBenhNhanDaChon))
                {
                     idBenhNhanDaChon = Convert.ToInt32(slkBenhNhan.EditValue); // Lấy ID của bệnh nhân đã chọn

                    //CHUANDOAN_DIEUTRI
                    var duLieuDaLocCDDT = _cddt.GetListFull()
                        .Where(item => item.MABN == idBenhNhanDaChon)
                        .Select(item => new { TÊN_ĐIỀU_TRỊ = item.TENDIEUTRI, THÀNH_TIỀN = Convert.ToDouble(item.THANHTIEN).ToString("N0"), MÃCDDT = item.MACDDC })
                        .ToList();

                    // DONTHUOC
                    var duLieuDaLocDonThuoc = _dt.GetListFull()
                        .Where(item => item.MABN == idBenhNhanDaChon)
                        .Select(item => new { TÊN_LOẠI_THUỐC = item.TENLOAITHUOC, THÀNH_TIỀN = Convert.ToDouble(item.THANHTIENTHUOC).ToString("N0") })
                        .ToList();

                    // Kiểm tra nếu danh sách rỗng, thêm giá trị 0
                    if (duLieuDaLocCDDT.Count == 0)
                    {
                        duLieuDaLocCDDT.Add(new { TÊN_ĐIỀU_TRỊ = "Không dùng", THÀNH_TIỀN = "0", MÃCDDT = 0 });
                    }

                    if (duLieuDaLocDonThuoc.Count == 0)
                    {
                        duLieuDaLocDonThuoc.Add(new { TÊN_LOẠI_THUỐC = "Không dùng", THÀNH_TIỀN = "0" });
                    }

                    // Gắn dữ liệu đã lọc vào dgvDichVuThanhToan
                    dgvLoaiDieuTri.DataSource = duLieuDaLocCDDT;
                    dgvDonThuoc.DataSource = duLieuDaLocDonThuoc;

                    // Điều chỉnh độ rộng của cột 
                    dgvLoaiDieuTri.Columns["TÊN_ĐIỀU_TRỊ"].Width = 300;
                    dgvDonThuoc.Columns["TÊN_LOẠI_THUỐC"].Width = 300;

                    // Tính tổng và hiển thị tổng
                    double tongPhaiThanhToanLoaiDieuTri = duLieuDaLocCDDT.Sum(item => Convert.ToDouble(item.THÀNH_TIỀN.Replace(",", "")));
                    double tongPhaiThanhToanThuoc = duLieuDaLocDonThuoc.Sum(item => Convert.ToDouble(item.THÀNH_TIỀN.Replace(",", "")));

                    double soTienDaThanhToan = (double) _thanhtoan.TinhSoTienDaThanhToan(idBenhNhanDaChon) ;
                    double tongPhaiThanhToan = ((tongPhaiThanhToanLoaiDieuTri) + (tongPhaiThanhToanThuoc)) - (soTienDaThanhToan);
                    txtTongPhaiThanhToan.Text = tongPhaiThanhToan.ToString("N0");

                   


                    //// Tính số tiền còn lại khi mới load số tiền phải thanhh tóan
                    //double soTienDaThanhToan = 0; // Thay bằng giá trị thực tế của số tiền đã thanh toán
                    //double soTienConLai = tongPhaiThanhToan - soTienDaThanhToan;
                    //txtSoTienConLai.Text = soTienConLai.ToString("N0");

                    // Lấy giá trị MACDDT từ danh sách đã lọc và đặt giá trị này vào txtMaCDDT
                    if (duLieuDaLocCDDT.Count > 0)
                    {
                        int maCDDT = duLieuDaLocCDDT[0].MÃCDDT;
                        txtMaCDDT.Text = maCDDT.ToString();
                    }
                    else
                    {
                        txtMaCDDT.Text = "0";
                    }
                }
            }

        }

        //private void txtSoTienDaThanhToan_TextChanged(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtTongPhaiThanhToan.Text))
        //    {
        //        // Kiểm tra nếu người dùng đã nhập số tiền hợp lệ
        //        if (double.TryParse(txtSoTienDaThanhToan.Text, out double soTienDaThanhToan))
        //        {
        //            double tongPhaiThanhToan = double.Parse(txtTongPhaiThanhToan.Text.Replace(",", ""));

        //            // Kiểm tra nếu số tiền đã thanh toán nhỏ hơn hoặc bằng số tiền phải thanh toán
        //            if (soTienDaThanhToan <= tongPhaiThanhToan)
        //            {
        //                double soTienConLai = tongPhaiThanhToan - soTienDaThanhToan;
        //                txtSoTienConLai.Text = soTienConLai.ToString("N0");
        //            }
        //            else
        //            {
        //                // Hiển thị thông báo lỗi hoặc thực hiện hành động phù hợp
        //                MessageBox.Show("Số tiền đã thanh toán không thể lớn hơn số tiền phải thanh toán.");
        //            }
        //        }
        //        else
        //        {
        //            // Nếu người dùng nhập không hợp lệ, có thể xử lý lỗi tại đây
        //            // Ví dụ: Hiển thị thông báo lỗi hoặc thực hiện hành động phù hợp
        //            MessageBox.Show("Số tiền đã thanh toán không hợp lệ.");
        //        }
        //    }
        //}

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MATHANHTOAN").ToString());
                _idbn = int.Parse(gvDanhSach.GetFocusedRowCellValue("MABN").ToString());
                _lstTT = _thanhtoan.getItemFull(_idbn);

                var tt = _thanhtoan.GetItem(_id);
                dtNgayThanhToan.Value = tt.NGAYTHANHTOAN.Value;
                txtSoTienDaThanhToan.Text = tt.SOTIENDATHANHTOAN.Value.ToString("N0");
                txtSoTienConLai.Text = tt.SOTIENCONLAI.Value.ToString("N0");
                txtGhiChu.Text = tt.GHICHU;
                txtTongPhaiThanhToan.Text = tt.TONGPHAITHANHTOAN.Value.ToString("N0");
                txtMaCDDT.Text = tt.MACDDC.ToString();
                slkBenhNhan.EditValue = tt.MABN;

            }
        }
        private void SaveData()
        {
            if (_them)
            {
                THANHTOAN tt = new THANHTOAN();
                tt.NGAYTHANHTOAN = dtNgayThanhToan.Value;
                tt.SOTIENDATHANHTOAN = double.Parse(txtSoTienDaThanhToan.Text);
                tt.SOTIENCONLAI = double.Parse(txtSoTienConLai.Text);
                tt.TONGPHAITHANHTOAN = double.Parse(txtTongPhaiThanhToan.Text);
                tt.GHICHU = txtGhiChu.Text;

                tt.MABN = int.Parse(slkBenhNhan.EditValue.ToString());
                tt.MACDDC = int.Parse(txtMaCDDT.Text);

                _thanhtoan.Add(tt);
            }
            else
            {
                var tt = _thanhtoan.GetItem(_id);
                tt.NGAYTHANHTOAN = dtNgayThanhToan.Value;
                tt.SOTIENDATHANHTOAN = double.Parse(txtSoTienDaThanhToan.Text);
                tt.SOTIENCONLAI = double.Parse(txtSoTienConLai.Text);
                tt.TONGPHAITHANHTOAN = double.Parse(txtTongPhaiThanhToan.Text);
                tt.GHICHU = txtGhiChu.Text;

                _thanhtoan.Update(tt);
            }
        }
        bool KiemTraThongTinNhap()
        {
            if (txtSoTienDaThanhToan.Text == "")
            {
                MessageBox.Show("Hãy nhập Số Tiền Thanh Toán", "Thông Báo");
                txtSoTienDaThanhToan.Focus();
                return false;
            }

            if (txtSoTienConLai.Text == "")
            {
                MessageBox.Show("Hãy nhập Số Tiền Còn Lại", "Thông Báo");
                txtSoTienConLai.Focus();
                return false;
            }

            return true;
        }
    }
}