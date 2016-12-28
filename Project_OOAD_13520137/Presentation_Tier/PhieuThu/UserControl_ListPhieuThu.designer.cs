namespace Presentation_Tier
{
    partial class UserControl_ListPhieuThu
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
            this.gridControl_DSPhieuThu = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSPhieuThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSPhieuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSPhieuThu
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl_DSPhieuThu.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_DSPhieuThu.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSPhieuThu.MainView = this.gridView_DSPhieuThu;
            this.gridControl_DSPhieuThu.Name = "gridControl_DSPhieuThu";
            this.gridControl_DSPhieuThu.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSPhieuThu.TabIndex = 1;
            this.gridControl_DSPhieuThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSPhieuThu});
            this.gridControl_DSPhieuThu.Load += new System.EventHandler(this.gridControl_DSPhieuThu_Load);
            // 
            // gridView_DSPhieuThu
            // 
            this.gridView_DSPhieuThu.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSPhieuThu.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuThu.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSPhieuThu.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuThu.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSPhieuThu.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSPhieuThu.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSPhieuThu.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuThu.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSPhieuThu.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSPhieuThu.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSPhieuThu.Appearance.Row.Options.UseFont = true;
            this.gridView_DSPhieuThu.GridControl = this.gridControl_DSPhieuThu;
            this.gridView_DSPhieuThu.Name = "gridView_DSPhieuThu";
            this.gridView_DSPhieuThu.OptionsBehavior.Editable = false;
            this.gridView_DSPhieuThu.OptionsFind.AlwaysVisible = true;
            this.gridView_DSPhieuThu.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSPhieuThu.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSPhieuThu.OptionsView.ShowGroupPanel = false;
            this.gridView_DSPhieuThu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSPhieuThu_RowClick);
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
            this.labelControl1.Size = new System.Drawing.Size(250, 33);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Danh sách Phiếu Thu";
            // 
            // UserControl_ListPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSPhieuThu);
            this.Name = "UserControl_ListPhieuThu";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSPhieuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSPhieuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSPhieuThu;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSPhieuThu;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
