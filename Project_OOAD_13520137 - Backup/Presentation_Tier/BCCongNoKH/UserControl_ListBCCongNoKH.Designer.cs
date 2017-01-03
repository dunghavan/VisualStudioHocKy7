namespace GUI
{
    partial class UserControl_ListBCCongNoKH
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
            this.gridControl_DSBCCongNoKH = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSBCCongNoKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSBCCongNoKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSBCCongNoKH)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSBCCongNoKH
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSBCCongNoKH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSBCCongNoKH.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSBCCongNoKH.MainView = this.gridView_DSBCCongNoKH;
            this.gridControl_DSBCCongNoKH.Name = "gridControl_DSBCCongNoKH";
            this.gridControl_DSBCCongNoKH.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSBCCongNoKH.TabIndex = 1;
            this.gridControl_DSBCCongNoKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSBCCongNoKH});
            this.gridControl_DSBCCongNoKH.Load += new System.EventHandler(this.gridControl_DSBCCongNoKH_Load);
            // 
            // gridView_DSBCCongNoKH
            // 
            this.gridView_DSBCCongNoKH.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSBCCongNoKH.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCCongNoKH.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSBCCongNoKH.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCCongNoKH.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSBCCongNoKH.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSBCCongNoKH.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSBCCongNoKH.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCCongNoKH.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSBCCongNoKH.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCCongNoKH.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSBCCongNoKH.Appearance.Row.Options.UseFont = true;
            this.gridView_DSBCCongNoKH.FooterPanelHeight = 6;
            this.gridView_DSBCCongNoKH.GridControl = this.gridControl_DSBCCongNoKH;
            this.gridView_DSBCCongNoKH.Name = "gridView_DSBCCongNoKH";
            this.gridView_DSBCCongNoKH.OptionsBehavior.Editable = false;
            this.gridView_DSBCCongNoKH.OptionsFind.AlwaysVisible = true;
            this.gridView_DSBCCongNoKH.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView_DSBCCongNoKH.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSBCCongNoKH.OptionsLayout.StoreAllOptions = true;
            this.gridView_DSBCCongNoKH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSBCCongNoKH.OptionsView.ShowGroupPanel = false;
            this.gridView_DSBCCongNoKH.RowHeight = 1;
            this.gridView_DSBCCongNoKH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSBCCongNoKH_RowClick);
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
            this.labelControl1.Size = new System.Drawing.Size(489, 33);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Danh sách Báo Cáo Công Nợ Khách Hàng";
            // 
            // UserControl_ListBCCongNoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSBCCongNoKH);
            this.Name = "UserControl_ListBCCongNoKH";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSBCCongNoKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSBCCongNoKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSBCCongNoKH;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSBCCongNoKH;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
