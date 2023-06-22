namespace Bookstore
{
    partial class Cart
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
            Label CityLabel;
            CartList = new ListBox();
            CartText = new Label();
            NameBox = new TextBox();
            CountryBox = new TextBox();
            CountyBox = new TextBox();
            City = new TextBox();
            Adress = new TextBox();
            NumberBox = new TextBox();
            namelabel = new Label();
            CountryLabel = new Label();
            CountyLabel = new Label();
            AdressLabel = new Label();
            PhoneLabel = new Label();
            OrderButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            PriceLabel = new Label();
            TransportLabel = new Label();
            TotalPriceLabel = new Label();
            TotalPriceBox = new TextBox();
            LogoCart = new PictureBox();
            buttonCartReturnMain = new Button();
            buttonDel = new Button();
            CityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoCart).BeginInit();
            SuspendLayout();
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.Location = new Point(614, 232);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 21);
            CityLabel.TabIndex = 11;
            CityLabel.Text = "City";
            // 
            // CartList
            // 
            CartList.FormattingEnabled = true;
            CartList.ItemHeight = 15;
            CartList.Location = new Point(29, 120);
            CartList.Name = "CartList";
            CartList.Size = new Size(351, 274);
            CartList.TabIndex = 0;
            CartList.SelectedIndexChanged += CartList_SelectedIndexChanged;
            // 
            // CartText
            // 
            CartText.AutoSize = true;
            CartText.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CartText.Location = new Point(29, 80);
            CartText.Name = "CartText";
            CartText.Size = new Size(90, 37);
            CartText.TabIndex = 1;
            CartText.Text = "In cart";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(614, 87);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(152, 23);
            NameBox.TabIndex = 2;
            // 
            // CountryBox
            // 
            CountryBox.Location = new Point(614, 144);
            CountryBox.Name = "CountryBox";
            CountryBox.Size = new Size(152, 23);
            CountryBox.TabIndex = 3;
            CountryBox.TextChanged += CountryBox_TextChanged;
            // 
            // CountyBox
            // 
            CountyBox.Location = new Point(614, 201);
            CountyBox.Name = "CountyBox";
            CountyBox.Size = new Size(152, 23);
            CountyBox.TabIndex = 4;
            // 
            // City
            // 
            City.Location = new Point(614, 256);
            City.Name = "City";
            City.Size = new Size(152, 23);
            City.TabIndex = 5;
            // 
            // Adress
            // 
            Adress.Location = new Point(614, 310);
            Adress.Name = "Adress";
            Adress.Size = new Size(152, 23);
            Adress.TabIndex = 6;
            // 
            // NumberBox
            // 
            NumberBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumberBox.Location = new Point(614, 370);
            NumberBox.Name = "NumberBox";
            NumberBox.Size = new Size(152, 23);
            NumberBox.TabIndex = 7;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            namelabel.Location = new Point(614, 63);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(55, 21);
            namelabel.TabIndex = 8;
            namelabel.Text = "Name:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountryLabel.Location = new Point(614, 120);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(69, 21);
            CountryLabel.TabIndex = 9;
            CountryLabel.Text = "Country:";
            // 
            // CountyLabel
            // 
            CountyLabel.AutoSize = true;
            CountyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CountyLabel.Location = new Point(614, 177);
            CountyLabel.Name = "CountyLabel";
            CountyLabel.Size = new Size(63, 21);
            CountyLabel.TabIndex = 10;
            CountyLabel.Text = "County:";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdressLabel.Location = new Point(614, 286);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(57, 21);
            AdressLabel.TabIndex = 12;
            AdressLabel.Text = "Adress";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(614, 346);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(119, 21);
            PhoneLabel.TabIndex = 13;
            PhoneLabel.Text = "Phone Number:";
            // 
            // OrderButton
            // 
            OrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderButton.Location = new Point(449, 344);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(92, 35);
            OrderButton.TabIndex = 14;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 165);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 220);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceLabel.Location = new Point(430, 141);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(47, 21);
            PriceLabel.TabIndex = 17;
            PriceLabel.Text = "Price:";
            // 
            // TransportLabel
            // 
            TransportLabel.AutoSize = true;
            TransportLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TransportLabel.Location = new Point(430, 196);
            TransportLabel.Name = "TransportLabel";
            TransportLabel.Size = new Size(117, 21);
            TransportLabel.TabIndex = 18;
            TransportLabel.Text = "Transport Price:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPriceLabel.Location = new Point(430, 250);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(83, 21);
            TotalPriceLabel.TabIndex = 19;
            TotalPriceLabel.Text = "Total Price:";
            // 
            // TotalPriceBox
            // 
            TotalPriceBox.Location = new Point(430, 274);
            TotalPriceBox.Name = "TotalPriceBox";
            TotalPriceBox.ReadOnly = true;
            TotalPriceBox.Size = new Size(127, 23);
            TotalPriceBox.TabIndex = 20;
            TotalPriceBox.TextChanged += TotalPriceBox_TextChanged;
            // 
            // LogoCart
            // 
            LogoCart.Location = new Point(294, 12);
            LogoCart.Name = "LogoCart";
            LogoCart.Size = new Size(183, 100);
            LogoCart.TabIndex = 21;
            LogoCart.TabStop = false;
            // 
            // buttonCartReturnMain
            // 
            buttonCartReturnMain.Location = new Point(29, 12);
            buttonCartReturnMain.Name = "buttonCartReturnMain";
            buttonCartReturnMain.Size = new Size(103, 44);
            buttonCartReturnMain.TabIndex = 22;
            buttonCartReturnMain.Text = "Return To Main Screen";
            buttonCartReturnMain.UseVisualStyleBackColor = true;
            buttonCartReturnMain.Click += buttonCartReturnMain_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(29, 400);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 23;
            buttonDel.Text = "Delete Selected";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDel);
            Controls.Add(buttonCartReturnMain);
            Controls.Add(LogoCart);
            Controls.Add(TotalPriceBox);
            Controls.Add(TotalPriceLabel);
            Controls.Add(TransportLabel);
            Controls.Add(PriceLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(OrderButton);
            Controls.Add(PhoneLabel);
            Controls.Add(AdressLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountyLabel);
            Controls.Add(CountryLabel);
            Controls.Add(namelabel);
            Controls.Add(NumberBox);
            Controls.Add(Adress);
            Controls.Add(City);
            Controls.Add(CountyBox);
            Controls.Add(CountryBox);
            Controls.Add(NameBox);
            Controls.Add(CartText);
            Controls.Add(CartList);
            Name = "Cart";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)LogoCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CartList;
        private Label CartText;
        private TextBox NameBox;
        private TextBox CountryBox;
        private TextBox CountyBox;
        private TextBox City;
        private TextBox Adress;
        private TextBox NumberBox;
        private Label namelabel;
        private Label CountryLabel;
        private Label CountyLabel;
        private Label AdressLabel;
        private Label PhoneLabel;
        private Button OrderButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label PriceLabel;
        private Label TransportLabel;
        private Label TotalPriceLabel;
        private TextBox TotalPriceBox;
        private PictureBox LogoCart;
        private Button buttonCartReturnMain;
        private Button buttonDel;
    }
}