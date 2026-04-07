namespace MyWinFormsProject
{
    partial class Hamburger_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbToppings = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.chBacon = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chPickles = new System.Windows.Forms.CheckBox();
            this.chExtraChees = new System.Windows.Forms.CheckBox();
            this.chLettuce = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.gbBun1Type = new System.Windows.Forms.Panel();
            this.gbBunType = new System.Windows.Forms.Label();
            this.rdBriocheBun = new System.Windows.Forms.RadioButton();
            this.rdSesameSeedBun = new System.Windows.Forms.RadioButton();
            this.grpWhereToEat = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPattyTye1 = new System.Windows.Forms.Button();
            this.lblWhereToEat = new System.Windows.Forms.Button();
            this.lblBunType = new System.Windows.Forms.Button();
            this.lblTotalPrice2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPattyType = new System.Windows.Forms.Label();
            this.butResetForm = new System.Windows.Forms.Button();
            this.butOrderHamburger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdTripleBeef = new System.Windows.Forms.RadioButton();
            this.rdDoubleBeef = new System.Windows.Forms.RadioButton();
            this.rdSingleBeef = new System.Windows.Forms.RadioButton();
            this.gbPattyType = new System.Windows.Forms.Panel();
            this.butCloseScreen = new System.Windows.Forms.Button();
            this.gbToppings.SuspendLayout();
            this.gbBun1Type.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbPattyType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.label9);
            this.gbToppings.Controls.Add(this.chBacon);
            this.gbToppings.Controls.Add(this.chTomatoes);
            this.gbToppings.Controls.Add(this.chPickles);
            this.gbToppings.Controls.Add(this.chExtraChees);
            this.gbToppings.Controls.Add(this.chLettuce);
            this.gbToppings.Controls.Add(this.chOnion);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(565, 257);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(357, 238);
            this.gbToppings.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Toppings ";
            // 
            // chBacon
            // 
            this.chBacon.AutoSize = true;
            this.chBacon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBacon.Location = new System.Drawing.Point(211, 153);
            this.chBacon.Name = "chBacon";
            this.chBacon.Size = new System.Drawing.Size(87, 32);
            this.chBacon.TabIndex = 11;
            this.chBacon.Tag = "9";
            this.chBacon.Text = "Bacon";
            this.chBacon.UseVisualStyleBackColor = true;
            this.chBacon.CheckedChanged += new System.EventHandler(this.chBacon_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTomatoes.Location = new System.Drawing.Point(27, 152);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(118, 32);
            this.chTomatoes.TabIndex = 8;
            this.chTomatoes.Tag = "6";
            this.chTomatoes.Text = "Tomatose";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chPickles
            // 
            this.chPickles.AutoSize = true;
            this.chPickles.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPickles.Location = new System.Drawing.Point(211, 104);
            this.chPickles.Name = "chPickles";
            this.chPickles.Size = new System.Drawing.Size(92, 32);
            this.chPickles.TabIndex = 10;
            this.chPickles.Tag = "7";
            this.chPickles.Text = "Pickles";
            this.chPickles.UseVisualStyleBackColor = true;
            this.chPickles.CheckedChanged += new System.EventHandler(this.chPickles_CheckedChanged);
            // 
            // chExtraChees
            // 
            this.chExtraChees.AutoSize = true;
            this.chExtraChees.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chExtraChees.Location = new System.Drawing.Point(27, 58);
            this.chExtraChees.Name = "chExtraChees";
            this.chExtraChees.Size = new System.Drawing.Size(143, 32);
            this.chExtraChees.TabIndex = 6;
            this.chExtraChees.Tag = "5";
            this.chExtraChees.Text = "Extra Cheese";
            this.chExtraChees.UseVisualStyleBackColor = true;
            this.chExtraChees.CheckedChanged += new System.EventHandler(this.chExtraChees_CheckedChanged);
            // 
            // chLettuce
            // 
            this.chLettuce.AutoSize = true;
            this.chLettuce.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chLettuce.Location = new System.Drawing.Point(27, 101);
            this.chLettuce.Name = "chLettuce";
            this.chLettuce.Size = new System.Drawing.Size(97, 32);
            this.chLettuce.TabIndex = 7;
            this.chLettuce.Tag = "8";
            this.chLettuce.Text = "Lettuce";
            this.chLettuce.UseVisualStyleBackColor = true;
            this.chLettuce.CheckedChanged += new System.EventHandler(this.chLettuce_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOnion.Location = new System.Drawing.Point(211, 59);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(88, 32);
            this.chOnion.TabIndex = 9;
            this.chOnion.Tag = "4";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // gbBun1Type
            // 
            this.gbBun1Type.BackColor = System.Drawing.Color.Transparent;
            this.gbBun1Type.Controls.Add(this.gbBunType);
            this.gbBun1Type.Controls.Add(this.rdBriocheBun);
            this.gbBun1Type.Controls.Add(this.rdSesameSeedBun);
            this.gbBun1Type.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBun1Type.ForeColor = System.Drawing.Color.White;
            this.gbBun1Type.Location = new System.Drawing.Point(156, 510);
            this.gbBun1Type.Name = "gbBun1Type";
            this.gbBun1Type.Size = new System.Drawing.Size(357, 160);
            this.gbBun1Type.TabIndex = 21;
            // 
            // gbBunType
            // 
            this.gbBunType.AutoSize = true;
            this.gbBunType.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBunType.Location = new System.Drawing.Point(3, 0);
            this.gbBunType.Name = "gbBunType";
            this.gbBunType.Size = new System.Drawing.Size(153, 37);
            this.gbBunType.TabIndex = 16;
            this.gbBunType.Text = "Bun Type";
            // 
            // rdBriocheBun
            // 
            this.rdBriocheBun.AutoSize = true;
            this.rdBriocheBun.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBriocheBun.Location = new System.Drawing.Point(54, 105);
            this.rdBriocheBun.Name = "rdBriocheBun";
            this.rdBriocheBun.Size = new System.Drawing.Size(136, 32);
            this.rdBriocheBun.TabIndex = 5;
            this.rdBriocheBun.TabStop = true;
            this.rdBriocheBun.Tag = "30";
            this.rdBriocheBun.Text = "Brioche Bun";
            this.rdBriocheBun.UseVisualStyleBackColor = true;
            this.rdBriocheBun.CheckedChanged += new System.EventHandler(this.rdBriocheBun_CheckedChanged);
            // 
            // rdSesameSeedBun
            // 
            this.rdSesameSeedBun.AutoSize = true;
            this.rdSesameSeedBun.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSesameSeedBun.Location = new System.Drawing.Point(54, 52);
            this.rdSesameSeedBun.Name = "rdSesameSeedBun";
            this.rdSesameSeedBun.Size = new System.Drawing.Size(185, 32);
            this.rdSesameSeedBun.TabIndex = 4;
            this.rdSesameSeedBun.TabStop = true;
            this.rdSesameSeedBun.Tag = "20";
            this.rdSesameSeedBun.Text = "Sesame Seed Bun";
            this.rdSesameSeedBun.UseVisualStyleBackColor = true;
            this.rdSesameSeedBun.CheckedChanged += new System.EventHandler(this.rdSesameSeedBun_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.grpWhereToEat.Controls.Add(this.label10);
            this.grpWhereToEat.Controls.Add(this.rdTakeOut);
            this.grpWhereToEat.Controls.Add(this.rdEatIn);
            this.grpWhereToEat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereToEat.ForeColor = System.Drawing.Color.White;
            this.grpWhereToEat.Location = new System.Drawing.Point(565, 536);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(357, 100);
            this.grpWhereToEat.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 37);
            this.label10.TabIndex = 21;
            this.label10.Text = "Where To Eat ";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeOut.Location = new System.Drawing.Point(211, 50);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(134, 34);
            this.rdTakeOut.TabIndex = 13;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatIn.Location = new System.Drawing.Point(62, 50);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(109, 34);
            this.rdEatIn.TabIndex = 12;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblPattyTye1);
            this.panel5.Controls.Add(this.lblWhereToEat);
            this.panel5.Controls.Add(this.lblBunType);
            this.panel5.Controls.Add(this.lblTotalPrice2);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.grpOrderSummary);
            this.panel5.Controls.Add(this.lbl3);
            this.panel5.Controls.Add(this.lblToppings);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbl);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(1051, 247);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 542);
            this.panel5.TabIndex = 24;
            // 
            // lblPattyTye1
            // 
            this.lblPattyTye1.BackColor = System.Drawing.Color.Transparent;
            this.lblPattyTye1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPattyTye1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattyTye1.Location = new System.Drawing.Point(189, 43);
            this.lblPattyTye1.Name = "lblPattyTye1";
            this.lblPattyTye1.Size = new System.Drawing.Size(142, 36);
            this.lblPattyTye1.TabIndex = 38;
            this.lblPattyTye1.UseVisualStyleBackColor = false;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWhereToEat.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(225, 306);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(132, 41);
            this.lblWhereToEat.TabIndex = 37;
            this.lblWhereToEat.UseVisualStyleBackColor = false;
            // 
            // lblBunType
            // 
            this.lblBunType.BackColor = System.Drawing.Color.Transparent;
            this.lblBunType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBunType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBunType.Location = new System.Drawing.Point(174, 257);
            this.lblBunType.Name = "lblBunType";
            this.lblBunType.Size = new System.Drawing.Size(169, 41);
            this.lblBunType.TabIndex = 36;
            this.lblBunType.UseVisualStyleBackColor = false;
            // 
            // lblTotalPrice2
            // 
            this.lblTotalPrice2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalPrice2.Font = new System.Drawing.Font("Elephant", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice2.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice2.Location = new System.Drawing.Point(162, 420);
            this.lblTotalPrice2.Name = "lblTotalPrice2";
            this.lblTotalPrice2.Size = new System.Drawing.Size(169, 87);
            this.lblTotalPrice2.TabIndex = 35;
            this.lblTotalPrice2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-4, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 37);
            this.label11.TabIndex = 33;
            this.label11.Text = "Order Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Where To Eat : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total Price : ";
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.Location = new System.Drawing.Point(3, 0);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(10, 10);
            this.grpOrderSummary.TabIndex = 12;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(26, 263);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(155, 30);
            this.lbl3.TabIndex = 27;
            this.lbl3.Text = "Bun Type : ";
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblToppings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(30, 127);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(301, 87);
            this.lblToppings.TabIndex = 26;
            this.lblToppings.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Toppings : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(26, 47);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(169, 30);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "Patty Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 22;
            // 
            // lblPattyType
            // 
            this.lblPattyType.AutoSize = true;
            this.lblPattyType.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattyType.Location = new System.Drawing.Point(3, 0);
            this.lblPattyType.Name = "lblPattyType";
            this.lblPattyType.Size = new System.Drawing.Size(167, 37);
            this.lblPattyType.TabIndex = 7;
            this.lblPattyType.Text = "Patty Type";
            // 
            // butResetForm
            // 
            this.butResetForm.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butResetForm.Location = new System.Drawing.Point(786, 684);
            this.butResetForm.Name = "butResetForm";
            this.butResetForm.Size = new System.Drawing.Size(169, 47);
            this.butResetForm.TabIndex = 15;
            this.butResetForm.Text = "Reset Form";
            this.butResetForm.UseVisualStyleBackColor = true;
            this.butResetForm.Click += new System.EventHandler(this.butResetForm_Click);
            // 
            // butOrderHamburger
            // 
            this.butOrderHamburger.BackColor = System.Drawing.Color.Transparent;
            this.butOrderHamburger.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOrderHamburger.Location = new System.Drawing.Point(572, 684);
            this.butOrderHamburger.Name = "butOrderHamburger";
            this.butOrderHamburger.Size = new System.Drawing.Size(177, 47);
            this.butOrderHamburger.TabIndex = 14;
            this.butOrderHamburger.Text = "Order Hamburger";
            this.butOrderHamburger.UseVisualStyleBackColor = false;
            this.butOrderHamburger.Click += new System.EventHandler(this.butOrderPizza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 103);
            this.label1.TabIndex = 17;
            this.label1.Text = "Make Your Hamburger";
            // 
            // rdTripleBeef
            // 
            this.rdTripleBeef.AutoSize = true;
            this.rdTripleBeef.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTripleBeef.Location = new System.Drawing.Point(54, 152);
            this.rdTripleBeef.Name = "rdTripleBeef";
            this.rdTripleBeef.Size = new System.Drawing.Size(122, 32);
            this.rdTripleBeef.TabIndex = 3;
            this.rdTripleBeef.TabStop = true;
            this.rdTripleBeef.Tag = "50";
            this.rdTripleBeef.Text = "Triple Beef";
            this.rdTripleBeef.UseVisualStyleBackColor = true;
            this.rdTripleBeef.CheckedChanged += new System.EventHandler(this.rdTripleBeef_CheckedChanged);
            // 
            // rdDoubleBeef
            // 
            this.rdDoubleBeef.AutoSize = true;
            this.rdDoubleBeef.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDoubleBeef.Location = new System.Drawing.Point(54, 101);
            this.rdDoubleBeef.Name = "rdDoubleBeef";
            this.rdDoubleBeef.Size = new System.Drawing.Size(139, 32);
            this.rdDoubleBeef.TabIndex = 2;
            this.rdDoubleBeef.TabStop = true;
            this.rdDoubleBeef.Tag = "40";
            this.rdDoubleBeef.Text = "Double Beef";
            this.rdDoubleBeef.UseVisualStyleBackColor = true;
            this.rdDoubleBeef.CheckedChanged += new System.EventHandler(this.rdDoubleBeef_CheckedChanged);
            // 
            // rdSingleBeef
            // 
            this.rdSingleBeef.AutoSize = true;
            this.rdSingleBeef.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSingleBeef.Location = new System.Drawing.Point(54, 58);
            this.rdSingleBeef.Name = "rdSingleBeef";
            this.rdSingleBeef.Size = new System.Drawing.Size(129, 32);
            this.rdSingleBeef.TabIndex = 1;
            this.rdSingleBeef.TabStop = true;
            this.rdSingleBeef.Tag = "30";
            this.rdSingleBeef.Text = "Single Beef";
            this.rdSingleBeef.UseVisualStyleBackColor = true;
            this.rdSingleBeef.CheckedChanged += new System.EventHandler(this.rdSingleBeef_CheckedChanged);
            // 
            // gbPattyType
            // 
            this.gbPattyType.BackColor = System.Drawing.Color.Transparent;
            this.gbPattyType.Controls.Add(this.lblPattyType);
            this.gbPattyType.Controls.Add(this.rdTripleBeef);
            this.gbPattyType.Controls.Add(this.rdDoubleBeef);
            this.gbPattyType.Controls.Add(this.rdSingleBeef);
            this.gbPattyType.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPattyType.ForeColor = System.Drawing.Color.White;
            this.gbPattyType.Location = new System.Drawing.Point(156, 257);
            this.gbPattyType.Name = "gbPattyType";
            this.gbPattyType.Size = new System.Drawing.Size(357, 238);
            this.gbPattyType.TabIndex = 19;
            // 
            // butCloseScreen
            // 
            this.butCloseScreen.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseScreen.Location = new System.Drawing.Point(691, 766);
            this.butCloseScreen.Name = "butCloseScreen";
            this.butCloseScreen.Size = new System.Drawing.Size(154, 49);
            this.butCloseScreen.TabIndex = 25;
            this.butCloseScreen.Text = "Close";
            this.butCloseScreen.UseVisualStyleBackColor = true;
            this.butCloseScreen.Click += new System.EventHandler(this.butCloseScreen_Click);
            // 
            // Hamburger_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWinFormsProject.Properties.Resources._1245;
            this.ClientSize = new System.Drawing.Size(1517, 895);
            this.Controls.Add(this.butCloseScreen);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbBun1Type);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.butResetForm);
            this.Controls.Add(this.butOrderHamburger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPattyType);
            this.Name = "Hamburger_Order";
            this.Text = "Hamburger_Order";
            this.Load += new System.EventHandler(this.Hamburger_Order_Load);
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbBun1Type.ResumeLayout(false);
            this.gbBun1Type.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbPattyType.ResumeLayout(false);
            this.gbPattyType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gbToppings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chBacon;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chPickles;
        private System.Windows.Forms.CheckBox chExtraChees;
        private System.Windows.Forms.CheckBox chLettuce;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.Panel gbBun1Type;
        private System.Windows.Forms.Label gbBunType;
        private System.Windows.Forms.RadioButton rdBriocheBun;
        private System.Windows.Forms.RadioButton rdSesameSeedBun;
        private System.Windows.Forms.Panel grpWhereToEat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button lblPattyTye1;
        private System.Windows.Forms.Button lblWhereToEat;
        private System.Windows.Forms.Button lblBunType;
        private System.Windows.Forms.Button lblTotalPrice2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button lblToppings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPattyType;
        private System.Windows.Forms.Button butResetForm;
        private System.Windows.Forms.Button butOrderHamburger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdTripleBeef;
        private System.Windows.Forms.RadioButton rdDoubleBeef;
        private System.Windows.Forms.RadioButton rdSingleBeef;
        private System.Windows.Forms.Panel gbPattyType;
        private System.Windows.Forms.Button butCloseScreen;
    }
}