using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Rodriguez
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // click to load
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataIntoDataGridView()
        {
            try
            {

                string connectionString = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2016;Initial Catalog=PRACTICALDB;Integrated Security=True";


                string selectQuery = "SELECT RecId, ContactName, TelNo, MobileNo, IsActive FROM tbl_000_Contact";


                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
                    {
                        //ari ma load
                        adapter.Fill(dataTable);
                    }
                }


                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //adto pikas page
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddContact addContactForm = new AddContact();
            addContactForm.Show();
        }

        //Delete function
        private void Delete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                int recIdToDelete = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["RecId"].Value);

                try
                {
                    string connectionString = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2016;Initial Catalog=PRACTICALDB;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = $"DELETE FROM tbl_000_Contact WHERE RecId = {recIdToDelete}";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadDataIntoDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                LoadDataIntoDataGridView();
            }
        }


        private void SearchClick_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2016;Initial Catalog=PRACTICALDB;Integrated Security=True";
                string searchQuery = "SELECT RecId, ContactName, TelNo, MobileNo, IsActive FROM tbl_000_Contact WHERE ContactName LIKE @ContactName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@ContactName", "%" + textBox1.Text + "%");
                        DataTable searchResultTable = new DataTable();
                        adapter.Fill(searchResultTable);
                        dataGridView1.DataSource = searchResultTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //edit
        private void EditContact_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int recIdToEdit = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["RecId"].Value);

                FetchContactDetails(recIdToEdit);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FetchContactDetails(int recId)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2016;Initial Catalog=PRACTICALDB;Integrated Security=True";
                string selectQuery = "SELECT ContactName, TelNo, MobileNo, IsActive FROM tbl_000_Contact WHERE RecId = @RecId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@RecId", recId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ContactName.Text = reader["ContactName"].ToString();
                                TelNo.Text = reader["TelNo"].ToString();
                                MobileNo.Text = reader["MobileNo"].ToString();
                                checkBoxIsActive.Checked = Convert.ToBoolean(reader["IsActive"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // To save changes
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int recIdToSave = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["RecId"].Value);

                try
                {
                    string connectionString = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2016;Initial Catalog=PRACTICALDB;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE tbl_000_Contact SET ContactName = @ContactName, TelNo = @TelNo, MobileNo = @MobileNo, IsActive = @IsActive, UpdatedDate = GETDATE() WHERE RecId = @RecId";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RecId", recIdToSave);
                            command.Parameters.AddWithValue("@ContactName", ContactName.Text);
                            command.Parameters.AddWithValue("@TelNo", TelNo.Text);
                            command.Parameters.AddWithValue("@MobileNo", MobileNo.Text);
                            command.Parameters.AddWithValue("@IsActive", checkBoxIsActive.Checked ? 1 : 0);

                            command.ExecuteNonQuery();
                        }
                    }

                    LoadDataIntoDataGridView();
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to save changes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearTextBoxes()
        {
            ContactName.Text = "";
            TelNo.Text = "";
            MobileNo.Text = "";
            checkBoxIsActive.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
