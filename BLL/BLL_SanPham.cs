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
        public void addSP(string MaSP, string TenSP, int Gia, int  SoLuong,int  DungTich)
        {
            a.MyExecuteNonQuery("InsertSP", CommandType.StoredProcedure, new SqlParameter("@MaSP", MaSP), new SqlParameter("@TenSP", MaSP), new SqlParameter("@Gia", Gia), new SqlParameter("@SoLuong", SoLuong), new SqlParameter("@DungTich", DungTich));
        }


        public void updateSP(string MaSP, string TenSP, int Gia, int SoLuong, int DungTich)
        {
            a.MyExecuteNonQuery("UpdateSP", CommandType.StoredProcedure, new SqlParameter("@MaSP", MaSP), new SqlParameter("@TenSP", TenSP), new SqlParameter("@Gia", Gia), new SqlParameter("@SoLuong", SoLuong), new SqlParameter("@DungTich", DungTich));
        }


        public void deleteSP(string MaSP)
        {
            a.MyExecuteNonQuery("DeleteSP", CommandType.StoredProcedure, new SqlParameter("@MaSP", MaSP));
        }


    }
}
