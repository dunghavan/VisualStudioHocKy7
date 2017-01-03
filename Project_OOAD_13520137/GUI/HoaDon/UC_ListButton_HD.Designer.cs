namespace GUI
{
    partial class UC_ListButton_HD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ListButton_HD));
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(95, 111);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(162, 58);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm mới";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(467, 111);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(162, 58);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Appearance.Options.UseFont = true;
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(281, 111);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(162, 58);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // UC_ListButton_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Name = "UC_ListButton_HD";
            this.Size = new System.Drawing.Size(1104, 231);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btn_them;
        public DevExpress.XtraEditors.SimpleButton btn_Xoa;
        public DevExpress.XtraEditors.SimpleButton btn_Sua;
    }
}
