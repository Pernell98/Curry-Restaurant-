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
            this.SuspendLayout();
            // 
            // optPizza
            // 
            this.optPizza.AutoSize = true;
            this.optPizza.Location = new System.Drawing.Point(67, 77);
            this.optPizza.Name = "optPizza";
            this.optPizza.Size = new System.Drawing.Size(63, 21);
            this.optPizza.TabIndex = 0;
            this.optPizza.TabStop = true;
            this.optPizza.Text = "Pizza";
            this.optPizza.UseVisualStyleBackColor = true;
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
            this.btnSubmit.Location = new System.Drawing.Point(574, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 31);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmCurryRestaurant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.optPasta);
            this.Controls.Add(this.optBuritto);
            this.Controls.Add(this.optPizza);
            this.Name = "frmCurryRestaurant";
            this.Text = "Curry Restaurant Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optPizza;
        private System.Windows.Forms.RadioButton optBuritto;
        private System.Windows.Forms.RadioButton optPasta;
        private System.Windows.Forms.Button btnSubmit;
    }
}

