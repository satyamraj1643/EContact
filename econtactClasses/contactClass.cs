using Npgsql;
using System.CodeDom;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace EContact.econtactClasses
{
    internal class ContactClass
    {

        //Getter Setter properties
        //Acts as data carrier
        public int ContactID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string ContactNumber { get; set; }
        public  string Address { get; set; }
        public  string Gender { get; set; }

        private static string myConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        //selecting data from database


        //public DataTable Select()
        //{
        //    //Step1 : Establish DataBase COnnection

        //    SqlConnection ConnectionInstance = new SqlConnection(myConnectionString);
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        //STEP 2 : Providing a SQL C
        //        string sql = "SELECT * FROM tbl_contact";
        //        //Creating command using sql and ConnectionInstance (to show where to run the query)
        //        SqlCommand cmd = new SqlCommand(sql, ConnectionInstance);
        //        // Creating SQL adapter using command
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //        ConnectionInstance.Open();

        //        adapter.Fill(dt);
        //    }

        //    catch (Exception exc)
        //    {
        //        Console.WriteLine(exc.ToString());

        //    }
        //    finally
        //    {

        //        ConnectionInstance.Close();

        //    }

        //    return dt;


        //}


        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "Select * from tbl_contact";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
                    {
                        adapter.Fill(dt);
                    }
                }

                catch (Exception ex)
                {
                    //MessageBox.Show("Error", ex.Message);
                }
            }

            return dt;
        }

        //Inserting Data into database

        public bool Insert(ContactClass dataToInsert)
        {

            bool isInserted = false;

            using (NpgsqlConnection conn = new NpgsqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                     string sqlQuery = @"
                                   INSERT INTO tbl_contact (""FirstName"", ""LastName"", ""ContactNumber"", ""Address"", ""Gender"")
                                   VALUES (@FirstName, @LastName, @ContactNumber, @Address, @Gender)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", dataToInsert.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", dataToInsert.LastName);
                        cmd.Parameters.AddWithValue("@ContactNumber", dataToInsert.ContactNumber);
                        cmd.Parameters.AddWithValue("@Address", dataToInsert.Address);
                        cmd.Parameters.AddWithValue("@Gender", dataToInsert.Gender);


                        int rows = cmd.ExecuteNonQuery();
                        isInserted = rows > 0;

                    }
                }
                catch (Exception Exc)
                {
                   // MessageBox.Show("Error: " + Exc.Message);
                }
            }
            return isInserted;


        }


        //Method to update data in the database from our application

        public bool Update(ContactClass dataToUpdate)
        {

            Debug.WriteLine("In the update function!");
            bool isUpdated = false;

            using (NpgsqlConnection conn = new NpgsqlConnection(myConnectionString))
            {
                string sqlQuery = @"UPDATE tbl_contact SET 
                            ""FirstName"" = @FirstName, 
                            ""LastName"" = @LastName, 
                            ""ContactNumber"" = @ContactNumber, 
                            ""Address"" = @Address, 
                            ""Gender"" = @Gender 
                            WHERE ""ContactID"" = @ContactID";

                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", dataToUpdate.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", dataToUpdate.LastName);
                        cmd.Parameters.AddWithValue("@ContactNumber", dataToUpdate.ContactNumber);
                        cmd.Parameters.AddWithValue("@Address", dataToUpdate.Address);
                        cmd.Parameters.AddWithValue("@Gender", dataToUpdate.Gender);
                        cmd.Parameters.AddWithValue("@ContactID", dataToUpdate.ContactID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        isUpdated = rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error", ex.Message);
                }
            }

            return isUpdated;
        }


        public bool Delete(int contactIdToDelete)
        {

            bool isDeleted = false;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(myConnectionString))
                {
                    connection.Open();

                    // Step 1: Delete the contact from tbl_contact
                    string deleteQuery = "DELETE FROM tbl_contact WHERE \"ContactID\" = @ContactID";
                    using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ContactID", contactIdToDelete);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Step 2: Reset the sequence after successful deletion
                            ResetContactIDSequence(connection);

                            isDeleted = true;
                        }
                        else
                        {
                            isDeleted = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isDeleted;
        }

        private void ResetContactIDSequence(NpgsqlConnection connection)
        {
            try
            {
                // Find the maximum ContactID
                string getMaxContactIDQuery = "SELECT MAX(\"ContactID\") FROM tbl_contact";
                int maxContactID;
                using (NpgsqlCommand getMaxContactIDCommand = new NpgsqlCommand(getMaxContactIDQuery, connection))
                {
                    maxContactID = Convert.ToInt32(getMaxContactIDCommand.ExecuteScalar());
                }

                // Reset the sequence to the next value after the maximum ContactID
                string resetSequenceQuery = "SELECT setval('public.\"tbl_contact_ContactID_seq\"', @NextValue)";
                using (NpgsqlCommand resetSequenceCommand = new NpgsqlCommand(resetSequenceQuery, connection))
                {
                    resetSequenceCommand.Parameters.AddWithValue("@NextValue", maxContactID);
                    resetSequenceCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting sequence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int GetNextID()
        {
            int id = 0;

            using (NpgsqlConnection conn = new NpgsqlConnection(myConnectionString))
            {
                string query = "SELECT MAX(\"ContactID\") AS MaxContactID FROM tbl_contact";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value && result != null)
                    {
                        int maxID = Convert.ToInt32(result);
                        id = maxID + 1; 
                    }

                }
            }

            return id;
        }

    }
}
