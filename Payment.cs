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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cardtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pincodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Totalamounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conformbtn_Click(object sender, EventArgs e)
        {

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1(); // Create an instance of the Home form
            homeForm.Show();              // Show the Home form
            this.Close();                 // Close the current Login form
        }
    }
}
