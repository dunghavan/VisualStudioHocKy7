namespace GUI
{
    partial class UC_EditDDH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colDonGia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.groupControl_DDH = new DevExpress.XtraEditors.GroupControl();
            this.dtp_NgayGiao = new System.Windows.Forms.DateTimePicker();
            this.cbb_KH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.txt_maDDH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colSoLuong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpNgayLap_PDH = new System.Windows.Forms.DateTimePicker();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.txtTongthanhtoan = new System.Windows.Forms.TextBox();
            this.label_tongthanhtoan = new System.Windows.Forms.Label();
            this.btn_HoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.colTenSP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.sanPhamTableAdapter = new GUI.SanPhamDataSetTableAdapters.SanPhamTableAdapter();
            this.quanLiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_SL = new System.Windows.Forms.NumericUpDown();
            this.txt_maSP = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_DMSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DMSP = new DevExpress.XtraGrid.GridControl();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamDataSet = new GUI.SanPhamDataSet();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gc_CTDDH = new DevExpress.XtraGrid.GridControl();
            this.cTDonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDH = new GUI.CTDDH();
            this.gv_CTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_SanPham = new DevExpress.XtraEditors.GroupControl();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_DDH)).BeginInit();
            this.groupControl_DDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SanPham)).BeginInit();
            this.groupControl_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colDonGia1
            // 
            this.colDonGia1.Caption = "Đơn giá";
            this.colDonGia1.FieldName = "DonGia";
            this.colDonGia1.Name = "colDonGia1";
            this.colDonGia1.Visible = true;
            this.colDonGia1.VisibleIndex = 3;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 5;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // groupControl_DDH
            // 
            this.groupControl_DDH.Controls.Add(this.dtp_NgayGiao);
            this.groupControl_DDH.Controls.Add(this.cbb_KH);
            this.groupControl_DDH.Controls.Add(this.label1);
            this.groupControl_DDH.Controls.Add(this.label2);
            this.groupControl_DDH.Controls.Add(this.txt_maNV);
            this.groupControl_DDH.Controls.Add(this.txt_maDDH);
            this.groupControl_DDH.Controls.Add(this.label3);
            this.groupControl_DDH.Controls.Add(this.label4);
            this.groupControl_DDH.Controls.Add(this.dtpNgayLap_PDH);
            this.groupControl_DDH.Controls.Add(this.label78);
            this.groupControl_DDH.Location = new System.Drawing.Point(17, 235);
            this.groupControl_DDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl_DDH.Name = "groupControl_DDH";
            this.groupControl_DDH.Size = new System.Drawing.Size(518, 174);
            this.groupControl_DDH.TabIndex = 66;
            this.groupControl_DDH.Text = "Thông tin đơn đặt hàng";
            // 
            // dtp_NgayGiao
            // 
            this.dtp_NgayGiao.Enabled = false;
            this.dtp_NgayGiao.Location = new System.Drawing.Point(211, 147);
            this.dtp_NgayGiao.Name = "dtp_NgayGiao";
            this.dtp_NgayGiao.Size = new System.Drawing.Size(183, 21);
            this.dtp_NgayGiao.TabIndex = 57;
            // 
            // cbb_KH
            // 
            this.cbb_KH.Enabled = false;
            this.cbb_KH.FormattingEnabled = true;
            this.cbb_KH.Location = new System.Drawing.Point(211, 117);
            this.cbb_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_KH.Name = "cbb_KH";
            this.cbb_KH.Size = new System.Drawing.Size(183, 21);
            this.cbb_KH.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng:";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(211, 85);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.ReadOnly = true;
            this.txt_maNV.Size = new System.Drawing.Size(183, 21);
            this.txt_maNV.TabIndex = 5;
            // 
            // txt_maDDH
            // 
            this.txt_maDDH.Location = new System.Drawing.Point(211, 54);
            this.txt_maDDH.Name = "txt_maDDH";
            this.txt_maDDH.ReadOnly = true;
            this.txt_maDDH.Size = new System.Drawing.Size(183, 21);
            this.txt_maDDH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân viên lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phiếu:";
            // 
            // colSoLuong1
            // 
            this.colSoLuong1.Caption = "Số Lượng";
            this.colSoLuong1.FieldName = "SoLuong";
            this.colSoLuong1.Name = "colSoLuong1";
            this.colSoLuong1.Visible = true;
            this.colSoLuong1.VisibleIndex = 4;
            // 
            // dtpNgayLap_PDH
            // 
            this.dtpNgayLap_PDH.Enabled = false;
            this.dtpNgayLap_PDH.Location = new System.Drawing.Point(211, 26);
            this.dtpNgayLap_PDH.Name = "dtpNgayLap_PDH";
            this.dtpNgayLap_PDH.Size = new System.Drawing.Size(183, 21);
            this.dtpNgayLap_PDH.TabIndex = 71;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(73, 28);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(53, 13);
            this.label78.TabIndex = 70;
            this.label78.Text = "Ngày lập:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.Location = new System.Drawing.Point(417, 20);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(140, 16);
            this.label79.TabIndex = 69;
            this.label79.Text = "SỬA ĐƠN ĐẶT HÀNG";
            // 
            // txtTongthanhtoan
            // 
            this.txtTongthanhtoan.Location = new System.Drawing.Point(958, 414);
            this.txtTongthanhtoan.Name = "txtTongthanhtoan";
            this.txtTongthanhtoan.Size = new System.Drawing.Size(110, 21);
            this.txtTongthanhtoan.TabIndex = 67;
            // 
            // label_tongthanhtoan
            // 
            this.label_tongthanhtoan.AutoSize = true;
            this.label_tongthanhtoan.Location = new System.Drawing.Point(865, 417);
            this.label_tongthanhtoan.Name = "label_tongthanhtoan";
            this.label_tongthanhtoan.Size = new System.Drawing.Size(87, 13);
            this.label_tongthanhtoan.TabIndex = 68;
            this.label_tongthanhtoan.Text = "Tổng thanh toán";
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(755, 414);
            this.btn_HoanTat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(83, 21);
            this.btn_HoanTat.TabIndex = 77;
            this.btn_HoanTat.Text = "Hoàn Tất DDH";
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // colTenSP1
            // 
            this.colTenSP1.Caption = "Tên sản phẩm";
            this.colTenSP1.FieldName = "TenSP";
            this.colTenSP1.Name = "colTenSP1";
            this.colTenSP1.Visible = true;
            this.colTenSP1.VisibleIndex = 1;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(188, 144);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(116, 23);
            this.btn_CapNhat.TabIndex = 58;
            this.btn_CapNhat.Text = "Cập nhật sản phẩm";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(338, 144);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(112, 23);
            this.btnXoaSP.TabIndex = 56;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(35, 144);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(116, 23);
            this.btnThemSP.TabIndex = 56;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(86, 88);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(120, 21);
            this.txt_SL.TabIndex = 57;
            this.txt_SL.ValueChanged += new System.EventHandler(this.txt_SL_ValueChanged);
            // 
            // txt_maSP
            // 
            this.txt_maSP.Location = new System.Drawing.Point(86, 25);
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.ReadOnly = true;
            this.txt_maSP.Size = new System.Drawing.Size(120, 21);
            this.txt_maSP.TabIndex = 51;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(312, 57);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(99, 21);
            this.txt_ThanhTien.TabIndex = 52;
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn Vị Tính";
            this.colDonVi.FieldName = "DonVi";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 2;
            // 
            // colTenSP
            // 
            this.colTenSP.Caption = "Tên sản phẩm";
            this.colTenSP.FieldName = "TenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            // 
            // colMaSP
            // 
            this.colMaSP.Caption = "Mã sản phẩm";
            this.colMaSP.FieldName = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            // 
            // gv_DMSP
            // 
            this.gv_DMSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colDonVi,
            this.colDonGia,
            this.colSoLuong});
            this.gv_DMSP.GridControl = this.gc_DMSP;
            this.gv_DMSP.Name = "gv_DMSP";
            this.gv_DMSP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_DMSP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_DMSP.OptionsBehavior.Editable = false;
            this.gv_DMSP.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gv_DMSP.OptionsFind.AlwaysVisible = true;
            this.gv_DMSP.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gv_DMSP.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm ...";
            this.gv_DMSP.OptionsFind.SearchInPreview = true;
            this.gv_DMSP.OptionsView.ShowGroupPanel = false;
            this.gv_DMSP.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_DMSP_RowClick);
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            // 
            // gc_DMSP
            // 
            this.gc_DMSP.DataSource = this.sanPhamBindingSource;
            this.gc_DMSP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_DMSP.Location = new System.Drawing.Point(17, 54);
            this.gc_DMSP.MainView = this.gv_DMSP;
            this.gc_DMSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_DMSP.Name = "gc_DMSP";
            this.gc_DMSP.Size = new System.Drawing.Size(518, 168);
            this.gc_DMSP.TabIndex = 63;
            this.gc_DMSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DMSP});
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.sanPhamDataSet;
            // 
            // sanPhamDataSet
            // 
            this.sanPhamDataSet.DataSetName = "SanPhamDataSet";
            this.sanPhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(312, 27);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(99, 21);
            this.txt_DonGia.TabIndex = 53;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(86, 57);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.ReadOnly = true;
            this.txt_TenSP.Size = new System.Drawing.Size(120, 21);
            this.txt_TenSP.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mã SP:";
            // 
            // gc_CTDDH
            // 
            this.gc_CTDDH.DataSource = this.cTDonDatHangBindingSource;
            this.gc_CTDDH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_CTDDH.Location = new System.Drawing.Point(595, 250);
            this.gc_CTDDH.MainView = this.gv_CTDDH;
            this.gc_CTDDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gc_CTDDH.Name = "gc_CTDDH";
            this.gc_CTDDH.Size = new System.Drawing.Size(473, 159);
            this.gc_CTDDH.TabIndex = 65;
            this.gc_CTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTDDH});
            // 
            // cTDonDatHangBindingSource
            // 
            this.cTDonDatHangBindingSource.DataMember = "CT_DonDatHang";
            this.cTDonDatHangBindingSource.DataSource = this.cTDDHBindingSource;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataSource = this.cTDDH;
            this.cTDDHBindingSource.Position = 0;
            // 
            // cTDDH
            // 
            this.cTDDH.DataSetName = "QuanLiDataSet2";
            this.cTDDH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gv_CTDDH
            // 
            this.gv_CTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDDH,
            this.colMaSP1,
            this.colTenSP1,
            this.colDonGia1,
            this.colSoLuong1,
            this.colThanhTien});
            this.gv_CTDDH.GridControl = this.gc_CTDDH;
            this.gv_CTDDH.Name = "gv_CTDDH";
            this.gv_CTDDH.OptionsBehavior.Editable = false;
            this.gv_CTDDH.OptionsFind.AlwaysVisible = true;
            this.gv_CTDDH.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm ...";
            this.gv_CTDDH.OptionsFind.SearchInPreview = true;
            this.gv_CTDDH.OptionsView.ShowGroupPanel = false;
            this.gv_CTDDH.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colThanhTien, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_CTDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_CTDDH_RowClick);
            // 
            // colMaDDH
            // 
            this.colMaDDH.Caption = "Mã đơn đặt hàng";
            this.colMaDDH.FieldName = "MaDDH";
            this.colMaDDH.Name = "colMaDDH";
            this.colMaDDH.OptionsColumn.AllowEdit = false;
            this.colMaDDH.OptionsColumn.ReadOnly = true;
            this.colMaDDH.Visible = true;
            this.colMaDDH.VisibleIndex = 0;
            // 
            // colMaSP1
            // 
            this.colMaSP1.Caption = "Mã sản phẩm";
            this.colMaSP1.FieldName = "MaSP";
            this.colMaSP1.Name = "colMaSP1";
            this.colMaSP1.Visible = true;
            this.colMaSP1.VisibleIndex = 2;
            // 
            // groupControl_SanPham
            // 
            this.groupControl_SanPham.Controls.Add(this.btn_CapNhat);
            this.groupControl_SanPham.Controls.Add(this.txt_SL);
            this.groupControl_SanPham.Controls.Add(this.btnXoaSP);
            this.groupControl_SanPham.Controls.Add(this.btnThemSP);
            this.groupControl_SanPham.Controls.Add(this.txt_maSP);
            this.groupControl_SanPham.Controls.Add(this.txt_ThanhTien);
            this.groupControl_SanPham.Controls.Add(this.txt_DonGia);
            this.groupControl_SanPham.Controls.Add(this.txt_TenSP);
            this.groupControl_SanPham.Controls.Add(this.label11);
            this.groupControl_SanPham.Controls.Add(this.label10);
            this.groupControl_SanPham.Controls.Add(this.label5);
            this.groupControl_SanPham.Controls.Add(this.label6);
            this.groupControl_SanPham.Controls.Add(this.label7);
            this.groupControl_SanPham.Controls.Add(this.label8);
            this.groupControl_SanPham.Controls.Add(this.label9);
            this.groupControl_SanPham.Location = new System.Drawing.Point(595, 51);
            this.groupControl_SanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl_SanPham.Name = "groupControl_SanPham";
            this.groupControl_SanPham.Size = new System.Drawing.Size(473, 171);
            this.groupControl_SanPham.TabIndex = 64;
            this.groupControl_SanPham.Text = "Thông tin sản phẩm";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(397, 442);
            this.lb_thongbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 13);
            this.lb_thongbao.TabIndex = 76;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(630, 414);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(83, 21);
            this.btn_Huy.TabIndex = 77;
            this.btn_Huy.Text = "Hủy DDH";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(592, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 79;
            this.label17.Text = "Chi tiết đơn đặt hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 13);
            this.label16.TabIndex = 78;
            this.label16.Text = "Danh mục sản phẩm trong kho";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_DMSP);
            this.groupControl1.Controls.Add(this.txtTongthanhtoan);
            this.groupControl1.Controls.Add(this.label17);
            this.groupControl1.Controls.Add(this.groupControl_SanPham);
            this.groupControl1.Controls.Add(this.label_tongthanhtoan);
            this.groupControl1.Controls.Add(this.label16);
            this.groupControl1.Controls.Add(this.btn_Huy);
            this.groupControl1.Controls.Add(this.lb_thongbao);
            this.groupControl1.Controls.Add(this.gc_CTDDH);
            this.groupControl1.Controls.Add(this.groupControl_DDH);
            this.groupControl1.Controls.Add(this.btn_HoanTat);
            this.groupControl1.Controls.Add(this.label79);
            this.groupControl1.Location = new System.Drawing.Point(21, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1132, 502);
            this.groupControl1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày giao:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(417, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "(vnđ)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(417, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "(vnđ)";
            // 
            // UC_EditDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_EditDDH";
            this.Size = new System.Drawing.Size(1361, 455);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_DDH)).EndInit();
            this.groupControl_DDH.ResumeLayout(false);
            this.groupControl_DDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SanPham)).EndInit();
            this.groupControl_SanPham.ResumeLayout(false);
            this.groupControl_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colDonGia1;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.GroupControl groupControl_DDH;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiao;
        private System.Windows.Forms.ComboBox cbb_KH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maDDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap_PDH;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox txtTongthanhtoan;
        private System.Windows.Forms.Label label_tongthanhtoan;
        private DevExpress.XtraEditors.SimpleButton btn_HoanTat;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private SanPhamDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.BindingSource quanLiDataSetBindingSource;

        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private System.Windows.Forms.NumericUpDown txt_SL;
        public System.Windows.Forms.TextBox txt_maSP;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DMSP;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        public DevExpress.XtraGrid.GridControl gc_DMSP;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SanPhamDataSet sanPhamDataSet;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.GridControl gc_CTDDH;
        private System.Windows.Forms.BindingSource cTDonDatHangBindingSource;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private CTDDH cTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP1;
        private DevExpress.XtraEditors.GroupControl groupControl_SanPham;
        private System.Windows.Forms.Label lb_thongbao;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
