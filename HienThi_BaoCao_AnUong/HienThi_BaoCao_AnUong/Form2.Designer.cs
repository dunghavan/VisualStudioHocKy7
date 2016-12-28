namespace HienThi_BaoCao_AnUong
{
    partial class Form_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Edit));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_MaNV = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.label_NgayTao = new System.Windows.Forms.Label();
            this.label_Ma_NV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_GhiChu = new System.Windows.Forms.TextBox();
            this.label_GhiChu = new System.Windows.Forms.Label();
            this.textBox_TT_VuiChoi = new System.Windows.Forms.TextBox();
            this.label_TinhTrangAn = new System.Windows.Forms.Label();
            this.label_TinhTrangNgu = new System.Windows.Forms.Label();
            this.label_TinhTrangVuiChoi = new System.Windows.Forms.Label();
            this.textBox_TT_An = new System.Windows.Forms.TextBox();
            this.textBox_TT_Ngu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_MaTre = new System.Windows.Forms.ComboBox();
            this.label_MaTre = new System.Windows.Forms.Label();
            this.label_TenTre = new System.Windows.Forms.Label();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label_TenBC = new System.Windows.Forms.Label();
            this.label_MaBC = new System.Windows.Forms.Label();
            this.label_BaoCaoNgay = new System.Windows.Forms.Label();
            this.textBox_MaBC = new System.Windows.Forms.TextBox();
            this.textBox_TenBC = new System.Windows.Forms.TextBox();
            this.label_ThongBao = new System.Windows.Forms.Label();
            this.button_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.button_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.comboBox_MaNV);
            this.groupBox4.Controls.Add(this.dateTimePicker_NgayTao);
            this.groupBox4.Controls.Add(this.label_NgayTao);
            this.groupBox4.Controls.Add(this.label_Ma_NV);
            this.groupBox4.Location = new System.Drawing.Point(307, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 110);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // comboBox_MaNV
            // 
            this.comboBox_MaNV.FormattingEnabled = true;
            this.comboBox_MaNV.Location = new System.Drawing.Point(92, 74);
            this.comboBox_MaNV.Name = "comboBox_MaNV";
            this.comboBox_MaNV.Size = new System.Drawing.Size(141, 21);
            this.comboBox_MaNV.TabIndex = 17;
            this.comboBox_MaNV.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaNV_SelectedIndexChanged);
            // 
            // dateTimePicker_NgayTao
            // 
            this.dateTimePicker_NgayTao.Enabled = false;
            this.dateTimePicker_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayTao.Location = new System.Drawing.Point(93, 27);
            this.dateTimePicker_NgayTao.Name = "dateTimePicker_NgayTao";
            this.dateTimePicker_NgayTao.Size = new System.Drawing.Size(140, 21);
            this.dateTimePicker_NgayTao.TabIndex = 39;
            // 
            // label_NgayTao
            // 
            this.label_NgayTao.AutoSize = true;
            this.label_NgayTao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayTao.Location = new System.Drawing.Point(1, 32);
            this.label_NgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgayTao.Name = "label_NgayTao";
            this.label_NgayTao.Size = new System.Drawing.Size(63, 15);
            this.label_NgayTao.TabIndex = 7;
            this.label_NgayTao.Text = "Ngày Tạo:";
            // 
            // label_Ma_NV
            // 
            this.label_Ma_NV.AutoSize = true;
            this.label_Ma_NV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ma_NV.Location = new System.Drawing.Point(1, 81);
            this.label_Ma_NV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ma_NV.Name = "label_Ma_NV";
            this.label_Ma_NV.Size = new System.Drawing.Size(88, 15);
            this.label_Ma_NV.TabIndex = 20;
            this.label_Ma_NV.Text = "Mã Người Tạo:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.textBox_GhiChu);
            this.groupBox3.Controls.Add(this.label_GhiChu);
            this.groupBox3.Controls.Add(this.textBox_TT_VuiChoi);
            this.groupBox3.Controls.Add(this.label_TinhTrangAn);
            this.groupBox3.Controls.Add(this.label_TinhTrangNgu);
            this.groupBox3.Controls.Add(this.label_TinhTrangVuiChoi);
            this.groupBox3.Controls.Add(this.textBox_TT_An);
            this.groupBox3.Controls.Add(this.textBox_TT_Ngu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(307, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 182);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình Trạng Trẻ";
            // 
            // textBox_GhiChu
            // 
            this.textBox_GhiChu.Location = new System.Drawing.Point(128, 132);
            this.textBox_GhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_GhiChu.Name = "textBox_GhiChu";
            this.textBox_GhiChu.Size = new System.Drawing.Size(348, 22);
            this.textBox_GhiChu.TabIndex = 19;
            this.textBox_GhiChu.TextChanged += new System.EventHandler(this.textBox_GhiChu_TextChanged);
            // 
            // label_GhiChu
            // 
            this.label_GhiChu.AutoSize = true;
            this.label_GhiChu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GhiChu.Location = new System.Drawing.Point(4, 136);
            this.label_GhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GhiChu.Name = "label_GhiChu";
            this.label_GhiChu.Size = new System.Drawing.Size(53, 15);
            this.label_GhiChu.TabIndex = 18;
            this.label_GhiChu.Text = "Ghi Chú:";
            // 
            // textBox_TT_VuiChoi
            // 
            this.textBox_TT_VuiChoi.Location = new System.Drawing.Point(128, 62);
            this.textBox_TT_VuiChoi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TT_VuiChoi.Name = "textBox_TT_VuiChoi";
            this.textBox_TT_VuiChoi.Size = new System.Drawing.Size(348, 22);
            this.textBox_TT_VuiChoi.TabIndex = 17;
            this.textBox_TT_VuiChoi.TextChanged += new System.EventHandler(this.textBox_TT_VuiChoi_TextChanged);
            // 
            // label_TinhTrangAn
            // 
            this.label_TinhTrangAn.AutoSize = true;
            this.label_TinhTrangAn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TinhTrangAn.Location = new System.Drawing.Point(4, 102);
            this.label_TinhTrangAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TinhTrangAn.Name = "label_TinhTrangAn";
            this.label_TinhTrangAn.Size = new System.Drawing.Size(90, 15);
            this.label_TinhTrangAn.TabIndex = 8;
            this.label_TinhTrangAn.Text = "Tình Trạng Ăn:";
            // 
            // label_TinhTrangNgu
            // 
            this.label_TinhTrangNgu.AutoSize = true;
            this.label_TinhTrangNgu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TinhTrangNgu.Location = new System.Drawing.Point(4, 25);
            this.label_TinhTrangNgu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TinhTrangNgu.Name = "label_TinhTrangNgu";
            this.label_TinhTrangNgu.Size = new System.Drawing.Size(96, 15);
            this.label_TinhTrangNgu.TabIndex = 9;
            this.label_TinhTrangNgu.Text = "Tình Trạng Ngủ:";
            // 
            // label_TinhTrangVuiChoi
            // 
            this.label_TinhTrangVuiChoi.AutoSize = true;
            this.label_TinhTrangVuiChoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TinhTrangVuiChoi.Location = new System.Drawing.Point(4, 65);
            this.label_TinhTrangVuiChoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TinhTrangVuiChoi.Name = "label_TinhTrangVuiChoi";
            this.label_TinhTrangVuiChoi.Size = new System.Drawing.Size(118, 15);
            this.label_TinhTrangVuiChoi.TabIndex = 10;
            this.label_TinhTrangVuiChoi.Text = "Tình Trạng Vui Chơi:";
            // 
            // textBox_TT_An
            // 
            this.textBox_TT_An.Location = new System.Drawing.Point(128, 99);
            this.textBox_TT_An.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TT_An.Name = "textBox_TT_An";
            this.textBox_TT_An.Size = new System.Drawing.Size(348, 22);
            this.textBox_TT_An.TabIndex = 14;
            this.textBox_TT_An.TextChanged += new System.EventHandler(this.textBox_TT_An_TextChanged);
            // 
            // textBox_TT_Ngu
            // 
            this.textBox_TT_Ngu.Location = new System.Drawing.Point(128, 22);
            this.textBox_TT_Ngu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TT_Ngu.Name = "textBox_TT_Ngu";
            this.textBox_TT_Ngu.Size = new System.Drawing.Size(348, 22);
            this.textBox_TT_Ngu.TabIndex = 16;
            this.textBox_TT_Ngu.TextChanged += new System.EventHandler(this.textBox_TT_Ngu_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.comboBox_MaTre);
            this.groupBox2.Controls.Add(this.label_MaTre);
            this.groupBox2.Controls.Add(this.label_TenTre);
            this.groupBox2.Controls.Add(this.textBox_HoTen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-1, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 110);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Trẻ";
            // 
            // comboBox_MaTre
            // 
            this.comboBox_MaTre.FormattingEnabled = true;
            this.comboBox_MaTre.Location = new System.Drawing.Point(96, 28);
            this.comboBox_MaTre.Name = "comboBox_MaTre";
            this.comboBox_MaTre.Size = new System.Drawing.Size(141, 24);
            this.comboBox_MaTre.TabIndex = 16;
            this.comboBox_MaTre.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaTre_SelectedIndexChanged);
            // 
            // label_MaTre
            // 
            this.label_MaTre.AutoSize = true;
            this.label_MaTre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaTre.Location = new System.Drawing.Point(31, 32);
            this.label_MaTre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaTre.Name = "label_MaTre";
            this.label_MaTre.Size = new System.Drawing.Size(49, 15);
            this.label_MaTre.TabIndex = 4;
            this.label_MaTre.Text = "Mã Trẻ:";
            // 
            // label_TenTre
            // 
            this.label_TenTre.AutoSize = true;
            this.label_TenTre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenTre.Location = new System.Drawing.Point(9, 78);
            this.label_TenTre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenTre.Name = "label_TenTre";
            this.label_TenTre.Size = new System.Drawing.Size(71, 15);
            this.label_TenTre.TabIndex = 5;
            this.label_TenTre.Text = "Họ Tên Trẻ:";
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Enabled = false;
            this.textBox_HoTen.Location = new System.Drawing.Point(85, 77);
            this.textBox_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(192, 22);
            this.textBox_HoTen.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dateTimePicker_Ngay);
            this.groupBox1.Controls.Add(this.label_TenBC);
            this.groupBox1.Controls.Add(this.label_MaBC);
            this.groupBox1.Controls.Add(this.label_BaoCaoNgay);
            this.groupBox1.Controls.Add(this.textBox_MaBC);
            this.groupBox1.Controls.Add(this.textBox_TenBC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(283, 157);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // dateTimePicker_Ngay
            // 
            this.dateTimePicker_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Ngay.Location = new System.Drawing.Point(97, 108);
            this.dateTimePicker_Ngay.MaxDate = new System.DateTime(2016, 7, 12, 0, 0, 0, 0);
            this.dateTimePicker_Ngay.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Ngay.Name = "dateTimePicker_Ngay";
            this.dateTimePicker_Ngay.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker_Ngay.TabIndex = 38;
            this.dateTimePicker_Ngay.Value = new System.DateTime(2016, 7, 9, 0, 0, 0, 0);
            this.dateTimePicker_Ngay.ValueChanged += new System.EventHandler(this.dateTimePicker_Ngay_ValueChanged);
            // 
            // label_TenBC
            // 
            this.label_TenBC.AutoSize = true;
            this.label_TenBC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenBC.Location = new System.Drawing.Point(9, 73);
            this.label_TenBC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenBC.Name = "label_TenBC";
            this.label_TenBC.Size = new System.Drawing.Size(79, 15);
            this.label_TenBC.TabIndex = 3;
            this.label_TenBC.Text = "Tên Báo Cáo:";
            // 
            // label_MaBC
            // 
            this.label_MaBC.AutoSize = true;
            this.label_MaBC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaBC.Location = new System.Drawing.Point(9, 34);
            this.label_MaBC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaBC.Name = "label_MaBC";
            this.label_MaBC.Size = new System.Drawing.Size(76, 15);
            this.label_MaBC.TabIndex = 2;
            this.label_MaBC.Text = "Mã Báo Cáo:";
            // 
            // label_BaoCaoNgay
            // 
            this.label_BaoCaoNgay.AutoSize = true;
            this.label_BaoCaoNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BaoCaoNgay.Location = new System.Drawing.Point(9, 112);
            this.label_BaoCaoNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BaoCaoNgay.Name = "label_BaoCaoNgay";
            this.label_BaoCaoNgay.Size = new System.Drawing.Size(87, 15);
            this.label_BaoCaoNgay.TabIndex = 6;
            this.label_BaoCaoNgay.Text = "Báo Cáo Ngày:";
            // 
            // textBox_MaBC
            // 
            this.textBox_MaBC.Enabled = false;
            this.textBox_MaBC.Location = new System.Drawing.Point(97, 32);
            this.textBox_MaBC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MaBC.Name = "textBox_MaBC";
            this.textBox_MaBC.Size = new System.Drawing.Size(140, 22);
            this.textBox_MaBC.TabIndex = 11;
            // 
            // textBox_TenBC
            // 
            this.textBox_TenBC.Location = new System.Drawing.Point(97, 71);
            this.textBox_TenBC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TenBC.Name = "textBox_TenBC";
            this.textBox_TenBC.Size = new System.Drawing.Size(140, 22);
            this.textBox_TenBC.TabIndex = 12;
            this.textBox_TenBC.TextChanged += new System.EventHandler(this.textBox_TenBC_TextChanged);
            // 
            // label_ThongBao
            // 
            this.label_ThongBao.AutoSize = true;
            this.label_ThongBao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongBao.ForeColor = System.Drawing.Color.Red;
            this.label_ThongBao.Location = new System.Drawing.Point(577, 198);
            this.label_ThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ThongBao.Name = "label_ThongBao";
            this.label_ThongBao.Size = new System.Drawing.Size(0, 15);
            this.label_ThongBao.TabIndex = 40;
            // 
            // button_Huy
            // 
            this.button_Huy.Image = global::HienThi_BaoCao_AnUong.Properties.Resources.cancel;
            this.button_Huy.Location = new System.Drawing.Point(701, 241);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(82, 36);
            this.button_Huy.TabIndex = 42;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_Luu
            // 
            this.button_Luu.Image = global::HienThi_BaoCao_AnUong.Properties.Resources.save;
            this.button_Luu.Location = new System.Drawing.Point(598, 241);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(82, 35);
            this.button_Luu.TabIndex = 41;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(820, 286);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.label_ThongBao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Edit";
            this.Text = "Chỉnh sửa thông tin Báo Cáo Ăn Uống";
            this.Activated += new System.EventHandler(this.Form_Edit_Activated);
            this.Deactivate += new System.EventHandler(this.Form_Edit_Deactivated);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_NgayTao;
        private System.Windows.Forms.Label label_Ma_NV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_TT_VuiChoi;
        private System.Windows.Forms.Label label_TinhTrangAn;
        private System.Windows.Forms.Label label_TinhTrangNgu;
        private System.Windows.Forms.Label label_TinhTrangVuiChoi;
        private System.Windows.Forms.TextBox textBox_TT_An;
        private System.Windows.Forms.TextBox textBox_TT_Ngu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_MaTre;
        private System.Windows.Forms.Label label_TenTre;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_TenBC;
        private System.Windows.Forms.Label label_MaBC;
        private System.Windows.Forms.Label label_BaoCaoNgay;
        private System.Windows.Forms.TextBox textBox_TenBC;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayTao;
        private System.Windows.Forms.ComboBox comboBox_MaTre;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ngay;
        private System.Windows.Forms.TextBox textBox_MaBC;
        private System.Windows.Forms.TextBox textBox_GhiChu;
        private System.Windows.Forms.Label label_GhiChu;
        private System.Windows.Forms.ComboBox comboBox_MaNV;
        private System.Windows.Forms.Label label_ThongBao;
        private DevExpress.XtraEditors.SimpleButton button_Luu;
        private DevExpress.XtraEditors.SimpleButton button_Huy;
    }
}