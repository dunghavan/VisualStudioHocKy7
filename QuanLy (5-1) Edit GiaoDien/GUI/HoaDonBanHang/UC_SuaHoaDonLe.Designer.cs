namespace GUI
{
    partial class UC_SuaHoaDonLe
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.txt_SL = new System.Windows.Forms.NumericUpDown();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.colDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_DMSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DMSP = new DevExpress.XtraGrid.GridControl();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamDataSet = new GUI.SanPhamDataSet();
            this.txt_maSP = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cTDonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDH = new GUI.CTDDH();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.groupControl_DDH = new DevExpress.XtraEditors.GroupControl();
            this.cbb_KH = new System.Windows.Forms.ComboBox();
            this.cbb_NV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl_SanPham = new DevExpress.XtraEditors.GroupControl();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgayLap_HD = new System.Windows.Forms.DateTimePicker();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.txtTongthanhtoan = new System.Windows.Forms.TextBox();
            this.label_tongthanhtoan = new System.Windows.Forms.Label();
            this.btn_HoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.sanPhamTableAdapter = new GUI.SanPhamDataSetTableAdapters.SanPhamTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.quanLiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gc_CTHD = new DevExpress.XtraGrid.GridControl();
            this.gv_CTHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_DDH)).BeginInit();
            this.groupControl_DDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SanPham)).BeginInit();
            this.groupControl_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(86, 88);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(119, 21);
            this.txt_SL.TabIndex = 57;
            this.txt_SL.ValueChanged += new System.EventHandler(this.txt_SL_ValueChanged);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(292, 57);
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
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // gc_DMSP
            // 
            this.gc_DMSP.DataSource = this.sanPhamBindingSource;
            this.gc_DMSP.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_DMSP.Location = new System.Drawing.Point(25, 60);
            this.gc_DMSP.MainView = this.gv_DMSP;
            this.gc_DMSP.Margin = new System.Windows.Forms.Padding(2);
            this.gc_DMSP.Name = "gc_DMSP";
            this.gc_DMSP.Size = new System.Drawing.Size(469, 168);
            this.gc_DMSP.TabIndex = 78;
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
            // txt_maSP
            // 
            this.txt_maSP.Location = new System.Drawing.Point(86, 25);
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.ReadOnly = true;
            this.txt_maSP.Size = new System.Drawing.Size(120, 21);
            this.txt_maSP.TabIndex = 51;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(292, 27);
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
            this.label5.Location = new System.Drawing.Point(232, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Thành tiền:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Đơn giá:";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(407, 419);
            this.lb_thongbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 13);
            this.lb_thongbao.TabIndex = 88;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // groupControl_DDH
            // 
            this.groupControl_DDH.Controls.Add(this.cbb_KH);
            this.groupControl_DDH.Controls.Add(this.cbb_NV);
            this.groupControl_DDH.Controls.Add(this.label2);
            this.groupControl_DDH.Controls.Add(this.txt_maHD);
            this.groupControl_DDH.Controls.Add(this.label3);
            this.groupControl_DDH.Controls.Add(this.label4);
            this.groupControl_DDH.Location = new System.Drawing.Point(25, 253);
            this.groupControl_DDH.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl_DDH.Name = "groupControl_DDH";
            this.groupControl_DDH.Size = new System.Drawing.Size(469, 171);
            this.groupControl_DDH.TabIndex = 81;
            this.groupControl_DDH.Text = "Thông tin hóa đơn bán lẻ";
            // 
            // cbb_KH
            // 
            this.cbb_KH.Enabled = false;
            this.cbb_KH.FormattingEnabled = true;
            this.cbb_KH.Location = new System.Drawing.Point(143, 106);
            this.cbb_KH.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_KH.Name = "cbb_KH";
            this.cbb_KH.Size = new System.Drawing.Size(183, 21);
            this.cbb_KH.TabIndex = 47;
            // 
            // cbb_NV
            // 
            this.cbb_NV.Enabled = false;
            this.cbb_NV.FormattingEnabled = true;
            this.cbb_NV.Location = new System.Drawing.Point(143, 76);
            this.cbb_NV.Name = "cbb_NV";
            this.cbb_NV.Size = new System.Drawing.Size(183, 21);
            this.cbb_NV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng:";
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(143, 43);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.ReadOnly = true;
            this.txt_maHD.Size = new System.Drawing.Size(183, 21);
            this.txt_maHD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên nhân viên lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã phiếu:";
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
            this.groupControl_SanPham.Controls.Add(this.label10);
            this.groupControl_SanPham.Controls.Add(this.label1);
            this.groupControl_SanPham.Controls.Add(this.label5);
            this.groupControl_SanPham.Controls.Add(this.label6);
            this.groupControl_SanPham.Controls.Add(this.label7);
            this.groupControl_SanPham.Controls.Add(this.label8);
            this.groupControl_SanPham.Controls.Add(this.label9);
            this.groupControl_SanPham.Location = new System.Drawing.Point(522, 60);
            this.groupControl_SanPham.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl_SanPham.Name = "groupControl_SanPham";
            this.groupControl_SanPham.Size = new System.Drawing.Size(467, 171);
            this.groupControl_SanPham.TabIndex = 79;
            this.groupControl_SanPham.Text = "Thông tin sản phẩm";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(173, 134);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(121, 23);
            this.btn_CapNhat.TabIndex = 58;
            this.btn_CapNhat.Text = "Cập nhật sản phẩm";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(309, 134);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(116, 23);
            this.btnXoaSP.TabIndex = 56;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(36, 134);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(116, 23);
            this.btnThemSP.TabIndex = 56;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // dtpNgayLap_HD
            // 
            this.dtpNgayLap_HD.Location = new System.Drawing.Point(435, 30);
            this.dtpNgayLap_HD.Name = "dtpNgayLap_HD";
            this.dtpNgayLap_HD.Size = new System.Drawing.Size(187, 20);
            this.dtpNgayLap_HD.TabIndex = 86;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(380, 34);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(52, 13);
            this.label78.TabIndex = 85;
            this.label78.Text = "Ngày lập:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.Red;
            this.label79.Location = new System.Drawing.Point(393, 2);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(150, 16);
            this.label79.TabIndex = 84;
            this.label79.Text = "SỬA HÓA ĐƠN BÁN LẺ";
            // 
            // txtTongthanhtoan
            // 
            this.txtTongthanhtoan.Location = new System.Drawing.Point(879, 412);
            this.txtTongthanhtoan.Name = "txtTongthanhtoan";
            this.txtTongthanhtoan.Size = new System.Drawing.Size(110, 20);
            this.txtTongthanhtoan.TabIndex = 82;
            // 
            // label_tongthanhtoan
            // 
            this.label_tongthanhtoan.AutoSize = true;
            this.label_tongthanhtoan.Location = new System.Drawing.Point(787, 416);
            this.label_tongthanhtoan.Name = "label_tongthanhtoan";
            this.label_tongthanhtoan.Size = new System.Drawing.Size(89, 13);
            this.label_tongthanhtoan.TabIndex = 83;
            this.label_tongthanhtoan.Text = "Tổng thanh toán:";
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(689, 412);
            this.btn_HoanTat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(83, 21);
            this.btn_HoanTat.TabIndex = 89;
            this.btn_HoanTat.Text = "Hoàn Tất HD";
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 426);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 87;
            // 
            // gc_CTHD
            // 
            this.gc_CTHD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            gridLevelNode1.RelationName = "Level1";
            this.gc_CTHD.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_CTHD.Location = new System.Drawing.Point(522, 242);
            this.gc_CTHD.MainView = this.gv_CTHD;
            this.gc_CTHD.Margin = new System.Windows.Forms.Padding(2);
            this.gc_CTHD.Name = "gc_CTHD";
            this.gc_CTHD.Size = new System.Drawing.Size(467, 168);
            this.gc_CTHD.TabIndex = 90;
            this.gc_CTHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTHD});
            // 
            // gv_CTHD
            // 
            this.gv_CTHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_CTHD.GridControl = this.gc_CTHD;
            this.gv_CTHD.Name = "gv_CTHD";
            this.gv_CTHD.OptionsBehavior.Editable = false;
            this.gv_CTHD.OptionsFind.AlwaysVisible = true;
            this.gv_CTHD.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm ...";
            this.gv_CTHD.OptionsFind.SearchInPreview = true;
            this.gv_CTHD.OptionsView.ShowGroupPanel = false;
            this.gv_CTHD.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_CTHD.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_CTHD_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã hóa đơn";
            this.gridColumn1.FieldName = "MaHD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
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
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên sản phẩm";
            this.gridColumn3.FieldName = "TenSP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn giá";
            this.gridColumn4.FieldName = "DonGia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Lượng";
            this.gridColumn5.FieldName = "SoLuong";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Thành tiền";
            this.gridColumn6.FieldName = "ThanhTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(400, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "(vnđ)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(400, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "(vnđ)";
            // 
            // UC_SuaHoaDonLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_CTHD);
            this.Controls.Add(this.gc_DMSP);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.groupControl_DDH);
            this.Controls.Add(this.groupControl_SanPham);
            this.Controls.Add(this.dtpNgayLap_HD);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.txtTongthanhtoan);
            this.Controls.Add(this.label_tongthanhtoan);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.label15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_SuaHoaDonLe";
            this.Size = new System.Drawing.Size(1361, 455);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDonDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_DDH)).EndInit();
            this.groupControl_DDH.ResumeLayout(false);
            this.groupControl_DDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SanPham)).EndInit();
            this.groupControl_SanPham.ResumeLayout(false);
            this.groupControl_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txt_SL;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DMSP;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        public DevExpress.XtraGrid.GridControl gc_DMSP;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SanPhamDataSet sanPhamDataSet;
        public System.Windows.Forms.TextBox txt_maSP;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource cTDonDatHangBindingSource;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private CTDDH cTDDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_thongbao;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.GroupControl groupControl_DDH;
        private System.Windows.Forms.ComboBox cbb_KH;
        private System.Windows.Forms.ComboBox cbb_NV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl_SanPham;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private System.Windows.Forms.DateTimePicker dtpNgayLap_HD;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox txtTongthanhtoan;
        private System.Windows.Forms.Label label_tongthanhtoan;
        private DevExpress.XtraEditors.SimpleButton btn_HoanTat;
        private SanPhamDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource quanLiDataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gc_CTHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTHD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
    }
}
