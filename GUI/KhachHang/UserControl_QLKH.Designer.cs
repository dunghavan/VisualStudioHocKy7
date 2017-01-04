namespace GUI
{
    partial class UserControl_QLKH
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
            this.gridControl_DSKH = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSKH
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSKH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSKH.Location = new System.Drawing.Point(40, 188);
            this.gridControl_DSKH.MainView = this.gridView_DSKhachHang;
            this.gridControl_DSKH.Name = "gridControl_DSKH";
            this.gridControl_DSKH.Size = new System.Drawing.Size(1208, 412);
            this.gridControl_DSKH.TabIndex = 44;
            this.gridControl_DSKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSKhachHang});
            this.gridControl_DSKH.Load += new System.EventHandler(this.gridControl_DSKH_Load);
            // 
            // gridView_DSKhachHang
            // 
            this.gridView_DSKhachHang.GridControl = this.gridControl_DSKH;
            this.gridView_DSKhachHang.Name = "gridView_DSKhachHang";
            this.gridView_DSKhachHang.OptionsBehavior.Editable = false;
            this.gridView_DSKhachHang.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSKhachHang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSKhachHang_RowClick);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Location = new System.Drawing.Point(550, 654);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 20);
            this.label_notification.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(339, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 59);
            this.label1.TabIndex = 49;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // UserControl_QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSKH);
            this.Name = "UserControl_QLKH";
            this.Size = new System.Drawing.Size(2042, 700);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSKH;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSKhachHang;
        public System.Windows.Forms.Label label_notification;
        private System.Windows.Forms.Label label1;
    }
}
