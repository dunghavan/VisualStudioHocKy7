namespace GUI
{
    partial class UC_HoaDonSi
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
            this.gv_DSHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl_ThemHD = new DevExpress.XtraEditors.GroupControl();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV2 = new System.Windows.Forms.TextBox();
            this.cbb_MaDDH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayLap2 = new System.Windows.Forms.DateTimePicker();
            this.cbb_KH2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_maHD2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemHD = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_KH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ChietKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.cTDDH = new GUI.CTDDH();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_HoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HuyHD = new DevExpress.XtraEditors.SimpleButton();
            this.label_NameGridView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThemHD)).BeginInit();
            this.groupControl_ThemHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_HD
            // 
            this.gridControl_HD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl_HD.Location = new System.Drawing.Point(266, 162);
            this.gridControl_HD.MainView = this.gv_DSHD;
            this.gridControl_HD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl_HD.Name = "gridControl_HD";
            this.gridControl_HD.Size = new System.Drawing.Size(741, 258);
            this.gridControl_HD.TabIndex = 4;
            this.gridControl_HD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DSHD});
            // 
            // gv_DSHD
            // 
            this.gv_DSHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_DSHD.GridControl = this.gridControl_HD;
            this.gv_DSHD.Name = "gv_DSHD";
            this.gv_DSHD.OptionsBehavior.ReadOnly = true;
            this.gv_DSHD.OptionsFind.AlwaysVisible = true;
            this.gv_DSHD.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm";
            this.gv_DSHD.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sản phẩm";
            this.gridColumn1.FieldName = "MaSP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "TenSP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn giá";
            this.gridColumn3.FieldName = "DonGia";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số lượng";
            this.gridColumn4.FieldName = "SoLuong";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thành tiền";
            this.gridColumn5.FieldName = "ThanhTien";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // donDatHangBindingSource
            // 
            this.donDatHangBindingSource.DataMember = "DonDatHang";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(558, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(242, 35);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "LẬP HÓA ĐƠN BÁN SỈ";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Location = new System.Drawing.Point(765, 57);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(196, 20);
            this.dtp_NgayLap.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày lập:";
            // 
            // groupControl_ThemHD
            // 
            this.groupControl_ThemHD.Controls.Add(this.txt_TenNV2);
            this.groupControl_ThemHD.Controls.Add(this.cbb_MaDDH);
            this.groupControl_ThemHD.Controls.Add(this.label5);
            this.groupControl_ThemHD.Controls.Add(this.dtp_NgayLap2);
            this.groupControl_ThemHD.Controls.Add(this.cbb_KH2);
            this.groupControl_ThemHD.Controls.Add(this.label4);
            this.groupControl_ThemHD.Controls.Add(this.label12);
            this.groupControl_ThemHD.Controls.Add(this.txt_maHD2);
            this.groupControl_ThemHD.Controls.Add(this.label13);
            this.groupControl_ThemHD.Controls.Add(this.label14);
            this.groupControl_ThemHD.Location = new System.Drawing.Point(494, 57);
            this.groupControl_ThemHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl_ThemHD.Name = "groupControl_ThemHD";
            this.groupControl_ThemHD.Size = new System.Drawing.Size(381, 187);
            this.groupControl_ThemHD.TabIndex = 60;
            this.groupControl_ThemHD.Text = "Thông tin hóa đơn bán sỉ";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Enabled = false;
            this.txt_TenNV.Location = new System.Drawing.Point(471, 53);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.ReadOnly = true;
            this.txt_TenNV.Size = new System.Drawing.Size(183, 20);
            this.txt_TenNV.TabIndex = 67;
            // 
            // txt_TenNV2
            // 
            this.txt_TenNV2.Enabled = false;
            this.txt_TenNV2.Location = new System.Drawing.Point(133, 56);
            this.txt_TenNV2.Name = "txt_TenNV2";
            this.txt_TenNV2.Size = new System.Drawing.Size(183, 21);
            this.txt_TenNV2.TabIndex = 60;
            // 
            // cbb_MaDDH
            // 
            this.cbb_MaDDH.FormattingEnabled = true;
            this.cbb_MaDDH.Location = new System.Drawing.Point(133, 117);
            this.cbb_MaDDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_MaDDH.Name = "cbb_MaDDH";
            this.cbb_MaDDH.Size = new System.Drawing.Size(183, 21);
            this.cbb_MaDDH.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mã đơn đặt hàng:";
            // 
            // dtp_NgayLap2
            // 
            this.dtp_NgayLap2.Location = new System.Drawing.Point(129, 149);
            this.dtp_NgayLap2.Name = "dtp_NgayLap2";
            this.dtp_NgayLap2.Size = new System.Drawing.Size(187, 21);
            this.dtp_NgayLap2.TabIndex = 57;
            // 
            // cbb_KH2
            // 
            this.cbb_KH2.FormattingEnabled = true;
            this.cbb_KH2.Location = new System.Drawing.Point(133, 88);
            this.cbb_KH2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_KH2.Name = "cbb_KH2";
            this.cbb_KH2.Size = new System.Drawing.Size(183, 21);
            this.cbb_KH2.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ngày lập:\r\n\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tên khách hàng:";
            // 
            // txt_maHD2
            // 
            this.txt_maHD2.Location = new System.Drawing.Point(133, 25);
            this.txt_maHD2.Name = "txt_maHD2";
            this.txt_maHD2.Size = new System.Drawing.Size(183, 21);
            this.txt_maHD2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tên nhân viên lập:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Mã phiếu:";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(494, 289);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(135, 23);
            this.btn_Huy.TabIndex = 62;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.Location = new System.Drawing.Point(689, 289);
            this.btn_ThemHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(135, 23);
            this.btn_ThemHD.TabIndex = 61;
            this.btn_ThemHD.Text = "Thêm HD";
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // cbb_KH
            // 
            this.cbb_KH.FormattingEnabled = true;
            this.cbb_KH.Location = new System.Drawing.Point(471, 88);
            this.cbb_KH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_KH.Name = "cbb_KH";
            this.cbb_KH.Size = new System.Drawing.Size(183, 21);
            this.cbb_KH.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Chiết khấu:";
            // 
            // txt_ChietKhau
            // 
            this.txt_ChietKhau.Enabled = false;
            this.txt_ChietKhau.Location = new System.Drawing.Point(765, 88);
            this.txt_ChietKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ChietKhau.Name = "txt_ChietKhau";
            this.txt_ChietKhau.Size = new System.Drawing.Size(92, 20);
            this.txt_ChietKhau.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 435);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(798, 432);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(129, 20);
            this.txt_TongTien.TabIndex = 64;
            // 
            // cTDDH
            // 
            this.cTDDH.DataSetName = "QuanLiDataSet2";
            this.cTDDH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataSource = this.cTDDH;
            this.cTDDHBindingSource.Position = 0;
            // 
            // cTDDHBindingSource1
            // 
            this.cTDDHBindingSource1.DataSource = this.cTDDH;
            this.cTDDHBindingSource1.Position = 0;
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.Location = new System.Drawing.Point(343, 432);
            this.btn_HoanTat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(92, 21);
            this.btn_HoanTat.TabIndex = 65;
            this.btn_HoanTat.Text = "Hoàn tất HĐ";
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_HuyHD
            // 
            this.btn_HuyHD.Location = new System.Drawing.Point(482, 431);
            this.btn_HuyHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_HuyHD.Name = "btn_HuyHD";
            this.btn_HuyHD.Size = new System.Drawing.Size(92, 21);
            this.btn_HuyHD.TabIndex = 66;
            this.btn_HuyHD.Text = "Hủy HĐ";
            this.btn_HuyHD.Click += new System.EventHandler(this.btn_HuyHD_Click);
            // 
            // label_NameGridView
            // 
            this.label_NameGridView.AutoSize = true;
            this.label_NameGridView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameGridView.Location = new System.Drawing.Point(263, 145);
            this.label_NameGridView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NameGridView.Name = "label_NameGridView";
            this.label_NameGridView.Size = new System.Drawing.Size(190, 16);
            this.label_NameGridView.TabIndex = 10;
            this.label_NameGridView.Text = "Chi tiết đơn đặt hàng tương ứng";
            // 
            // UC_HoaDonSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.btn_HuyHD);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_ChietKhau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_KH);
            this.Controls.Add(this.groupControl_ThemHD);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_ThemHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_NameGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_NgayLap);
            this.Controls.Add(this.gridControl_HD);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_HoaDonSi";
            this.Size = new System.Drawing.Size(1361, 455);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThemHD)).EndInit();
            this.groupControl_ThemHD.ResumeLayout(false);
            this.groupControl_ThemHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl_HD;
        private System.Windows.Forms.BindingSource donDatHangBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView gv_DSHD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl groupControl_ThemHD;
        private System.Windows.Forms.ComboBox cbb_MaDDH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap2;
        private System.Windows.Forms.ComboBox cbb_KH2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_maHD2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        private DevExpress.XtraEditors.SimpleButton btn_ThemHD;
        private System.Windows.Forms.ComboBox cbb_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ChietKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private CTDDH cTDDH;
        private System.Windows.Forms.BindingSource cTDDHBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_HoanTat;
        private System.Windows.Forms.TextBox txt_TenNV2;
        private DevExpress.XtraEditors.SimpleButton btn_HuyHD;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Label label_NameGridView;
    }
}
