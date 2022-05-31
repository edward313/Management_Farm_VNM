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
    public class BLL_HoaDon
    {
        DataProvider a = new DataProvider();

        public DataTable DSHoaDon()
        {

            DataTable table = a.ExecuteQueryDataSet("DS_HoaDon", CommandType.StoredProcedure);
            return table;
        }
        public void addHoaDon(string MaHD, string MaNT, string MaNPP, DateTime NgayBan, float ThanhTien)
        {
            a.MyExecuteNonQuery("insertHoaDon", CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD), new SqlParameter("@MaNT", MaNT), new SqlParameter("@MaNPP", MaNPP), new SqlParameter("@NgayBan", NgayBan), new SqlParameter("@ThanhTien", ThanhTien));
            

        }
    }
}
