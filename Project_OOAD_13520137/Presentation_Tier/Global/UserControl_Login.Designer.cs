namespace Presentation_Tier
{
    partial class UserControl_Login
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.lb_password = new System.Windows.Forms.Label();
            this.textEdit_password = new DevExpress.XtraEditors.TextEdit();
            this.lb_username = new System.Windows.Forms.Label();
            this.textEdit_username = new DevExpress.XtraEditors.TextEdit();
            this.label_tittle = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_login);
            this.groupControl1.Controls.Add(this.lb_password);
            this.groupControl1.Controls.Add(this.textEdit_password);
            this.groupControl1.Controls.Add(this.lb_username);
            this.groupControl1.Controls.Add(this.textEdit_username);
            this.groupControl1.Location = new System.Drawing.Point(499, 44);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(369, 161);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Location = new System.Drawing.Point(221, 110);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_password
            // 
            this.lb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(26, 78);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(57, 13);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password:";
            // 
            // textEdit_password
            // 
            this.textEdit_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit_password.EditValue = "123456";
            this.textEdit_password.Location = new System.Drawing.Point(115, 75);
            this.textEdit_password.Name = "textEdit_password";
            this.textEdit_password.Properties.UseSystemPasswordChar = true;
            this.textEdit_password.Size = new System.Drawing.Size(181, 20);
            this.textEdit_password.TabIndex = 1;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(26, 39);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(59, 13);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username:";
            // 
            // textEdit_username
            // 
            this.textEdit_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEdit_username.EditValue = "dunghavan";
            this.textEdit_username.Location = new System.Drawing.Point(115, 36);
            this.textEdit_username.Name = "textEdit_username";
            this.textEdit_username.Size = new System.Drawing.Size(181, 20);
            this.textEdit_username.TabIndex = 0;
            // 
            // label_tittle
            // 
            this.label_tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tittle.AutoSize = true;
            this.label_tittle.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_tittle.ForeColor = System.Drawing.Color.Orange;
            this.label_tittle.Location = new System.Drawing.Point(605, 11);
            this.label_tittle.Name = "label_tittle";
            this.label_tittle.Size = new System.Drawing.Size(184, 19);
            this.label_tittle.TabIndex = 4;
            this.label_tittle.Text = "Đăng nhập vào hệ thống";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::Presentation_Tier.Properties.Resources.icon;
            this.pictureEdit1.Location = new System.Drawing.Point(499, 226);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(369, 96);
            this.pictureEdit1.TabIndex = 5;
            // 
            // UserControl_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label_tittle);
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Login";
            this.Size = new System.Drawing.Size(1370, 360);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private System.Windows.Forms.Label lb_password;
        private DevExpress.XtraEditors.TextEdit textEdit_password;
        private System.Windows.Forms.Label lb_username;
        private DevExpress.XtraEditors.TextEdit textEdit_username;
        private System.Windows.Forms.Label label_tittle;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
