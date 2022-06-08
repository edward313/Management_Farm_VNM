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
    public class BLL_NPP
    {

        DataProvider a = new DataProvider();
        public DataTable DSNhaPhanPhoi()
        {

            DataTable table = a.ExecuteQueryDataSet("DSNPP", CommandType.StoredProcedure);
            return table;
        }

        public void addNPP(string MaNPP,string TenNPP,string Diachi,string SDT,string MaTK)
        {
            a.MyExecuteNonQuery("insertNPP", CommandType.StoredProcedure, new SqlParameter("@MaNPP", MaNPP), new SqlParameter("@TenNPP", TenNPP), new SqlParameter("@Diachi", Diachi), new SqlParameter("@SDT", SDT), new SqlParameter("@MaTk", MaTK));
        }

        public void UpdateNPP(string MaNPP, string TenNPP, string Diachi, string SDT, string MaTK)
        {
            a.MyExecuteNonQuery("UpdateNPP", CommandType.StoredProcedure, new SqlParameter("@MaNPP", MaNPP), new SqlParameter("@TenNPP", TenNPP), new SqlParameter("@Diachi", Diachi), new SqlParameter("@SDTNPP", SDT), new SqlParameter("@MaTk", MaTK));
        }



        public void deleteNPP(string MaNPP)
        {
            a.MyExecuteNonQuery("deleteNPP", CommandType.StoredProcedure, new SqlParameter("@MaNPP", MaNPP));
        }
    }
}
