using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormsProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            butMakePizzaOrder.Text = "Make\nOrder";
            lblTital1.Text = "\t\t\t\t\t\t                  " +
                "                      Welcome! \nLet’s get started and create your favorite meal!";
        }

        private void butMakePizzaOrder_Click(object sender, EventArgs e)
        {

            Form Pizza = new Pizza_Order();
            Pizza.ShowDialog();
        }

        private void butMakeHamburger_Click(object sender, EventArgs e)
        {
            Form Hamburger = new Hamburger_Order();
            Hamburger.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
