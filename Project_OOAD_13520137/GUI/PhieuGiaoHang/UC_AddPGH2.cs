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
using GUI;
namespace GUI
{
    public partial class UC_AddPGH2 : UserControl
    {
        public UC_AddPGH2()
        {
            InitializeComponent();
            LoadData();
            ToggleUI(true);

        }

        // tạo phiếu giao hàng trước
        public void ToggleUI(bool isAdd = false)
        {
            if (isAdd)
            {
                //TODO chỉ hiển thị hộp thoại đơn đặt hàng

                groupControl_CTPGH.Visible = false;
                groupControl_ThemPGH.Visible = true;
                btn_ThemPGH.Visible = true;
                btn_HuyPGH.Visible = true;
                groupControl_SanPham.Visible = false;
                gc_DMSP.Visible = false;
                gc_CTPGH.Visible = false;
                gc_DSDDH.Visible = false;
                label17.Visible = false;
                label10.Visible = false;
                txt_SLDaGiao.Visible = false;
                txt_SLConLai.Visible = false;
                txtTongthanhtoan.Visible = false;
                btn_HoanTatPGH.Visible = false;
                txtTongthanhtoan.Visible = false;


            }
            else
            {
                // hiển thị các thành phần
                //TODO show UI hien thi thong tin chi tiet
                //.Location = _groupControl_DDH_normalPosition;
                groupControl_CTPGH.Visible = true;
                
                groupControl_ThemPGH.Visible = false;
                btn_ThemPGH.Visible = false;
                btn_HuyPGH.Visible = false;
                groupControl_SanPham.Visible = true;
                gc_DMSP.Visible = true;
                gc_CTPGH.Visible = true;
                label_tongthanhtoan.Visible = true;
                txtTongthanhtoan.Visible = true;
                lb_thongbao.Visible = true;
                btn_HoanTatPGH.Visible = true;


                txt_SL_PGH.Enabled = false;

            }
        }

