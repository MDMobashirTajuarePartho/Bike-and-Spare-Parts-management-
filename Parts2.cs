using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BikeParts
{
    public partial class Parts2 : Form
    {
        public Parts2()
        {
            InitializeComponent();
        }
        public string Username { get; set; }


        private void LoadPartDataToGrid()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT PartName, Price FROM AdminData WHERE PartName IS NOT NULL AND Price IS NOT NULL";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No part data available in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        dataGridView2.DataSource = dt; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string partName = dataGridView2.Rows[e.RowIndex].Cells["PartName"].Value.ToString();
                string price = dataGridView2.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                CartForm cartForm = new CartForm();

                textBox2.Text = price;

                MessageBox.Show($"You selected part: {partName}, Price: {price}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Purchasecs purchasecs = new Purchasecs();
            purchasecs.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CartForm form = new CartForm();
            string partName = dataGridView2.CurrentRow.Cells["PartName"].Value.ToString();
            string price = textBox2.Text; 
            form.SetCartData1(partName, price);
            form.Username = this.Username;

            form.Show();
            this.Hide();
        }

        private void Parts2_Load(object sender, EventArgs e)
        {
            LoadPartDataToGrid();
            
        }
    }
}
