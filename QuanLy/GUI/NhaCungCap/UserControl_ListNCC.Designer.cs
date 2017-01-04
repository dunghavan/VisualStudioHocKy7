namespace GUI
{
    partial class UserControl_ListNCC
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
            this.gridControl_DSNCC = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSNCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSNCC
            // 
            this.gridControl_DSNCC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSNCC.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSNCC.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSNCC.MainView = this.gridView_DSNCC;
            this.gridControl_DSNCC.Name = "gridControl_DSNCC";
            this.gridControl_DSNCC.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSNCC.TabIndex = 47;
            this.gridControl_DSNCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSNCC});
            this.gridControl_DSNCC.Load += new System.EventHandler(this.gridControl_DSNCC_Load);
            this.gridControl_DSNCC.Click += new System.EventHandler(this.gridControl_DSNCC_Click);
            // 
            // gridView_DSNCC
            // 
            this.gridView_DSNCC.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSNCC.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNCC.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSNCC.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNCC.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSNCC.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSNCC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSNCC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNCC.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSNCC.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNCC.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSNCC.Appearance.Row.Options.UseFont = true;
            this.gridView_DSNCC.GridControl = this.gridControl_DSNCC;
            this.gridView_DSNCC.Name = "gridView_DSNCC";
            this.gridView_DSNCC.OptionsBehavior.Editable = false;
            this.gridView_DSNCC.OptionsFind.AlwaysVisible = true;
            this.gridView_DSNCC.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView_DSNCC.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSNCC.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSNCC.OptionsView.ShowGroupPanel = false;
            this.gridView_DSNCC.RowHeight = 3;
            this.gridView_DSNCC.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSNCC_RowClick);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification.Location = new System.Drawing.Point(453, 341);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 19);
            this.label_notification.TabIndex = 54;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(196, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(300, 33);
            this.labelControl1.TabIndex = 55;
            this.labelControl1.Text = "Danh sách Nhà Cung Cấp";
            // 
            // UserControl_ListNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl_DSNCC);
            this.Controls.Add(this.label_notification);
            this.Name = "UserControl_ListNCC";
            this.Size = new System.Drawing.Size(1361, 455);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl_DSNCC;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSNCC;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
