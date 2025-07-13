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
using System.Data.SqlClient;

namespace BikeParts
{
    
    public partial class PartsForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-JNA3O30\SQLEXPRESS;Integrated Security=True;Trust Server Certificate=True";
        public PartsForm()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of the Home form
            homeForm.Show();              // Show the Home form
            this.Close();                 // Close the current Login form
        }
        private void LoadPartsData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT PartID, PartName, Price, PaymentOption FROM Parts"; // Query to fetch required data from Parts table
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Binding data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
