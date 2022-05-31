using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_ACCOUNT
    {


        DataProvider a = new DataProvider();
        public DataTable DStaiKhoan()
        {

            DataTable table = a.ExecuteQueryDataSet("DS_taikhoan", CommandType.StoredProcedure);
            return table;
        }
        public int checklogin(string tk, string mk)
        {
            return a.ExecuteFunction_DonTri("check_login_role", CommandType.StoredProcedure, new SqlParameter("@matk", tk), new SqlParameter("@mk", mk));
        }
        public void addAccount(string MaTK, string MK, string role)
        {
            a.MyExecuteNonQuery("insertAccount", CommandType.StoredProcedure, new SqlParameter("@MaTK", MaTK), new SqlParameter("@MK",MK), new SqlParameter("@role", role));
        }

        public void editAccount(string MaTK, string MK, string role)
        {
            a.MyExecuteNonQuery("UpdateAccount", CommandType.StoredProcedure, new SqlParameter("@MaTK", MaTK), new SqlParameter("@MK", MK), new SqlParameter("@role", role));
        }
    }
}
