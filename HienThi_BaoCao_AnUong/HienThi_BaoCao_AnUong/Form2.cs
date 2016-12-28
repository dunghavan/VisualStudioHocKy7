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

namespace HienThi_BaoCao_AnUong
{
    public partial class Form_Edit : Form
    {
        public Form_Edit(Form callingForm)
        {
            f1 = callingForm as Form_View;
            InitializeComponent();
            button_Luu.Enabled = false;
        }
        private Form_View f1 = new Form_View();
        SqlConnection conn = new SqlConnection("Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");
        SqlDataReader reader;
        DataTable dt_MaTre;
        DataTable dt_MaNV;
        //DataTable dt_MaBC;
        // Declare Parameters:
        SqlCommand sqlcmd;
        SqlParameter _ma_BC, _ten_BC, _ma_Tre, _ngay, _tinh_Trang_An, _tinh_Trang_Ngu,
            _tinh_Trang_VuiChoi, _ma_NV, _ngay_Tao, _ghiChu;

        private void comboBox_MaTre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void textBox_HoTen_TextChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void textBox_TT_Ngu_TextChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void textBox_TT_VuiChoi_TextChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void textBox_TT_An_TextChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void textBox_GhiChu_TextChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void comboBox_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void dateTimePicker_Ngay_ValueChanged(object sender, EventArgs e)
        {
            button_Luu.Enabled = true;
        }

        private void textBox_TenBC_TextChanged(object sender, EventArgs e)
        {
            //button_Luu.Enabled = true;
        }

        private void textBox_MaBC_TextChanged(object sender, EventArgs e)
        {
            button_Luu.Enabled = true;
        }

