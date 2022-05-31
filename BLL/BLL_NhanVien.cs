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
    }


}