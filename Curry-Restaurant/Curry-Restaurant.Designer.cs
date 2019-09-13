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
            this.optBurrito = new System.Windows.Forms.RadioButton();
            this.optPasta = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpPizzaSizes = new System.Windows.Forms.GroupBox();
            this.chkLarge = new System.Windows.Forms.CheckBox();
            this.chkMedium = new System.Windows.Forms.CheckBox();
            this.chkSmallPizza = new System.Windows.Forms.CheckBox();
            this.grpPastaVariety = new System.Windows.Forms.GroupBox();
            this.chkRigatoniCheese = new System.Windows.Forms.CheckBox();
            this.chkRigatoniSausage = new System.Windows.Forms.CheckBox();
            this.chkRigatoniBeef = new System.Windows.Forms.CheckBox();
            this.chkRigatoniStuffed = new System.Windows.Forms.CheckBox();
            this.chkAngelHair = new System.Windows.Forms.CheckBox();
            this.chkSpaghetti = new System.Windows.Forms.CheckBox();
            this.grpBurritoSizes = new System.Windows.Forms.GroupBox();
            this.chkHumongous = new System.Windows.Forms.CheckBox();
            this.chkAverage = new System.Windows.Forms.CheckBox();
            this.chkPetite = new System.Windows.Forms.CheckBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grpSauces = new System.Windows.Forms.GroupBox();
            this.chkWhite = new System.Windows.Forms.CheckBox();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.grpBurritoTypes = new System.Windows.Forms.GroupBox();
            this.chkVegetarian = new System.Windows.Forms.CheckBox();
            this.chkPolo = new System.Windows.Forms.CheckBox();
            this.chkMachaca = new System.Windows.Forms.CheckBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.chkStuffed = new System.Windows.Forms.CheckBox();
            this.chkThin = new System.Windows.Forms.CheckBox();
            this.chkThick = new System.Windows.Forms.CheckBox();
            this.grpPizzaVariety = new System.Windows.Forms.GroupBox();
            this.chkBaked = new System.Windows.Forms.CheckBox();
            this.chkBrownedTop = new System.Windows.Forms.CheckBox();
            this.grpStuffing = new System.Windows.Forms.GroupBox();
            this.chkCheeseStuffed = new System.Windows.Forms.CheckBox();
            this.chkPlain = new System.Windows.Forms.CheckBox();
            this.chkCheesyCoating = new System.Windows.Forms.CheckBox();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkMeatballs = new System.Windows.Forms.CheckBox();
            this.chkPlainAdd = new System.Windows.Forms.CheckBox();
            this.txtDisplayOrder = new System.Windows.Forms.TextBox();
            this.grpPizzaSizes.SuspendLayout();
            this.grpPastaVariety.SuspendLayout();
            this.grpBurritoSizes.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpSauces.SuspendLayout();
            this.grpBurritoTypes.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpPizzaVariety.SuspendLayout();
            this.grpStuffing.SuspendLayout();
            this.grpAddOn.SuspendLayout();
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
            // optBurrito
            // 
            this.optBurrito.AutoSize = true;
            this.optBurrito.Location = new System.Drawing.Point(507, 77);
            this.optBurrito.Name = "optBurrito";
            this.optBurrito.Size = new System.Drawing.Size(78, 21);
            this.optBurrito.TabIndex = 1;
            this.optBurrito.Text = "Burritos";
            this.optBurrito.UseVisualStyleBackColor = true;
            this.optBurrito.CheckedChanged += new System.EventHandler(this.OptBuritto_CheckedChanged);
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
            this.optPasta.CheckedChanged += new System.EventHandler(this.OptPasta_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(276, 656);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 31);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // grpPizzaSizes
            // 
            this.grpPizzaSizes.Controls.Add(this.chkLarge);
            this.grpPizzaSizes.Controls.Add(this.chkMedium);
            this.grpPizzaSizes.Controls.Add(this.chkSmallPizza);
            this.grpPizzaSizes.Enabled = false;
            this.grpPizzaSizes.Location = new System.Drawing.Point(40, 154);
            this.grpPizzaSizes.Name = "grpPizzaSizes";
            this.grpPizzaSizes.Size = new System.Drawing.Size(200, 100);
            this.grpPizzaSizes.TabIndex = 4;
            this.grpPizzaSizes.TabStop = false;
            this.grpPizzaSizes.Text = "Pizza Sizes";
            // 
            // chkLarge
            // 
            this.chkLarge.AutoSize = true;
            this.chkLarge.Location = new System.Drawing.Point(27, 75);
            this.chkLarge.Name = "chkLarge";
            this.chkLarge.Size = new System.Drawing.Size(67, 21);
            this.chkLarge.TabIndex = 2;
            this.chkLarge.Text = "Large";
            this.chkLarge.UseVisualStyleBackColor = true;
            // 
            // chkMedium
            // 
            this.chkMedium.AutoSize = true;
            this.chkMedium.Location = new System.Drawing.Point(27, 45);
            this.chkMedium.Name = "chkMedium";
            this.chkMedium.Size = new System.Drawing.Size(79, 21);
            this.chkMedium.TabIndex = 1;
            this.chkMedium.Text = "Medium";
            this.chkMedium.UseVisualStyleBackColor = true;
            this.chkMedium.CheckedChanged += new System.EventHandler(this.ChkMedium_CheckedChanged);
            // 
            // chkSmallPizza
            // 
            this.chkSmallPizza.AutoSize = true;
            this.chkSmallPizza.Location = new System.Drawing.Point(27, 18);
            this.chkSmallPizza.Name = "chkSmallPizza";
            this.chkSmallPizza.Size = new System.Drawing.Size(64, 21);
            this.chkSmallPizza.TabIndex = 0;
            this.chkSmallPizza.Text = "Small";
            this.chkSmallPizza.UseVisualStyleBackColor = true;
            // 
            // grpPastaVariety
            // 
            this.grpPastaVariety.Controls.Add(this.chkRigatoniCheese);
            this.grpPastaVariety.Controls.Add(this.chkRigatoniSausage);
            this.grpPastaVariety.Controls.Add(this.chkRigatoniBeef);
            this.grpPastaVariety.Controls.Add(this.chkRigatoniStuffed);
            this.grpPastaVariety.Controls.Add(this.chkAngelHair);
            this.grpPastaVariety.Controls.Add(this.chkSpaghetti);
            this.grpPastaVariety.Enabled = false;
            this.grpPastaVariety.Location = new System.Drawing.Point(285, 154);
            this.grpPastaVariety.Name = "grpPastaVariety";
            this.grpPastaVariety.Size = new System.Drawing.Size(200, 176);
            this.grpPastaVariety.TabIndex = 5;
            this.grpPastaVariety.TabStop = false;
            this.grpPastaVariety.Text = "Pasta Variety";
            // 
            // chkRigatoniCheese
            // 
            this.chkRigatoniCheese.AutoSize = true;
            this.chkRigatoniCheese.Location = new System.Drawing.Point(23, 153);
            this.chkRigatoniCheese.Name = "chkRigatoniCheese";
            this.chkRigatoniCheese.Size = new System.Drawing.Size(143, 21);
            this.chkRigatoniCheese.TabIndex = 8;
            this.chkRigatoniCheese.Text = "Rigatoni - Cheese";
            this.chkRigatoniCheese.UseVisualStyleBackColor = true;
            // 
            // chkRigatoniSausage
            // 
            this.chkRigatoniSausage.AutoSize = true;
            this.chkRigatoniSausage.Location = new System.Drawing.Point(23, 129);
            this.chkRigatoniSausage.Name = "chkRigatoniSausage";
            this.chkRigatoniSausage.Size = new System.Drawing.Size(151, 21);
            this.chkRigatoniSausage.TabIndex = 7;
            this.chkRigatoniSausage.Text = "Rigatoni - Sausage";
            this.chkRigatoniSausage.UseVisualStyleBackColor = true;
            // 
            // chkRigatoniBeef
            // 
            this.chkRigatoniBeef.AutoSize = true;
            this.chkRigatoniBeef.Location = new System.Drawing.Point(23, 102);
            this.chkRigatoniBeef.Name = "chkRigatoniBeef";
            this.chkRigatoniBeef.Size = new System.Drawing.Size(124, 21);
            this.chkRigatoniBeef.TabIndex = 6;
            this.chkRigatoniBeef.Text = "Rigatoni - Beef";
            this.chkRigatoniBeef.UseVisualStyleBackColor = true;
            // 
            // chkRigatoniStuffed
            // 
            this.chkRigatoniStuffed.AutoSize = true;
            this.chkRigatoniStuffed.Location = new System.Drawing.Point(23, 75);
            this.chkRigatoniStuffed.Name = "chkRigatoniStuffed";
            this.chkRigatoniStuffed.Size = new System.Drawing.Size(140, 21);
            this.chkRigatoniStuffed.TabIndex = 5;
            this.chkRigatoniStuffed.Text = "Rigatoni - Stuffed";
            this.chkRigatoniStuffed.UseVisualStyleBackColor = true;
            // 
            // chkAngelHair
            // 
            this.chkAngelHair.AutoSize = true;
            this.chkAngelHair.Location = new System.Drawing.Point(23, 45);
            this.chkAngelHair.Name = "chkAngelHair";
            this.chkAngelHair.Size = new System.Drawing.Size(96, 21);
            this.chkAngelHair.TabIndex = 4;
            this.chkAngelHair.Text = "Angel Hair";
            this.chkAngelHair.UseVisualStyleBackColor = true;
            // 
            // chkSpaghetti
            // 
            this.chkSpaghetti.AutoSize = true;
            this.chkSpaghetti.Location = new System.Drawing.Point(23, 18);
            this.chkSpaghetti.Name = "chkSpaghetti";
            this.chkSpaghetti.Size = new System.Drawing.Size(90, 21);
            this.chkSpaghetti.TabIndex = 3;
            this.chkSpaghetti.Text = "Spaghetti";
            this.chkSpaghetti.UseVisualStyleBackColor = true;
            // 
            // grpBurritoSizes
            // 
            this.grpBurritoSizes.Controls.Add(this.chkHumongous);
            this.grpBurritoSizes.Controls.Add(this.chkAverage);
            this.grpBurritoSizes.Controls.Add(this.chkPetite);
            this.grpBurritoSizes.Enabled = false;
            this.grpBurritoSizes.Location = new System.Drawing.Point(507, 154);
            this.grpBurritoSizes.Name = "grpBurritoSizes";
            this.grpBurritoSizes.Size = new System.Drawing.Size(200, 100);
            this.grpBurritoSizes.TabIndex = 5;
            this.grpBurritoSizes.TabStop = false;
            this.grpBurritoSizes.Text = "Burrito Sizes";
            // 
            // chkHumongous
            // 
            this.chkHumongous.AutoSize = true;
            this.chkHumongous.Location = new System.Drawing.Point(25, 75);
            this.chkHumongous.Name = "chkHumongous";
            this.chkHumongous.Size = new System.Drawing.Size(106, 21);
            this.chkHumongous.TabIndex = 5;
            this.chkHumongous.Text = "Humongous";
            this.chkHumongous.UseVisualStyleBackColor = true;
            // 
            // chkAverage
            // 
            this.chkAverage.AutoSize = true;
            this.chkAverage.Location = new System.Drawing.Point(25, 45);
            this.chkAverage.Name = "chkAverage";
            this.chkAverage.Size = new System.Drawing.Size(83, 21);
            this.chkAverage.TabIndex = 4;
            this.chkAverage.Text = "Average";
            this.chkAverage.UseVisualStyleBackColor = true;
            // 
            // chkPetite
            // 
            this.chkPetite.AutoSize = true;
            this.chkPetite.Location = new System.Drawing.Point(25, 18);
            this.chkPetite.Name = "chkPetite";
            this.chkPetite.Size = new System.Drawing.Size(66, 21);
            this.chkPetite.TabIndex = 3;
            this.chkPetite.Text = "Petite";
            this.chkPetite.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkMushroom);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Enabled = false;
            this.grpToppings.Location = new System.Drawing.Point(40, 277);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(200, 100);
            this.grpToppings.TabIndex = 6;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(27, 72);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(69, 21);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(27, 45);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(96, 21);
            this.chkMushroom.TabIndex = 4;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(27, 21);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(95, 21);
            this.chkPepperoni.TabIndex = 3;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // grpSauces
            // 
            this.grpSauces.Controls.Add(this.chkWhite);
            this.grpSauces.Controls.Add(this.chkRed);
            this.grpSauces.Enabled = false;
            this.grpSauces.Location = new System.Drawing.Point(285, 358);
            this.grpSauces.Name = "grpSauces";
            this.grpSauces.Size = new System.Drawing.Size(200, 72);
            this.grpSauces.TabIndex = 5;
            this.grpSauces.TabStop = false;
            this.grpSauces.Text = "Sauces";
            // 
            // chkWhite
            // 
            this.chkWhite.AutoSize = true;
            this.chkWhite.Location = new System.Drawing.Point(23, 42);
            this.chkWhite.Name = "chkWhite";
            this.chkWhite.Size = new System.Drawing.Size(66, 21);
            this.chkWhite.TabIndex = 4;
            this.chkWhite.Text = "White";
            this.chkWhite.UseVisualStyleBackColor = true;
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Location = new System.Drawing.Point(23, 15);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(56, 21);
            this.chkRed.TabIndex = 3;
            this.chkRed.Text = "Red";
            this.chkRed.UseVisualStyleBackColor = true;
            // 
            // grpBurritoTypes
            // 
            this.grpBurritoTypes.Controls.Add(this.chkVegetarian);
            this.grpBurritoTypes.Controls.Add(this.chkPolo);
            this.grpBurritoTypes.Controls.Add(this.chkMachaca);
            this.grpBurritoTypes.Enabled = false;
            this.grpBurritoTypes.Location = new System.Drawing.Point(507, 322);
            this.grpBurritoTypes.Name = "grpBurritoTypes";
            this.grpBurritoTypes.Size = new System.Drawing.Size(200, 100);
            this.grpBurritoTypes.TabIndex = 7;
            this.grpBurritoTypes.TabStop = false;
            this.grpBurritoTypes.Text = "Types";
            // 
            // chkVegetarian
            // 
            this.chkVegetarian.AutoSize = true;
            this.chkVegetarian.Location = new System.Drawing.Point(25, 72);
            this.chkVegetarian.Name = "chkVegetarian";
            this.chkVegetarian.Size = new System.Drawing.Size(99, 21);
            this.chkVegetarian.TabIndex = 5;
            this.chkVegetarian.Text = "Vegetarian";
            this.chkVegetarian.UseVisualStyleBackColor = true;
            // 
            // chkPolo
            // 
            this.chkPolo.AutoSize = true;
            this.chkPolo.Location = new System.Drawing.Point(25, 42);
            this.chkPolo.Name = "chkPolo";
            this.chkPolo.Size = new System.Drawing.Size(58, 21);
            this.chkPolo.TabIndex = 4;
            this.chkPolo.Text = "Polo";
            this.chkPolo.UseVisualStyleBackColor = true;
            // 
            // chkMachaca
            // 
            this.chkMachaca.AutoSize = true;
            this.chkMachaca.Location = new System.Drawing.Point(25, 15);
            this.chkMachaca.Name = "chkMachaca";
            this.chkMachaca.Size = new System.Drawing.Size(87, 21);
            this.chkMachaca.TabIndex = 3;
            this.chkMachaca.Text = "Machaca";
            this.chkMachaca.UseVisualStyleBackColor = true;
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.chkStuffed);
            this.grpCrust.Controls.Add(this.chkThin);
            this.grpCrust.Controls.Add(this.chkThick);
            this.grpCrust.Enabled = false;
            this.grpCrust.Location = new System.Drawing.Point(40, 407);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(200, 100);
            this.grpCrust.TabIndex = 0;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // chkStuffed
            // 
            this.chkStuffed.AutoSize = true;
            this.chkStuffed.Location = new System.Drawing.Point(27, 72);
            this.chkStuffed.Name = "chkStuffed";
            this.chkStuffed.Size = new System.Drawing.Size(75, 21);
            this.chkStuffed.TabIndex = 8;
            this.chkStuffed.Text = "Stuffed";
            this.chkStuffed.UseVisualStyleBackColor = true;
            // 
            // chkThin
            // 
            this.chkThin.AutoSize = true;
            this.chkThin.Location = new System.Drawing.Point(27, 21);
            this.chkThin.Name = "chkThin";
            this.chkThin.Size = new System.Drawing.Size(58, 21);
            this.chkThin.TabIndex = 6;
            this.chkThin.Text = "Thin";
            this.chkThin.UseVisualStyleBackColor = true;
            // 
            // chkThick
            // 
            this.chkThick.AutoSize = true;
            this.chkThick.Location = new System.Drawing.Point(27, 45);
            this.chkThick.Name = "chkThick";
            this.chkThick.Size = new System.Drawing.Size(64, 21);
            this.chkThick.TabIndex = 7;
            this.chkThick.Text = "Thick";
            this.chkThick.UseVisualStyleBackColor = true;
            // 
            // grpPizzaVariety
            // 
            this.grpPizzaVariety.Controls.Add(this.chkBaked);
            this.grpPizzaVariety.Controls.Add(this.chkBrownedTop);
            this.grpPizzaVariety.Enabled = false;
            this.grpPizzaVariety.Location = new System.Drawing.Point(40, 534);
            this.grpPizzaVariety.Name = "grpPizzaVariety";
            this.grpPizzaVariety.Size = new System.Drawing.Size(200, 100);
            this.grpPizzaVariety.TabIndex = 0;
            this.grpPizzaVariety.TabStop = false;
            this.grpPizzaVariety.Text = "Pizza Variety";
            // 
            // chkBaked
            // 
            this.chkBaked.AutoSize = true;
            this.chkBaked.Location = new System.Drawing.Point(27, 21);
            this.chkBaked.Name = "chkBaked";
            this.chkBaked.Size = new System.Drawing.Size(70, 21);
            this.chkBaked.TabIndex = 9;
            this.chkBaked.Text = "Baked";
            this.chkBaked.UseVisualStyleBackColor = true;
            // 
            // chkBrownedTop
            // 
            this.chkBrownedTop.AutoSize = true;
            this.chkBrownedTop.Location = new System.Drawing.Point(27, 45);
            this.chkBrownedTop.Name = "chkBrownedTop";
            this.chkBrownedTop.Size = new System.Drawing.Size(114, 21);
            this.chkBrownedTop.TabIndex = 10;
            this.chkBrownedTop.Text = "Browned Top";
            this.chkBrownedTop.UseVisualStyleBackColor = true;
            // 
            // grpStuffing
            // 
            this.grpStuffing.Controls.Add(this.chkCheeseStuffed);
            this.grpStuffing.Controls.Add(this.chkPlain);
            this.grpStuffing.Controls.Add(this.chkCheesyCoating);
            this.grpStuffing.Enabled = false;
            this.grpStuffing.Location = new System.Drawing.Point(40, 665);
            this.grpStuffing.Name = "grpStuffing";
            this.grpStuffing.Size = new System.Drawing.Size(200, 100);
            this.grpStuffing.TabIndex = 0;
            this.grpStuffing.TabStop = false;
            this.grpStuffing.Text = "Stuffing";
            // 
            // chkCheeseStuffed
            // 
            this.chkCheeseStuffed.AutoSize = true;
            this.chkCheeseStuffed.Location = new System.Drawing.Point(27, 72);
            this.chkCheeseStuffed.Name = "chkCheeseStuffed";
            this.chkCheeseStuffed.Size = new System.Drawing.Size(127, 21);
            this.chkCheeseStuffed.TabIndex = 14;
            this.chkCheeseStuffed.Text = "Cheese Stuffed";
            this.chkCheeseStuffed.UseVisualStyleBackColor = true;
            // 
            // chkPlain
            // 
            this.chkPlain.AutoSize = true;
            this.chkPlain.Location = new System.Drawing.Point(27, 21);
            this.chkPlain.Name = "chkPlain";
            this.chkPlain.Size = new System.Drawing.Size(61, 21);
            this.chkPlain.TabIndex = 12;
            this.chkPlain.Text = "Plain";
            this.chkPlain.UseVisualStyleBackColor = true;
            // 
            // chkCheesyCoating
            // 
            this.chkCheesyCoating.AutoSize = true;
            this.chkCheesyCoating.Location = new System.Drawing.Point(27, 45);
            this.chkCheesyCoating.Name = "chkCheesyCoating";
            this.chkCheesyCoating.Size = new System.Drawing.Size(129, 21);
            this.chkCheesyCoating.TabIndex = 13;
            this.chkCheesyCoating.Text = "Cheesy Coating";
            this.chkCheesyCoating.UseVisualStyleBackColor = true;
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.chkSausage);
            this.grpAddOn.Controls.Add(this.chkMeatballs);
            this.grpAddOn.Controls.Add(this.chkPlainAdd);
            this.grpAddOn.Enabled = false;
            this.grpAddOn.Location = new System.Drawing.Point(285, 452);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(200, 106);
            this.grpAddOn.TabIndex = 8;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add On";
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(23, 75);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(86, 21);
            this.chkSausage.TabIndex = 5;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkMeatballs
            // 
            this.chkMeatballs.AutoSize = true;
            this.chkMeatballs.Location = new System.Drawing.Point(23, 45);
            this.chkMeatballs.Name = "chkMeatballs";
            this.chkMeatballs.Size = new System.Drawing.Size(90, 21);
            this.chkMeatballs.TabIndex = 4;
            this.chkMeatballs.Text = "Meatballs";
            this.chkMeatballs.UseVisualStyleBackColor = true;
            // 
            // chkPlainAdd
            // 
            this.chkPlainAdd.AutoSize = true;
            this.chkPlainAdd.Location = new System.Drawing.Point(23, 18);
            this.chkPlainAdd.Name = "chkPlainAdd";
            this.chkPlainAdd.Size = new System.Drawing.Size(61, 21);
            this.chkPlainAdd.TabIndex = 3;
            this.chkPlainAdd.Text = "Plain";
            this.chkPlainAdd.UseVisualStyleBackColor = true;
            // 
            // txtDisplayOrder
            // 
            this.txtDisplayOrder.Location = new System.Drawing.Point(410, 584);
            this.txtDisplayOrder.Multiline = true;
            this.txtDisplayOrder.Name = "txtDisplayOrder";
            this.txtDisplayOrder.Size = new System.Drawing.Size(297, 181);
            this.txtDisplayOrder.TabIndex = 9;
            // 
            // frmCurryRestaurant
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 790);
            this.Controls.Add(this.txtDisplayOrder);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpPizzaVariety);
            this.Controls.Add(this.grpStuffing);
            this.Controls.Add(this.grpBurritoTypes);
            this.Controls.Add(this.grpSauces);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpBurritoSizes);
            this.Controls.Add(this.grpPastaVariety);
            this.Controls.Add(this.grpPizzaSizes);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.optPasta);
            this.Controls.Add(this.optBurrito);
            this.Controls.Add(this.optPizza);
            this.Name = "frmCurryRestaurant";
            this.Text = "Curry Restaurant Menu";
            this.Load += new System.EventHandler(this.FrmCurryRestaurant_Load);
            this.grpPizzaSizes.ResumeLayout(false);
            this.grpPizzaSizes.PerformLayout();
            this.grpPastaVariety.ResumeLayout(false);
            this.grpPastaVariety.PerformLayout();
            this.grpBurritoSizes.ResumeLayout(false);
            this.grpBurritoSizes.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpSauces.ResumeLayout(false);
            this.grpSauces.PerformLayout();
            this.grpBurritoTypes.ResumeLayout(false);
            this.grpBurritoTypes.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpPizzaVariety.ResumeLayout(false);
            this.grpPizzaVariety.PerformLayout();
            this.grpStuffing.ResumeLayout(false);
            this.grpStuffing.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optPizza;
        private System.Windows.Forms.RadioButton optBurrito;
        private System.Windows.Forms.RadioButton optPasta;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpPizzaSizes;
        private System.Windows.Forms.GroupBox grpPastaVariety;
        private System.Windows.Forms.GroupBox grpBurritoSizes;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpSauces;
        private System.Windows.Forms.GroupBox grpBurritoTypes;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.GroupBox grpPizzaVariety;
        private System.Windows.Forms.GroupBox grpStuffing;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox chkLarge;
        private System.Windows.Forms.CheckBox chkMedium;
        private System.Windows.Forms.CheckBox chkSmallPizza;
        private System.Windows.Forms.TextBox txtDisplayOrder;
        private System.Windows.Forms.CheckBox chkRigatoniCheese;
        private System.Windows.Forms.CheckBox chkRigatoniSausage;
        private System.Windows.Forms.CheckBox chkRigatoniBeef;
        private System.Windows.Forms.CheckBox chkRigatoniStuffed;
        private System.Windows.Forms.CheckBox chkAngelHair;
        private System.Windows.Forms.CheckBox chkSpaghetti;
        private System.Windows.Forms.CheckBox chkHumongous;
        private System.Windows.Forms.CheckBox chkAverage;
        private System.Windows.Forms.CheckBox chkPetite;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkWhite;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.CheckBox chkVegetarian;
        private System.Windows.Forms.CheckBox chkPolo;
        private System.Windows.Forms.CheckBox chkMachaca;
        private System.Windows.Forms.CheckBox chkStuffed;
        private System.Windows.Forms.CheckBox chkThin;
        private System.Windows.Forms.CheckBox chkThick;
        private System.Windows.Forms.CheckBox chkBaked;
        private System.Windows.Forms.CheckBox chkBrownedTop;
        private System.Windows.Forms.CheckBox chkCheeseStuffed;
        private System.Windows.Forms.CheckBox chkPlain;
        private System.Windows.Forms.CheckBox chkCheesyCoating;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkMeatballs;
        private System.Windows.Forms.CheckBox chkPlainAdd;
    }
}

