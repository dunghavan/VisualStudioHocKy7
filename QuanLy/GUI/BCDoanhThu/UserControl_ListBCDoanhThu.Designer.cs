namespace GUI
{
    partial class UserControl_ListBCDoanhThu
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl_DSBCDoanhThu = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSBCDoanhThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSBCDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSBCDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSBCDoanhThu
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gridControl_DSBCDoanhThu.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl_DSBCDoanhThu.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSBCDoanhThu.MainView = this.gridView_DSBCDoanhThu;
            this.gridControl_DSBCDoanhThu.Name = "gridControl_DSBCDoanhThu";
            this.gridControl_DSBCDoanhThu.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSBCDoanhThu.TabIndex = 1;
            this.gridControl_DSBCDoanhThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSBCDoanhThu});
            this.gridControl_DSBCDoanhThu.Load += new System.EventHandler(this.gridControl_DSBCDoanhThu_Load);
            // 
            // gridView_DSBCDoanhThu
            // 
            this.gridView_DSBCDoanhThu.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSBCDoanhThu.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCDoanhThu.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSBCDoanhThu.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCDoanhThu.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSBCDoanhThu.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSBCDoanhThu.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSBCDoanhThu.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCDoanhThu.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSBCDoanhThu.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCDoanhThu.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSBCDoanhThu.Appearance.Row.Options.UseFont = true;
            this.gridView_DSBCDoanhThu.FooterPanelHeight = 6;
            this.gridView_DSBCDoanhThu.GridControl = this.gridControl_DSBCDoanhThu;
            this.gridView_DSBCDoanhThu.Name = "gridView_DSBCDoanhThu";
            this.gridView_DSBCDoanhThu.OptionsBehavior.Editable = false;
            this.gridView_DSBCDoanhThu.OptionsFind.AlwaysVisible = true;
            this.gridView_DSBCDoanhThu.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView_DSBCDoanhThu.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSBCDoanhThu.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSBCDoanhThu.OptionsView.ShowGroupPanel = false;
            this.gridView_DSBCDoanhThu.RowHeight = 6;
            this.gridView_DSBCDoanhThu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSBCTonKho_RowClick);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_notification.Location = new System.Drawing.Point(453, 341);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 16);
            this.label_notification.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(196, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(368, 33);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Danh sách Báo Cáo Doanh Thu";
            // 
            // UserControl_ListBCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSBCDoanhThu);
            this.Name = "UserControl_ListBCDoanhThu";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSBCDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSBCDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSBCDoanhThu;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSBCDoanhThu;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
