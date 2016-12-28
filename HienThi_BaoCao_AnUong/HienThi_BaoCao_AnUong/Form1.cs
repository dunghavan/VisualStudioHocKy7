using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;


namespace HienThi_BaoCao_AnUong
{
    public partial class Form_View : Form
    {
        public Form_View()
        {
            InitializeComponent();
            comboBox_SapXep.SelectedItem = "--- default ---";
            //gridView1.OptionsFilter.AllowFilter
        }
        SqlConnection conn = new SqlConnection("Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");
        SqlDataReader reader;
        DataTable dt;
        // Declare Parameters:
        static SqlCommand sqlcmd;
        SqlParameter _ma_BC, _ten_BC, _ma_Tre, _ten_Tre, _ngay, _tinh_Trang_An, _tinh_Trang_Ngu, _tinh_Trang_VuiChoi,
                    _ma_NV, _ngay_Tao, _sort_by;

        private void textBox_BaoCaoNgay_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_MaTre_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_HoTen_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void comboBox_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_TT_Ngu_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_TT_VuiChoi_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_TT_An_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_Ngay_Tao_TextChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_Ma_Nguoi_Tao_TextChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void label_TinhTrangAn_Click(object sender, EventArgs e)
        {

        }

        private void label_TinhTrangVuiChoi_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TenBC_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void textBox_MaBC_EditValueChanged(object sender, EventArgs e)
        {
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sqlcmd = new SqlCommand("BaoCao_An_Ngu_Del", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                Ma_BC.Value = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                sqlcmd.ExecuteNonQuery();
                label_ThongBao.Text = "Đã xóa thành công!";
                conn.Close();
                TimKiem();
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
                label_ThongBao.Text = "Xóa không thành công!";
                label_ThongBao.ForeColor = System.Drawing.Color.Red;
                conn.Close();
            }
            
        }

        private void gridView1_CellMouseClick(object sender, EventArgs e)
        {
            if(gridView1.RowCount != 0)
            {
                maBC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
                tenBC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
                maTre = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
                tenTre = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
                ngay = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
                ttAn = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
                ttNgu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
                ttVuiChoi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();
                maNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8]).ToString();
                ngayTao = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[9]).ToString();
                ghiChu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[10]).ToString();
                button_Sua.Enabled = true;
                button_Xoa.Enabled = true;
                label_ThongBao.Text = "";
            }

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string maBC, tenBC, maTre, tenTre, ngay, ttAn, ttNgu, ttVuiChoi, maNV, ngayTao, ghiChu;
        //private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    //object dr = gridView1.GetRow(gridView1.FocusedRowHandle);
        //    maBC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
        //    tenBC = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    maTre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    tenTre = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    ngay = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //    ttAn = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //    ttNgu = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //    ttVuiChoi = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        //    maNV = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        //    ngayTao = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        //    ghiChu = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        //}
        private void button_NhapLaiTatCa_Click(object sender, EventArgs e)
        {
            comboBox_SapXep.SelectedItem = "--- default ---";
            textBox_MaBC.Text = null;
            textBox_TenBC.Text = null;
            textBox_MaTre.Text = null;
            textBox_HoTen.Text = null;
            textBox_BaoCaoNgay.Text = null;
            textBox_TT_An.Text = null;
            textBox_TT_Ngu.Text = null;
            textBox_TT_VuiChoi.Text = null;
            textBox_Ngay_Tao.Text = null;
            textBox_Ma_Nguoi_Tao.Text = null;
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
        }

        //internal Form_Edit f;
        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Edit f = new Form_Edit(this);
                f.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void TimKiem()
        {
            try
            {
                conn.Open();
                dt = new DataTable();
                switch (comboBox_SapXep.SelectedItem.ToString())
                {
                    case "--- default ---":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Search", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 50);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 100);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        gridControl1.DataSource = dt;
                        break;
                    case "Họ tên       A -> Z":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Name", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 50);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 100);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 0;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        gridControl1.DataSource = dt;
                        break;
                    case "Họ tên       Z -> A":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Name", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 50);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 100);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 1;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        gridControl1.DataSource = dt;
                        break;

                    case "Ngày tháng tăng dần":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Date", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 50);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 100);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 0;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        gridControl1.DataSource = dt;
                        break;
                    case "Ngày tháng giảm dần":
                        sqlcmd = new SqlCommand("BaoCao_An_Ngu_Sort_by_Date", conn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        // Construction Parameters:
                        _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                        _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 50);
                        _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                        _ten_Tre = sqlcmd.Parameters.Add("@p_TEN_TRE", SqlDbType.NVarChar, 30);
                        _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                        _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                        _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                        _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 100);
                        _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                        _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                        _sort_by = sqlcmd.Parameters.Add("@p_SORT_BY", SqlDbType.Int);
                        // Transmitted value to Parameter:
                        _ma_BC.Value = textBox_MaBC.Text;
                        _ten_BC.Value = textBox_TenBC.Text;
                        _ma_Tre.Value = textBox_MaTre.Text;
                        _ten_Tre.Value = textBox_HoTen.Text;
                        _ngay.Value = textBox_BaoCaoNgay.Text.ToString();
                        _tinh_Trang_An.Value = textBox_TT_An.Text;
                        _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                        _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                        _ma_NV.Value = textBox_Ma_NV.Text;
                        _ngay_Tao.Value = textBox_Ngay_Tao.Text.ToString();
                        _sort_by.Value = 1;
                        reader = sqlcmd.ExecuteReader();
                        dt.Load(reader);
                        gridControl1.DataSource = dt;
                        break;
                    default:
                        //reader = sqlcmd.ExecuteReader();
                        //dt = new DataTable();
                        //dt.Load(reader);
                        //dataGridView1.DataSource = dt;
                        break;
                }
                conn.Close();
                label_SoLuong.Text = "Có tổng cộng " + gridView1.DataRowCount + " báo cáo";
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.StackTrace);
            }
    }
    
    }
}
