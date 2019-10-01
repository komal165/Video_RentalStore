using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalStore
{
    public partial class Form1 : Form
    {
        // Indexing Variables
        private int CustomersRowIndex;
        private int MovieRowIndex;
        private int RentalRowIndex;

        // Selected Row ID's
        private int CustomerRowID = 0;
        private int MovieRowID = 0;
        private int RentalRawID = 0;

        private void RunStoredProc()
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

            try
            {
                conn = new SqlConnection(Database.GetConnection());
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.MovieProcedure", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            RunStoredProc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill the tables
            Database.AddToDataGridView("Movies", MoviesList);
            Database.AddToDataGridView("Customers", CustomersList);
            Database.AddToDataGridView("Rented", RentalsList);

            // Add Movie Genre
            AddGenre();

            // Calculate movie price based on release date
            TimeSpan timeSpan = DateTime.Now.Subtract(MovieReleaseDateText.Value);
            float totalYears = Convert.ToInt32(timeSpan.TotalDays) / 364.5f;
            if (totalYears >= 5)
            {
                MovieCostText.Text = "2.0";
            }
            else
            {
                MovieCostText.Text = "5.0";
            }

            // Make sure all the fields have default values!
            ResetMovieFields();
            ResetCustomersFields();
            ResetRentalsFields();
        }

        /***********************************************************/
        // MOVIE

        // Resets all the fields for renting
        private void ResetMovieFields()
        {
            MovieTitleText.Text = "";
            MovieReleaseDateText.Value = DateTime.Now;
            MovieRatings.Value = 0.5m;
            AvailableCopiesValue.Value = 0;
            MovieCostText.Text = "";
            MovieGenreBox.SelectedIndex = 0;

            // Change movie row ID to 0 so that in case if user tries to tap on delete it won't work unless correct field is selected
            MovieRowID = 0;
        }

        private void AddGenre()
        {
            string[] listOfGenre = { "Action", "Adventure", "Comedy", "Sci-Fi", "Galactic Patrol", "Animated", "Romance" };
            MovieGenreBox.Items.AddRange( listOfGenre );
        }

        private void MovieAdd_Click(object sender, EventArgs e)
        {
            if(MovieTitleText.Text != "" || MovieCostText.Text != "")
            {
                string columns = "(MovieTitle, MovieReleaseDate, MovieRatings, MovieCopies, MovieRentingCost, MovieGenre)";
                string values = "(@title, @release, @ratings, @copies, @cost, @genre)";
                string[] fieldNames = { "@title", "@release", "@ratings", "@copies", "@cost", "@genre" };
                object[] inputFields = { MovieTitleText.Text, MovieReleaseDateText.Value, MovieRatings.Value, AvailableCopiesValue.Value, MovieCostText.Text, MovieGenreBox.SelectedItem.ToString() };
                Database.INSERT("Movies", columns, values, false, "", inputFields, fieldNames);
            }
            else
            {
                MessageBox.Show("One of More fields are empty");
            }

            ResetMovieFields();

            // Refresh Table with changes made to it
            Database.AddToDataGridView("Movies", MoviesList);
        }

        private void MovieModify_Click(object sender, EventArgs e)
        {
            if (MovieTitleText.Text != "" || MovieCostText.Text != "")
            {
                string values = "MovieTitle=@title, MovieReleaseDate=@release, MovieRatings=@ratings, MovieCopies=@copies, MovieRentingCost=@cost, MovieGenre=@genre";
                string[] inputs     = { "@title", "@release", "@ratings", "@copies", "@cost", "@genre" };
                object[] fieldNames = { MovieTitleText.Text, MovieReleaseDateText.Value, MovieRatings.Value, AvailableCopiesValue.Value, MovieCostText.Text, MovieGenreBox.SelectedItem.ToString() };
                Database.UPDATE("Movies", values, true, "MovieID=" + MovieRowID, inputs, fieldNames);
            }
            else
            {
                MessageBox.Show("One of More fields are empty");
            }

            ResetMovieFields();

            // Refresh Table with changes made to it
            Database.AddToDataGridView("Movies", MoviesList);
        }

        private void MovieDelete_Click(object sender, EventArgs e)
        {
            // Checks if user has rented any movies before User can be deleted
            if (Database.HasRentedCopies(MovieRowID))
            {
                MessageBox.Show("One of more copies of this movie are rented!");
            }
            else
            {
                Database.DELETE("Movies", "MovieID", MovieRowID.ToString());

                // Refresh Table with changes made to database table
                Database.AddToDataGridView("Movies", MoviesList);
                ResetMovieFields();
            }
        }

        private void MoviesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MovieRowIndex = e.RowIndex;

            // To avoid crashing if incorrect index is selected we run this condition
            if (this.MovieRowIndex < 0)
            {
                Console.WriteLine("Invalid Index Selected!");
                ResetMovieFields();
            }
            else
            {
                DataGridViewRow row = MoviesList.Rows[this.MovieRowIndex];

                // Check's whether row is selected or not
                if (row.Selected)
                {
                    // Check's if the user didn't select the auto generated row
                    if (this.MovieRowIndex < MoviesList.Rows.Count - 1)
                    {
                        // Enable delete button so user has the functionality to delete
                        MovieDelete.Enabled = true;

                        // Assign values to all the form fields
                        MovieRowID = Convert.ToInt32(row.Cells[0].Value);
                        MovieTitleText.Text = row.Cells[1].Value.ToString();
                        MovieReleaseDateText.Value = Convert.ToDateTime(row.Cells[2].Value);
                        MovieRatings.Value = Convert.ToDecimal(row.Cells[3].Value);
                        AvailableCopiesValue.Value = Convert.ToInt32(row.Cells[4].Value);
                        MovieCostText.Text = row.Cells[5].Value.ToString();
                        if (MovieGenreBox.Items.Contains(row.Cells[6].Value.ToString()))
                        {
                            MovieGenreBox.SelectedItem = row.Cells[6].Value.ToString();
                        }
                        else
                        {
                            MovieGenreBox.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MovieDelete.Enabled = false;
                        Console.WriteLine("Null operator doesn't exist!");
                        ResetMovieFields();
                    }
                }
                else
                {
                    ResetMovieFields();
                }
            }
        }

        /***********************************************************/
        // CUSTOMERS

        private void ResetCustomersFields()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            addressText.Text = "";
            phoneNumberText.Text = "";

            // Change movie row ID to 0 so that in case if user tries to tap on delete it won't work unless correct field is selected
            CustomerRowID = 0;
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            // If all the fields have valid value proceed
            if(firstNameText.Text != "" || lastNameText.Text != "" || addressText.Text != "" || phoneNumberText.Text != "")
            {
                string columns = "(FirstName, LastName, Address, PhoneNumber)";
                string values = "(@first, @last, @address, @phone)";
                object[] inputFields = { firstNameText.Text, lastNameText.Text, addressText.Text, phoneNumberText.Text };
                string[] fieldNames = { "@first", "@last", "@address", "@phone" };
                Database.INSERT("Customers", columns, values, false, "", inputFields, fieldNames);

                // Refresh table and apply new changes to the table
                Database.AddToDataGridView("Customers", CustomersList);

                ResetCustomersFields();
            }
            else
            {
                MessageBox.Show("One or More fields are empty!");
            }
        }

        private void ModifyCustomer_Click(object sender, EventArgs e)
        {
            // If all the fields have valid value proceed
            if (firstNameText.Text != "" || lastNameText.Text != "" || addressText.Text != "" || phoneNumberText.Text != "")
            {
                string values = "FirstName=@first, LastName=@last, Address=@address, PhoneNumber=@phone";
                object[] inputFields = { firstNameText.Text, lastNameText.Text, addressText.Text, phoneNumberText.Text };
                string[] fieldNames = { "@first", "@last", "@address", "@phone" };
                Database.UPDATE("Customers", values, true, "CustomerID=" + CustomerRowID, fieldNames, inputFields);

                // Refresh table and apply new changes to the table
                Database.AddToDataGridView("Customers", CustomersList);

                ResetCustomersFields();
            }
            else
            {
                MessageBox.Show("One or More fields are empty!");
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (Database.HasUserRentedMovie(CustomerRowID))
            {
                MessageBox.Show("This Customer has Rented Movies!");
            }
            else
            {
                // Delete Customer from list
                Database.DELETE("Customers", "CustomerID", CustomerRowID.ToString());
                Database.AddToDataGridView("Customers", CustomersList);

                // Makes sure to clear the fields once the user is deleted.
                ResetCustomersFields();
            }
        }

        private void CustomersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CustomersRowIndex = e.RowIndex;

            // To avoid crashing if incorrect index is selected we run this condition
            if (this.CustomersRowIndex < 0)
            {
                Console.WriteLine("Invalid Index Selected!");
            }
            else
            {
                DataGridViewRow row = CustomersList.Rows[this.CustomersRowIndex];

                // Check's whether row is selected or not
                if (row.Selected)
                {
                    // Check's if the user didn't select the auto generated row
                    if (this.CustomersRowIndex < CustomersList.Rows.Count - 1)
                    {
                        // Enable delete button so user has the functionality to delete
                        deleteCustomer.Enabled = true;

                        CustomerRowID = Convert.ToInt32(row.Cells[0].Value);
                        firstNameText.Text = row.Cells[1].Value.ToString();
                        lastNameText.Text = row.Cells[2].Value.ToString();
                        addressText.Text = row.Cells[3].Value.ToString();
                        phoneNumberText.Text = row.Cells[4].Value.ToString();
                    }
                    else
                    {
                        deleteCustomer.Enabled = false;
                        Console.WriteLine("Null operator doesn't exist!");

                        // Clear all fields
                        ResetCustomersFields();
                    }
                }
                else
                {
                    // Clear all fields
                    ResetCustomersFields();
                }
            }
        }

        /***********************************************************/
        // RENTAL

        private void ResetRentalsFields()
        {
            RentFromMovie.Value = DateTime.Now;
            RentTillMovie.Value = RentTillMovie.Value.AddDays(1);
        }

        private void RentalsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RentalRowIndex = e.RowIndex;

            // To avoid crashing if incorrect index is selected we run this condition
            if (this.RentalRowIndex < 0)
            {
                Console.WriteLine("Invalid Index Selected!");
            }
            else
            {
                DataGridViewRow row = RentalsList.Rows[this.RentalRowIndex];

                // Check's whether row is selected or not
                if (row.Selected)
                {
                    // Check's if the user didn't select the auto generated row
                    if (this.RentalRowIndex < RentalsList.Rows.Count - 1)
                    {
                        // Enable delete button so user has the functionality to delete
                        deleteCustomer.Enabled = true;

                        RentalRawID = Convert.ToInt32(row.Cells[0].Value);
                        RentFromMovie.Value = Convert.ToDateTime(row.Cells[3].Value);
                        RentTillMovie.Value = Convert.ToDateTime(row.Cells[4].Value);
                    }
                    else
                    {
                        deleteCustomer.Enabled = false;
                        Console.WriteLine("Null operator doesn't exist!");

                        // Clear all fields
                        ResetRentalsFields();
                    }
                }
                else
                {
                    // Clear all fields
                    ResetRentalsFields();
                }
            }
        }

        private void IssueMovie_Click(object sender, EventArgs e)
        {
            if (CustomerRowID > 0 && MovieRowID > 0)
            {
                using (SqlConnection conn = new SqlConnection(Database.GetConnection()))
                {
                    // Open Connection
                    conn.Open();

                    // Only issues movies if the copies of movie are available
                    if (AvailableCopiesValue.Value > 0)
                    {
                        using (SqlCommand _cmd = new SqlCommand("UPDATE Movies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                        {
                            _cmd.Parameters.AddWithValue("@copies", Convert.ToInt32(AvailableCopiesValue.Value - 1));
                            _cmd.Parameters.AddWithValue("@id", MovieRowID);
                            _cmd.ExecuteNonQuery();
                        }

                        // Add Movie to Rented Movies table
                        using (SqlCommand _cmd = new SqlCommand("INSERT INTO Rented (CustomerID, MovieID, RentFrom, RentTill) VALUES(@cid, @mid, @from, @till)", conn))
                        {
                            _cmd.Parameters.AddWithValue("@cid", CustomerRowID);
                            _cmd.Parameters.AddWithValue("@mid", MovieRowID);
                            _cmd.Parameters.AddWithValue("@from", RentFromMovie.Value);
                            _cmd.Parameters.AddWithValue("@till", RentTillMovie.Value);
                            _cmd.ExecuteNonQuery();
                        }

                        // Calculate renting period in days
                        TimeSpan time = RentTillMovie.Value.Subtract(RentFromMovie.Value);

                        // Display as pop-up message
                        MessageBox.Show(firstNameText.Text + " has rented " + MovieTitleText.Text + " for " + Convert.ToInt32(time.TotalDays) + " days!");

                        // Update all the tables
                        Database.AddToDataGridView("Movies", MoviesList);
                        Database.AddToDataGridView("Customers", CustomersList);
                        Database.AddToDataGridView("Rented", RentalsList);
                    }
                    else
                    {
                        MessageBox.Show("All copies of " + MovieTitleText.Text + " are rented!");
                    }
                }
            }
            else
            {
                if (CustomerRowID <= 0)
                {
                    MessageBox.Show("Please Select the customer!");
                }
                else
                {
                    MessageBox.Show("Please Select the Movie!");
                }
            }
        }

        private void ReturnMovie_Click(object sender, EventArgs e)
        {
            Database.DELETE("Rented", "RentalID", RentalRawID.ToString());

            Database.AddToDataGridView("Rented", RentalsList);

            using (SqlConnection conn = new SqlConnection(Database.GetConnection()))
            {
                // Open Connection
                conn.Open();

                // Execute Query
                using (SqlCommand _cmd = new SqlCommand("UPDATE Movies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                {
                    int copies = 0;
                    SqlCommand _getcopies = new SqlCommand("SELECT MovieCopies FROM Movies WHERE MovieID=@mid", conn);
                    _getcopies.Parameters.AddWithValue("@mid", MovieRowID);
                    SqlDataReader reader = _getcopies.ExecuteReader();
                    while (reader.Read())
                    {
                        copies = Convert.ToInt32(reader["MovieCopies"]);
                    }
                    reader.Close();

                    _cmd.Parameters.AddWithValue("@copies", copies + 1);
                    _cmd.Parameters.AddWithValue("@id", MovieRowID);
                    _cmd.ExecuteNonQuery();

                    MessageBox.Show(firstNameText.Text + " has returned the movie " + MovieTitleText.Text);
                }

                // Update Tables to keep the table data in sync
                Database.AddToDataGridView("Movies", MoviesList);
            }
        }

        private void RentFromMovie_ValueChanged(object sender, EventArgs e)
        {
            if (RentFromMovie.Value.Date >= RentTillMovie.Value.Date)
            {
                RentTillMovie.Value = RentFromMovie.Value.AddDays(1);
            }
        }

        private void RentTillMovie_ValueChanged(object sender, EventArgs e)
        {
            if (RentTillMovie.Value.Date <= RentFromMovie.Value.Date)
            {
                RentTillMovie.Value = RentFromMovie.Value.AddDays(1);
            }
        }

        private void MovieReleaseDateText_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan spanTime = DateTime.Now.Subtract(MovieReleaseDateText.Value);
            float totalYears = Convert.ToInt32(spanTime.TotalDays) / 364.5f;
            if(totalYears >= 5)
            {
                MovieCostText.Text = "2.0";
            }
            else
            {
                MovieCostText.Text = "5.0";
            }
        }
    }
}
