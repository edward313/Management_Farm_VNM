using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_SanPham
    {


        DataProvider a = new DataProvider();
        public DataTable DSSanPham()
        {

            DataTable table = a.ExecuteQueryDataSet("DS_SanPham", CommandType.StoredProcedure);
            return table;
        }

        public DataTable DSSanPham_DonGia(string SanPham)
        {

            DataTable table = a.ExecuteQueryDataSet("SanPham_DonGia", CommandType.StoredProcedure, new SqlParameter("@MaSanPham", SanPham));
            return table;
        }
    }
}
