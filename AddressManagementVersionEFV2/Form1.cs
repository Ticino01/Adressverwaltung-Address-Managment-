using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;

namespace AddressManagementVersionEFV2
{
    public partial class Form1 : Form
    {

        private bool isCityAppEntered = false;
        public Form1()
        {
            InitializeComponent();
            MyDbContext myDbContext = new MyDbContext();
            LoadDataIntoGridView();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Load event for initial data


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataIntoGridView()
        {
            using var context = new MyDbContext();
            var allUsers = context.Users.ToList();////load all users using linq
            dataGridView1.DataSource = allUsers;
        }

        public class MyDbContext : DbContext
        {
            // what tables do i need in the database. store uers using class DbSet mot a list or something else
            public DbSet<User> Users { get; set; }// this creates a table in the upcoming database

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LI4Q33C\\SQLEXPRESS;Database=EFUserDb;Trusted_Connection=true;");
            }

        }

        public class User
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string FirstName { get; set; } = string.Empty;

            public string LastName { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Street { get; set; } = string.Empty;
            public string HouseNum { get; set; } = string.Empty;

            public string city { get; set; } = string.Empty;
            public string ZipCode { get; set; } = string.Empty;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using var context = new MyDbContext();
            var user = new User()
            {

                FirstName = nameTextBox.Text,
                LastName = lastNameBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                Street = streetTextBox.Text,
                HouseNum = houseNrBox.Text,
                city = cityTextBox.Text,
                ZipCode = plzBox.Text,


            };
            context.Users.Add(user);
            context.SaveChanges();
            var allusers = context.Users.ToList();
            dataGridView1.DataSource = allusers;
            MessageBox.Show("Person added successfully!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected user's ID
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedUserId = (Guid)selectedRow.Cells["Id"].Value;

                using var context = new MyDbContext();
                var userToUpdate = context.Users.FirstOrDefault(u => u.Id == selectedUserId);/// using linq

                if (userToUpdate != null)
                {
                    // Update fields with input from form
                    userToUpdate.FirstName = nameTextBox.Text;
                    userToUpdate.LastName = lastNameBox.Text;
                    userToUpdate.Email = emailTextBox.Text;
                    userToUpdate.Phone = phoneTextBox.Text;
                    userToUpdate.Street = streetTextBox.Text;
                    userToUpdate.HouseNum = houseNrBox.Text;
                    userToUpdate.city = cityTextBox.Text;
                    userToUpdate.ZipCode = plzBox.Text;

                    context.SaveChanges();

                    LoadDataIntoGridView(); // Refresh data
                    MessageBox.Show("User updated successfully!");
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                nameTextBox.Text = row.Cells["FirstName"].Value?.ToString();
                lastNameBox.Text = row.Cells["LastName"].Value?.ToString();
                emailTextBox.Text = row.Cells["Email"].Value?.ToString();
                phoneTextBox.Text = row.Cells["Phone"].Value?.ToString();
                streetTextBox.Text = row.Cells["Street"].Value?.ToString();
                houseNrBox.Text = row.Cells["HouseNum"].Value?.ToString();
                cityTextBox.Text = row.Cells["city"].Value?.ToString();
                plzBox.Text = row.Cells["ZipCode"].Value?.ToString();
            }
        }

        private static List<string> FindCitiesFromPlz(string plz)
        {
            string filePath = @"C:\Users\ehsan\source\repos\AddressManagementVersionEFV2\AddressManagementVersionEFV2\Postleitzahlen-Schweiz-Download.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                HasHeaderRecord = true,
            };


            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvHelper.CsvReader(reader, config))
                {
                    var records = csv.GetRecords<PostalRecord>().ToList();

                    // Find all matching cities for the given postal code
                    var matches = records
                        .Where(record => record.PLZ == plz && !string.IsNullOrEmpty(record.Ort))
                        .Select(record => record.Ort!)
                        .Distinct() // To ensure there are no duplicates
                        .ToList();

                    return matches; // Return a list of matching cities
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: The postal code file was not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: There was a problem reading the file.", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CsvHelperException csvEx)
            {
                MessageBox.Show($"Error: The CSV file may be corrupted or incorrectly formatted.\r\nException Message: {csvEx.Message}\r\n{csvEx}", "CSV Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}\r\n{ex}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<string>();
        }



        private class PostalRecord
        {
            public string? PLZ { get; set; }
            public string? Ort { get; set; }
            public string? Kanton { get; set; }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedUserId = (Guid)selectedRow.Cells["Id"].Value;
                DialogResult result = MessageBox.Show("Are You sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    using var context = new MyDbContext();
                    var userToDelete = context.Users.FirstOrDefault(x => x.Id == selectedUserId); // uisng linq 
                    context.Users.Remove(userToDelete);
                    context.SaveChanges();
                    LoadDataIntoGridView();
                    MessageBox.Show("User deleted successfully");
                    nameTextBox.Clear();
                    lastNameBox.Clear();
                    emailTextBox.Clear();
                    phoneTextBox.Clear();
                    streetTextBox.Clear();
                    houseNrBox.Clear();
                    cityTextBox.Clear();
                    plzBox.Clear();


                }

                else
                {
                    MessageBox.Show("User Not Found");

                }

            }
            else
            {
                MessageBox.Show("Please select a user to delete");
            }
        }

        private void plzBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string zipcode = textBox.Text.Trim()
                ;
            if (zipcode.Length > 4 && isCityAppEntered)
            {
                cityTextBox.Text = string.Empty; return;
            }


            if (zipcode.Length == 4)
            {
                List<string> citeis = FindCitiesFromPlz(zipcode);
                cityComboBox.Items.Clear();
                if (citeis.Count == 1)
                {
                    // If only one city found, auto-fill the city text box
                    cityComboBox.SelectedIndexChanged -= cityComboBox_SelectedIndexChanged;
                    cityComboBox.Items.Add(citeis[0]);
                    cityComboBox.SelectedIndex = 0;
                    isCityAppEntered = string.IsNullOrWhiteSpace(cityTextBox.Text);
                    if (isCityAppEntered)
                    {
                        cityTextBox.Text = citeis[0];
                    }
                    cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
                }

                else if (citeis.Count > 1)
                {
                    cityComboBox.Items.AddRange(citeis.ToArray());
                    cityComboBox.SelectedIndex = 0;
                }
            }
        }

