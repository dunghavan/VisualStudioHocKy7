﻿namespace GUI
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
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_NV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maDDH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colSoLuong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label15 = new System.Windows.Forms.Label();
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
            this.groupControl_DDH.Controls.Add(this.label11);
            this.groupControl_DDH.Controls.Add(this.cbb_NV);
            this.groupControl_DDH.Controls.Add(this.label2);
            this.groupControl_DDH.Controls.Add(this.txt_maDDH);
            this.groupControl_DDH.Controls.Add(this.label3);
            this.groupControl_DDH.Controls.Add(this.label4);
            this.groupControl_DDH.Location = new System.Drawing.Point(713, 88);
            this.groupControl_DDH.Name = "groupControl_DDH";
            this.groupControl_DDH.Size = new System.Drawing.Size(587, 263);
            this.groupControl_DDH.TabIndex = 66;
            this.groupControl_DDH.Text = "Thông tin đơn đặt hàng";
            // 
            // dtp_NgayGiao
            // 
            this.dtp_NgayGiao.Enabled = false;
            this.dtp_NgayGiao.Location = new System.Drawing.Point(199, 181);
            this.dtp_NgayGiao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_NgayGiao.Name = "dtp_NgayGiao";
            this.dtp_NgayGiao.Size = new System.Drawing.Size(278, 27);
            this.dtp_NgayGiao.TabIndex = 57;
            // 
            // cbb_KH
            // 
            this.cbb_KH.Enabled = false;
            this.cbb_KH.FormattingEnabled = true;
            this.cbb_KH.Location = new System.Drawing.Point(199, 136);
            this.cbb_KH.Name = "cbb_KH";
            this.cbb_KH.Size = new System.Drawing.Size(273, 27);
            this.cbb_KH.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 38);
            this.label11.TabIndex = 56;
            this.label11.Text = "Ngày giao:\r\n\r\n";
            // 
            // cbb_NV
            // 
            this.cbb_NV.Enabled = false;
            this.cbb_NV.FormattingEnabled = true;
            this.cbb_NV.Location = new System.Drawing.Point(199, 90);
            this.cbb_NV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_NV.Name = "cbb_NV";
            this.cbb_NV.Size = new System.Drawing.Size(273, 27);
            this.cbb_NV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng:";
            // 
            // txt_maDDH
            // 
            this.txt_maDDH.Location = new System.Drawing.Point(199, 39);
            this.txt_maDDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maDDH.Name = "txt_maDDH";
            this.txt_maDDH.ReadOnly = true;
            this.txt_maDDH.Size = new System.Drawing.Size(273, 27);
            this.txt_maDDH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân viên lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(527, 656);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 75;
            // 
            // dtpNgayLap_PDH
            // 
            this.dtpNgayLap_PDH.Location = new System.Drawing.Point(652, 46);
            this.dtpNgayLap_PDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayLap_PDH.Name = "dtpNgayLap_PDH";
            this.dtpNgayLap_PDH.Size = new System.Drawing.Size(278, 26);
            this.dtpNgayLap_PDH.TabIndex = 71;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(570, 52);
            this.label78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(74, 20);
            this.label78.TabIndex = 70;
            this.label78.Text = "Ngày lập:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.Location = new System.Drawing.Point(590, 0);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(211, 25);
            this.label79.TabIndex = 69;
            this.label79.Text = "SỬA ĐƠN ĐẶT HÀNG";
            // 
            // txtTongthanhtoan
            // 
            this.txtTongthanhtoan.Location = new System.Drawing.Point(1137, 638);
            this.txtTongthanhtoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongthanhtoan.Name = "txtTongthanhtoan";
            this.txtTongthanhtoan.Size = new System.Drawing.Size(163, 26);
            this.txtTongthanhtoan.TabIndex = 67;
            // 
            // label_tongthanhtoan
            // 
            this.label_tongthanhtoan.AutoSize = true;
            this.label_tongthanhtoan.Location = new System.Drawing.Point(1003, 648);
            this.label_tongthanhtoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tongthanhtoan.Name = "label_tongthanhtoan";
            this.label_tongthanhtoan.Size = new System.Drawing.Size(126, 20);
            this.label_tongthanhtoan.TabIndex = 68;
            this.label_tongthanhtoan.Text = "Tổng thanh toán";
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(852, 636);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(124, 32);
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
            this.btn_CapNhat.Location = new System.Drawing.Point(350, 228);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(202, 35);
            this.btn_CapNhat.TabIndex = 58;
            this.btn_CapNhat.Text = "Cập nhật sản phẩm";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(350, 173);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(202, 35);
            this.btnXoaSP.TabIndex = 56;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(350, 128);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(202, 35);
            this.btnThemSP.TabIndex = 56;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // quanLiDataSetBindingSource
            // 

            this.quanLiDataSetBindingSource.Position = 0;
            // 
            // quanLiDataSet
            // 


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
            this.txt_SL.Location = new System.Drawing.Point(129, 136);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(178, 27);
            this.txt_SL.TabIndex = 57;
            this.txt_SL.ValueChanged += new System.EventHandler(this.txt_SL_ValueChanged);
            // 
            // txt_maSP
            // 
            this.txt_maSP.Location = new System.Drawing.Point(129, 38);
            this.txt_maSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.ReadOnly = true;
            this.txt_maSP.Size = new System.Drawing.Size(178, 27);
            this.txt_maSP.TabIndex = 51;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(411, 87);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(146, 27);
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
            this.gc_DMSP.Location = new System.Drawing.Point(21, 371);
            this.gc_DMSP.MainView = this.gv_DMSP;
            this.gc_DMSP.Name = "gc_DMSP";
            this.gc_DMSP.Size = new System.Drawing.Size(590, 259);
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
            this.txt_DonGia.Location = new System.Drawing.Point(411, 41);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(146, 27);
            this.txt_DonGia.TabIndex = 53;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(129, 87);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.ReadOnly = true;
            this.txt_TenSP.Size = new System.Drawing.Size(178, 27);
            this.txt_TenSP.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mã SP:";
            // 
            // gc_CTDDH
            // 
            this.gc_CTDDH.DataSource = this.cTDonDatHangBindingSource;
            this.gc_CTDDH.Location = new System.Drawing.Point(713, 371);
            this.gc_CTDDH.MainView = this.gv_CTDDH;
            this.gc_CTDDH.Name = "gc_CTDDH";
            this.gc_CTDDH.Size = new System.Drawing.Size(587, 259);
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
            this.groupControl_SanPham.Controls.Add(this.label5);
            this.groupControl_SanPham.Controls.Add(this.label6);
            this.groupControl_SanPham.Controls.Add(this.label7);
            this.groupControl_SanPham.Controls.Add(this.label8);
            this.groupControl_SanPham.Controls.Add(this.label9);
            this.groupControl_SanPham.Location = new System.Drawing.Point(21, 88);
            this.groupControl_SanPham.Name = "groupControl_SanPham";
            this.groupControl_SanPham.Size = new System.Drawing.Size(590, 263);
            this.groupControl_SanPham.TabIndex = 64;
            this.groupControl_SanPham.Text = "Thông tin sản phẩm";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(611, 644);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 20);
            this.lb_thongbao.TabIndex = 76;
            // 
            // UC_EditDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl_DDH);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpNgayLap_PDH);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.txtTongthanhtoan);
            this.Controls.Add(this.label_tongthanhtoan);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.gc_DMSP);
            this.Controls.Add(this.gc_CTDDH);
            this.Controls.Add(this.groupControl_SanPham);
            this.Controls.Add(this.lb_thongbao);
            this.Name = "UC_EditDDH";
            this.Size = new System.Drawing.Size(1320, 677);
            this.Load += new System.EventHandler(this.UC_EditDDH_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colDonGia1;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.GroupControl groupControl_DDH;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiao;
        private System.Windows.Forms.ComboBox cbb_KH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbb_NV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maDDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong1;
        private System.Windows.Forms.Label label15;
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
    }
}
