namespace Presentation_Tier
{
    partial class UserControl_QLUser
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_QLUser));
            this.gridControl_DSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_findNamSinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBox_findMaLoaiNV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label_loaiNV = new DevExpress.XtraEditors.LabelControl();
            this.label_namSinh = new DevExpress.XtraEditors.LabelControl();
            this.label_hoTen = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_findHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label_maNV = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_findMaNV = new DevExpress.XtraEditors.TextEdit();
            this.btn_reset = new DevExpress.XtraEditors.SimpleButton();
            this.label_notification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_findNamSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_findMaLoaiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_findHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_findMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSNhanVien
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSNhanVien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSNhanVien.Location = new System.Drawing.Point(46, 120);
            this.gridControl_DSNhanVien.MainView = this.gridView_DSNhanVien;
            this.gridControl_DSNhanVien.Name = "gridControl_DSNhanVien";
            this.gridControl_DSNhanVien.Size = new System.Drawing.Size(1082, 287);
            this.gridControl_DSNhanVien.TabIndex = 1;
            this.gridControl_DSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSNhanVien});
            this.gridControl_DSNhanVien.Load += new System.EventHandler(this.gridControl_DSNhanVien_Load);
            // 
            // gridView_DSNhanVien
            // 
            this.gridView_DSNhanVien.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.GridControl = this.gridControl_DSNhanVien;
            this.gridView_DSNhanVien.Name = "gridView_DSNhanVien";
            this.gridView_DSNhanVien.OptionsBehavior.Editable = false;
            this.gridView_DSNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSNhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSNhanVien_RowClick);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Appearance.Options.UseFont = true;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(652, 47);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(108, 38);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // comboBox_findNamSinh
            // 
            this.comboBox_findNamSinh.Location = new System.Drawing.Point(129, 67);
            this.comboBox_findNamSinh.Name = "comboBox_findNamSinh";
            this.comboBox_findNamSinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox_findNamSinh.Size = new System.Drawing.Size(86, 20);
            this.comboBox_findNamSinh.TabIndex = 2;
            // 
            // comboBox_findMaLoaiNV
            // 
            this.comboBox_findMaLoaiNV.Location = new System.Drawing.Point(476, 68);
            this.comboBox_findMaLoaiNV.Name = "comboBox_findMaLoaiNV";
            this.comboBox_findMaLoaiNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox_findMaLoaiNV.Size = new System.Drawing.Size(88, 20);
            this.comboBox_findMaLoaiNV.TabIndex = 3;
            // 
            // label_loaiNV
            // 
            this.label_loaiNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loaiNV.Location = new System.Drawing.Point(354, 71);
            this.label_loaiNV.Name = "label_loaiNV";
            this.label_loaiNV.Size = new System.Drawing.Size(111, 16);
            this.label_loaiNV.TabIndex = 30;
            this.label_loaiNV.Text = "Mã Loại Nhân Viên:";
            // 
            // label_namSinh
            // 
            this.label_namSinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namSinh.Location = new System.Drawing.Point(46, 69);
            this.label_namSinh.Name = "label_namSinh";
            this.label_namSinh.Size = new System.Drawing.Size(60, 16);
            this.label_namSinh.TabIndex = 29;
            this.label_namSinh.Text = "Năm Sinh:";
            // 
            // label_hoTen
            // 
            this.label_hoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoTen.Location = new System.Drawing.Point(46, 37);
            this.label_hoTen.Name = "label_hoTen";
            this.label_hoTen.Size = new System.Drawing.Size(46, 16);
            this.label_hoTen.TabIndex = 28;
            this.label_hoTen.Text = "Họ Tên:";
            // 
            // textEdit_findHoTen
            // 
            this.textEdit_findHoTen.Location = new System.Drawing.Point(129, 36);
            this.textEdit_findHoTen.Name = "textEdit_findHoTen";
            this.textEdit_findHoTen.Size = new System.Drawing.Size(161, 20);
            this.textEdit_findHoTen.TabIndex = 0;
            // 
            // label_maNV
            // 
            this.label_maNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maNV.Location = new System.Drawing.Point(383, 37);
            this.label_maNV.Name = "label_maNV";
            this.label_maNV.Size = new System.Drawing.Size(84, 16);
            this.label_maNV.TabIndex = 31;
            this.label_maNV.Text = "Mã Nhân Viên:";
            // 
            // textEdit_findMaNV
            // 
            this.textEdit_findMaNV.Location = new System.Drawing.Point(476, 36);
            this.textEdit_findMaNV.Name = "textEdit_findMaNV";
            this.textEdit_findMaNV.Size = new System.Drawing.Size(161, 20);
            this.textEdit_findMaNV.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Appearance.Options.UseFont = true;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.Location = new System.Drawing.Point(806, 47);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(108, 38);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Location = new System.Drawing.Point(452, 417);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 13);
            this.label_notification.TabIndex = 32;
            // 
            // UserControl_QLUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.comboBox_findNamSinh);
            this.Controls.Add(this.comboBox_findMaLoaiNV);
            this.Controls.Add(this.label_loaiNV);
            this.Controls.Add(this.label_namSinh);
            this.Controls.Add(this.label_hoTen);
            this.Controls.Add(this.textEdit_findHoTen);
            this.Controls.Add(this.label_maNV);
            this.Controls.Add(this.textEdit_findMaNV);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.gridControl_DSNhanVien);
            this.Name = "UserControl_QLUser";
            this.Size = new System.Drawing.Size(1298, 618);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_findNamSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_findMaLoaiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_findHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_findMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        public DevExpress.XtraGrid.GridControl gridControl_DSNhanVien;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSNhanVien;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox_findNamSinh;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox_findMaLoaiNV;
        private DevExpress.XtraEditors.LabelControl label_loaiNV;
        private DevExpress.XtraEditors.LabelControl label_namSinh;
        private DevExpress.XtraEditors.LabelControl label_hoTen;
        private DevExpress.XtraEditors.TextEdit textEdit_findHoTen;
        private DevExpress.XtraEditors.LabelControl label_maNV;
        private DevExpress.XtraEditors.TextEdit textEdit_findMaNV;
        private DevExpress.XtraEditors.SimpleButton btn_reset;
        public System.Windows.Forms.Label label_notification;
    }
}
