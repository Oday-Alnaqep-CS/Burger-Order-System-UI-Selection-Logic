using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyWinFormsProject
{
    public partial class Pizza_Order : Form
    {

        public Pizza_Order()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
       //  ⁄—Ì› «·»›— («·ﬂ«‘) Â‰« ·ÌﬂÊ‰ „ «Õ« ·ﬂ· «·ﬂÊœ
            private Dictionary<string, Image> _imageCache = new Dictionary<string, Image>();

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rdSmall.Checked)

            {
                lblSize.Text = "Small";
                return;
            }

            if (rdMeduim.Checked)

            {
                lblSize.Text = "Medium";
                return;
            }

            if (rdLarg.Checked)

            {
                lblSize.Text = "Large";
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

            if (chMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;


        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rdThinCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }

            if (rdThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }


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

        float GetSelectedSizePrice()
        {
            if (rdLarg.Checked)

                return Convert.ToSingle(rdLarg.Tag);

            else if (rdMeduim.Checked)

                return Convert.ToSingle(rdMeduim.Tag);

            else

                return Convert.ToSingle(rdSmall.Tag);

        }

        float GetSelectedCrustPrice()
        {
            if (rdThinCrust.Checked)

                return Convert.ToSingle(rdThinCrust.Tag);

            else
                return Convert.ToSingle(rdThickCrust.Tag);

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

            if (chOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chOlives.Tag);
            }

            if (chMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chMushrooms.Tag);
            }

            if (chTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chTomatoes.Tag);
            }

            if (chGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {

            //reset Groups
            grpSize.Enabled = true;
            grpToppings.Enabled = true;
            grpCrustType.Enabled = true;
            grpWhereToEat.Enabled = true;


            rdMeduim.Checked = true;

            //reset Toppings.
            chExtraChees.Checked = false;
            chOnion.Checked = false;
            chMushrooms.Checked = false;
            chOlives.Checked = false;
            chTomatoes.Checked = false;
            chGreenPeppers.Checked = false;

            //reset CrustType
            rdThinCrust.Checked = true;

            //reset Where to Eat
            rdEatIn.Checked = true;

            //Reset Order Button
            butOrderPizza.Enabled = true;

        }

        private void rdSmall_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMeduim_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLarg_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
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

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chGreenPeppers_CheckedChanged(object sender, EventArgs e)
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

        private void butOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                butOrderPizza.Enabled = false;
                grpSize.Enabled = false;
                grpCrustType.Enabled = false;
                grpToppings.Enabled = false;
                grpWhereToEat.Enabled = false;


            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void Pizza_Order_Load(object sender, EventArgs e)
        {
            //  Õ„Ì· «·’Ê— ›Ì «·»›— „—… Ê«Õœ… ›ﬁÿ ⁄‰œ «· ‘€Ì·
            try
            {
                _imageCache["pizza_main"] = Image.FromFile("pizza.png");

                // «·¬‰ ‰÷⁄ «·’Ê—… ›Ì «·Œ·›Ì… √Ê ›Ì PictureBox
                this.BackgroundImage = _imageCache["pizza_main"];
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { /*  √ﬂœ „‰ ÊÃÊœ „·› «·’Ê—… ›Ì „Ã·œ bin/debug */ }

            UpdateOrderSummary();
        }

        private void butResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Size_Click(object sender, EventArgs e)
        {

        }
    }
}
