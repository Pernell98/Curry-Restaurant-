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
            this.grpVariety = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
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
            this.optBuritto.TabStop = true;
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
            this.optPasta.TabStop = true;
            this.optPasta.Text = "Pasta";
            this.optPasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optPasta.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(871, 547);
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
            // grpVariety
            // 
            this.grpVariety.Enabled = false;
            this.grpVariety.Location = new System.Drawing.Point(285, 154);
            this.grpVariety.Name = "grpVariety";
            this.grpVariety.Size = new System.Drawing.Size(200, 100);
            this.grpVariety.TabIndex = 5;
            this.grpVariety.TabStop = false;
            this.grpVariety.Text = "Variety";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(507, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // grpToppings
            // 
            this.grpToppings.Enabled = false;
            this.grpToppings.Location = new System.Drawing.Point(40, 322);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(200, 100);
            this.grpToppings.TabIndex = 6;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // groupBox5
            // 
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(273, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(507, 322);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // frmCurryRestaurant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1076, 625);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpVariety);
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
        private System.Windows.Forms.GroupBox grpVariety;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

