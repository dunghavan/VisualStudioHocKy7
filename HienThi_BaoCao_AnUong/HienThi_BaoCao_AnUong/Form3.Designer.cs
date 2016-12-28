namespace HienThi_BaoCao_AnUong
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenBC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVuiChoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Tao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_Trang_Vui_Choi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_Trang_Ngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trinh_Trang_An = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Tre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTTAn = new System.Windows.Forms.TextBox();
            this.txtTTNgu = new System.Windows.Forms.TextBox();
            this.txtMaTre = new System.Windows.Forms.TextBox();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Enabled = false;
            this.dateNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTao.Location = new System.Drawing.Point(641, 158);
            this.dateNgayTao.MaxDate = new System.DateTime(2016, 7, 12, 0, 0, 0, 0);
            this.dateNgayTao.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(135, 20);
            this.dateNgayTao.TabIndex = 41;
            this.dateNgayTao.Value = new System.DateTime(2016, 7, 12, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(561, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ngày Tạo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTenBC
            // 
            this.txtTenBC.Location = new System.Drawing.Point(331, 106);
            this.txtTenBC.Name = "txtTenBC";
            this.txtTenBC.Size = new System.Drawing.Size(135, 20);
            this.txtTenBC.TabIndex = 3;
            this.txtTenBC.Tag = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tên Báo Cáo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtVuiChoi
            // 
            this.txtVuiChoi.Location = new System.Drawing.Point(641, 106);
            this.txtVuiChoi.Name = "txtVuiChoi";
            this.txtVuiChoi.Size = new System.Drawing.Size(135, 20);
            this.txtVuiChoi.TabIndex = 8;
            this.txtVuiChoi.Tag = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "TT Vui Chơi";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Ghi_Chu
            // 
            this.Ghi_Chu.DataPropertyName = "Ghi_Chu";
            this.Ghi_Chu.HeaderText = "Ghi Chú";
            this.Ghi_Chu.Name = "Ghi_Chu";
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Giáo Viên Trông Trẻ";
            this.Ma_NV.Name = "Ma_NV";
            // 
            // Ngay_Tao
            // 
            this.Ngay_Tao.DataPropertyName = "Ngay_Tao";
            this.Ngay_Tao.HeaderText = "Ngày Tạo";
            this.Ngay_Tao.Name = "Ngay_Tao";
            // 
            // Tinh_Trang_Vui_Choi
            // 
            this.Tinh_Trang_Vui_Choi.DataPropertyName = "Tinh_Trang_Vui_Choi";
            this.Tinh_Trang_Vui_Choi.HeaderText = "Tình Trạng Vui Chơi";
            this.Tinh_Trang_Vui_Choi.Name = "Tinh_Trang_Vui_Choi";
            // 
            // Tinh_Trang_Ngu
            // 
            this.Tinh_Trang_Ngu.DataPropertyName = "Tinh_Trang_Ngu";
            this.Tinh_Trang_Ngu.HeaderText = "Tình Trạng Ngủ";
            this.Tinh_Trang_Ngu.Name = "Tinh_Trang_Ngu";
            // 
            // Trinh_Trang_An
            // 
            this.Trinh_Trang_An.DataPropertyName = "Tinh_Trang_An";
            this.Trinh_Trang_An.HeaderText = "Tình Trạng Ăn";
            this.Trinh_Trang_An.Name = "Trinh_Trang_An";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày ";
            this.Ngay.Name = "Ngay";
            // 
            // Ten_BC
            // 
            this.Ten_BC.DataPropertyName = "Ten_BC";
            this.Ten_BC.HeaderText = "Tên Báo Cáo";
            this.Ten_BC.Name = "Ten_BC";
            // 
            // Ma_Tre
            // 
            this.Ma_Tre.DataPropertyName = "Ma_Tre";
            this.Ma_Tre.HeaderText = "Mã Trẻ";
            this.Ma_Tre.Name = "Ma_Tre";
            // 
            // Ma_BC
            // 
            this.Ma_BC.DataPropertyName = "Ma_BC";
            this.Ma_BC.HeaderText = "Mã Báo Cáo";
            this.Ma_BC.Name = "Ma_BC";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(676, 210);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 11;
            this.btThoat.Tag = "11";
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_BC,
            this.Ma_Tre,
            this.Ten_BC,
            this.Ngay,
            this.Trinh_Trang_An,
            this.Tinh_Trang_Ngu,
            this.Tinh_Trang_Vui_Choi,
            this.Ngay_Tao,
            this.Ma_NV,
            this.Ghi_Chu});
            this.dataGridView1.Location = new System.Drawing.Point(2, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 288);
            this.dataGridView1.TabIndex = 35;
            // 
            // dateNgay
            // 
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(641, 132);
            this.dateNgay.MaxDate = new System.DateTime(2016, 7, 12, 8, 7, 16, 0);
            this.dateNgay.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(135, 20);
            this.dateNgay.TabIndex = 9;
            this.dateNgay.Tag = "9";
            this.dateNgay.Value = new System.DateTime(2016, 7, 12, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ghi Chú";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(331, 132);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(135, 20);
            this.txtMaNV.TabIndex = 4;
            this.txtMaNV.Tag = "4";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(331, 158);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(135, 20);
            this.txtGhiChu.TabIndex = 5;
            this.txtGhiChu.Tag = "5";
            // 
            // txtTTAn
            // 
            this.txtTTAn.Location = new System.Drawing.Point(641, 80);
            this.txtTTAn.Name = "txtTTAn";
            this.txtTTAn.Size = new System.Drawing.Size(135, 20);
            this.txtTTAn.TabIndex = 7;
            this.txtTTAn.Tag = "7";
            // 
            // txtTTNgu
            // 
            this.txtTTNgu.Location = new System.Drawing.Point(641, 54);
            this.txtTTNgu.Name = "txtTTNgu";
            this.txtTTNgu.Size = new System.Drawing.Size(135, 20);
            this.txtTTNgu.TabIndex = 6;
            this.txtTTNgu.Tag = "6";
            // 
            // txtMaTre
            // 
            this.txtMaTre.Location = new System.Drawing.Point(331, 77);
            this.txtMaTre.Name = "txtMaTre";
            this.txtMaTre.Size = new System.Drawing.Size(135, 20);
            this.txtMaTre.TabIndex = 2;
            this.txtMaTre.Tag = "2";
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(331, 51);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(135, 20);
            this.txtMaBC.TabIndex = 1;
            this.txtMaBC.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "TT Ăn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "TT Ngủ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Trẻ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Báo Cáo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã Nhân Viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(333, 211);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 10;
            this.btThem.Tag = "10";
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1047, 544);
            this.Controls.Add(this.dateNgayTao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTenBC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVuiChoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateNgay);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTTAn);
            this.Controls.Add(this.txtTTNgu);
            this.Controls.Add(this.txtMaTre);
            this.Controls.Add(this.txtMaBC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Nhập Thông Tin Báo Cáo Ăn Ngủ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenBC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVuiChoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Tao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_Trang_Vui_Choi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_Trang_Ngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trinh_Trang_An;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_BC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Tre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_BC;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTTAn;
        private System.Windows.Forms.TextBox txtTTNgu;
        private System.Windows.Forms.TextBox txtMaTre;
        private System.Windows.Forms.TextBox txtMaBC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}