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
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            //home page button
            this.Hide();
            adminPage adminPage = new adminPage();
            adminPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //logout code goes here
            this.Hide();
            loginPage loginPage = new loginPage(); 
            loginPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show attendants page
            this.Hide();
            attendants attendantsPage = new attendants();
            attendantsPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //management button
            this.Hide();
            AttendantManagement managementPage = new AttendantManagement();
            managementPage.Show();
        }

        private void category_Click(object sender, EventArgs e)
        {
            //products and category page goes here

        }

        private void products_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
