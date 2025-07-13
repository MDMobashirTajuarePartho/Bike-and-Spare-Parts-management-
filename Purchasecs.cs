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
    public partial class Purchasecs : Form
    {
        public Purchasecs()
        {
            InitializeComponent();
        }
        public string Username { get; set; }

        private void BuyParts_Click(object sender, EventArgs e)
        {
            Parts2 part = new Parts2();
            part.Username = this.Username; 
            part.Show();
            this.Hide();
        }

        private void BuyBike_Click(object sender, EventArgs e)
        {
            Biker biker = new Biker();
            biker.Username = this.Username; 
            biker.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void Purchasecs_Load(object sender, EventArgs e)
        {
            
        }
    }
}
