namespace Bookstore
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SeachBar = new TextBox();
            SearchButton = new Button();
            RecommendationsLabel = new Label();
            pictureBox1 = new PictureBox();
            AccountButton = new Button();
            CategoryList = new ListBox();
            Categories = new Label();
            CartButton = new Button();
            Logo = new PictureBox();
            RecommList = new ListBox();
            BookSelectButton = new Button();
            buttonGeanra = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // SeachBar
            // 
            SeachBar.Location = new Point(275, 79);
            SeachBar.Name = "SeachBar";
            SeachBar.Size = new Size(398, 23);
            SeachBar.TabIndex = 1;
            SeachBar.Text = "Looking for a certain book?";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(673, 79);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(81, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // RecommendationsLabel
            // 
            RecommendationsLabel.AutoSize = true;
            RecommendationsLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RecommendationsLabel.Location = new Point(86, 125);
            RecommendationsLabel.Name = "RecommendationsLabel";
            RecommendationsLabel.Size = new Size(192, 30);
            RecommendationsLabel.TabIndex = 4;
            RecommendationsLabel.Text = "Recommendations";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(284, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 654);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // AccountButton
            // 
            AccountButton.Location = new Point(778, 32);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(75, 23);
            AccountButton.TabIndex = 6;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // CategoryList
            // 
            CategoryList.FormattingEnabled = true;
            CategoryList.ItemHeight = 15;
            CategoryList.Location = new Point(750, 158);
            CategoryList.Name = "CategoryList";
            CategoryList.Size = new Size(120, 289);
            CategoryList.TabIndex = 7;
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Categories.Location = new Point(750, 125);
            Categories.Name = "Categories";
            Categories.Size = new Size(117, 30);
            Categories.TabIndex = 8;
            Categories.Text = "Categories";
            // 
            // CartButton
            // 
            CartButton.Location = new Point(778, 61);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(75, 23);
            CartButton.TabIndex = 9;
            CartButton.Text = "Cart";
            CartButton.UseVisualStyleBackColor = true;
            CartButton.Click += CartButton_Click;
            // 
            // Logo
            // 
            Logo.Location = new Point(54, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(183, 100);
            Logo.TabIndex = 10;
            Logo.TabStop = false;
            // 
            // RecommList
            // 
            RecommList.FormattingEnabled = true;
            RecommList.HorizontalScrollbar = true;
            RecommList.ItemHeight = 15;
            RecommList.Location = new Point(86, 158);
            RecommList.Name = "RecommList";
            RecommList.ScrollAlwaysVisible = true;
            RecommList.Size = new Size(192, 289);
            RecommList.TabIndex = 3;
            RecommList.SelectedIndexChanged += RecommList_SelectedIndexChanged;
            // 
            // BookSelectButton
            // 
            BookSelectButton.Location = new Point(128, 466);
            BookSelectButton.Name = "BookSelectButton";
            BookSelectButton.Size = new Size(95, 23);
            BookSelectButton.TabIndex = 11;
            BookSelectButton.Text = "Select Book";
            BookSelectButton.UseVisualStyleBackColor = true;
            BookSelectButton.Click += BookSelectButton_Click;
            // 
            // buttonGeanra
            // 
            buttonGeanra.Location = new Point(750, 459);
            buttonGeanra.Name = "buttonGeanra";
            buttonGeanra.Size = new Size(120, 36);
            buttonGeanra.TabIndex = 12;
            buttonGeanra.Text = "Search By Geanra";
            buttonGeanra.UseVisualStyleBackColor = true;
            buttonGeanra.Click += buttonGeanra_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 815);
            Controls.Add(buttonGeanra);
            Controls.Add(BookSelectButton);
            Controls.Add(Logo);
            Controls.Add(CartButton);
            Controls.Add(Categories);
            Controls.Add(CategoryList);
            Controls.Add(AccountButton);
            Controls.Add(pictureBox1);
            Controls.Add(RecommendationsLabel);
            Controls.Add(RecommList);
            Controls.Add(SearchButton);
            Controls.Add(SeachBar);
            Name = "MainScreen";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SeachBar;
        private Button SearchButton;
        private Label RecommendationsLabel;
        private PictureBox pictureBox1;
        private Button AccountButton;
        private ListBox CategoryList;
        private Label Categories;
        private Button CartButton;
        private PictureBox Logo;
        private ListBox RecommList;
        private Button BookSelectButton;
        private Button buttonGeanra;
    }
}