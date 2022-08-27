using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donkomi_inventory
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void attendants_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendants attendants = new attendants();
            attendants.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            this.Hide();
            products products = new products();
            products.Show();
        }

        private void category_Click(object sender, EventArgs e)
        {

        }
    }
}