        private static UC_AddPGH2 _instance;
        public static UC_AddPGH2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_AddPGH2();
                return _instance;
            }
        }
        
        int tongtien = 0;
        int soluong = 0;
        SanPham sp = new SanPham();
        int sl_truocCN = 0;
        int thanhtien_truocCN = 0;
        SanPhamBUS spBUS = new SanPhamBUS();
        DonDatHangBUS ddhBUS = new DonDatHangBUS();
        PhieuGiaoHangBUS pghBUS = new PhieuGiaoHangBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        KhachHangBUS khBUS = new KhachHangBUS();
        CT_PhieuGiaoHangDTO ct_pghDTO = new CT_PhieuGiaoHangDTO();
      
       

        // khởi tạo dữ liệu
        public void LoadData()
        {
            //SanPhamBUS spBUS = new SanPhamBUS();
            //DonDatHangBUS ddhBUS = new DonDatHangBUS();
            //NhanVienBUS nvBUS = new NhanVienBUS(
            //KhachHangBUS khBUS = new KhachHangBUS();
            //gc_DMSP.DataSource = spBUS.getAllSanPham_TheoMaDDH(cbb_maDDH.SelectedValue.ToString());
            //gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
            //txt_SL_PGH.Enabled = false;
            cbb_NV2.DataSource = nvBUS.getAllNhanVien();
            cbb_NV2.DisplayMember = "HoTen";
            cbb_NV2.ValueMember = "MaNV";
            cbb_MaDDH2.DataSource = ddhBUS.Load_DSDonDatHang_TheoMaDDH();
            cbb_MaDDH2.DisplayMember = "MaDDH";
            cbb_MaDDH2.ValueMember = "MaDDH";
            cbb_KH2.DataSource = khBUS.Load_DSKhachHang();
            cbb_KH2.DisplayMember = "HoTen";
            cbb_KH2.ValueMember = "MaKH";
            
           
            



        }

       // lấy dữ liệu từ gridview sản phẩm lên groupcontrol sản phẩm
        private void UpdateThongtinSPView(string maSP, string tenSP, string dongia, string soluongtong)
        {

            txt_maSP_PGH.Text = maSP;
            txt_TenSP_PGH.Text = tenSP;
            txt_DonGia_PGH.Text = dongia;
            txt_SL_PGH.Text = string.Format("{0}", 1);
            txt_SL_PGH.Maximum = int.Parse(soluongtong);
            txt_ThanhTien_PGH.Text = (int.Parse(txt_DonGia_PGH.Text) * int.Parse(txt_SL_PGH.Text)).ToString();
            
        }

        
      // thêm phiếu giao hàng
        private void btn_ThemPGH_Click_1(object sender, EventArgs e)
        {
            if (txt_maPGH2.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập Mã Phiếu Giao Hàng !");
                txt_maPGH2.Focus();
            }
            else
            {
                // nếu chưa có phiếu giao hàng cùng tên
                if (pghBUS.KT_maPGH(txt_maPGH2.Text)==null)
                {


                    if (pghBUS.Insert_PhieuGiaoHang(txt_maPGH2.Text,
                                                    cbb_MaDDH2.SelectedValue.ToString(),
                                                    dtp_NgayLap2_PGH.Value,
                                                    cbb_NV2.SelectedValue.ToString(),
                                                    cbb_KH2.SelectedValue.ToString(),
                                                     0, ""))
                    {
                        txt_maPGH.Text = txt_maPGH2.Text;
                        cbb_KH.Text = cbb_KH2.Text;
                        cbb_NV.Text = cbb_NV2.Text;
                        dtp_NgayLap2_PGH = dtp_NgayLap_PGH;

                        //gc_DMSP.DataSource = spBUS.getAllSanPham_TheoMaDDH(cbb_MaDDH2.Text);
                        gc_DMSP.DataSource = spBUS.getAllSanPham();
                        gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
                        //gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
                        ToggleUI(false);
                        gc_DSDDH.DataSource = ddhBUS.Load_DSCT_TheoMaDDH(cbb_MaDDH2.Text);
                        
                    }
                    else
                    {
                        //TODO show thong bao
                    }

                }
                else
                {
                    // kiểm tra phiếu giao hàng cùng tên
                    XtraMessageBox.Show("Mã phiếu giao hàng đã tồn tại, vui lòng nhập mã khác !");
                }
            }

        }

        // hủy phiếu giao hàng
        private void btn_HuyPGH_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListPGH.Instance);
            UC_ListPGH.Instance.BringToFront();
        }
    
        // thêm sản phẩm
        private void btnThemSP_PGH_Click_1(object sender, EventArgs e)
        {
            
            // lấy số lượng trong kho tự update
            
            soluong = spBUS.kiemtraSLSanPham(txt_maSP_PGH.Text); //
            tongtien = 0;
            spBUS.updateSLSanPham(txt_maSP_PGH.Text, soluong - Convert.ToInt32(txt_SL_PGH.Value));
            // nếu đã có sản phẩm trong chi tiết thì update cộng số lượng
            // nếu chưa có thì thêm sản phẩm mới
            if (int.Parse(gv_CTPGH.RowCount.ToString()) != 0)
            {
                for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
                {
                    if ((txt_maPGH.Text == (gv_CTPGH.GetRowCellValue(i, "MaPGH").ToString())) && (txt_maSP_PGH.Text == (gv_CTPGH.GetRowCellValue(i, "MaSP").ToString())))
                    {
                        pghBUS.Update_CT_PhieuGiaoHang(txt_maPGH.Text,
                                                    txt_maSP_PGH.Text,
                                                    Convert.ToInt32(txt_SL_PGH.Value) + int.Parse(gv_CTPGH.GetRowCellValue(i, "SoLuong").ToString()),
                                                    int.Parse(txt_ThanhTien_PGH.Text) + int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString()), "");
                        
                    }
                    else
                    {
                        pghBUS.Insert_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP_PGH.Text, Convert.ToInt32(txt_SL_PGH.Value), int.Parse(txt_ThanhTien_PGH.Text), "");
                        
                    }
                }
            }
            else
            {
                pghBUS.Insert_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP_PGH.Text, Convert.ToInt32(txt_SL_PGH.Value), int.Parse(txt_ThanhTien_PGH.Text), "");
               
            }
            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
            
            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }
            txtTongthanhtoan.Text = tongtien.ToString();
            gc_DMSP.DataSource = spBUS.getAllSanPham();
           
        }

        private void btnXoaSP_PGH_Click_1(object sender, EventArgs e)
        {
            pghBUS.Delete_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP_PGH.Text);// xóa chi tiết
            soluong=spBUS.kiemtraSLSanPham(txt_maSP_PGH.Text);// số lượng còn lại
            spBUS.updateSLSanPham(txt_maSP_PGH.Text, soluong + Convert.ToInt32(txt_SL_PGH.Value));// update sl cho sản phẩm
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);// tính tổng tiền
            tongtien = 0;
            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }
            txtTongthanhtoan.Text = tongtien.ToString();
           
        }

        private void btn_CapNhat_PGH_Click_1(object sender, EventArgs e)
        {
            soluong = spBUS.kiemtraSLSanPham(txt_maSP_PGH.Text);
            spBUS.updateSLSanPham(txt_maSP_PGH.Text, soluong + sl_truocCN - Convert.ToInt32(txt_SL_PGH.Value));
            pghBUS.Update_CT_PhieuGiaoHang(txt_maPGH.Text, txt_maSP_PGH.Text, Convert.ToInt32(txt_SL_PGH.Value), int.Parse(txt_ThanhTien_PGH.Text), "");
            tongtien = 0;
            gc_DMSP.DataSource = spBUS.getAllSanPham();
            gc_CTPGH.DataSource = pghBUS.Load_DSCT_TheoMaPGH(txt_maPGH.Text);
            for (int i = 0; i < int.Parse(gv_CTPGH.RowCount.ToString()); i++)
            {
                tongtien += int.Parse(gv_CTPGH.GetRowCellValue(i, "ThanhTien").ToString());
            }
            txtTongthanhtoan.Text = tongtien.ToString();
        }

        private void btn_HoanTatPGH_Click_1(object sender, EventArgs e)
        {
            pghBUS.Update_TongTienPGH(txt_maPGH.Text, int.Parse(txtTongthanhtoan.Text));

            Form parentForm = this.FindForm();
            ((MainForm)parentForm).mainPanel.Controls.Add(UC_ListPGH.Instance);
            UC_ListPGH.Instance.BringToFront();
        }

        private void txt_SL_PGH_ValueChanged(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(txt_DonGia_PGH.Text) * Convert.ToInt32(txt_SL_PGH.Value);
            txt_ThanhTien_PGH.Text = thanhtien.ToString();

        }

        private void gv_DMSP_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_DMSP.GetDataRow(e.RowHandle);
            if (ddhBUS.KT_maSP(cbb_MaDDH2.Text,row["MaSP"].ToString()) != null)
            {
                int soluongDaGiao;// lấy thông tin lên groupcontrol sản phẩm
                UpdateThongtinSPView(row["MaSP"].ToString(),
                row["TenSP"].ToString(),
                row["DonGia"].ToString(),
                row["SoLuong"].ToString());
                txt_SL_PGH.Enabled = true;
                btnXoaSP_PGH.Enabled = false;
                btn_CapNhat_PGH.Enabled = false;
                btnThemSP_PGH.Enabled = true;
                //kiểm tra số lượng đã giao
               if(pghBUS.KTSoLuongDaGiao(cbb_MaDDH2.Text, txt_maSP_PGH.Text)==-1)
                {
                    soluongDaGiao=0;
                }
                else
                {
                    soluongDaGiao=pghBUS.KTSoLuongDaGiao(cbb_MaDDH2.Text, txt_maSP_PGH.Text);
                }
                int soluongDat = pghBUS.KT_SoLuong_TheoMaDDH(cbb_MaDDH2.Text, txt_maSP_PGH.Text);
                txt_SLDaGiao.Text = soluongDaGiao.ToString();
                txt_SLConLai.Text=(soluongDat-soluongDaGiao).ToString();
                if (int.Parse(txt_SLConLai.Text) < int.Parse(row["SoLuong"].ToString()))
                {
                    txt_SL_PGH.Maximum = int.Parse(txt_SLConLai.Text);
                }
                else
                {
                    txt_SL_PGH.Maximum = int.Parse(row["SoLuong"].ToString());
                }
            }
            else
            {
                XtraMessageBox.Show("Sản phẩm không có trong đơn đặt hàng");
            }
        }

      

        private void gv_CTPGH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gv_CTPGH.GetDataRow(e.RowHandle);
            txt_maSP_PGH.Text = row["MaSP"].ToString();
            txt_TenSP_PGH.Text = row["TenSP"].ToString();
            txt_DonGia_PGH.Text = row["DonGia"].ToString();
            txt_SL_PGH.Value = int.Parse(row["SoLuong"].ToString());
            txt_ThanhTien_PGH.Text = row["ThanhTien"].ToString();
            txt_SL_PGH.Enabled = true;
            sl_truocCN = int.Parse(row["SoLuong"].ToString());
            thanhtien_truocCN = int.Parse(row["ThanhTien"].ToString());
            btnThemSP_PGH.Enabled = false;
            btn_CapNhat_PGH.Enabled = true;
            btnXoaSP_PGH.Enabled = true;
        }

        
        
       
    }
}
