namespace MyWinFormsProject
{
    partial class Pizza_Order
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
            this.chExtraChees = new System.Windows.Forms.CheckBox();
            this.rdThickCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.chGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chMushrooms = new System.Windows.Forms.CheckBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.butOrderPizza = new System.Windows.Forms.Button();
            this.butResetForm = new System.Windows.Forms.Button();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMeduim = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.grpSize = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.grpCrustType = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.grpWhereToEat = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Button();
            this.lblWhereToEat = new System.Windows.Forms.Button();
            this.lblCrustType = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butCloseScreen = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chExtraChees
            // 
            this.chExtraChees.AutoSize = true;
            this.chExtraChees.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chExtraChees.Location = new System.Drawing.Point(27, 58);
            this.chExtraChees.Name = "chExtraChees";
            this.chExtraChees.Size = new System.Drawing.Size(143, 32);
            this.chExtraChees.TabIndex = 3;
            this.chExtraChees.Tag = "5";
            this.chExtraChees.Text = "Extra Cheese";
            this.chExtraChees.UseVisualStyleBackColor = true;
            this.chExtraChees.CheckedChanged += new System.EventHandler(this.chExtraChees_CheckedChanged);
            // 
            // rdThickCrust
            // 
            this.rdThickCrust.AutoSize = true;
            this.rdThickCrust.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThickCrust.Location = new System.Drawing.Point(54, 105);
            this.rdThickCrust.Name = "rdThickCrust";
            this.rdThickCrust.Size = new System.Drawing.Size(128, 32);
            this.rdThickCrust.TabIndex = 1;
            this.rdThickCrust.TabStop = true;
            this.rdThickCrust.Tag = "10";
            this.rdThickCrust.Text = "Thick Crust";
            this.rdThickCrust.UseVisualStyleBackColor = true;
            this.rdThickCrust.CheckedChanged += new System.EventHandler(this.rdThinkCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinCrust.Location = new System.Drawing.Point(54, 52);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(120, 32);
            this.rdThinCrust.TabIndex = 0;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Tag = "0";
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // chGreenPeppers
            // 
            this.chGreenPeppers.AutoSize = true;
            this.chGreenPeppers.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chGreenPeppers.Location = new System.Drawing.Point(211, 153);
            this.chGreenPeppers.Name = "chGreenPeppers";
            this.chGreenPeppers.Size = new System.Drawing.Size(160, 32);
            this.chGreenPeppers.TabIndex = 7;
            this.chGreenPeppers.Tag = "5";
            this.chGreenPeppers.Text = "Green Peppers";
            this.chGreenPeppers.UseVisualStyleBackColor = true;
            this.chGreenPeppers.CheckedChanged += new System.EventHandler(this.chGreenPeppers_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOlives.Location = new System.Drawing.Point(211, 104);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(87, 32);
            this.chOlives.TabIndex = 6;
            this.chOlives.Tag = "5";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTomatoes.Location = new System.Drawing.Point(27, 152);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(118, 32);
            this.chTomatoes.TabIndex = 5;
            this.chTomatoes.Tag = "5";
            this.chTomatoes.Text = "Tomatose";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOnion.Location = new System.Drawing.Point(211, 59);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(88, 32);
            this.chOnion.TabIndex = 4;
            this.chOnion.Tag = "5";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chMushrooms
            // 
            this.chMushrooms.AutoSize = true;
            this.chMushrooms.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMushrooms.Location = new System.Drawing.Point(27, 101);
            this.chMushrooms.Name = "chMushrooms";
            this.chMushrooms.Size = new System.Drawing.Size(138, 32);
            this.chMushrooms.TabIndex = 0;
            this.chMushrooms.Tag = "5";
            this.chMushrooms.Text = "Mushrooms";
            this.chMushrooms.UseVisualStyleBackColor = true;
            this.chMushrooms.CheckedChanged += new System.EventHandler(this.chMushrooms_CheckedChanged);
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeOut.Location = new System.Drawing.Point(211, 50);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(130, 30);
            this.rdTakeOut.TabIndex = 1;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatIn.Location = new System.Drawing.Point(62, 50);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(105, 30);
            this.rdEatIn.TabIndex = 0;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(402, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butOrderPizza
            // 
            this.butOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.butOrderPizza.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOrderPizza.Location = new System.Drawing.Point(586, 686);
            this.butOrderPizza.Name = "butOrderPizza";
            this.butOrderPizza.Size = new System.Drawing.Size(177, 47);
            this.butOrderPizza.TabIndex = 8;
            this.butOrderPizza.Text = "Order Pizza";
            this.butOrderPizza.UseVisualStyleBackColor = false;
            this.butOrderPizza.Click += new System.EventHandler(this.butOrderPizza_Click);
            // 
            // butResetForm
            // 
            this.butResetForm.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butResetForm.Location = new System.Drawing.Point(800, 686);
            this.butResetForm.Name = "butResetForm";
            this.butResetForm.Size = new System.Drawing.Size(169, 47);
            this.butResetForm.TabIndex = 9;
            this.butResetForm.Text = "Reset Form";
            this.butResetForm.UseVisualStyleBackColor = true;
            this.butResetForm.Click += new System.EventHandler(this.butResetForm_Click);
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarg.Location = new System.Drawing.Point(54, 152);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(71, 32);
            this.rdLarg.TabIndex = 5;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "40";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged_1);
            // 
            // rdMeduim
            // 
            this.rdMeduim.AutoSize = true;
            this.rdMeduim.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMeduim.Location = new System.Drawing.Point(54, 101);
            this.rdMeduim.Name = "rdMeduim";
            this.rdMeduim.Size = new System.Drawing.Size(106, 32);
            this.rdMeduim.TabIndex = 4;
            this.rdMeduim.TabStop = true;
            this.rdMeduim.Tag = "30";
            this.rdMeduim.Text = "Meduim";
            this.rdMeduim.UseVisualStyleBackColor = true;
            this.rdMeduim.CheckedChanged += new System.EventHandler(this.rdMeduim_CheckedChanged_1);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(54, 58);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(81, 32);
            this.rdSmall.TabIndex = 3;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged_1);
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
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.Transparent;
            this.grpSize.Controls.Add(this.label7);
            this.grpSize.Controls.Add(this.rdLarg);
            this.grpSize.Controls.Add(this.rdMeduim);
            this.grpSize.Controls.Add(this.rdSmall);
            this.grpSize.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.White;
            this.grpSize.Location = new System.Drawing.Point(170, 259);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(357, 238);
            this.grpSize.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Size";
            // 
            // grpCrustType
            // 
            this.grpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.grpCrustType.Controls.Add(this.label8);
            this.grpCrustType.Controls.Add(this.rdThickCrust);
            this.grpCrustType.Controls.Add(this.rdThinCrust);
            this.grpCrustType.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrustType.ForeColor = System.Drawing.Color.White;
            this.grpCrustType.Location = new System.Drawing.Point(170, 512);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(357, 160);
            this.grpCrustType.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 37);
            this.label8.TabIndex = 16;
            this.label8.Text = "Crust Type ";
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.Transparent;
            this.grpToppings.Controls.Add(this.label9);
            this.grpToppings.Controls.Add(this.chGreenPeppers);
            this.grpToppings.Controls.Add(this.chTomatoes);
            this.grpToppings.Controls.Add(this.chOlives);
            this.grpToppings.Controls.Add(this.chExtraChees);
            this.grpToppings.Controls.Add(this.chMushrooms);
            this.grpToppings.Controls.Add(this.chOnion);
            this.grpToppings.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.Color.White;
            this.grpToppings.Location = new System.Drawing.Point(579, 259);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(357, 238);
            this.grpToppings.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Toppings ";
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.grpWhereToEat.Controls.Add(this.label10);
            this.grpWhereToEat.Controls.Add(this.rdTakeOut);
            this.grpWhereToEat.Controls.Add(this.rdEatIn);
            this.grpWhereToEat.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereToEat.ForeColor = System.Drawing.Color.White;
            this.grpWhereToEat.Location = new System.Drawing.Point(579, 538);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(357, 100);
            this.grpWhereToEat.TabIndex = 15;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblSize);
            this.panel5.Controls.Add(this.lblWhereToEat);
            this.panel5.Controls.Add(this.lblCrustType);
            this.panel5.Controls.Add(this.lblTotalPrice);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.grpOrderSummary);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblToppings);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbl1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(1065, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 542);
            this.panel5.TabIndex = 16;
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSize.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(80, 36);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(142, 36);
            this.lblSize.TabIndex = 38;
            this.lblSize.UseVisualStyleBackColor = false;
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWhereToEat.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(200, 298);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(154, 41);
            this.lblWhereToEat.TabIndex = 37;
            this.lblWhereToEat.UseVisualStyleBackColor = false;
            // 
            // lblCrustType
            // 
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCrustType.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(162, 256);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(169, 41);
            this.lblCrustType.TabIndex = 36;
            this.lblCrustType.UseVisualStyleBackColor = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalPrice.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(162, 420);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(169, 87);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.UseVisualStyleBackColor = false;
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
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Where To Eat : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Crust Type : ";
            // 
            // lblToppings
            // 
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblToppings.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(30, 127);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(301, 87);
            this.lblToppings.TabIndex = 26;
            this.lblToppings.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Toppings : ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(26, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 26);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "Size : ";
            this.lbl1.Click += new System.EventHandler(this.Size_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 22;
            // 
            // butCloseScreen
            // 
            this.butCloseScreen.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCloseScreen.Location = new System.Drawing.Point(709, 770);
            this.butCloseScreen.Name = "butCloseScreen";
            this.butCloseScreen.Size = new System.Drawing.Size(156, 48);
            this.butCloseScreen.TabIndex = 17;
            this.butCloseScreen.Text = "Close";
            this.butCloseScreen.UseVisualStyleBackColor = true;
            this.butCloseScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pizza_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWinFormsProject.Properties.Resources._1233;
            this.ClientSize = new System.Drawing.Size(1575, 876);
            this.Controls.Add(this.butCloseScreen);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.butResetForm);
            this.Controls.Add(this.butOrderPizza);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Pizza_Order";
            this.Text = "Pizza_Order";
            this.Load += new System.EventHandler(this.Pizza_Order_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chExtraChees;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.CheckBox chMushrooms;
        private System.Windows.Forms.CheckBox chGreenPeppers;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.RadioButton rdThickCrust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.Button butOrderPizza;
        private System.Windows.Forms.Button butResetForm;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMeduim;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Panel grpSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel grpCrustType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel grpToppings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel grpWhereToEat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button lblToppings;
        private System.Windows.Forms.Button lblTotalPrice;
        private System.Windows.Forms.Button lblCrustType;
        private System.Windows.Forms.Button lblSize;
        private System.Windows.Forms.Button lblWhereToEat;
        private System.Windows.Forms.Button butCloseScreen;
    }
}