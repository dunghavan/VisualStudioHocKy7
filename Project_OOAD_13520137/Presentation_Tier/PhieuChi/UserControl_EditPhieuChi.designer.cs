namespace Presentation_Tier
{
    partial class UserControl_EditPhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_EditPhieuChi));
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl_EditPhieuChi = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit_ngayLap = new DevExpress.XtraEditors.DateEdit();
            this.label_maNV = new DevExpress.XtraEditors.LabelControl();
            this.comboBox_maNCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit_maNV = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_maPhieuChi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_soTienChi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_soTienNo = new DevExpress.XtraEditors.TextEdit();
            this.label_mNCC = new DevExpress.XtraEditors.LabelControl();
            this.label_ngayLap = new DevExpress.XtraEditors.LabelControl();
            this.label_soTienChi = new DevExpress.XtraEditors.LabelControl();
            this.label_maPhieuChi = new DevExpress.XtraEditors.LabelControl();
            this.label_soTienNo = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_EditPhieuChi)).BeginInit();
            this.groupControl_EditPhieuChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_maNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_maNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_maPhieuChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_soTienChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_soTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(866, 282);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(108, 38);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1011, 282);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 38);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Hủy";
            this.simpleButton1.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // groupControl_EditPhieuChi
            // 
            this.groupControl_EditPhieuChi.Controls.Add(this.comboBox_maNCC);
            this.groupControl_EditPhieuChi.Controls.Add(this.textEdit_soTienChi);
            this.groupControl_EditPhieuChi.Controls.Add(this.textEdit_soTienNo);
            this.groupControl_EditPhieuChi.Controls.Add(this.label_mNCC);
            this.groupControl_EditPhieuChi.Controls.Add(this.label_soTienChi);
            this.groupControl_EditPhieuChi.Controls.Add(this.label_soTienNo);
            this.groupControl_EditPhieuChi.Location = new System.Drawing.Point(415, 37);
            this.groupControl_EditPhieuChi.Name = "groupControl_EditPhieuChi";
            this.groupControl_EditPhieuChi.Size = new System.Drawing.Size(371, 283);
            this.groupControl_EditPhieuChi.TabIndex = 25;
            // 
            // dateEdit_ngayLap
            // 
            this.dateEdit_ngayLap.EditValue = new System.DateTime(2016, 12, 10, 0, 0, 0, 0);
            this.dateEdit_ngayLap.Enabled = false;
            this.dateEdit_ngayLap.Location = new System.Drawing.Point(154, 119);
            this.dateEdit_ngayLap.Name = "dateEdit_ngayLap";
            this.dateEdit_ngayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_ngayLap.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_ngayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ngayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ngayLap.Properties.MaxValue = new System.DateTime(2016, 12, 10, 0, 0, 0, 0);
            this.dateEdit_ngayLap.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateEdit_ngayLap.Size = new System.Drawing.Size(161, 26);
            this.dateEdit_ngayLap.TabIndex = 2;
            // 
            // label_maNV
            // 
            this.label_maNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maNV.Appearance.Options.UseFont = true;
            this.label_maNV.Location = new System.Drawing.Point(32, 192);
            this.label_maNV.Name = "label_maNV";
            this.label_maNV.Size = new System.Drawing.Size(104, 19);
            this.label_maNV.TabIndex = 21;
            this.label_maNV.Text = "Mã Nhân Viên:";
            // 
            // comboBox_maNCC
            // 
            this.comboBox_maNCC.AllowDrop = true;
            this.comboBox_maNCC.Location = new System.Drawing.Point(142, 48);
            this.comboBox_maNCC.Name = "comboBox_maNCC";
            this.comboBox_maNCC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maNCC.Properties.Appearance.Options.UseFont = true;
            this.comboBox_maNCC.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.comboBox_maNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBox_maNCC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBox_maNCC.Size = new System.Drawing.Size(161, 26);
            this.comboBox_maNCC.TabIndex = 4;
            // 
            // textEdit_maNV
            // 
            this.textEdit_maNV.Enabled = false;
            this.textEdit_maNV.Location = new System.Drawing.Point(154, 191);
            this.textEdit_maNV.Name = "textEdit_maNV";
            this.textEdit_maNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_maNV.Properties.Appearance.Options.UseFont = true;
            this.textEdit_maNV.Size = new System.Drawing.Size(161, 26);
            this.textEdit_maNV.TabIndex = 3;
            // 
            // textEdit_maPhieuChi
            // 
            this.textEdit_maPhieuChi.Enabled = false;
            this.textEdit_maPhieuChi.Location = new System.Drawing.Point(154, 48);
            this.textEdit_maPhieuChi.Name = "textEdit_maPhieuChi";
            this.textEdit_maPhieuChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_maPhieuChi.Properties.Appearance.Options.UseFont = true;
            this.textEdit_maPhieuChi.Properties.MaxLength = 10;
            this.textEdit_maPhieuChi.Size = new System.Drawing.Size(161, 26);
            this.textEdit_maPhieuChi.TabIndex = 1;
            // 
            // textEdit_soTienChi
            // 
            this.textEdit_soTienChi.EditValue = "0";
            this.textEdit_soTienChi.Location = new System.Drawing.Point(142, 189);
            this.textEdit_soTienChi.Name = "textEdit_soTienChi";
            this.textEdit_soTienChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_soTienChi.Properties.Appearance.Options.UseFont = true;
            this.textEdit_soTienChi.Size = new System.Drawing.Size(161, 26);
            this.textEdit_soTienChi.TabIndex = 6;
            // 
            // textEdit_soTienNo
            // 
            this.textEdit_soTienNo.EditValue = "0";
            this.textEdit_soTienNo.Location = new System.Drawing.Point(142, 119);
            this.textEdit_soTienNo.Name = "textEdit_soTienNo";
            this.textEdit_soTienNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_soTienNo.Properties.Appearance.Options.UseFont = true;
            this.textEdit_soTienNo.Size = new System.Drawing.Size(161, 26);
            this.textEdit_soTienNo.TabIndex = 5;
            // 
            // label_mNCC
            // 
            this.label_mNCC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mNCC.Appearance.Options.UseFont = true;
            this.label_mNCC.Location = new System.Drawing.Point(20, 49);
            this.label_mNCC.Name = "label_mNCC";
            this.label_mNCC.Size = new System.Drawing.Size(115, 19);
            this.label_mNCC.TabIndex = 14;
            this.label_mNCC.Text = "Mã Khách Hàng:";
            // 
            // label_ngayLap
            // 
            this.label_ngayLap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayLap.Appearance.Options.UseFont = true;
            this.label_ngayLap.Location = new System.Drawing.Point(32, 120);
            this.label_ngayLap.Name = "label_ngayLap";
            this.label_ngayLap.Size = new System.Drawing.Size(72, 19);
            this.label_ngayLap.TabIndex = 16;
            this.label_ngayLap.Text = "Ngày Lập:";
            // 
            // label_soTienChi
            // 
            this.label_soTienChi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soTienChi.Appearance.Options.UseFont = true;
            this.label_soTienChi.Location = new System.Drawing.Point(20, 192);
            this.label_soTienChi.Name = "label_soTienChi";
            this.label_soTienChi.Size = new System.Drawing.Size(93, 19);
            this.label_soTienChi.TabIndex = 17;
            this.label_soTienChi.Text = "Số Tiền Thu:";
            // 
            // label_maPhieuChi
            // 
            this.label_maPhieuChi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maPhieuChi.Appearance.Options.UseFont = true;
            this.label_maPhieuChi.Location = new System.Drawing.Point(32, 51);
            this.label_maPhieuChi.Name = "label_maPhieuChi";
            this.label_maPhieuChi.Size = new System.Drawing.Size(98, 19);
            this.label_maPhieuChi.TabIndex = 16;
            this.label_maPhieuChi.Text = "Mã Phiếu Chi:";
            // 
            // label_soTienNo
            // 
            this.label_soTienNo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soTienNo.Appearance.Options.UseFont = true;
            this.label_soTienNo.Location = new System.Drawing.Point(20, 122);
            this.label_soTienNo.Name = "label_soTienNo";
            this.label_soTienNo.Size = new System.Drawing.Size(85, 19);
            this.label_soTienNo.TabIndex = 17;
            this.label_soTienNo.Text = "Số Tiền Nợ:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateEdit_ngayLap);
            this.groupControl1.Controls.Add(this.textEdit_maNV);
            this.groupControl1.Controls.Add(this.label_maNV);
            this.groupControl1.Controls.Add(this.label_maPhieuChi);
            this.groupControl1.Controls.Add(this.label_ngayLap);
            this.groupControl1.Controls.Add(this.textEdit_maPhieuChi);
            this.groupControl1.Location = new System.Drawing.Point(20, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(371, 283);
            this.groupControl1.TabIndex = 26;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl_EditPhieuChi);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btn_Luu);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Location = new System.Drawing.Point(17, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1337, 355);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Chỉnh sửa thông tin phiếu chi";
            // 
            // UserControl_EditPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Name = "UserControl_EditPhieuChi";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_EditPhieuChi)).EndInit();
            this.groupControl_EditPhieuChi.ResumeLayout(false);
            this.groupControl_EditPhieuChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ngayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox_maNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_maNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_maPhieuChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_soTienChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_soTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl_EditPhieuChi;
        private DevExpress.XtraEditors.DateEdit dateEdit_ngayLap;
        private DevExpress.XtraEditors.LabelControl label_maNV;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox_maNCC;
        private DevExpress.XtraEditors.TextEdit textEdit_maNV;
        private DevExpress.XtraEditors.TextEdit textEdit_maPhieuChi;
        private DevExpress.XtraEditors.TextEdit textEdit_soTienChi;
        private DevExpress.XtraEditors.TextEdit textEdit_soTienNo;
        private DevExpress.XtraEditors.LabelControl label_mNCC;
        private DevExpress.XtraEditors.LabelControl label_ngayLap;
        private DevExpress.XtraEditors.LabelControl label_soTienChi;
        private DevExpress.XtraEditors.LabelControl label_maPhieuChi;
        private DevExpress.XtraEditors.LabelControl label_soTienNo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}
