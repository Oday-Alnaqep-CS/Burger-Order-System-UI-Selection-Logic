namespace MyWinFormsProject
{
    partial class Main
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
            this.butMakeHamburger = new System.Windows.Forms.Button();
            this.lblTital = new System.Windows.Forms.Label();
            this.lblTital1 = new System.Windows.Forms.Label();
            this.butMakePizzaOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMakeHamburger
            // 
            this.butMakeHamburger.BackColor = System.Drawing.Color.Transparent;
            this.butMakeHamburger.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMakeHamburger.Location = new System.Drawing.Point(1262, 634);
            this.butMakeHamburger.Name = "butMakeHamburger";
            this.butMakeHamburger.Size = new System.Drawing.Size(189, 98);
            this.butMakeHamburger.TabIndex = 1;
            this.butMakeHamburger.Text = "!Let\'s Make Hamburger Order";
            this.butMakeHamburger.UseVisualStyleBackColor = false;
            this.butMakeHamburger.Click += new System.EventHandler(this.butMakeHamburger_Click);
            // 
            // lblTital
            // 
            this.lblTital.AutoSize = true;
            this.lblTital.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTital.Location = new System.Drawing.Point(449, 110);
            this.lblTital.Name = "lblTital";
            this.lblTital.Size = new System.Drawing.Size(0, 77);
            this.lblTital.TabIndex = 2;
            this.lblTital.Tag = "Tital";
            // 
            // lblTital1
            // 
            this.lblTital1.AutoSize = true;
            this.lblTital1.BackColor = System.Drawing.Color.Transparent;
            this.lblTital1.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTital1.ForeColor = System.Drawing.Color.Red;
            this.lblTital1.Location = new System.Drawing.Point(161, 18);
            this.lblTital1.Name = "lblTital1";
            this.lblTital1.Size = new System.Drawing.Size(0, 77);
            this.lblTital1.TabIndex = 3;
            // 
            // butMakePizzaOrder
            // 
            this.butMakePizzaOrder.BackColor = System.Drawing.Color.Transparent;
            this.butMakePizzaOrder.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMakePizzaOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butMakePizzaOrder.Location = new System.Drawing.Point(248, 634);
            this.butMakePizzaOrder.Name = "butMakePizzaOrder";
            this.butMakePizzaOrder.Size = new System.Drawing.Size(185, 102);
            this.butMakePizzaOrder.TabIndex = 0;
            this.butMakePizzaOrder.Text = "!Let\'s Make Pizza Order";
            this.butMakePizzaOrder.UseVisualStyleBackColor = false;
            this.butMakePizzaOrder.Click += new System.EventHandler(this.butMakePizzaOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWinFormsProject.Properties.Resources._1000;
            this.ClientSize = new System.Drawing.Size(1574, 896);
            this.Controls.Add(this.lblTital1);
            this.Controls.Add(this.lblTital);
            this.Controls.Add(this.butMakeHamburger);
            this.Controls.Add(this.butMakePizzaOrder);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butMakeHamburger;
        private System.Windows.Forms.Label lblTital;
        private System.Windows.Forms.Label lblTital1;
        private System.Windows.Forms.Button butMakePizzaOrder;
    }
}