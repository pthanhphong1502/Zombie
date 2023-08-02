using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_băn_Zombie
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh
        SqlDataReader dataReader; //dung de doc du lieu trong bang
        SqlDataAdapter dataAdapter;
        public List<TaiKhoan> tK(string query)
        {
            List<TaiKhoan> tk = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    tk.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return tk;
        }
        public void Command(string query)   //dung de dk tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thuc thi cau truy van
                sqlConnection.Close();
            }
        }
        public DataTable getAllTaiKhoan()
        {
            DataTable dta = new DataTable();
            string query = "select * from DangNhap";
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                dataAdapter = new SqlDataAdapter(query, con);
                dataAdapter.Fill(dta);
                con.Close();
            }
            return dta;
        }
        public bool insert(TaiKhoan taikhoan)
        {
            SqlConnection con = Connection.GetSqlConnection();
            string query = "insert into DangNhap values (@TENTK,@MK)";
            try
            {
                con.Open();
                sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.Add("@TENTK", SqlDbType.VarChar).Value = taikhoan.Tentk;
                sqlCommand.Parameters.Add("@MK", SqlDbType.VarChar).Value = taikhoan.Mk;
                sqlCommand.ExecuteNonQuery(); //thuc thi lenh truy van

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        public bool delete(string tk)
        {
            SqlConnection con = Connection.GetSqlConnection();
            string query = "delete DangNhap where TENTK=@TENTK";
            try
            {
                con.Open();
                sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.Add("@TENTK", SqlDbType.VarChar).Value = tk;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
    }
}
