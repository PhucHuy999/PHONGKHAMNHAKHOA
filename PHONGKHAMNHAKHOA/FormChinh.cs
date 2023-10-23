﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            ribbon.SelectedPage = ribbonPage2; //set khi load hiển thị lên ribbonPage2(Bệnh Nhân) trước.
        }
        void openForm(Type typeForm) ///// Đoạn này thiết lập openform cho nó không bị mở thêm form mới khi click vào button mà khi form đã mở 
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;//Thuộc tính để show form trong nền form chính của documentManager
            f.Show();

        }
        private void btnThongTinBenhNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormBenhNhan));
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)//open form thông tin lâm sàng
        {
            openForm(typeof(FormThongTinLamSang));

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)//open form thông tin cận lâm sàng
        {
            openForm(typeof(FormThongTinCanLamSang));

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)//open form chuẩn đoán điều trị
        {
            openForm(typeof(FormChuanDoanDieuTri));
        }

        private void btnLoaiDieuTri_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormLoaiDieuTri));

        }

        private void btnDonThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormDonThuoc));
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormLoaiThuoc));

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormTHANHTOAN));
        }

        private void btnSaoLuuDuLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSaoLuuDuLieu frm = new FormSaoLuuDuLieu();
            frm.ShowDialog();
        }

        private void btnKhoiPhucDuLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormKhoiPhucDuLieu frm = new FormKhoiPhucDuLieu();
            frm.ShowDialog();
        }
    }
}