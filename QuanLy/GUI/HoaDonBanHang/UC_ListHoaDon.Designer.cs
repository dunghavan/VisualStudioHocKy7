namespace GUI
{
    partial class UC_ListHoaDon
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
            this.gridControl_HD = new DevExpress.XtraGrid.GridControl();
            this.donDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_DSHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_HD
            // 
            this.gridControl_HD.DataSource = this.donDatHangBindingSource;
            this.gridControl_HD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl_HD.Location = new System.Drawing.Point(70, 84);
            this.gridControl_HD.MainView = this.gv_DSHD;
            this.gridControl_HD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl_HD.Name = "gridControl_HD";
            this.gridControl_HD.Size = new System.Drawing.Size(741, 298);
            this.gridControl_HD.TabIndex = 4;
            this.gridControl_HD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DSHD});
            this.gridControl_HD.Load += new System.EventHandler(this.gridControl_HD_Load);
            // 
            // donDatHangBindingSource
            // 
            this.donDatHangBindingSource.DataMember = "DonDatHang";
            // 
            // gv_DSHD
            // 
            this.gv_DSHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHD,
            this.NgayLap,
            this.colMaKH,
            this.colMaNV,
            this.colTongTien});
            this.gv_DSHD.GridControl = this.gridControl_HD;
            this.gv_DSHD.Name = "gv_DSHD";
            this.gv_DSHD.OptionsBehavior.ReadOnly = true;
            this.gv_DSHD.OptionsFind.AlwaysVisible = true;
            this.gv_DSHD.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm";
            this.gv_DSHD.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_DSHD_RowClick);
            // 
            // MaHD
            // 
            this.MaHD.Caption = "Mã hóa đơn";
            this.MaHD.FieldName = "MaDDH";
            this.MaHD.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = true;
            this.MaHD.VisibleIndex = 0;
            this.MaHD.Width = 150;
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
            // colTongTien
            // 
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            this.colTongTien.Width = 206;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(725, 396);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(80, 28);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(619, 396);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(80, 28);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(302, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(289, 55);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // UC_ListHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_HD);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_ListHoaDon";
            this.Size = new System.Drawing.Size(1361, 455);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl_HD;
        private System.Windows.Forms.BindingSource donDatHangBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView gv_DSHD;
        private DevExpress.XtraGrid.Columns.GridColumn MaHD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
