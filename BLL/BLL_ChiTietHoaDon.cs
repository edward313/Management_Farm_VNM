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
    public class BLL_ChiTietHoaDon
    {

        DataProvider a = new DataProvider();
        public void addCTHoaDon(string MaHD, string MaSP, float SoLuong, float DonGia, float ThanhTien)
        {
            a.MyExecuteNonQuery("insertChiTietTHoaDon", CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD), new SqlParameter("@MaSP", MaSP), new SqlParameter("@SoLuong", SoLuong), new SqlParameter("@DonGia", DonGia), new SqlParameter("@ThanhTien", ThanhTien));

        }

        public DataTable ChiTietHoaDon(string MaHD)
        {

            DataTable table = a.ExecuteQueryDataSet("ChiTietDonHang", CommandType.StoredProcedure, new SqlParameter("@MaHoaDon", MaHD));
            return table;
        }

        



    }
}
