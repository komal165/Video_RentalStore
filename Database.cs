using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public class Database
    {
        private static string DataSource = "DESKTOP-POQE336\\SQLEXPRESS";
        private static string DataBase = "RentingStore";

        public static string GetConnection()
        {
            return @"Data Source=" + DataSource + "; Initial Catalog=" + DataBase + "; Integrated Security=True";
        }
        public static void INSERT(string table, string columns, string values, bool bHasCondition, string condition, object[] inputs, string[] fieldValues)
        {
            using (SqlConnection conn = new SqlConnection(GetConnection()))
            {
                // Open Connection
                conn.Open();

                SqlCommand _cmd;

                // Check's if Query contains condition
                if (bHasCondition)
                {
                    _cmd = new SqlCommand("INSERT INTO " + table + columns + " VALUES " + values + " WHERE " + condition, conn);
                }
                else
                {
                    _cmd = new SqlCommand("INSERT INTO " + table + columns + " VALUES " + values, conn);
                }

                for (int i = 0; i < fieldValues.Length; i++)
                {
                    _cmd.Parameters.AddWithValue(fieldValues[i], inputs[i]);
                }

                _cmd.ExecuteNonQuery();
            }
        }

        public static void UPDATE(string table, string values, bool bHasCondition, string condition, string[] inputs, object[] fieldValues)
        {
            using (SqlConnection conn = new SqlConnection(GetConnection()))
            {
                // Open Connection
                conn.Open();

                SqlCommand _cmd = null;

                // Check's if Query contains condition
                if (bHasCondition)
                {
                    _cmd = new SqlCommand("UPDATE " + table + " SET " + values + " WHERE " + condition, conn);
                }
                else
                {
                    _cmd = new SqlCommand("UPDATE " + table + " SET " + values, conn);
                }

                for (int i = 0; i < fieldValues.Length; i++)
                {
                    _cmd.Parameters.AddWithValue(inputs[i], fieldValues[i]);
                }

                _cmd.ExecuteNonQuery();
            }
        }

        public static void DELETE(string table, string columnName, string rowID)
        {
            using (SqlConnection conn = new SqlConnection(GetConnection()))
            {
                // Open Connection
                conn.Open();

                string query = "DELETE FROM " + table + " WHERE " + columnName + "=" + rowID;
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.ExecuteNonQuery();
            }
        }

        // Add to DataGridView
        public static void AddToDataGridView(string table, DataGridView view)
        {
            using (SqlConnection conn = new SqlConnection(GetConnection()))
            {
                // Establish Connection
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + table, conn);
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                adapter.Fill(dataTable);

                view.AutoGenerateColumns = false;
                view.DataSource = dataTable;
            }
        }

        public static bool HasRentedCopies(int MovieID)
        {
            List<string> moviesList = new List<string>();
            using (SqlConnection conn = new SqlConnection(GetConnection()))
            {
                // Open Connection
                conn.Open();

                SqlCommand _cmd = new SqlCommand("SELECT * FROM Rented WHERE MovieID=@id", conn);
                _cmd.Parameters.AddWithValue("@id", MovieID.ToString());
                SqlDataReader reader;
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    moviesList.Add(reader["RentalID"].ToString());
                }
                reader.Close();

                return moviesList.Count > 0;
            }
        }

        public bool HasCopiesRented(int MovieID)
        {
            return HasRentedCopies(MovieID);
        }

        public static bool HasUserRentedMovie(int customerID)
        {
            List<string> MoviesList = new List<string>();
            using (SqlConnection conn = new SqlConnection(GetConnection()))
            {
                // Open Connection
                conn.Open();

                SqlCommand _cmd = new SqlCommand("Select * FROM Rented WHERE CustomerID=@id", conn);
                _cmd.Parameters.AddWithValue("@id", customerID);
                SqlDataReader reader;
                reader = _cmd.ExecuteReader();
                while (reader.Read())
                {
                    MoviesList.Add(reader["RentalID"].ToString());
                }
                reader.Close();
                return MoviesList.Count > 0;
            }
        }

        public bool UserHasRentedMovies(int CustomerID)
        {
            return HasUserRentedMovie(CustomerID);
        }
    }
}
