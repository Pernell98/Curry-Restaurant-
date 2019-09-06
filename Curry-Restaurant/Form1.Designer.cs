namespace Curry_Restaurant
{
    partial class frmCurryRestaurant
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
            this.optPizza = new System.Windows.Forms.RadioButton();
            this.optBuritto = new System.Windows.Forms.RadioButton();
            this.optPasta = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.grpPastaVariety = new System.Windows.Forms.GroupBox();
            this.grpSizes = new System.Windows.Forms.GroupBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.grpSauces = new System.Windows.Forms.GroupBox();
            this.grpTypes = new System.Windows.Forms.GroupBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.grpPizzaVariety = new System.Windows.Forms.GroupBox();
            this.grpStuffing = new System.Windows.Forms.GroupBox();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // optPizza
            // 
            this.optPizza.AutoSize = true;
            this.optPizza.Location = new System.Drawing.Point(67, 74);
            this.optPizza.Name = "optPizza";
            this.optPizza.Size = new System.Drawing.Size(63, 21);
            this.optPizza.TabIndex = 0;
            this.optPizza.Text = "Pizza";
            this.optPizza.UseVisualStyleBackColor = true;
            this.optPizza.CheckedChanged += new System.EventHandler(this.OptPizza_CheckedChanged);
            // 
            // optBuritto
            // 
            this.optBuritto.AutoSize = true;
            this.optBuritto.Location = new System.Drawing.Point(507, 77);
            this.optBuritto.Name = "optBuritto";
            this.optBuritto.Size = new System.Drawing.Size(77, 21);
            this.optBuritto.TabIndex = 1;
            this.optBuritto.Text = "Burittos";
            this.optBuritto.UseVisualStyleBackColor = true;
            // 
            // optPasta
            // 
            this.optPasta.AutoSize = true;
            this.optPasta.Location = new System.Drawing.Point(285, 77);
            this.optPasta.Name = "optPasta";
            this.optPasta.Size = new System.Drawing.Size(65, 21);
            this.optPasta.TabIndex = 2;
            this.optPasta.Text = "Pasta";
            this.optPasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optPasta.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(862, 391);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 31);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Enabled = false;
            this.grpSize.Location = new System.Drawing.Point(40, 154);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 100);
            this.grpSize.TabIndex = 4;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // grpPastaVariety
            // 
            this.grpPastaVariety.Enabled = false;
            this.grpPastaVariety.Location = new System.Drawing.Point(285, 154);
            this.grpPastaVariety.Name = "grpPastaVariety";
            this.grpPastaVariety.Size = new System.Drawing.Size(200, 100);
            this.grpPastaVariety.TabIndex = 5;
            this.grpPastaVariety.TabStop = false;
            this.grpPastaVariety.Text = "Pasta Variety";
            // 
            // grpSizes
            // 
            this.grpSizes.Location = new System.Drawing.Point(507, 154);
            this.grpSizes.Name = "grpSizes";
            this.grpSizes.Size = new System.Drawing.Size(200, 100);
            this.grpSizes.TabIndex = 5;
            this.grpSizes.TabStop = false;
            this.grpSizes.Text = "Sizes";
            // 
            // grpToppings
            // 
            this.grpToppings.Enabled = false;
            this.grpToppings.Location = new System.Drawing.Point(40, 277);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(200, 100);
            this.grpToppings.TabIndex = 6;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // grpSauces
            // 
            this.grpSauces.Enabled = false;
            this.grpSauces.Location = new System.Drawing.Point(273, 322);
            this.grpSauces.Name = "grpSauces";
            this.grpSauces.Size = new System.Drawing.Size(200, 100);
            this.grpSauces.TabIndex = 5;
            this.grpSauces.TabStop = false;
            this.grpSauces.Text = "Sauces";
            // 
            // grpTypes
            // 
            this.grpTypes.Location = new System.Drawing.Point(507, 307);
            this.grpTypes.Name = "grpTypes";
            this.grpTypes.Size = new System.Drawing.Size(200, 100);
            this.grpTypes.TabIndex = 7;
            this.grpTypes.TabStop = false;
            this.grpTypes.Text = "Types";
            // 
            // grpCrust
            // 
            this.grpCrust.Location = new System.Drawing.Point(40, 407);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(200, 100);
            this.grpCrust.TabIndex = 0;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // grpPizzaVariety
            // 
            this.grpPizzaVariety.Location = new System.Drawing.Point(40, 534);
            this.grpPizzaVariety.Name = "grpPizzaVariety";
            this.grpPizzaVariety.Size = new System.Drawing.Size(200, 100);
            this.grpPizzaVariety.TabIndex = 0;
            this.grpPizzaVariety.TabStop = false;
            this.grpPizzaVariety.Text = "Pizza Variety";
            // 
            // grpStuffing
            // 
            this.grpStuffing.Location = new System.Drawing.Point(40, 665);
            this.grpStuffing.Name = "grpStuffing";
            this.grpStuffing.Size = new System.Drawing.Size(200, 100);
            this.grpStuffing.TabIndex = 0;
            this.grpStuffing.TabStop = false;
            this.grpStuffing.Text = "Stuffing";
            // 
            // grpAddOn
            // 
            this.grpAddOn.Enabled = false;
            this.grpAddOn.Location = new System.Drawing.Point(285, 461);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(200, 100);
            this.grpAddOn.TabIndex = 8;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add On";
            // 
            // frmCurryRestaurant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(999, 790);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpPizzaVariety);
            this.Controls.Add(this.grpStuffing);
            this.Controls.Add(this.grpTypes);
            this.Controls.Add(this.grpSauces);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSizes);
            this.Controls.Add(this.grpPastaVariety);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.optPasta);
            this.Controls.Add(this.optBuritto);
            this.Controls.Add(this.optPizza);
            this.Name = "frmCurryRestaurant";
            this.Text = "Curry Restaurant Menu";
            this.Load += new System.EventHandler(this.FrmCurryRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optPizza;
        private System.Windows.Forms.RadioButton optBuritto;
        private System.Windows.Forms.RadioButton optPasta;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpPastaVariety;
        private System.Windows.Forms.GroupBox grpSizes;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpSauces;
        private System.Windows.Forms.GroupBox grpTypes;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.GroupBox grpPizzaVariety;
        private System.Windows.Forms.GroupBox grpStuffing;
        private System.Windows.Forms.GroupBox grpAddOn;
    }
}

