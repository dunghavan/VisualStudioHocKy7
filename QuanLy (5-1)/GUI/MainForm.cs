using GUI;
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
            //
            if (!buttonPanel.Controls.Contains(UserControl_ListButton_Empty.Instance))
                buttonPanel.Controls.Add(UserControl_ListButton_Empty.Instance);
            UserControl_ListButton_Empty.Instance.BringToFront();

            hyperlink_dangXuat.Visible = false;
            label_usernameLogin.Text = null;
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).tabPanel.Visible = false;
            //((MainForm)parentForm).buttonPanel.Hide();
            UserControl_Login.Instance.Show();
            ((MainForm)parentForm).panel38.BringToFront();
            ((MainForm)parentForm).panel38.Show();
            //((MainForm)parentForm).panelControl1.Show();
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

        private void btn_phieuGiaoHang_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_ListPGH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListPGH.Instance);
            UC_ListPGH.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UC_ListButton_PGH.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UC_ListButton_PGH.Instance);
            UC_ListButton_PGH.Instance.BringToFront();

            UC_ListButton_PGH.Instance.btn_them.Enabled = true;
            UC_ListButton_PGH.Instance.btn_Sua.Enabled = false;
            UC_ListButton_PGH.Instance.btn_Xoa.Enabled = false;
        }

        
        private void btn_QLKhachHang_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_QLKH.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_QLKH.Instance);
            UserControl_QLKH.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_KH.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_KH.Instance);
            UserControl_ListButton_KH.Instance.BringToFront();

            UserControl_ListButton_KH.Instance.btn_them.Enabled = true;
            UserControl_ListButton_KH.Instance.btn_Sua.Enabled = false;
            UserControl_ListButton_KH.Instance.btn_Xoa.Enabled = false;
        }

        private void MainForm_MaximumSizeChanged(object sender, EventArgs e)
        {
            label_size.Text = "Kích thước size.....: " + this.Size;
        }

        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListSanPham.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListSanPham.Instance);
            UserControl_ListSanPham.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_SanPham.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_SanPham.Instance);
            UserControl_ListButton_SanPham.Instance.BringToFront();

            UserControl_ListButton_SanPham.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_SanPham.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_SanPham.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_QLNhaCC_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UserControl_ListNCC.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UserControl_ListNCC.Instance);
            UserControl_ListNCC.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UserControl_ListButton_NCC.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UserControl_ListButton_NCC.Instance);
            UserControl_ListButton_NCC.Instance.BringToFront();

            UserControl_ListButton_NCC.Instance.btn_themMoi.Enabled = true;
            UserControl_ListButton_NCC.Instance.btn_Edit.Enabled = false;
            UserControl_ListButton_NCC.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_HDBanHangSi_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_HoaDonSi.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_HoaDonSi.Instance);
            UC_HoaDonSi.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UC_ListButton_HD.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UC_ListButton_HD.Instance);
            UC_ListButton_HD.Instance.BringToFront();

            UC_ListButton_HD.Instance.btn_them.Enabled = true;
            UC_ListButton_HD.Instance.btn_Sua.Enabled = false;
            UC_ListButton_HD.Instance.btn_Xoa.Enabled = false;
        }

        private void btn_HDBanHangLe_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (!((MainForm)parentForm).mainPanel.Controls.Contains(UC_ListHoaDon.Instance))
                ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListHoaDon.Instance);
            UC_ListHoaDon.Instance.BringToFront();

            if (!((MainForm)parentForm).buttonPanel.Controls.Contains(UC_ListButton_HD.Instance))
                ((MainForm)parentForm).buttonPanel.Controls.Add(UC_ListButton_HD.Instance);
            UC_ListButton_HD.Instance.BringToFront();

            UC_ListButton_HD.Instance.btn_them.Enabled = true;
            UC_ListButton_HD.Instance.btn_Sua.Enabled = false;
            UC_ListButton_HD.Instance.btn_Xoa.Enabled = false;
        }
    }
}
