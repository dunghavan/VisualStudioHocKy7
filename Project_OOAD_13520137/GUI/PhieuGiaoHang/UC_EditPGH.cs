using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class UC_EditPGH : UserControl
    {
       
        public UC_EditPGH()
        {
            InitializeComponent();
        }
        private static UC_EditPGH _instance;
        public static UC_EditPGH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_EditPGH();
                return _instance;
            }
        }

        int tongtien = 0;

        int soluong = 0;
        SanPham sp = new SanPham();
        int sl_truocCN = 0;
        int thanhtien_truocCN = 0;
        SanPhamBUS spBUS = new SanPhamBUS();
        PhieuGiaoHangBUS pghBUS = new PhieuGiaoHangBUS();
        DonDatHangBUS ddhBUS = new DonDatHangBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        string maEdit =  UC_ListPGH.Instance.maPGH_edit;
        private void UC_EditPGH_Load(object sender, EventArgs e)
        {
            txt_maDDH.Text = UC_ListPGH.Instance.maDDH_edit.ToString();
            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(maEdit);
            gc_DSDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(txt_maDDH.Text);
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            cbb_NV.DataSource = nvBUS.getAllNhanVien();
            txt_maPGH.Text = maEdit;
            cbb_NV.DisplayMember = "HoTen";
            cbb_NV.ValueMember = "MaNV";
            cbb_KH.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH.DisplayMember = "HoTen";
            cbb_KH.ValueMember = "MaKH";
            cbb_KH.Enabled = true;
            cbb_NV.Enabled = true;
           
            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongThanhToan.Text = tongtien.ToString();
        }

       
      
        private void gv_DMSP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DMSP.GetDataRow(e.RowHandle);
            if (ddhBUS.KT_maSP(txt_maDDH.Text,row["MaSP"].ToString()) != null)
            {
                int soluongDaGiao;
                UpdateThongtinSPView(row["MaSP"].ToString(),
                row["TenSP"].ToString(),
                row["DonGia"].ToString(),
                row["SoLuong"].ToString());
                txt_SL.Enabled = true;
                btnXoaSP.Enabled = false;
                btn_CapNhat.Enabled = false;
                btnThemSP.Enabled = true;
               if(pghBUS.KTSoLuongDaGiao(txt_maDDH.Text, txt_maSP.Text)==-1)
                {
                    soluongDaGiao=0;
                }
                else
                {
                    soluongDaGiao=pghBUS.KTSoLuongDaGiao(txt_maDDH.Text, txt_maSP.Text);
                }
                int soluongDat = pghBUS.KT_SoLuong_TheoMaDDH(txt_maDDH.Text, txt_maSP.Text);
                txt_SLDaGiao.Text = soluongDaGiao.ToString();
                txt_SLConLai.Text=(soluongDat-soluongDaGiao).ToString();
                if (int.Parse(txt_SLConLai.Text) < int.Parse(row["SoLuong"].ToString()))
                {
                    txt_SL.Maximum = int.Parse(txt_SLConLai.Text);
                }
                else
                {
                    txt_SL.Maximum = int.Parse(row["SoLuong"].ToString());
                }

            }
            else
            {
                XtraMessageBox.Show("Sản phẩm không có trong đơn đặt hàng");
            }
                
                
            
            
        }

        private void UpdateThongtinSPView(string maSP, string tenSP, string dongia, string soluongtong)
        {

            txt_maSP.Text = maSP;
            txt_TenSP.Text = tenSP;
            txt_DonGia.Text = dongia;
            txt_SL.Text = string.Format("{0}", 1);
            txt_SL.Maximum = int.Parse(soluongtong);
            txt_ThanhTien.Text = (int.Parse(txt_DonGia.Text) * int.Parse(txt_SL.Text)).ToString();

        }

        

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            tongtien = 0;
            spBUS.updateSLSanPham(txt_maSP.Text, soluong - Convert.ToInt32(txt_SL.Value));

            if (int.Parse(gv_CTPGH.RowCount.ToString()) != 0)
            {
                for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
                {
                    if ((txt_maPGH.Text == (gv_CTPGH.GetRowCellValue(i, "MaPGH").ToString())) && (txt_maSP.Text == (gv_CTPGH.GetRowCellValue(i, "MaSP").ToString())))
                    {
                        pghBUS.Update_CT_PhieuGiaoHang(txt_maPGH.Text,
                                                    txt_maSP.Text,
                                                    Convert.ToInt32(txt_SL.Value) + int.Parse(gv_CTPGH.GetRowCellValue(i, "SoLuong").ToString()),
                                                    int.Parse(txt_ThanhTien.Text) + int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString()), "");

                    }
                    else
                    {
                        pghBUS.Insert_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");

                    }
                }
            }
            else
            {
                pghBUS.Insert_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");

            }


            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);

            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }

            txtTongThanhToan.Text = tongtien.ToString();
            gc_DMSP.DataSource = spBUS.getAllSanPham();
           
           
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            pghBUS.Delete_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP.Text);
            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + Convert.ToInt32(txt_SL.Value));

            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }
            txtTongThanhToan.Text = tongtien.ToString();
            lb_thongbao.Text = "";
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            soluong = spBUS.kiemtraSLSanPham(txt_maSP.Text);
            spBUS.updateSLSanPham(txt_maSP.Text, soluong + sl_truocCN - Convert.ToInt32(txt_SL.Value));
            pghBUS.Update_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP.Text, Convert.ToInt32(txt_SL.Value), int.Parse(txt_ThanhTien.Text), "");
            tongtien = 0;
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }
            txtTongThanhToan.Text = tongtien.ToString();
        }

        private void gv_CTPGH_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DMSP.GetDataRow(e.RowHandle);
            UpdateThongtinSPView(row["MaSP"].ToString(),
            row["TenSP"].ToString(),
            row["DonGia"].ToString(),
            row["SoLuong"].ToString());
            txt_SL.Enabled = true;
            btnXoaSP.Enabled = false;
            btn_CapNhat.Enabled = false;
            btnThemSP.Enabled = true;
        }

        private void txt_SL_ValueChanged(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(txt_DonGia.Text) * Convert.ToInt32(txt_SL.Value);
            txt_ThanhTien.Text = thanhtien.ToString();
        }

        
        
    }
}
