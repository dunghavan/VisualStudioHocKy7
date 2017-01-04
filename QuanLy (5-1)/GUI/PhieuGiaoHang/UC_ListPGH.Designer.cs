namespace GUI
{
    partial class UC_ListPGH
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
            this.gc_PGH = new DevExpress.XtraGrid.GridControl();
            this.donDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_DSPGH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPGH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSPGH)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_PGH
            // 
            this.gc_PGH.DataSource = this.donDatHangBindingSource;
            this.gc_PGH.Location = new System.Drawing.Point(105, 129);
            this.gc_PGH.MainView = this.gv_DSPGH;
            this.gc_PGH.Name = "gc_PGH";
            this.gc_PGH.Size = new System.Drawing.Size(1112, 458);
            this.gc_PGH.TabIndex = 4;
            this.gc_PGH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DSPGH});
            this.gc_PGH.Load += new System.EventHandler(this.gc_PGH_Load);
            // 
            // donDatHangBindingSource
            // 
            this.donDatHangBindingSource.DataMember = "DonDatHang";
            // 
            // gv_DSPGH
            // 
            this.gv_DSPGH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPGH,
            this.MaDDH,
            this.NgayLap,
            this.colMaKH,
            this.colMaNV,
            this.colTongTien});
            this.gv_DSPGH.GridControl = this.gc_PGH;
            this.gv_DSPGH.Name = "gv_DSPGH";
            this.gv_DSPGH.OptionsBehavior.Editable = false;
            this.gv_DSPGH.OptionsBehavior.ReadOnly = true;
            this.gv_DSPGH.OptionsFind.AlwaysVisible = true;
            this.gv_DSPGH.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm";
            this.gv_DSPGH.OptionsView.ShowGroupPanel = false;
            this.gv_DSPGH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_DSPGH_RowClick);
            // 
            // MaPGH
            // 
            this.MaPGH.Caption = "Mã PGH";
            this.MaPGH.FieldName = "MaPGH";
            this.MaPGH.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.MaPGH.Name = "MaPGH";
            this.MaPGH.Visible = true;
            this.MaPGH.VisibleIndex = 0;
            this.MaPGH.Width = 148;
            // 
            // MaDDH
            // 
            this.MaDDH.Caption = "Mã DDH";
            this.MaDDH.FieldName = "MaDDH";
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.Visible = true;
            this.MaDDH.VisibleIndex = 1;
            this.MaDDH.Width = 137;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày Lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 4;
            this.NgayLap.Width = 143;
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Tên khách hàng";
            this.colMaKH.FieldName = "HoTen";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 3;
            this.colMaKH.Width = 172;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Tên Nhân Viên";
            this.colMaNV.FieldName = "HoTen";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            this.colMaNV.Width = 172;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 5;
            this.colTongTien.Width = 190;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(453, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(494, 85);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "DANH SÁCH PHIẾU GIAO HÀNG";
            // 
            // UC_ListPGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gc_PGH);
            this.Controls.Add(this.labelControl1);
            this.Name = "UC_ListPGH";
            this.Size = new System.Drawing.Size(2042, 700);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSPGH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gc_PGH;
        private System.Windows.Forms.BindingSource donDatHangBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView gv_DSPGH;
        private DevExpress.XtraGrid.Columns.GridColumn MaPGH;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDDH;
    }
}
