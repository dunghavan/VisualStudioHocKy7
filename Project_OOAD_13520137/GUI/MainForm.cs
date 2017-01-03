﻿using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            mainPanel.Controls.Add(UserControl_Login.Instance);
            UserControl_Login.Instance.BringToFront();

            //label_size.Text = "Kích thước size: " + this.Size;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListUser.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListUser.Instance);
            UserControl_ListUser.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_User.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_User.Instance);
            UserControl_ListButton_User.Instance.BringToFront();
            //
            UserControl_ListButton_User.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_User.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_User.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_phieuThu_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListPhieuThu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuThu.Instance);
            UserControl_ListPhieuThu.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_PhieuThu.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_PhieuThu.Instance);
            UserControl_ListButton_PhieuThu.Instance.BringToFront();

            UserControl_ListButton_PhieuThu.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_PhieuThu.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_PhieuThu.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_BCCongNoKH_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListBCCongNoKH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCCongNoKH.Instance);
            UserControl_ListBCCongNoKH.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_BCCongNoKH.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_BCCongNoKH.Instance);
            UserControl_ListButton_BCCongNoKH.Instance.BringToFront();

            UserControl_ListButton_BCCongNoKH.Instance.btn_themMoi.Enabled = true;
            //UserControl_ListButton_BCCongNoKH.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCCongNoKH.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_phieuChi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListPhieuChi.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListPhieuChi.Instance);
            UserControl_ListPhieuChi.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_PhieuChi.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_PhieuChi.Instance);
            UserControl_ListButton_PhieuChi.Instance.BringToFront();

            UserControl_ListButton_PhieuChi.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_PhieuChi.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_PhieuChi.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_BCTonKho_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListBCTonKho.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCTonKho.Instance);
            UserControl_ListBCTonKho.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_BCTonKho.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_BCTonKho.Instance);
            UserControl_ListButton_BCTonKho.Instance.BringToFront();

            UserControl_ListButton_BCTonKho.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_BCTonKho.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCTonKho.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_BackUpCSDL_Click(object sender, EventArgs e)
        {

        }

        private void btn_RestoreCSDL_Click(object sender, EventArgs e)
        {

        }

        private void btn_BCDoanhThu_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListBCDoanhThu.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListBCDoanhThu.Instance);
            UserControl_ListBCDoanhThu.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_BCDoanhThu.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_BCDoanhThu.Instance);
            UserControl_ListButton_BCDoanhThu.Instance.BringToFront();

            UserControl_ListButton_BCDoanhThu.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_BCDoanhThu.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_thayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ThayDoiQuyDinh.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ThayDoiQuyDinh.Instance);
            UserControl_ThayDoiQuyDinh.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(ThayDoiQuyDinh_ListButton.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(ThayDoiQuyDinh_ListButton.Instance);
            ThayDoiQuyDinh_ListButton.Instance.BringToFront();
        }

        private void hyperlink_dangXuat_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            if (!mainPanel.Controls.Contains(UserControl_Login.Instance))
                mainPanel.Controls.Add(UserControl_Login.Instance);
            UserControl_Login.Instance.Dock = DockStyle.Fill;
            UserControl_Login.Instance.BringToFront();

            hyperlink_dangXuat.Visible = false;
            label_usernameLogin.Text = null;
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).tabPanel.Visible = false;
            ((MainForm)parentForm).buttonPanel.Hide();
            UserControl_Login.Instance.Show();
            ((MainForm)parentForm).panelControl1.BringToFront();
            ((MainForm)parentForm).panelControl1.Show();
        }

        private void btn_donDatHang_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_ListDonDatHang.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListDonDatHang.Instance);
            UC_ListDonDatHang.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UC_ListButton_DDH.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UC_ListButton_DDH.Instance);
            UC_ListButton_DDH.Instance.BringToFront();

            UC_ListButton_DDH.Instance.btn_them.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Sua.Enabled = false;
            UC_ListButton_DDH.Instance.btn_Xoa.Enabled = false;
        }
    }
}