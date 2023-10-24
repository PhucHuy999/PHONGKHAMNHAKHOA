namespace PHONGKHAMNHAKHOA.GUI
{
    partial class FormTHANHTOAN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTHANHTOAN));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.dgvLoaiDieuTri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaCDDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongPhaiThanhToan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtSoTienConLai = new System.Windows.Forms.TextBox();
            this.txtSoTienDaThanhToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slkBenhNhan = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDIEUTRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAITHUOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONGPHAITHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIENDATHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTIENCONLAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDieuTri)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkBenhNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnIn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm thanh toán";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 6;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1379, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1379, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 730);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1379, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 730);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.dgvDonThuoc);
            this.splitContainer1.Panel1.Controls.Add(this.dgvLoaiDieuTri);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1379, 730);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(758, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Thuốc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(758, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sử dụng điều trị:";
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Location = new System.Drawing.Point(761, 139);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.Size = new System.Drawing.Size(447, 91);
            this.dgvDonThuoc.TabIndex = 16;
            // 
            // dgvLoaiDieuTri
            // 
            this.dgvLoaiDieuTri.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiDieuTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDieuTri.Location = new System.Drawing.Point(761, 26);
            this.dgvLoaiDieuTri.Name = "dgvLoaiDieuTri";
            this.dgvLoaiDieuTri.ReadOnly = true;
            this.dgvLoaiDieuTri.Size = new System.Drawing.Size(447, 91);
            this.dgvLoaiDieuTri.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayThanhToan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaCDDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTongPhaiThanhToan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtSoTienConLai);
            this.groupBox1.Controls.Add(this.txtSoTienDaThanhToan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slkBenhNhan);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 213);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dtNgayThanhToan
            // 
            this.dtNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtNgayThanhToan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThanhToan.Location = new System.Drawing.Point(482, 30);
            this.dtNgayThanhToan.Name = "dtNgayThanhToan";
            this.dtNgayThanhToan.Size = new System.Drawing.Size(153, 24);
            this.dtNgayThanhToan.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "MACDDT";
            // 
            // txtMaCDDT
            // 
            this.txtMaCDDT.Location = new System.Drawing.Point(101, 146);
            this.txtMaCDDT.Name = "txtMaCDDT";
            this.txtMaCDDT.ReadOnly = true;
            this.txtMaCDDT.Size = new System.Drawing.Size(90, 21);
            this.txtMaCDDT.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng phải thanh toán";
            // 
            // txtTongPhaiThanhToan
            // 
            this.txtTongPhaiThanhToan.Location = new System.Drawing.Point(482, 65);
            this.txtTongPhaiThanhToan.Name = "txtTongPhaiThanhToan";
            this.txtTongPhaiThanhToan.ReadOnly = true;
            this.txtTongPhaiThanhToan.Size = new System.Drawing.Size(211, 21);
            this.txtTongPhaiThanhToan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số tiền còn lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số tiền thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày thanh toán";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(482, 163);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(211, 21);
            this.txtGhiChu.TabIndex = 3;
            // 
            // txtSoTienConLai
            // 
            this.txtSoTienConLai.Location = new System.Drawing.Point(482, 130);
            this.txtSoTienConLai.Name = "txtSoTienConLai";
            this.txtSoTienConLai.Size = new System.Drawing.Size(211, 21);
            this.txtSoTienConLai.TabIndex = 2;
            // 
            // txtSoTienDaThanhToan
            // 
            this.txtSoTienDaThanhToan.Location = new System.Drawing.Point(482, 97);
            this.txtSoTienDaThanhToan.Name = "txtSoTienDaThanhToan";
            this.txtSoTienDaThanhToan.Size = new System.Drawing.Size(211, 21);
            this.txtSoTienDaThanhToan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bệnh Nhân";
            // 
            // slkBenhNhan
            // 
            this.slkBenhNhan.Location = new System.Drawing.Point(101, 62);
            this.slkBenhNhan.Name = "slkBenhNhan";
            this.slkBenhNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkBenhNhan.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkBenhNhan.Size = new System.Drawing.Size(211, 20);
            this.slkBenhNhan.TabIndex = 0;
            this.slkBenhNhan.EditValueChanged += new System.EventHandler(this.slkBenhNhan_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MABN,
            this.HOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MABN
            // 
            this.MABN.Caption = "MÃ BN";
            this.MABN.FieldName = "MABN";
            this.MABN.MaxWidth = 60;
            this.MABN.MinWidth = 60;
            this.MABN.Name = "MABN";
            this.MABN.Visible = true;
            this.MABN.VisibleIndex = 0;
            this.MABN.Width = 60;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "TÊN BỆNH NHÂN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1379, 454);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATHANHTOAN,
            this.colHOTEN,
            this.colTENDIEUTRI,
            this.colTENLOAITHUOC,
            this.NGAYTHANHTOAN,
            this.TONGPHAITHANHTOAN,
            this.SOTIENDATHANHTOAN,
            this.SOTIENCONLAI,
            this.GHICHU});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // colMATHANHTOAN
            // 
            this.colMATHANHTOAN.AppearanceCell.Options.UseTextOptions = true;
            this.colMATHANHTOAN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMATHANHTOAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMATHANHTOAN.AppearanceHeader.Options.UseFont = true;
            this.colMATHANHTOAN.Caption = "MÃTT";
            this.colMATHANHTOAN.FieldName = "MATHANHTOAN";
            this.colMATHANHTOAN.MaxWidth = 50;
            this.colMATHANHTOAN.MinWidth = 50;
            this.colMATHANHTOAN.Name = "colMATHANHTOAN";
            this.colMATHANHTOAN.Visible = true;
            this.colMATHANHTOAN.VisibleIndex = 0;
            this.colMATHANHTOAN.Width = 50;
            // 
            // colHOTEN
            // 
            this.colHOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHOTEN.AppearanceHeader.Options.UseFont = true;
            this.colHOTEN.Caption = "TÊN BỆNH NHÂN";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MaxWidth = 200;
            this.colHOTEN.MinWidth = 200;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 200;
            // 
            // colTENDIEUTRI
            // 
            this.colTENDIEUTRI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTENDIEUTRI.AppearanceHeader.Options.UseFont = true;
            this.colTENDIEUTRI.Caption = "TÊN ĐIỀU TRỊ";
            this.colTENDIEUTRI.FieldName = "TENDIEUTRI";
            this.colTENDIEUTRI.MaxWidth = 200;
            this.colTENDIEUTRI.MinWidth = 200;
            this.colTENDIEUTRI.Name = "colTENDIEUTRI";
            this.colTENDIEUTRI.Visible = true;
            this.colTENDIEUTRI.VisibleIndex = 2;
            this.colTENDIEUTRI.Width = 200;
            // 
            // colTENLOAITHUOC
            // 
            this.colTENLOAITHUOC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTENLOAITHUOC.AppearanceHeader.Options.UseFont = true;
            this.colTENLOAITHUOC.Caption = "TÊN THUỐC";
            this.colTENLOAITHUOC.FieldName = "TENLOAITHUOC";
            this.colTENLOAITHUOC.MaxWidth = 210;
            this.colTENLOAITHUOC.MinWidth = 210;
            this.colTENLOAITHUOC.Name = "colTENLOAITHUOC";
            this.colTENLOAITHUOC.Visible = true;
            this.colTENLOAITHUOC.VisibleIndex = 3;
            this.colTENLOAITHUOC.Width = 210;
            // 
            // NGAYTHANHTOAN
            // 
            this.NGAYTHANHTOAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYTHANHTOAN.AppearanceHeader.Options.UseFont = true;
            this.NGAYTHANHTOAN.Caption = "NGÀY THANH TOÁN";
            this.NGAYTHANHTOAN.FieldName = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.MaxWidth = 113;
            this.NGAYTHANHTOAN.MinWidth = 113;
            this.NGAYTHANHTOAN.Name = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.Visible = true;
            this.NGAYTHANHTOAN.VisibleIndex = 4;
            this.NGAYTHANHTOAN.Width = 113;
            // 
            // TONGPHAITHANHTOAN
            // 
            this.TONGPHAITHANHTOAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TONGPHAITHANHTOAN.AppearanceHeader.Options.UseFont = true;
            this.TONGPHAITHANHTOAN.Caption = "TỔNG PHẢI TT";
            this.TONGPHAITHANHTOAN.DisplayFormat.FormatString = "n0";
            this.TONGPHAITHANHTOAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TONGPHAITHANHTOAN.FieldName = "TONGPHAITHANHTOAN";
            this.TONGPHAITHANHTOAN.MaxWidth = 90;
            this.TONGPHAITHANHTOAN.MinWidth = 90;
            this.TONGPHAITHANHTOAN.Name = "TONGPHAITHANHTOAN";
            this.TONGPHAITHANHTOAN.Visible = true;
            this.TONGPHAITHANHTOAN.VisibleIndex = 5;
            this.TONGPHAITHANHTOAN.Width = 90;
            // 
            // SOTIENDATHANHTOAN
            // 
            this.SOTIENDATHANHTOAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SOTIENDATHANHTOAN.AppearanceHeader.Options.UseFont = true;
            this.SOTIENDATHANHTOAN.Caption = "ĐÃ TRẢ";
            this.SOTIENDATHANHTOAN.DisplayFormat.FormatString = "n0";
            this.SOTIENDATHANHTOAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SOTIENDATHANHTOAN.FieldName = "SOTIENDATHANHTOAN";
            this.SOTIENDATHANHTOAN.MaxWidth = 90;
            this.SOTIENDATHANHTOAN.MinWidth = 90;
            this.SOTIENDATHANHTOAN.Name = "SOTIENDATHANHTOAN";
            this.SOTIENDATHANHTOAN.Visible = true;
            this.SOTIENDATHANHTOAN.VisibleIndex = 6;
            this.SOTIENDATHANHTOAN.Width = 90;
            // 
            // SOTIENCONLAI
            // 
            this.SOTIENCONLAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SOTIENCONLAI.AppearanceHeader.Options.UseFont = true;
            this.SOTIENCONLAI.Caption = "THIẾU";
            this.SOTIENCONLAI.DisplayFormat.FormatString = "n0";
            this.SOTIENCONLAI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SOTIENCONLAI.FieldName = "SOTIENCONLAI";
            this.SOTIENCONLAI.MaxWidth = 90;
            this.SOTIENCONLAI.MinWidth = 90;
            this.SOTIENCONLAI.Name = "SOTIENCONLAI";
            this.SOTIENCONLAI.Visible = true;
            this.SOTIENCONLAI.VisibleIndex = 7;
            this.SOTIENCONLAI.Width = 90;
            // 
            // GHICHU
            // 
            this.GHICHU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GHICHU.AppearanceHeader.Options.UseFont = true;
            this.GHICHU.Caption = "GHI CHÚ";
            this.GHICHU.FieldName = "GHICHU";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = true;
            this.GHICHU.VisibleIndex = 8;
            this.GHICHU.Width = 499;
            // 
            // FormTHANHTOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 774);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTHANHTOAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN";
            this.Load += new System.EventHandler(this.FormTHANHTOAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDieuTri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkBenhNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMATHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongPhaiThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtSoTienConLai;
        private System.Windows.Forms.TextBox txtSoTienDaThanhToan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit slkBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MABN;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDIEUTRI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAITHUOC;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn TONGPHAITHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIENDATHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIENCONLAI;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.DataGridView dgvLoaiDieuTri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaCDDT;
        private System.Windows.Forms.DateTimePicker dtNgayThanhToan;
    }
}