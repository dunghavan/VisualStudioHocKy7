using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace Presentation_Tier
{
    public partial class UserControl_ThayDoiQuyDinh : UserControl
    {
        private static UserControl_ThayDoiQuyDinh _instance;
        public static UserControl_ThayDoiQuyDinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl_ThayDoiQuyDinh();
                return _instance;
            }
        }
        public UserControl_ThayDoiQuyDinh()
        {
            InitializeComponent();
            loadValueFromDatabase();
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            label_notification.Text = null;
            numericUpDown_slTonKhoToiThieu.Focus();
        }
        // Các biến lưu giá trị:
        public static int slTonKhoToiThieu = 0;
        public static int soTienNoToiDa = 0;
        public static int chietKhau = 0;

        private ThamSoBUS objTSBUS = new ThamSoBUS();
        DataTable _tableThamSo = new DataTable();
        private void loadValueFromDatabase()
        {
            try
            {
                _tableThamSo = objTSBUS.getAllThamSo();
                foreach(DataRow dr in _tableThamSo.Rows)
                {
                    if (dr["TenThamSo"].ToString() == "SLTonToiThieu")
                        slTonKhoToiThieu = Convert.ToInt32(dr["GiaTri"]);
                    if (dr["TenThamSo"].ToString() == "SoTienNoToiDa")
                        soTienNoToiDa = Convert.ToInt32(dr["GiaTri"]);
                    if (dr["TenThamSo"].ToString() == "ChietKhau")
                        chietKhau = Convert.ToInt32(dr["GiaTri"]);
                }
                numericUpDown_slTonKhoToiThieu.Value = slTonKhoToiThieu;
                numericUpDown_soTienNoToiDa.Value = soTienNoToiDa;
                numericUpDown_chietKhau.Value = chietKhau;
            }
            catch(Exception e)
            {
                XtraMessageBox.Show("Lỗi load tham số: " + e.Message);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                slTonKhoToiThieu = (int)numericUpDown_slTonKhoToiThieu.Value;
                soTienNoToiDa = (int)numericUpDown_soTienNoToiDa.Value;
                chietKhau = (int)numericUpDown_chietKhau.Value;

                ThamSo[] thamSo_array = new ThamSo[3];
                thamSo_array[0] = new ThamSo("SLTonToiThieu", slTonKhoToiThieu);
                thamSo_array[1] = new ThamSo("SoTienNoToiDa", soTienNoToiDa);
                thamSo_array[2] = new ThamSo("ChietKhau", chietKhau);

                foreach (ThamSo t in thamSo_array)
                    objTSBUS.updateThamSo(t);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi cập nhật tham số: " + ex.Message);
            }
            label_notification.Text = "Cập nhật thành công!";
            loadValueFromDatabase();
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            loadValueFromDatabase();
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            label_notification.Text = null;
        }

        private void numericUpDown_slTonKhoToiThieu_ValueChanged(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            label_notification.Text = null;
        }

        private void numericUpDown_soTienNoToiDa_ValueChanged(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            label_notification.Text = null;
        }

        private void numericUpDown_chietKhau_ValueChanged(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            label_notification.Text = null;
        }
    }
}
