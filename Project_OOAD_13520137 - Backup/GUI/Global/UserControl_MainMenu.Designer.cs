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
            this.btn_DDH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QLKH = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PGH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_HD = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_DDH
            // 
            this.btn_DDH.Location = new System.Drawing.Point(488, 114);
            this.btn_DDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DDH.Name = "btn_DDH";
            this.btn_DDH.Size = new System.Drawing.Size(196, 128);
            this.btn_DDH.TabIndex = 4;
            this.btn_DDH.Text = "Lập Đơn Đặt Hàng";
            // 
            // btn_QLKH
            // 
            this.btn_QLKH.Location = new System.Drawing.Point(124, 114);
            this.btn_QLKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_QLKH.Name = "btn_QLKH";
            this.btn_QLKH.Size = new System.Drawing.Size(196, 128);
            this.btn_QLKH.TabIndex = 5;
            this.btn_QLKH.Text = "Quản Lý Khách Hàng";
            this.btn_QLKH.Click += new System.EventHandler(this.btn_QLKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(743, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách các chức năng của phần mềm để ở đây";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu";
            // 
            // btn_PGH
            // 
            this.btn_PGH.Location = new System.Drawing.Point(828, 114);
            this.btn_PGH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PGH.Name = "btn_PGH";
            this.btn_PGH.Size = new System.Drawing.Size(196, 128);
            this.btn_PGH.TabIndex = 4;
            this.btn_PGH.Text = "Lập Phiếu Giao Hàng";
            // 
            // btn_HD
            // 
            this.btn_HD.Location = new System.Drawing.Point(1158, 114);
            this.btn_HD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HD.Name = "btn_HD";
            this.btn_HD.Size = new System.Drawing.Size(196, 128);
            this.btn_HD.TabIndex = 4;
            this.btn_HD.Text = "Lập Hóa Đơn";
            // 
            // UserControl_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_HD);
            this.Controls.Add(this.btn_PGH);
            this.Controls.Add(this.btn_DDH);
            this.Controls.Add(this.btn_QLKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_MainMenu";
            this.Size = new System.Drawing.Size(1485, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_DDH;
        private DevExpress.XtraEditors.SimpleButton btn_QLKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_PGH;
        private DevExpress.XtraEditors.SimpleButton btn_HD;
    }
}
