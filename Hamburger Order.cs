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
    public partial class Hamburger_Order : Form
    {
        public Hamburger_Order()
        {
            InitializeComponent();
        }

        void UpdatePatty()
        {
            UpdateTotalPrice();

            if (rdSingleBeef.Checked)
            {
                lblPattyTye1.Text = "Single Beef";
                return;
            }

            if (rdDoubleBeef.Checked)
            {
                lblPattyTye1.Text = "Double Beef";
                return;
            }

            if (rdTripleBeef.Checked)
            {
                lblPattyTye1.Text = "Triple Beef";
                return;
            }
        }

        void UpdateBun()
        {
            UpdateTotalPrice();

            if (rdSesameSeedBun.Checked)
            {
                lblBunType.Text = "Sesame Seed Bun";
                return;
            }

            if (rdBriocheBun.Checked)
            {
                lblBunType.Text = "Brioche Bun";
                return;
            }
        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chLettuce.Checked)
            {
                sToppings += ", Lettuce";
            }

            if (chPickles.Checked)
            {
                sToppings += ", Pickles";
            }

            if (chTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chBacon.Checked)
            {
                sToppings += ", Bacon";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;


        }

        void UpdateWhereToEat()
        {

            UpdateTotalPrice();

            if (rdEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rdTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }

        }

        float GetSelectedPattyPrice()
        {
            if (rdSingleBeef.Checked)

                return Convert.ToSingle(rdSingleBeef.Tag);

            else if (rdDoubleBeef.Checked)

                return Convert.ToSingle(rdDoubleBeef.Tag);

            else

                return Convert.ToSingle(rdTripleBeef.Tag);

        }

        float GetSelectedBunPrice()
        {
            if (rdSesameSeedBun.Checked)

                return Convert.ToSingle(rdSesameSeedBun.Tag);

            else
                return Convert.ToSingle(rdBriocheBun.Tag);

        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chExtraChees.Tag);
            }

            if (chOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chOnion.Tag);
            }

            if (chLettuce.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chLettuce.Tag);
            }

            if (chPickles.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chPickles.Tag);
            }

            if (chTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chTomatoes.Tag);
            }

            if (chBacon.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chBacon.Tag);
            }

            return ToppingsTotalPrice;
        }

        float CalculateTotalPrice()
        {
            return GetSelectedPattyPrice() + GetSelectedBunPrice() + CalculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {
         
            lblTotalPrice2.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateOrderSummary()
        {
            UpdatePatty();
            UpdateToppings();
            UpdateBun();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {

            //reset Groups
            gbBunType.Enabled = true;
            gbPattyType.Enabled = true;
            gbToppings.Enabled = true;
            grpWhereToEat.Enabled = true;
            rdSesameSeedBun.Enabled = true;
            rdBriocheBun.Enabled = true;

            rdSingleBeef.Checked = true;

            //reset Toppings.
            chExtraChees.Checked = false;
            chOnion.Checked = false;
            chLettuce.Checked = false;
            chBacon.Checked = false;
            chTomatoes.Checked = false;
            chPickles.Checked = false;

            //reset CrustType
            rdSesameSeedBun.Checked = true;

            //reset Where to Eat
            rdEatIn.Checked = true;

            //Reset Order Button
            butOrderHamburger.Enabled = true;

        }

        private void rdSingleBeef_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();
        }

        private void rdDoubleBeef_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();
        }

        private void rdTripleBeef_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();
        }

        private void rdSesameSeedBun_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBun();
        }

        private void rdBriocheBun_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBun();
        }

        private void chExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chLettuce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chPickles_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chBacon_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Hamburger_Order_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void butResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void butOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                butOrderHamburger.Enabled = false;
                gbPattyType.Enabled = false;
                gbBunType.Enabled = false;
                gbToppings.Enabled = false;
                grpWhereToEat.Enabled = false;
                rdSesameSeedBun.Enabled = false;
                rdBriocheBun.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butCloseScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
