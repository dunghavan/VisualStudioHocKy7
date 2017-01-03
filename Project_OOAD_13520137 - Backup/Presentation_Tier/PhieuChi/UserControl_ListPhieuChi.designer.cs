namespace GUI
{
    partial class UserControl_ListPhieuChi
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
            this.gridControl_DSPhieuChi = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSPhieuChi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSPhieuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSPhieuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSPhieuChi
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSPhieuChi.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSPhieuChi.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSPhieuChi.MainView = this.gridView_DSPhieuChi;
            this.gridControl_DSPhieuChi.Name = "gridControl_DSPhieuChi";
            this.gridControl_DSPhieuChi.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSPhieuChi.TabIndex = 1;
            this.gridControl_DSPhieuChi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSPhieuChi});
            this.gridControl_DSPhieuChi.Load += new System.EventHandler(this.gridControl_DSPhieuChi_Load);
            // 
            // gridView_DSPhieuChi
            // 
            this.gridView_DSPhieuChi.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSPhieuChi.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuChi.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSPhieuChi.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuChi.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSPhieuChi.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSPhieuChi.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSPhieuChi.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuChi.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSPhieuChi.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuChi.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSPhieuChi.Appearance.Row.Options.UseFont = true;
            this.gridView_DSPhieuChi.GridControl = this.gridControl_DSPhieuChi;
            this.gridView_DSPhieuChi.Name = "gridView_DSPhieuChi";
            this.gridView_DSPhieuChi.OptionsBehavior.Editable = false;
            this.gridView_DSPhieuChi.OptionsFind.AlwaysVisible = true;
            this.gridView_DSPhieuChi.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSPhieuChi.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSPhieuChi.OptionsView.ShowGroupPanel = false;
            this.gridView_DSPhieuChi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSPhieuChi_RowClick);
            // 
            // label_notification
            // 
            this.label_notification.AutoSize = true;
            this.label_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_notification.Location = new System.Drawing.Point(453, 341);
            this.label_notification.Name = "label_notification";
            this.label_notification.Size = new System.Drawing.Size(0, 20);
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
            this.labelControl1.Size = new System.Drawing.Size(241, 33);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Danh sách Phiếu Chi";
            // 
            // UserControl_ListPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSPhieuChi);
            this.Name = "UserControl_ListPhieuChi";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSPhieuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSPhieuChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSPhieuChi;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSPhieuChi;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
