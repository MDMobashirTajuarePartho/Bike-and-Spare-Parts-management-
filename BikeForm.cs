using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeParts
{
    public partial class BikeForm : Form
    {
        public BikeForm()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of the Home form
            homeForm.Show();              // Show the Home form
            this.Close();                 // Close the current Login form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
