using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        public static DataProvider instance;

        public string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        
        public static DataProvider Instance
        {
            get { if (instance == null) return instance = new DataProvider(); return instance;  }
            private set {  instance = value; }
        }
        public DataProvider() { }
        public DataTable ExcuteQuery(string query,object[] parameter =null)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query,connection);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    adapter.Fill(table);
                } 
            }
            return table;
        }

        public int NonExcuteQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteNonQuery();
            }
            return data;
        }

        public object ExcuteScalarQuery(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteScalar();
            }
            return data;
        }
    }
}
