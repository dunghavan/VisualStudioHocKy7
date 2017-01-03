namespace GUI
{
    partial class UserControl_MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QLUser = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PhieuThu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // btn_QLUser
            // 
            this.btn_QLUser.Location = new System.Drawing.Point(65, 56);
            this.btn_QLUser.Name = "btn_QLUser";
            this.btn_QLUser.Size = new System.Drawing.Size(131, 83);
            this.btn_QLUser.TabIndex = 1;
            this.btn_QLUser.Text = "Quản Lý Nhân Viên";
            this.btn_QLUser.Click += new System.EventHandler(this.btn_QLUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách các chức năng của phần mềm để ở đây";
            // 
            // btn_PhieuThu
            // 
            this.btn_PhieuThu.Location = new System.Drawing.Point(308, 56);
            this.btn_PhieuThu.Name = "btn_PhieuThu";
            this.btn_PhieuThu.Size = new System.Drawing.Size(131, 83);
            this.btn_PhieuThu.TabIndex = 1;
            this.btn_PhieuThu.Text = "Quản Lý Phiếu Thu";
            this.btn_PhieuThu.Click += new System.EventHandler(this.btn_PhieuThu_Click);
            // 
            // UserControl_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_PhieuThu);
            this.Controls.Add(this.btn_QLUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_MainMenu";
            this.Size = new System.Drawing.Size(990, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_QLUser;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_PhieuThu;
    }
}
