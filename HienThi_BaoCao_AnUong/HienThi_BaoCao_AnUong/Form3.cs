using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
namespace HienThi_BaoCao_AnUong
{
        public partial class Form3 : Form
        {
            public Form3()
            {
                InitializeComponent();
            }
            SqlConnection con = new SqlConnection(@"Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");

            private void KetNoiCSDL()
            {
                SqlConnection con = new SqlConnection(@"Data Source=REUS;Initial Catalog=QLNT;Integrated Security=True");
                con.Open();
                string sql = "select * from BaoCao_An_Ngu";
                SqlCommand com = new SqlCommand(sql, con);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }

            private void Form3_Load(object sender, EventArgs e)
            {
                KetNoiCSDL();

            }

            private void btThem_Click_1(object sender, EventArgs e)
            {
                if ((String.Compare(txtMaBC.Text.Trim(), "", true) == 0) || (String.Compare(txtMaTre.Text.Trim(), "", true) == 0))
                {
                    MessageBox.Show("Không được thiếu mã báo cáo hoặc mã trẻ! ");

                }
                else
                {
                    string ma = txtMaBC.Text.Trim();
                    DataTable dt = SqlHelper.ExecuteDataset(con, "KiemTra1", ma).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Báo Cáo đã bị trùng!");
                    }
                    else
                    {

                        string ma3 = txtMaTre.Text.Trim();
                        DataTable dta = SqlHelper.ExecuteDataset(con, "KiemTra3", ma3).Tables[0];
                        if (dta.Rows.Count <= 0)
                        {
                            MessageBox.Show("Mã Trẻ không tồn tại! ");
                        }
                        else
                        { 
                            string ma2 = txtMaNV.Text.Trim();
                            DataTable dta1 = SqlHelper.ExecuteDataset(con, "KiemTra2", ma2).Tables[0];
                            if (dta1.Rows.Count <= 0)
                            {
                                MessageBox.Show("Nhân viên không tồn tại! ");
                            }
                            else
                            {
                                try
                                {
                                    string strTenBC = txtTenBC.Text.Trim();
                                    string strMaBC = txtMaBC.Text.Trim();
                                    string strMaTre = txtMaTre.Text.Trim();
                                    string dtNgay = dateNgay.Text.Trim();
                                    string strTTAn = txtTTAn.Text.Trim();
                                    string strTTNgu = txtTTNgu.Text.Trim();
                                    string strTTVuiChoi = txtVuiChoi.Text.Trim();
                                    string strMaNV = txtMaNV.Text.Trim();
                                    string dtNgayTao = dateNgayTao.Text.Trim();
                                    string strGhiChu = txtGhiChu.Text.Trim();
                                    con.Open();
                                    string sql = "ThemBC_AnNgu";
                                    SqlCommand com = new SqlCommand(sql, con);
                                    com.CommandType = CommandType.StoredProcedure;

                                    com.Parameters.Add("@MaBC", SqlDbType.NVarChar, 10).Value = strMaBC;
                                    com.Parameters.Add("@MaTre", SqlDbType.NVarChar, 10).Value = strMaTre;
                                    com.Parameters.Add("@TenBC", SqlDbType.NVarChar, 50).Value = strTenBC;
                                    com.Parameters.Add("@Ngay", SqlDbType.Date).Value = dtNgay;
                                    com.Parameters.Add("@TinhTrang_An", SqlDbType.NVarChar, 100).Value = strTTAn;
                                    com.Parameters.Add("@TinhTrang_Ngu", SqlDbType.NVarChar, 100).Value = strTTNgu;
                                    com.Parameters.Add("@TinhTrang_Vui_Choi", SqlDbType.NVarChar, 100).Value = strTTVuiChoi;
                                    com.Parameters.Add("@Ma_NV", SqlDbType.NVarChar, 10).Value = strMaNV;
                                    com.Parameters.Add("@Ngay_Tao", SqlDbType.Date).Value = dtNgayTao;
                                    com.Parameters.Add("@Ghi_Chu", SqlDbType.NVarChar, 1000).Value = strGhiChu;
                                    com.ExecuteNonQuery();
                                    MessageBox.Show("Thêm thông tin thành công");
                                    KetNoiCSDL();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi:" + ex.ToString());
                                }
                                finally
                                {
                                    con.Close();
                                }
                            }
                        }
                    }
                }
            }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //private void btXoa_Click_1(object sender, EventArgs e)
        //{
        //    string ma = txtMaBC.Text.Trim();
        //    DataTable dt = SqlHelper.ExecuteDataset(con, "KiemTra", ma).Tables[0];
        //    if (dt.Rows.Count <= 0)
        //    {
        //        MessageBox.Show("Mã Báo Cáo Không Tồn Tại");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string strMaBC = txtMaBC.Text.Trim();
        //            con.Open();
        //            string sql = "XoaBC_AnNgu";
        //            SqlCommand com = new SqlCommand(sql, con);
        //            com.CommandType = CommandType.StoredProcedure;
        //            com.Parameters.Add("@Ma_BC", SqlDbType.NVarChar, 10).Value = strMaBC;
        //            com.ExecuteNonQuery();
        //            MessageBox.Show("Xóa Thành Công");
        //            KetNoiCSDL();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi:" + ex.ToString());
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }

        //    }
        //}

        //    private void btSua_Click_1(object sender, EventArgs e)
        //    {
        //        string ma = txtMaBC.Text.Trim();
        //        DataTable dt = SqlHelper.ExecuteDataset(con, "KiemTra", ma).Tables[0];
        //        if (dt.Rows.Count <= 0)
        //        {
        //            MessageBox.Show("Mã Báo Cáo Không Tồn Tại");
        //        }
        //        else
        //        {
        //            try
        //            {
        //                string strTenBC = txtTenBC.Text.Trim();
        //                string strMaBC = txtMaBC.Text.Trim();
        //                string strMaTre = txtMaTre.Text.Trim();
        //                string dtNgay = dateNgay.Text.Trim();
        //                string strTTAn = txtTTAn.Text.Trim();
        //                string strTTNgu = txtTTNgu.Text.Trim();
        //                string strTTVuiChoi = txtVuiChoi.Text.Trim();
        //                string strMaNV = txtMaNV.Text.Trim();
        //                string dtNgayTao = dateNgayTao.Text.Trim();
        //                string strGhiChu = txtGhiChu.Text.Trim();
        //                con.Open();
        //                string sql = "SuaBC_AnNgu";
        //                SqlCommand com = new SqlCommand(sql, con);
        //                com.CommandType = CommandType.StoredProcedure;

        //                com.Parameters.Add("@Ma_BC", SqlDbType.NVarChar, 10).Value = strMaBC;
        //                com.Parameters.Add("@Ma_Tre", SqlDbType.NVarChar, 10).Value = strMaTre;
        //                com.Parameters.Add("@Ten_BC", SqlDbType.NVarChar, 50).Value = strTenBC;
        //                com.Parameters.Add("@Ngay", SqlDbType.Date).Value = dtNgay;
        //                com.Parameters.Add("@TT_An", SqlDbType.NVarChar, 100).Value = strTTAn;
        //                com.Parameters.Add("@TT_Ngu", SqlDbType.NVarChar, 100).Value = strTTNgu;
        //                com.Parameters.Add("@TT_VuiChoi", SqlDbType.NVarChar, 100).Value = strTTVuiChoi;
        //                com.Parameters.Add("@Ma_NV", SqlDbType.NVarChar, 10).Value = strMaNV;
        //                com.Parameters.Add("@Ngay_Tao", SqlDbType.Date).Value = dtNgayTao;
        //                com.Parameters.Add("@Ghi_Chu", SqlDbType.NVarChar, 1000).Value = strGhiChu;
        //                com.ExecuteNonQuery();
        //                MessageBox.Show("Chỉnh Sửa Thành Công");
        //                KetNoiCSDL();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Lỗi:" + ex.ToString());
        //            }
        //            finally
        //            {
        //                con.Close();
        //            }

        //        }
        //    }
    }


}