        private void plzBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string zipcode = textBox.Text.Trim();
            if (!isCityAppEntered)
            {
                if (zipcode.Length > 4)
                {
                    return;
                }

                List<string> cities = FindCitiesFromPlz(zipcode);

                if (cities.Count == 0)
                {
                    if (isCityAppEntered) cityTextBox.Text = string.Empty;
                    cityComboBox.Items.Clear();
                    return;
                }

                if (cities.Count == 1)
                {
                    if (string.IsNullOrEmpty(cityTextBox.Text))
                    {
                        cityTextBox.Text = cities[0];
                        isCityAppEntered = true;

                    }
                    cityComboBox.Items.Clear();
                    cityComboBox.Items.Add(cities[0]);
                    cityComboBox.SelectedIndex = 0;

                }

                else
                {
                    cityComboBox.Items.Clear();
                    cityComboBox.Items.AddRange(cities.ToArray());
                    cityComboBox.SelectedIndex = 0;

                    if (string.IsNullOrEmpty(cityTextBox.Text))
                    {
                        cityTextBox.Text = cities[0];
                        isCityAppEntered = true;
                    }
                }
            }

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedIndex == 0)
            {
                isCityAppEntered = string.IsNullOrWhiteSpace(cityTextBox.Text);
                cityTextBox.Text = cityComboBox.SelectedItem?.ToString() ?? string.Empty;
                isCityAppEntered = isCityAppEntered && !string.IsNullOrWhiteSpace(cityTextBox.Text);
            }
        }





        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                using var context = new MyDbContext();
                List<User> searchResults = context.Users
                    .Where(u =>
                        u.FirstName.Contains(searchTerm) ||
                        u.LastName.Contains(searchTerm) ||
                        u.Email.Contains(searchTerm) ||
                        u.Phone.Contains(searchTerm) ||
                        u.Street.Contains(searchTerm) ||
                        u.HouseNum.Contains(searchTerm) ||
                        u.city.Contains(searchTerm) ||
                        u.ZipCode.Contains(searchTerm))
                    .ToList();

                dataGridView1.DataSource = null; // Clear the current data
                dataGridView1.DataSource = searchResults; // Bind the search results

                if (searchResults.Count == 0)
                {
                    MessageBox.Show("No matching records found.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // If search term is empty, reload all data
                LoadDataIntoGridView();
            }
        }

        private void SearchResultClear_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            LoadDataIntoGridView();

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            lastNameBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            streetTextBox.Clear();
            houseNrBox.Clear();
            cityTextBox.Clear();
            plzBox.Clear();
        }
    }

}