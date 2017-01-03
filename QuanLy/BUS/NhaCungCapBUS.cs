using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO objNCC = new NhaCungCapDAO();
        public bool addNCC(NhaCungCap nhacungcap)
        {
            return objNCC.addNhaCungCap(nhacungcap);
        }
        public bool deleteNhaCungCap(string maNCC)
        {
            return objNCC.deleteNhaCungCap(maNCC);
        }
        public bool updateNhaCungCap(NhaCungCap nhacungcap)
        {
            return objNCC.updateNhaCungCap(nhacungcap);
        }
        public NhaCungCap getNhaCungCap(string maNCC)
        {
            return objNCC.getNhaCungCap(maNCC);
        }
        public DataTable getAllNhaCungCap()
        {
            return objNCC.getAllNhaCungCap();
        }
        public DataTable searchNCC(string maNCC, string tenNCC)
        {
            return objNCC.searchNCC(maNCC, tenNCC);
        }
    }
}
