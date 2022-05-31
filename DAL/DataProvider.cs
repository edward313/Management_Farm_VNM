using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DataProvider
    {

        protected SqlConnection cnn;
        protected SqlCommand cmd;
        protected SqlDataAdapter adp;

        string strConnect =
            "Data Source=DESKTOP-UUE1LDF;Initial Catalog=vinamilk;Integrated Security=True";

        public DataProvider()
        {
            cnn = new SqlConnection(strConnect);
            cmd = cnn.CreateCommand();
        }

        // Select query
        public DataTable ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            adp = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adp.Fill(ds);
            return ds;
        }

        // action query
        public void MyExecuteNonQuery(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public int ExecuteFunction_DonTri(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            return (Int32)cmd.ExecuteScalar();
        }

        public float ExecuteFunction_DonTri_SoThuc(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            return (float)cmd.ExecuteScalar();
        }
        public string ExecuteFunction_Chuoi(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            return (string)cmd.ExecuteScalar().ToString();
        }
    }
}

