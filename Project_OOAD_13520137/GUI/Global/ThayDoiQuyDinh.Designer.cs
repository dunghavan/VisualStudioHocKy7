namespace GUI
{
    partial class UserControl_ThayDoiQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_ThayDoiQuyDinh));
            this.label_slTonKhoToiThieu = new DevExpress.XtraEditors.LabelControl();
            this.label_soTienNoToiDa = new DevExpress.XtraEditors.LabelControl();
            this.label_chietKhau = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown_slTonKhoToiThieu = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_soTienNoToiDa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_chietKhau = new System.Windows.Forms.NumericUpDown();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.label_notification = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_slTonKhoToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soTienNoToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chietKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_slTonKhoToiThieu
            // 
            this.label_slTonKhoToiThieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slTonKhoToiThieu.Appearance.Options.UseFont = true;
            this.label_slTonKhoToiThieu.Location = new System.Drawing.Point(66, 42);
            this.label_slTonKhoToiThieu.Name = "label_slTonKhoToiThieu";
            this.label_slTonKhoToiThieu.Size = new System.Drawing.Size(192, 19);
            this.label_slTonKhoToiThieu.TabIndex = 0;
            this.label_slTonKhoToiThieu.Text = "Số lượng tồn kho tối thiểu:";
            // 
            // label_soTienNoToiDa
            // 
            this.label_soTienNoToiDa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soTienNoToiDa.Appearance.Options.UseFont = true;
            this.label_soTienNoToiDa.Location = new System.Drawing.Point(66, 80);
            this.label_soTienNoToiDa.Name = "label_soTienNoToiDa";
            this.label_soTienNoToiDa.Size = new System.Drawing.Size(166, 19);
            this.label_soTienNoToiDa.TabIndex = 1;
            this.label_soTienNoToiDa.Text = "Số tiền nợ tối đa (vnđ):";
            // 
            // label_chietKhau
            // 
            this.label_chietKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chietKhau.Appearance.Options.UseFont = true;
            this.label_chietKhau.Location = new System.Drawing.Point(66, 119);
            this.label_chietKhau.Name = "label_chietKhau";
            this.label_chietKhau.Size = new System.Drawing.Size(114, 19);
            this.label_chietKhau.TabIndex = 2;
            this.label_chietKhau.Text = "Chiết khấu (%):";
            // 
            // numericUpDown_slTonKhoToiThieu
            // 
            this.numericUpDown_slTonKhoToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_slTonKhoToiThieu.Location = new System.Drawing.Point(276, 40);
            this.numericUpDown_slTonKhoToiThieu.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_slTonKhoToiThieu.Name = "numericUpDown_slTonKhoToiThieu";
            this.numericUpDown_slTonKhoToiThieu.Size = new System.Drawing.Size(171, 26);
            this.numericUpDown_slTonKhoToiThieu.TabIndex = 0;
            this.numericUpDown_slTonKhoToiThieu.ValueChanged += new System.EventHandler(this.numericUpDown_slTonKhoToiThieu_ValueChanged);
            // 
            // numericUpDown_soTienNoToiDa
            // 
            this.numericUpDown_soTienNoToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_soTienNoToiDa.Location = new System.Drawing.Point(276, 78);
            this.numericUpDown_soTienNoToiDa.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_soTienNoToiDa.Name = "numericUpDown_soTienNoToiDa";
            this.numericUpDown_soTienNoToiDa.Size = new System.Drawing.Size(171, 26);
            this.numericUpDown_soTienNoToiDa.TabIndex = 1;
            this.numericUpDown_soTienNoToiDa.ValueChanged += new System.EventHandler(this.numericUpDown_soTienNoToiDa_ValueChanged);
            // 
            // numericUpDown_chietKhau
            // 
            this.numericUpDown_chietKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_chietKhau.Location = new System.Drawing.Point(276, 117);
            this.numericUpDown_chietKhau.Name = "numericUpDown_chietKhau";
            this.numericUpDown_chietKhau.Size = new System.Drawing.Size(171, 26);
            this.numericUpDown_chietKhau.TabIndex = 2;
            this.numericUpDown_chietKhau.ValueChanged += new System.EventHandler(this.numericUpDown_chietKhau_ValueChanged);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(276, 172);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(86, 38);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.Location = new System.Drawing.Point(382, 172);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(86, 38);
            this.btn_Huy.TabIndex = 4;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_notification.Location = new System.Drawing.Point(426, 326);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 20);
            this.label_notification.TabIndex = 33;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numericUpDown_chietKhau);
            this.groupControl1.Controls.Add(this.label_slTonKhoToiThieu);
            this.groupControl1.Controls.Add(this.btn_Huy);
            this.groupControl1.Controls.Add(this.btn_Luu);
            this.groupControl1.Controls.Add(this.label_soTienNoToiDa);
            this.groupControl1.Controls.Add(this.label_chietKhau);
            this.groupControl1.Controls.Add(this.numericUpDown_slTonKhoToiThieu);
            this.groupControl1.Controls.Add(this.numericUpDown_soTienNoToiDa);
            this.groupControl1.Location = new System.Drawing.Point(333, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(553, 241);
            this.groupControl1.TabIndex = 34;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(353, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 33);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Thay đổi quy định";
            // 
            // UserControl_ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label_notification);
            this.Name = "UserControl_ThayDoiQuyDinh";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_slTonKhoToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soTienNoToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chietKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label_slTonKhoToiThieu;
        private DevExpress.XtraEditors.LabelControl label_soTienNoToiDa;
        private DevExpress.XtraEditors.LabelControl label_chietKhau;
        private System.Windows.Forms.NumericUpDown numericUpDown_slTonKhoToiThieu;
        private System.Windows.Forms.NumericUpDown numericUpDown_soTienNoToiDa;
        private System.Windows.Forms.NumericUpDown numericUpDown_chietKhau;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