        private void Form_Edit_Activated(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // Load Danh sách mã Báo Cáo
                //sqlcmd = new SqlCommand("BaoCao_An_Ngu_Lst_MaBC", conn);
                //sqlcmd.CommandType = CommandType.StoredProcedure;
                //reader = sqlcmd.ExecuteReader();
                //dt_MaBC.Load(reader);
                // Load Danh sách mã trẻ
                sqlcmd = new SqlCommand("Tre_Lst_MaTre", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                reader = sqlcmd.ExecuteReader();
                dt_MaTre = new DataTable();
                dt_MaTre.Load(reader);
                foreach(DataRow dr in dt_MaTre.Rows)
                {
                    comboBox_MaTre.Items.Add(dr[0]);
                }
                // Load Danh Sách mã Nhân Viên
                sqlcmd = new SqlCommand("Nhan_Vien_Lst_MaNV", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                reader = sqlcmd.ExecuteReader();
                dt_MaNV = new DataTable();
                dt_MaNV.Load(reader);
                foreach (DataRow dr in dt_MaNV.Rows)
                {
                    comboBox_MaNV.Items.Add(dr[0]);
                }
                conn.Close();
                // Gán các data từ DataGridView
                textBox_MaBC.Text = f1.maBC;
                textBox_TenBC.Text = f1.tenBC;
                comboBox_MaTre.Text = f1.maTre;
                textBox_HoTen.Text = f1.tenTre;
                dateTimePicker_Ngay.Text = f1.ngay;
                textBox_TT_An.Text = f1.ttAn;
                textBox_TT_Ngu.Text = f1.ttNgu;
                textBox_TT_VuiChoi.Text = f1.ttVuiChoi;
                comboBox_MaNV.Text = f1.maNV;
                dateTimePicker_NgayTao.Text = f1.ngayTao;
                textBox_GhiChu.Text = f1.ghiChu;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                conn.Close();
            }
        }

        private void Form_Edit_Deactivated(object sender, EventArgs e)
        {
        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            bool pass = true;
            // Kiểm tra các ràng buộc:
            if (comboBox_MaTre.Text == "")
            {
                pass = false;
                label_ThongBao.Text = "Lưu không thành công! \n Hãy nhập mã trẻ." + comboBox_MaTre.Text;
            }
            else if (!maTre_is_Exist(comboBox_MaTre.Text))
                {
                    pass = false;
                    label_ThongBao.Text = "Lưu không thành công! \n Không tồn tại trẻ có mã: " + comboBox_MaTre.Text;
                }

            if (comboBox_MaNV.Text == "")
            {
                pass = false;
                label_ThongBao.Text = "Lưu không thành công! \n Hãy nhập mã nhân viên." + comboBox_MaTre.Text;
            }
            else if (!maNV_is_Exist(comboBox_MaNV.Text))
                {
                    pass = false;
                    label_ThongBao.Text = "Lưu không thành công! \n Không tồn tại nhân viên có mã: " + comboBox_MaTre.Text;
                }
            if (pass == true)
            {
                try
                {

                    conn.Open();
                    sqlcmd = new SqlCommand("BaoCao_An_Ngu_Upd", conn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    // Construction Parameters:
                    _ma_BC = sqlcmd.Parameters.Add("@p_MA_BC", SqlDbType.NVarChar, 10);
                    _ten_BC = sqlcmd.Parameters.Add("@p_TEN_BC", SqlDbType.NVarChar, 50);
                    _ma_Tre = sqlcmd.Parameters.Add("@p_MA_TRE", SqlDbType.NVarChar, 10);
                    _ngay = sqlcmd.Parameters.Add("@p_NGAY", SqlDbType.NVarChar, 30);
                    _tinh_Trang_An = sqlcmd.Parameters.Add("@p_TINHTRANG_AN", SqlDbType.NVarChar, 100);
                    _tinh_Trang_Ngu = sqlcmd.Parameters.Add("@p_TINHTRANG_NGU", SqlDbType.NVarChar, 100);
                    _tinh_Trang_VuiChoi = sqlcmd.Parameters.Add("@p_TINHTRANG_VUICHOI", SqlDbType.NVarChar, 100);
                    _ma_NV = sqlcmd.Parameters.Add("@p_MA_NV", SqlDbType.NVarChar, 10);
                    _ngay_Tao = sqlcmd.Parameters.Add("@p_NGAY_TAO", SqlDbType.NVarChar, 30);
                    _ghiChu = sqlcmd.Parameters.Add("@p_GHI_CHU", SqlDbType.NVarChar, 1000);
                    // Transmitted value to Parameter:
                    _ma_BC.Value = textBox_MaBC.Text;
                    _ten_BC.Value = textBox_TenBC.Text;
                    _ma_Tre.Value = comboBox_MaTre.Text;
                    _ngay.Value = dateTimePicker_Ngay.Text;
                    _tinh_Trang_An.Value = textBox_TT_An.Text;
                    _tinh_Trang_Ngu.Value = textBox_TT_Ngu.Text;
                    _tinh_Trang_VuiChoi.Value = textBox_TT_VuiChoi.Text;
                    _ma_NV.Value = comboBox_MaNV.Text;
                    _ngay_Tao.Value = dateTimePicker_NgayTao.Text;
                    _ghiChu.Value = textBox_GhiChu.Text;
                    sqlcmd.ExecuteNonQuery();
                    conn.Close();
                    // Cập nhật kết quả:
                    f1.TimKiem();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    conn.Close();
                }
                f1.label_ThongBao.Text = "Cập nhật thành công!";
                f1.button_Sua.Enabled = false;
                f1.button_Xoa.Enabled = false;
                
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool maTre_is_Exist(string s)
        {
            foreach (DataRow dr in dt_MaTre.Rows)
                if (dr[0].ToString() == s)
                    return true;
            return false;
        }
        private bool maNV_is_Exist(string s)
        {
            foreach (DataRow dr in dt_MaNV.Rows)
                if (dr[0].ToString() == s)
                    return true;
            return false;
        }
        //private bool maBC_is_Exist(string s)
        //{
        //    foreach (DataRow dr in dt_MaBC.Rows)
        //        if (dr[0].ToString() == s)
        //            return true;
        //    return false;
        //}
    }
}
