namespace GUI
{
    partial class UC_ListDonDatHang
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
            this.gridControl_DDH = new DevExpress.XtraGrid.GridControl();
            this.donDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.gv_DSDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaoDuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();

            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.gv_DSDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DDH
            // 
            this.gridControl_DDH.DataSource = this.donDatHangBindingSource;
            this.gridControl_DDH.Location = new System.Drawing.Point(67, 138);
            this.gridControl_DDH.MainView = this.gv_DSDDH;
            this.gridControl_DDH.Name = "gridControl_DDH";
            this.gridControl_DDH.Size = new System.Drawing.Size(1111, 458);
            this.gridControl_DDH.TabIndex = 0;
            this.gridControl_DDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DSDDH});
            this.gridControl_DDH.Load += new System.EventHandler(this.gridControl_DDH_Load);
            // 
            // donDatHangBindingSource
            // 
            this.donDatHangBindingSource.DataMember = "DonDatHang";

            // 
            // quanLiDataSet4
            // 


            // 
            // gv_DSDDH
            // 
            this.gv_DSDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDDH,
            this.NgayLap,
            this.colMaKH,
            this.colMaNV,
            this.colNgayGiaoDuKien,
            this.colTongTien});
            this.gv_DSDDH.GridControl = this.gridControl_DDH;
            this.gv_DSDDH.Name = "gv_DSDDH";
            this.gv_DSDDH.OptionsBehavior.ReadOnly = true;
            this.gv_DSDDH.OptionsFind.AlwaysVisible = true;
            this.gv_DSDDH.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm";
            this.gv_DSDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_DSDDH_RowClick);
            // 
            // MaDDH
            // 
            this.MaDDH.Caption = "Mã đơn đặt hàng";
            this.MaDDH.FieldName = "MaDDH";
            this.MaDDH.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.Visible = true;
            this.MaDDH.VisibleIndex = 0;
            this.MaDDH.Width = 150;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày Lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 3;
            this.NgayLap.Width = 159;
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Tên khách hàng";
            this.colMaKH.FieldName = "HoTen";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 2;
            this.colMaKH.Width = 191;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Tên Nhân Viên";
            this.colMaNV.FieldName = "HoTen";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 1;
            this.colMaNV.Width = 191;
            // 
            // colNgayGiaoDuKien
            // 
            this.colNgayGiaoDuKien.FieldName = "NgayGiaoDuKien";
            this.colNgayGiaoDuKien.Name = "colNgayGiaoDuKien";
            this.colNgayGiaoDuKien.Visible = true;
            this.colNgayGiaoDuKien.VisibleIndex = 4;
            this.colNgayGiaoDuKien.Width = 191;
            // 
            // colTongTien
            // 
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 5;
            this.colTongTien.Width = 206;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(415, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(434, 84);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG";
            // 
            // donDatHangTableAdapter
            // 

            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(891, 617);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 43);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(1049, 617);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 43);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // UC_ListDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl_DDH);
            this.Name = "UC_ListDonDatHang";
            this.Size = new System.Drawing.Size(1320, 677);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.gv_DSDDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDDH;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private System.Windows.Forms.BindingSource donDatHangBindingSource;


        public DevExpress.XtraGrid.GridControl gridControl_DDH;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        public DevExpress.XtraGrid.Views.Grid.GridView gv_DSDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaoDuKien;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
    }
}
