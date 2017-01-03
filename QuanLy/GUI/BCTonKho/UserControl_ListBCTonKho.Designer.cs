namespace GUI
{
    partial class UserControl_ListBCTonKho
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
            this.gridControl_DSBCTonKho = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSBCTonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSBCTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSBCTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSBCTonKho
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSBCTonKho.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSBCTonKho.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSBCTonKho.MainView = this.gridView_DSBCTonKho;
            this.gridControl_DSBCTonKho.Name = "gridControl_DSBCTonKho";
            this.gridControl_DSBCTonKho.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSBCTonKho.TabIndex = 1;
            this.gridControl_DSBCTonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSBCTonKho});
            this.gridControl_DSBCTonKho.Load += new System.EventHandler(this.gridControl_DSBCTonKho_Load);
            // 
            // gridView_DSBCTonKho
            // 
            this.gridView_DSBCTonKho.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSBCTonKho.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCTonKho.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSBCTonKho.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCTonKho.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSBCTonKho.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSBCTonKho.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSBCTonKho.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCTonKho.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSBCTonKho.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSBCTonKho.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSBCTonKho.Appearance.Row.Options.UseFont = true;
            this.gridView_DSBCTonKho.GridControl = this.gridControl_DSBCTonKho;
            this.gridView_DSBCTonKho.Name = "gridView_DSBCTonKho";
            this.gridView_DSBCTonKho.OptionsBehavior.Editable = false;
            this.gridView_DSBCTonKho.OptionsFind.AlwaysVisible = true;
            this.gridView_DSBCTonKho.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView_DSBCTonKho.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSBCTonKho.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSBCTonKho.OptionsView.ShowGroupPanel = false;
            this.gridView_DSBCTonKho.RowHeight = 6;
            this.gridView_DSBCTonKho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSBCTonKho_RowClick);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Location = new System.Drawing.Point(453, 341);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 13);
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
            this.labelControl1.Size = new System.Drawing.Size(337, 33);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Danh sách Báo Cáo Tồn Kho";
            // 
            // UserControl_ListBCTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSBCTonKho);
            this.Name = "UserControl_ListBCTonKho";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSBCTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSBCTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSBCTonKho;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSBCTonKho;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
