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
    public partial class AttendantManagement : Form
    {
        public AttendantManagement()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void products_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendantManagement manageAttendants = new AttendantManagement();
            manageAttendants.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logout code goes here
            this.Hide();
            loginPage loginPage = new loginPage();
            loginPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //attendants
            this.Hide();
            attendants attendants = new attendants();
            attendants.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void manageAttendants_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
