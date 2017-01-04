namespace GUI
{
    partial class UserControl_ListUser
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
            this.gridControl_DSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView_DSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label_notification = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_DSNhanVien
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gridControl_DSNhanVien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl_DSNhanVien.Location = new System.Drawing.Point(22, 40);
            this.gridControl_DSNhanVien.MainView = this.gridView_DSNhanVien;
            this.gridControl_DSNhanVien.Name = "gridControl_DSNhanVien";
            this.gridControl_DSNhanVien.Size = new System.Drawing.Size(1326, 295);
            this.gridControl_DSNhanVien.TabIndex = 1;
            this.gridControl_DSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DSNhanVien});
            this.gridControl_DSNhanVien.Load += new System.EventHandler(this.gridControl_DSNhanVien_Load);
            // 
            // gridView_DSNhanVien
            // 
            this.gridView_DSNhanVien.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.FontSizeDelta = 6;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView_DSNhanVien.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_DSNhanVien.Appearance.Row.FontSizeDelta = 6;
            this.gridView_DSNhanVien.Appearance.Row.Options.UseFont = true;
            this.gridView_DSNhanVien.GridControl = this.gridControl_DSNhanVien;
            this.gridView_DSNhanVien.Name = "gridView_DSNhanVien";
            this.gridView_DSNhanVien.OptionsBehavior.Editable = false;
            this.gridView_DSNhanVien.OptionsFind.AlwaysVisible = true;
            this.gridView_DSNhanVien.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView_DSNhanVien.OptionsFind.FindNullPrompt = "Nhập thông tin bất kỳ để tìm kiếm...";
            this.gridView_DSNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_DSNhanVien.OptionsView.ShowGroupPanel = false;
            this.gridView_DSNhanVien.RowHeight = 1;
            this.gridView_DSNhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_DSNhanVien_RowClick);
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
            this.labelControl1.Size = new System.Drawing.Size(252, 33);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Danh sách Nhân Viên";
            // 
            // UserControl_ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label_notification);
            this.Controls.Add(this.gridControl_DSNhanVien);
            this.Name = "UserControl_ListUser";
            this.Size = new System.Drawing.Size(1374, 360);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl_DSNhanVien;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_DSNhanVien;
        public System.Windows.Forms.Label label_notification;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
