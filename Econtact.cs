using System;
using System.Data;
using System.Diagnostics;
using EContact.econtactClasses;

namespace EContact
{
    public partial class Econtact : Form


    {

        public Econtact()
        {
            InitializeComponent();
        }

        ContactClass ContactDetails = new ContactClass();

        DataTable dt;



        private void Econtact_Load(object sender, EventArgs e)
        {

            buttonAdd.Enabled = true;
            buttonAdd.Cursor = Cursors.Hand;
            buttonUpdate.Enabled = false;
            buttonUpdate.Cursor = Cursors.No;
            buttonDelete.Enabled = false;
            buttonDelete.Cursor = Cursors.No;
            buttonClear.Enabled = false;
            buttonClear.Cursor = Cursors.No;
            ;

            try
            {
                // Get the next available ContactID
                int nextContactID = ContactDetails.GetNextID();

                // Set the ContactID in the TextBox
                textBoxContactID.Text = nextContactID.ToString();

                // Load existing data into the DataGridView
                dt = ContactDetails.Select();
                ContactView.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelContactID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get the values of the input fields and try saving to the database

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string contactNumber = textBoxContactNumber.Text;
            string address = textBoxAddress.Text;
            string gender = comboBoxGender?.Text;

            //Debug.WriteLine($"FirstName: {firstName}, LastName: {lastName}, ContactNumber: {contactNumber}, Address: {address}, Gender: {gender}");



            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill all the fields properly", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int v;
                if (int.TryParse(textBoxContactID.Text, out v))
                {
                    ContactDetails.ContactID = v;
                }
                ContactDetails.FirstName = firstName;
                ContactDetails.LastName = lastName;
                ContactDetails.ContactNumber = contactNumber;
                ContactDetails.Address = address;
                ContactDetails.Gender = gender;
            }


            //Inserting Data into database.

            bool isInserted = ContactDetails.Insert(ContactDetails);

            if (isInserted)
            {
                int rows = ContactDetails.GetNextID();
                LoadData();
                MessageBox.Show("Contact added successfully", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                textBoxContactID.Text = (rows).ToString();

            }
            else
            {
                MessageBox.Show("An error ocurred while adding the contact, please try again later", "Error While Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Clearing all the fields




        }



        private void ContactView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {



            //Debug.WriteLine(ContactDetails);
            int v;
            if (int.TryParse(textBoxContactID.Text, out v))
            {
                ContactDetails.ContactID = v;
            }
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string contactNumber = textBoxContactNumber.Text;
            string address = textBoxAddress.Text;
            string gender = comboBoxGender?.Text;

            //Debug.WriteLine($"FirstName: {firstName}, LastName: {lastName}, ContactNumber: {contactNumber}, Address: {address}, Gender: {gender}");



            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill all the fields properly", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                ContactDetails.FirstName = firstName;
                ContactDetails.LastName = lastName;
                ContactDetails.ContactNumber = contactNumber;
                ContactDetails.Address = address;
                ContactDetails.Gender = gender;
            }



            bool isUpdated = ContactDetails.Update(ContactDetails);


            if (isUpdated)
            {
                int rows = ContactDetails.GetNextID();
                ClearFields();
                textBoxContactID.Text = (rows).ToString();


                buttonAdd.Enabled = true;
                buttonAdd.Cursor = Cursors.Hand;
                buttonUpdate.Enabled = false;
                buttonUpdate.Cursor = Cursors.No;
                buttonDelete.Enabled = false;
                buttonDelete.Cursor = Cursors.No;
                buttonClear.Enabled = false;
                buttonClear.Cursor = Cursors.No;
                LoadData();

                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error during update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void ContactView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data of selected item from the grid and put them in input boxes respectively
            //identify th erow on which mouse is clicked

            int rowIndex = e.RowIndex;
            DataGridViewRow row = ContactView.Rows[rowIndex];
            textBoxContactID.Text = (row.Cells["ContactID"].Value).ToString();
            textBoxFirstName.Text = (row.Cells["FirstName"].Value).ToString();
            textBoxLastName.Text = (row.Cells["LastName"].Value).ToString();
            textBoxContactNumber.Text = (row.Cells["ContactNumber"].Value).ToString();
            textBoxAddress.Text = (row.Cells["Address"].Value).ToString();
            comboBoxGender.Text = (row.Cells["Gender"].Value).ToString();

            buttonAdd.Enabled = false;
            buttonAdd.Cursor = Cursors.No;
            buttonUpdate.Enabled = true;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonDelete.Enabled = true;
            buttonDelete.Cursor = Cursors.Hand;
            buttonClear.Enabled = true;
            buttonClear.Cursor = Cursors.Hand;



        }


        void ClearFields()
        {
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxContactNumber.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            comboBoxGender.SelectedIndex = -1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            int v;
            if (int.TryParse(textBoxContactID.Text, out v))
            {
                ContactDetails.ContactID = v;
            }
            ContactDetails.FirstName = textBoxFirstName.Text.ToString();
            ContactDetails.LastName = textBoxLastName.Text.ToString();
            ContactDetails.ContactNumber = textBoxContactNumber.Text.ToString();
            ContactDetails.Address = textBoxAddress.Text.ToString();
            ContactDetails.Gender = comboBoxGender?.Text;



            bool isDeleted = ContactDetails.Delete(v);


            if (isDeleted)
            {
                int rows = ContactDetails.GetNextID();
                ClearFields();
                textBoxContactID.Text = (rows).ToString();


                buttonAdd.Enabled = true;
                buttonAdd.Cursor = Cursors.Hand;
                buttonUpdate.Enabled = false;
                buttonUpdate.Cursor = Cursors.No;
                buttonDelete.Enabled = false;
                buttonDelete.Cursor = Cursors.No;
                buttonClear.Enabled = false;
                buttonClear.Cursor = Cursors.No;
                LoadData();
                MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error during deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //load data in the data grid view

        private void LoadData()
        {

            try
            {

                dt = ContactDetails.Select();

                ContactView.DataSource = dt;

            }
            catch (Exception)
            {

            }

        }

       
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();

            // Create a DataView based on the DataTable
            DataView dv = dt.DefaultView;

            // Try to parse searchQuery as an integer (assuming ContactID is numeric)
            int contactID;
            bool isNumericSearch = int.TryParse(searchQuery, out contactID);

            if (isNumericSearch)
            {
                // Apply filter based on ContactID as integer
                dv.RowFilter = $"ContactID = {contactID}" +
                               $" OR FirstName LIKE '%{searchQuery}%'" +
                               $" OR LastName LIKE '%{searchQuery}%'" +
                               $" OR Address LIKE '%{searchQuery}%'" +
                               $" OR Gender LIKE '%{searchQuery}%'";
            }
            else
            {
                // Apply filter based on string fields only
                dv.RowFilter = $"FirstName LIKE '%{searchQuery}%'" +
                               $" OR LastName LIKE '%{searchQuery}%'" +
                               $" OR Address LIKE '%{searchQuery}%'" +
                               $" OR Gender LIKE '%{searchQuery}%'";
            }

            // Update DataGridView with filtered DataView
            ContactView.DataSource = dv.ToTable();
        }

    }
}
