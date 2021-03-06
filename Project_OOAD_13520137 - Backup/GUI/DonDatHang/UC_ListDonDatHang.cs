﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class UC_ListDonDatHang : UserControl
    {
        public UC_ListDonDatHang()
        {
            InitializeComponent();
        }
        private static UC_ListDonDatHang _instance;
        public static UC_ListDonDatHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ListDonDatHang ();
                return _instance;
            }
        }
        public static DonDatHangBUS ddhBUS = new DonDatHangBUS();
       
        public string maDDH_edit;
        private void loadDSDonDatHang()
        {
            //tableDDH = ddhBUS.Load_DSDonDatHang();
            //DataTable _tempTableDDH = new DataTable();
            //int stt = 0;
            //// khai bao ten cot

            //string [] columnName ={"STT", "Mã đơn đặt hàng", "Tên nhân viên", "Tên khách hàng", "Tổng Tiền", "Ngày" }
            gridControl_DDH.DataSource = ddhBUS.Load_DSDonDatHang();
            UC_ListButton_DDH.Instance.btn_them.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Sua.Enabled = true;
            UC_ListButton_DDH.Instance.btn_Xoa.Enabled = true;
        }

        // Mảng số nguyên chứa số thứ tự của các rows đã được chọn:
       


       
        private void gridControl_DDH_Load(object sender, EventArgs e)
        {
            loadDSDonDatHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!MainForm.mainPanel.Controls.Contains(UC_AddDDH.Instance))
                MainForm.mainPanel.Controls.Add(UC_AddDDH.Instance);
            UC_AddDDH.Instance.BringToFront();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (!MainForm.mainPanel.Controls.Contains(UC_EditDDH.Instance))
                MainForm.mainPanel.Controls.Add(UC_EditDDH.Instance);
            UC_EditDDH.Instance.BringToFront();

            //UC_EditDDH.Instance.loadDataFromGridView();
        }

        private void gv_DSDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //var row = gv_CTDDH.GetDataRow(e.RowHandle);
            //txt_maSP.Text = row["MaSP"].ToString();
            //txt_TenSP.Text = row["TenSP"].ToString();
            //txt_DonGia.Text = row["DonGia"].ToString();
            //txt_SL.Value = int.Parse(row["SoLuong"].ToString());
            //txt_ThanhTien.Text = row["ThanhTien"].ToString();

            var row = gv_DSDDH.GetDataRow(e.RowHandle);
            maDDH_edit = row["MaDDH"].ToString();
        }
    }
}
