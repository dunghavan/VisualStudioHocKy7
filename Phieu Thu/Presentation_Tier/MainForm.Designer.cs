namespace Presentation_Tier
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label_notification = new System.Windows.Forms.Label();
            this.hyperlink_dangXuat = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.label_usernameLogin = new DevExpress.XtraEditors.LabelControl();
            this.label_size = new DevExpress.XtraEditors.LabelControl();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackgroundImage = global::Presentation_Tier.Properties.Resources.bg_body;
            this.mainPanel.Location = new System.Drawing.Point(-1, 183);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1378, 524);
            this.mainPanel.TabIndex = 3;
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Location = new System.Drawing.Point(351, 459);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 13);
            this.label_notification.TabIndex = 0;
            // 
            // hyperlink_dangXuat
            // 
            this.hyperlink_dangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperlink_dangXuat.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperlink_dangXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlink_dangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlink_dangXuat.Location = new System.Drawing.Point(1136, 8);
            this.hyperlink_dangXuat.Name = "hyperlink_dangXuat";
            this.hyperlink_dangXuat.Size = new System.Drawing.Size(58, 16);
            this.hyperlink_dangXuat.TabIndex = 4;
            this.hyperlink_dangXuat.Text = "Đăng xuất";
            this.hyperlink_dangXuat.Visible = false;
            this.hyperlink_dangXuat.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // label_usernameLogin
            // 
            this.label_usernameLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_usernameLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usernameLogin.Location = new System.Drawing.Point(855, 7);
            this.label_usernameLogin.Name = "label_usernameLogin";
            this.label_usernameLogin.Size = new System.Drawing.Size(0, 16);
            this.label_usernameLogin.TabIndex = 5;
            // 
            // label_size
            // 
            this.label_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_size.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_size.Location = new System.Drawing.Point(459, 12);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(0, 16);
            this.label_size.TabIndex = 6;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(-1, 37);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(990, 140);
            this.buttonPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_usernameLogin);
            this.Controls.Add(this.hyperlink_dangXuat);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Label label_notification;
        public DevExpress.XtraEditors.HyperlinkLabelControl hyperlink_dangXuat;
        public DevExpress.XtraEditors.LabelControl label_usernameLogin;
        public DevExpress.XtraEditors.LabelControl label_size;
        public System.Windows.Forms.Panel buttonPanel;
    }
}

