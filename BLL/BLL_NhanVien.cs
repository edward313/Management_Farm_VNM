using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_NhanVien
    {
        DataProvider a = new DataProvider();


        public DataTable DSNhanVien()
        {

            DataTable table = a.ExecuteQueryDataSet("DS_NhanVien", CommandType.StoredProcedure);
            return table;
        }

        public void addNhanVien(string MaNV, string TenNV, string SDT, string GioiTinh, DateTime NgaySinh)
        {
            a.MyExecuteNonQuery("InsertNV", CommandType.StoredProcedure, new SqlParameter("@MaNV", MaNV), new SqlParameter("@TenNV", MaNV), new SqlParameter("@SDT", SDT), new SqlParameter("@GioiTinh", GioiTinh), new SqlParameter("@NgaySinh", NgaySinh));
        }


        public void updateNhanVien(string MaNV, string TenNV, string SDT, string GioiTinh, DateTime NgaySinh)
        {
            a.MyExecuteNonQuery("UpdateNV", CommandType.StoredProcedure, new SqlParameter("@MaNV", MaNV), new SqlParameter("@TenNV", TenNV), new SqlParameter("@SDT", SDT), new SqlParameter("@GioiTinh", GioiTinh), new SqlParameter("@NgaySinh", NgaySinh));
        }


        public void deleteNV(string MaNV)
        {
            a.MyExecuteNonQuery("DeleteNV", CommandType.StoredProcedure, new SqlParameter("@MaNV", MaNV));
        }
    }


}