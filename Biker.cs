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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BikeParts
{
    public partial class Biker : Form
    {
        public Biker()
        {
            InitializeComponent();
        }
        public string Username { get; set; }

        private void LoadBikeDataToGrid()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT BikeName, BikePrice FROM AdminData WHERE BikeName IS NOT NULL AND BikePrice IS NOT NULL";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No bike data available in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        dataGridView1.DataSource = dt; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string bikeName = dataGridView1.Rows[e.RowIndex].Cells["BikeName"].Value.ToString();
                string bikePrice = dataGridView1.Rows[e.RowIndex].Cells["BikePrice"].Value.ToString();

                textBox1.Text = bikePrice;

                MessageBox.Show($"You selected bike: {bikeName}, Price: {bikePrice}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Biker_Load(object sender, EventArgs e)
        {
            LoadBikeDataToGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Purchasecs purchasecs = new Purchasecs();
            purchasecs.Show();
            this.Hide();
        }

        private void AddtoCard_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            string bikeName = dataGridView1.CurrentRow.Cells["BikeName"].Value.ToString();
            string bikePrice = textBox1.Text; 
            cartForm.SetCartData(bikeName, bikePrice);
            cartForm.Username = this.Username;
            cartForm.Show();
            this.Show();
        }
    }
}
