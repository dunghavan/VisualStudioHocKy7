namespace GUI
{
    partial class UserControl_ListSanPham
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
            this.label_notification = new System.Windows.Forms.Label();
            this.gridControl_DSSanPham = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification.Location = new System.Drawing.Point(453, 341);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 19);
            this.label_notification.TabIndex = 44;
            // 
            // gridControl_DSSanPham
            // 
            this.gridControl_DSSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSSanPham.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSSanPham.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSSanPham.MainView = this.gridView_DSSanPham;
            this.gridControl_DSSanPham.Name = "gridControl_DSSanPham";
            this.gridControl_DSSanPham.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSSanPham.TabIndex = 48;
            this.gridControl_DSSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSSanPham});
            // 
            // gridView_DSSanPham
            // 
            this.gridView_DSSanPham.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSSanPham.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSSanPham.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSSanPham.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSSanPham.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSSanPham.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSSanPham.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSSanPham.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSSanPham.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSSanPham.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSSanPham.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSSanPham.Appearance.Row.Options.UseFont = true;
            this.gridView_DSSanPham.GridControl = this.gridControl_DSSanPham;
            this.gridView_DSSanPham.Name = "gridView_DSSanPham";
            this.gridView_DSSanPham.OptionsBehavior.Editable = false;
            this.gridView_DSSanPham.OptionsFind.AlwaysVisible = true;
            this.gridView_DSSanPham.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView_DSSanPham.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSSanPham.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSSanPham.OptionsView.ShowGroupPanel = false;
            this.gridView_DSSanPham.RowHeight = 6;
            this.gridView_DSSanPham.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSSanPham_RowClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(196, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(250, 33);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Danh sách Sản Phẩm";
            // 
            // UserControl_ListSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl_DSSanPham);
            this.Controls.Add(this.label_notification);
            this.Name = "UserControl_ListSanPham";
            this.Size = new System.Drawing.Size(1361, 455);
            this.Load += new System.EventHandler(this.gridControl_DSSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_notification;
        public DevExpress.XtraGrid.GridControl gridControl_DSSanPham;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
