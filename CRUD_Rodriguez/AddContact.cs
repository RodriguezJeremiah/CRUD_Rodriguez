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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string middleName = textBox3.Text;
            string gender = GetSelectedGender();
            string localAddress = textBox4.Text;
            string telNo = textBox5.Text;
            string mobileNo = textBox6.Text;

            // ContactName
            string contactName = GenerateContactName(lastName, firstName, middleName);

            // save sa database
            SaveToDatabase(contactName, firstName, lastName, middleName, gender, localAddress, telNo, mobileNo);

            // Clear the form
            ClearFormFields();

                MessageBox.Show("Added Contact Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SaveToDatabase(string contactName, string firstName, string lastName, string middleName, string gender, string localAddress, string telNo, string mobileNo)
        {
            string connectionString = "Data Source=DESKTOP-158DC4L\\SQLEXPRESS2016;Initial Catalog=PRACTICALDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO tbl_000_Contact (ContactName, FirstName, LastName, MiddleName, Gender, LocalAddress, TelNo, MobileNo, IsActive,CreatedDate) " +
                                     "VALUES (@ContactName, @FirstName, @LastName, @MiddleName, @Gender, @LocalAddress, @TelNo, @MobileNo, @IsActive, GETDATE())";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ContactName", contactName);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@LocalAddress", localAddress);
                    command.Parameters.AddWithValue("@TelNo", telNo);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);
                    command.Parameters.AddWithValue("@IsActive", 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        private string GenerateContactName(string lastName, string firstName, string middleName)
        {
            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName))
            {
                string contactName = $"{lastName}, {firstName}";

                if (!string.IsNullOrEmpty(middleName))
                {
                    contactName += $" {middleName.Substring(0, 1)}.";
                }

                return contactName;
            }

            return string.Empty;
        }


        private void ClearFormFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            Undecided.Checked = false;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private string GetSelectedGender()
        {
            if (Male.Checked)
            {
                return "Male";
            }
            else if (Female.Checked)
            {
                return "Female";
            }
            else if (Undecided.Checked)
            {
                return "Undecided";
            }

          
            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1Form = new Form1();
            Form1Form.Show();
        }
    }
}
