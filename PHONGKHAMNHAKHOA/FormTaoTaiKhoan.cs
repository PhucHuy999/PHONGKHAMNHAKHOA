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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }
        USERS _userr;
        bool _them;
        int _id;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            _them = false;
            _userr = new USERS();
            _showHide(true);
            loadData();
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;//// mới chạy thì lưu và hủy cho nó mờ đi
            btnHuy.Enabled = !kt;////
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            //btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtUserName.Enabled = !kt;
            txtHoTen.Enabled = !kt;
            txtPass.Enabled = !kt;
            cboQuyen.Enabled = !kt;
            txtDienThoai.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            txtEmail.Enabled = !kt;


        }
        void loadData()
        {
            gcDanhSach.DataSource = _userr.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            txtUserName.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtPass.Text = string.Empty;
            cboQuyen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
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

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }
        void SaveData()
        {
            if (_them)
            {
                tb_User us = new tb_User();
                us.USERNAME = txtUserName.Text;
                us.FULLNAME = txtHoTen.Text;
                us.PASS = Encryption.Encrypt(txtPass.Text);
                us.QUYEN = cboQuyen.Text;
                us.DIENTHOAI = txtDienThoai.Text;
                us.DIACHI = txtDiaChi.Text;
                us.EMAIL = txtEmail.Text;

                _userr.Add(us);
            }
            else
            {
                var us = _userr.getItem(_id);
                us.USERNAME = txtUserName.Text;
                us.FULLNAME = txtHoTen.Text;
                us.PASS = Encryption.Encrypt(txtPass.Text);
                us.QUYEN = cboQuyen.Text;
                us.DIENTHOAI = txtDienThoai.Text;
                us.DIACHI = txtDiaChi.Text;
                us.EMAIL = txtEmail.Text;

                _userr.Update(us);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)  // nếu có giá trị trong lưới thì mới chạy để không báo lỗi không có giá trị mà click á
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("IDUSER").ToString());
                var us = _userr.getItem(_id);
                txtUserName.Text = us.USERNAME;
                txtHoTen.Text = us.FULLNAME;
                txtPass.Text = us.PASS;
                cboQuyen.Text = us.QUYEN;
                txtDienThoai.Text = us.DIENTHOAI;
                txtDiaChi.Text = us.DIACHI;
                txtEmail.Text = us.EMAIL;
            }
        }
    }
}