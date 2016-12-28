using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO khDAO;

        public KhachHangBUS()
        {
            khDAO = new KhachHangDAO();
        }
        public DataTable Load_DSKhachHang()
        {

            return khDAO.Load_DSKhachHang();
        }
        
        public bool Update_KhachHang(string _maKH, string _hoTen, string _diaChi, string _soDT, string _ghiChu)
        {
            try
            {
                return khDAO.Update_KhachHang(_maKH, _hoTen, _diaChi, _soDT, _ghiChu);
    
            }
            catch
            {
                return false;
            }
        }

         public bool Insert_KhachHang(string _hoTen, string _diaChi, string _soDT, string _ghiChu)
        {
            try
            {
                return khDAO.Insert_KhachHang(_hoTen, _diaChi, _soDT, _ghiChu);
    
            }
            catch
            {
                return false;
            }
        }

         public bool DeleteKhachHang(string makh)
         {
             try
             {
                 return khDAO.Delete_KhachHang(makh);
             }
             catch
             {
                 return false;
             }
         }
         public DataTable Search_KhachHang(string TuKhoa)
         {
             try
             {
                 return khDAO.Search_KhachHangTuKhoa(TuKhoa);
             }
             catch
             {
                 return null;
             }
         }

        

    }
}
