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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Homebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Home Page!");

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            login loginForm = new login(); // Create an instance of LoginForm
            loginForm.Show();                     // Show the Login form
            this.Hide();                          // Hide the current form

        }

        private void Partsbtn_Click(object sender, EventArgs e)
        {
            PartsForm parts = new PartsForm();
            parts.Show();
            this.Hide();

        }

        private void Bikebtn_Click(object sender, EventArgs e)
        {
            BikeForm bikeForm = new BikeForm();
            bikeForm.Show();
            this.Hide();

        }

        private void Cartbtn_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm();
            cartForm.Show();
            this.Hide();

        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }

        
    }
}
