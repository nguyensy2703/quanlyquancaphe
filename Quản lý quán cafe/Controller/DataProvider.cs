using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_quán_cafe.Controller
{
   public class DataProvider
    {
        private string connectionString = @"Data Source=.\;Initial Catalog=QUANLYQUANCAFE;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            set => instance = value; 
        }

        public DataTable ExecuteQuery (string query, object[] value = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (value != null)
                {
                    string[] list_value = query.Split(' ');
                    int index_value = 0;
                    foreach (string val in list_value)
                    {
                        if (val.Contains('@'))
                        {
                            command.Parameters.AddWithValue(val, value[index_value]);
                            index_value++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] value = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (value != null)
                {
                    string[] list_value = query.Split(' ');
                    int index_value = 0;
                    foreach (string val in list_value)
                    {
                        if (val.Contains('@'))
                        {
                            command.Parameters.AddWithValue(val, value[index_value]);
                            index_value++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
        public object ExecuteNonQuery(string query, object[] value = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (value != null)
                {
                    string[] list_value = query.Split(' ');
                    int index_value = 0;
                    foreach (string val in list_value)
                    {
                        if (val.Contains('@'))
                        {
                            command.Parameters.AddWithValue(val, value[index_value]);
                            index_value++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
    }
    
}
