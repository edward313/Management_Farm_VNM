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
    public class BLL_TrangTrai
    {
        DataProvider a = new DataProvider();
        public DataTable DSNongTrai()
        {

            DataTable table = a.ExecuteQueryDataSet("DSNT", CommandType.StoredProcedure);
            return table;
        }


        public void addTrangtrai(string MaNT, string TenNT, string ChuSoHuu, string diachi, string SDT, string maTK)
        {
            a.MyExecuteNonQuery("insertNT", CommandType.StoredProcedure, new SqlParameter("@MaNT", MaNT), new SqlParameter("@TenNT", TenNT), new SqlParameter("@ChuSoHuu", ChuSoHuu), new SqlParameter("@diachi", diachi), new SqlParameter("@SDT", SDT), new SqlParameter("@MaTK", maTK));
        }
        public void deleteTrangtrai(string MaNT)
        {
            a.MyExecuteNonQuery("deleteNT", CommandType.StoredProcedure, new SqlParameter("@MaNT", MaNT));


            
        }



    }
}
