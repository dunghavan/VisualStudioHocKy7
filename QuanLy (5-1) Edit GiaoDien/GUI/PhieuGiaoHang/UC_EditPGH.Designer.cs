namespace GUI
{
    partial class UC_EditPGH
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
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamDataSet = new GUI.SanPhamDataSet();
            this.pGH = new GUI.PGH();
            this.cT_PhieuGiaoHangTableAdapter = new GUI.ctpghTableAdapters.CT_PhieuGiaoHangTableAdapter();
            this.gc_DMSP = new DevExpress.XtraGrid.GridControl();
            this.gv_DMSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sanPhamTableAdapter = new GUI.SanPhamDataSetTableAdapters.SanPhamTableAdapter();
            this.label79 = new System.Windows.Forms.Label();
            this.cTPhieuGiaoHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDH = new GUI.CTDDH();
            this.btn_HuyPGH = new DevExpress.XtraEditors.SimpleButton();
            this.pGHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl_CTPGH = new DevExpress.XtraEditors.GroupControl();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbb_KH = new System.Windows.Forms.ComboBox();
            this.gc_CTPGH = new DevExpress.XtraGrid.GridControl();
            this.gv_CTPGH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maDDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_maPGH = new System.Windows.Forms.TextBox();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HoaTat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongThanhToan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_SLConLai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SLDaGiao = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_SL = new System.Windows.Forms.NumericUpDown();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.txt_maSP = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gc_DSDDH = new DevExpress.XtraGrid.GridControl();
            this.gv_DSDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuGiaoHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CTPGH)).BeginInit();
            this.groupControl_CTPGH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTPGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTPGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DSDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(603, 598);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 20);
            this.lb_thongbao.TabIndex = 102;
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
            // pGH
            // 
            this.pGH.DataSetName = "PGH";
            this.pGH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cT_PhieuGiaoHangTableAdapter
            // 
            this.cT_PhieuGiaoHangTableAdapter.ClearBeforeFill = true;
            // 
            // gc_DMSP
            // 
            this.gc_DMSP.DataSource = this.sanPhamBindingSource;
            this.gc_DMSP.Location = new System.Drawing.Point(595, 58);
            this.gc_DMSP.MainView = this.gv_DMSP;
            this.gc_DMSP.Name = "gc_DMSP";
            this.gc_DMSP.Size = new System.Drawing.Size(612, 338);
            this.gc_DMSP.TabIndex = 91;
            this.gc_DMSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DMSP});
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
            // colMaSP
            // 
            this.colMaSP.Caption = "Mã sản phẩm";
            this.colMaSP.FieldName = "MaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            // 
            // colTenSP
            // 
            this.colTenSP.Caption = "Tên sản phẩm";
            this.colTenSP.FieldName = "TenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            // 
            // colDonVi
            // 
            this.colDonVi.Caption = "Đơn Vị Tính";
            this.colDonVi.FieldName = "DonVi";
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.Visible = true;
            this.colDonVi.VisibleIndex = 2;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.Location = new System.Drawing.Point(590, 0);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(235, 25);
            this.label79.TabIndex = 97;
            this.label79.Text = "SỬA PHIẾU GIAO HÀNG";
            // 
            // cTPhieuGiaoHangBindingSource
            // 
            this.cTPhieuGiaoHangBindingSource.DataMember = "CT_PhieuGiaoHang";
            // 
            // cTDDH
            // 
            this.cTDDH.DataSetName = "QuanLiDataSet2";
            this.cTDDH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_HuyPGH
            // 
            this.btn_HuyPGH.Location = new System.Drawing.Point(996, 140);
            this.btn_HuyPGH.Name = "btn_HuyPGH";
            this.btn_HuyPGH.Size = new System.Drawing.Size(202, 35);
            this.btn_HuyPGH.TabIndex = 100;
            this.btn_HuyPGH.Text = "Hủy";
            // 
            // pGHBindingSource
            // 
            this.pGHBindingSource.DataSource = this.pGH;
            this.pGHBindingSource.Position = 0;
            // 
            // groupControl_CTPGH
            // 
            this.groupControl_CTPGH.Controls.Add(this.txt_TenNV);
            this.groupControl_CTPGH.Controls.Add(this.dtp_NgayLap);
            this.groupControl_CTPGH.Controls.Add(this.cbb_KH);
            this.groupControl_CTPGH.Controls.Add(this.gc_CTPGH);
            this.groupControl_CTPGH.Controls.Add(this.label3);
            this.groupControl_CTPGH.Controls.Add(this.txt_maDDH);
            this.groupControl_CTPGH.Controls.Add(this.label1);
            this.groupControl_CTPGH.Controls.Add(this.label10);
            this.groupControl_CTPGH.Controls.Add(this.label12);
            this.groupControl_CTPGH.Controls.Add(this.txt_maPGH);
            this.groupControl_CTPGH.Controls.Add(this.btn_Huy);
            this.groupControl_CTPGH.Controls.Add(this.btn_HoaTat);
            this.groupControl_CTPGH.Controls.Add(this.txtTongThanhToan);
            this.groupControl_CTPGH.Controls.Add(this.label13);
            this.groupControl_CTPGH.Controls.Add(this.label14);
            this.groupControl_CTPGH.Location = new System.Drawing.Point(3, 402);
            this.groupControl_CTPGH.Name = "groupControl_CTPGH";
            this.groupControl_CTPGH.Size = new System.Drawing.Size(1384, 283);
            this.groupControl_CTPGH.TabIndex = 104;
            this.groupControl_CTPGH.Text = "Thông tin phiếu giao hàng";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Enabled = false;
            this.dtp_NgayLap.Location = new System.Drawing.Point(180, 228);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(278, 27);
            this.dtp_NgayLap.TabIndex = 61;
            // 
            // cbb_KH
            // 
            this.cbb_KH.Enabled = false;
            this.cbb_KH.FormattingEnabled = true;
            this.cbb_KH.Location = new System.Drawing.Point(180, 183);
            this.cbb_KH.Name = "cbb_KH";
            this.cbb_KH.Size = new System.Drawing.Size(272, 27);
            this.cbb_KH.TabIndex = 59;
            // 
            // gc_CTPGH
            // 
            this.gc_CTPGH.DataSource = this.cTPhieuGiaoHangBindingSource;
            this.gc_CTPGH.Location = new System.Drawing.Point(532, 42);
            this.gc_CTPGH.MainView = this.gv_CTPGH;
            this.gc_CTPGH.Name = "gc_CTPGH";
            this.gc_CTPGH.Size = new System.Drawing.Size(586, 226);
            this.gc_CTPGH.TabIndex = 80;
            this.gc_CTPGH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTPGH});
            // 
            // gv_CTPGH
            // 
            this.gv_CTPGH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_CTPGH.GridControl = this.gc_CTPGH;
            this.gv_CTPGH.Name = "gv_CTPGH";
            this.gv_CTPGH.OptionsBehavior.Editable = false;
            this.gv_CTPGH.OptionsFind.AlwaysVisible = true;
            this.gv_CTPGH.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm ...";
            this.gv_CTPGH.OptionsFind.SearchInPreview = true;
            this.gv_CTPGH.OptionsView.ShowGroupPanel = false;
            this.gv_CTPGH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_CTPGH_RowClick_1);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã phiếu giao hàng";
            this.gridColumn3.FieldName = "MaPGH";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã sản phẩm";
            this.gridColumn4.FieldName = "MaSP";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên sản phẩm";
            this.gridColumn5.FieldName = "TenSP";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Đơn giá";
            this.gridColumn6.FieldName = "DonGia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Số lượng";
            this.gridColumn7.FieldName = "SoLuong";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Thành tiền";
            this.gridColumn8.FieldName = "ThanhTien";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 110;
            this.label3.Text = "Mã DDH";
            // 
            // txt_maDDH
            // 
            this.txt_maDDH.Location = new System.Drawing.Point(180, 91);
            this.txt_maDDH.Name = "txt_maDDH";
            this.txt_maDDH.ReadOnly = true;
            this.txt_maDDH.Size = new System.Drawing.Size(272, 27);
            this.txt_maDDH.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 38);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ngày lập:\r\n\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "Tên khách hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tên nhân viên lập:";
            // 
            // txt_maPGH
            // 
            this.txt_maPGH.Location = new System.Drawing.Point(180, 55);
            this.txt_maPGH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maPGH.Name = "txt_maPGH";
            this.txt_maPGH.ReadOnly = true;
            this.txt_maPGH.Size = new System.Drawing.Size(272, 27);
            this.txt_maPGH.TabIndex = 7;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(1139, 196);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(124, 32);
            this.btn_Huy.TabIndex = 90;
            this.btn_Huy.Text = "Hủy PGH";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_HoaTat
            // 
            this.btn_HoaTat.Location = new System.Drawing.Point(1139, 140);
            this.btn_HoaTat.Name = "btn_HoaTat";
            this.btn_HoaTat.Size = new System.Drawing.Size(124, 32);
            this.btn_HoaTat.TabIndex = 90;
            this.btn_HoaTat.Text = "Hoàn Tất PGH";
            this.btn_HoaTat.Click += new System.EventHandler(this.btn_HoaTat_Click);
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.Location = new System.Drawing.Point(1140, 91);
            this.txtTongThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.Size = new System.Drawing.Size(163, 27);
            this.txtTongThanhToan.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Mã phiếu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1136, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 19);
            this.label14.TabIndex = 83;
            this.label14.Text = "Tổng thanh toán";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(315, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 19);
            this.label17.TabIndex = 112;
            this.label17.Text = "Số lượng còn lại:";
            // 
            // txt_SLConLai
            // 
            this.txt_SLConLai.Location = new System.Drawing.Point(468, 147);
            this.txt_SLConLai.Name = "txt_SLConLai";
            this.txt_SLConLai.Size = new System.Drawing.Size(151, 27);
            this.txt_SLConLai.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Số lượng đã giao:";
            // 
            // txt_SLDaGiao
            // 
            this.txt_SLDaGiao.Location = new System.Drawing.Point(468, 94);
            this.txt_SLDaGiao.Name = "txt_SLDaGiao";
            this.txt_SLDaGiao.Size = new System.Drawing.Size(151, 27);
            this.txt_SLDaGiao.TabIndex = 109;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_CapNhat);
            this.groupControl1.Controls.Add(this.txt_SL);
            this.groupControl1.Controls.Add(this.btnXoaSP);
            this.groupControl1.Controls.Add(this.label17);
            this.groupControl1.Controls.Add(this.btnThemSP);
            this.groupControl1.Controls.Add(this.txt_SLConLai);
            this.groupControl1.Controls.Add(this.txt_maSP);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_SLDaGiao);
            this.groupControl1.Controls.Add(this.txt_ThanhTien);
            this.groupControl1.Controls.Add(this.txt_DonGia);
            this.groupControl1.Controls.Add(this.txt_TenSP);
            this.groupControl1.Controls.Add(this.label19);
            this.groupControl1.Controls.Add(this.label20);
            this.groupControl1.Controls.Add(this.label21);
            this.groupControl1.Controls.Add(this.label22);
            this.groupControl1.Controls.Add(this.label23);
            this.groupControl1.Location = new System.Drawing.Point(1213, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(633, 338);
            this.groupControl1.TabIndex = 105;
            this.groupControl1.Text = "Thông tin sản phẩm";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(206, 236);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(153, 35);
            this.btn_CapNhat.TabIndex = 58;
            this.btn_CapNhat.Text = "Cập nhật sản phẩm";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(131, 95);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(146, 27);
            this.txt_SL.TabIndex = 57;
            this.txt_SL.ValueChanged += new System.EventHandler(this.txt_SL_ValueChanged);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(392, 236);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(165, 35);
            this.btnXoaSP.TabIndex = 56;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(18, 236);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(156, 35);
            this.btnThemSP.TabIndex = 56;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txt_maSP
            // 
            this.txt_maSP.Location = new System.Drawing.Point(468, 52);
            this.txt_maSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.ReadOnly = true;
            this.txt_maSP.Size = new System.Drawing.Size(151, 27);
            this.txt_maSP.TabIndex = 51;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(131, 147);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(146, 27);
            this.txt_ThanhTien.TabIndex = 52;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(131, 191);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(146, 27);
            this.txt_DonGia.TabIndex = 53;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(131, 48);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.ReadOnly = true;
            this.txt_TenSP.Size = new System.Drawing.Size(146, 27);
            this.txt_TenSP.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 150);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "Thành tiền:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 199);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 19);
            this.label20.TabIndex = 46;
            this.label20.Text = "Đơn giá:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 97);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 19);
            this.label21.TabIndex = 47;
            this.label21.Text = "Số lượng:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 52);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 19);
            this.label22.TabIndex = 48;
            this.label22.Text = "Tên sản phẩm:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(321, 52);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 19);
            this.label23.TabIndex = 49;
            this.label23.Text = "Mã SP:";
            // 
            // gc_DSDDH
            // 
            this.gc_DSDDH.Location = new System.Drawing.Point(10, 58);
            this.gc_DSDDH.MainView = this.gv_DSDDH;
            this.gc_DSDDH.Name = "gc_DSDDH";
            this.gc_DSDDH.Size = new System.Drawing.Size(569, 338);
            this.gc_DSDDH.TabIndex = 113;
            this.gc_DSDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DSDDH});
            // 
            // gv_DSDDH
            // 
            this.gv_DSDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gv_DSDDH.GridControl = this.gc_DSDDH;
            this.gv_DSDDH.Name = "gv_DSDDH";
            this.gv_DSDDH.OptionsBehavior.Editable = false;
            this.gv_DSDDH.OptionsFind.AlwaysVisible = true;
            this.gv_DSDDH.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm ...";
            this.gv_DSDDH.OptionsFind.SearchInPreview = true;
            this.gv_DSDDH.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã đơn đặt hàng";
            this.gridColumn1.FieldName = "MaDDH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã sản phẩm";
            this.gridColumn2.FieldName = "MaSP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên sản phẩm";
            this.gridColumn9.FieldName = "TenSP";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số lượng đặt";
            this.gridColumn10.FieldName = "SoLuong";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Đơn giá";
            this.gridColumn11.FieldName = "DonGia";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Thành tiền";
            this.gridColumn12.FieldName = "ThanhTien";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 114;
            this.label4.Text = "Thông tin sản phẩm đặt hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Thông tin sản phẩm trong kho";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(180, 137);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.ReadOnly = true;
            this.txt_TenNV.Size = new System.Drawing.Size(272, 27);
            this.txt_TenNV.TabIndex = 115;
            // 
            // UC_EditPGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gc_DSDDH);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl_CTPGH);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.gc_DMSP);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.btn_HuyPGH);
            this.Name = "UC_EditPGH";
            this.Size = new System.Drawing.Size(2042, 700);
            this.Load += new System.EventHandler(this.UC_EditPGH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPhieuGiaoHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_CTPGH)).EndInit();
            this.groupControl_CTPGH.ResumeLayout(false);
            this.groupControl_CTPGH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTPGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTPGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DSDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SanPhamDataSet sanPhamDataSet;
        private PGH pGH;
        private ctpghTableAdapters.CT_PhieuGiaoHangTableAdapter cT_PhieuGiaoHangTableAdapter;
        public DevExpress.XtraGrid.GridControl gc_DMSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DMSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private SanPhamDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.BindingSource cTPhieuGiaoHangBindingSource;
        private System.Windows.Forms.BindingSource cTDonDatHangBindingSource;
        private CTDDH cTDDH;
        private DevExpress.XtraEditors.SimpleButton btn_HuyPGH;
        private System.Windows.Forms.BindingSource pGHBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl_CTPGH;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.ComboBox cbb_KH;
        private DevExpress.XtraGrid.GridControl gc_CTPGH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTPGH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_maPGH;
        private DevExpress.XtraEditors.SimpleButton btn_HoaTat;
        private System.Windows.Forms.TextBox txtTongThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_SLConLai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SLDaGiao;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private System.Windows.Forms.NumericUpDown txt_SL;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        public System.Windows.Forms.TextBox txt_maSP;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraGrid.GridControl gc_DSDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DSDDH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.TextBox txt_maDDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private System.Windows.Forms.TextBox txt_TenNV;
    }
}
