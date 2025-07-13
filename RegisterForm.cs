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

namespace BikeParts
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of the Home form
            homeForm.Show();              // Show the Home form
            this.Close();                 // Close the current Login form
        }

        private void Nametxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UserNametxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Passwordtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Addresstxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DOBtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Gendercombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text.Trim();
            string username = UserNametxt.Text.Trim();
            string password = Passwordtxt.Text.Trim();
            string address = Addresstxt.Text.Trim();
            string dob = DOBtxt.Text.Trim();
            string gender = Gendercombox.SelectedItem?.ToString();

            // ✅ Validate input fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(dob) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Insert user data into the database
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Register (FullName, Username, Password, Address, DOB, Gender) VALUES (@name, @username, @password, @address, @dob, @gender)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Hash in production!
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@gender", gender);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to login page
                            login loginForm = new login();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }                                                      


        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
