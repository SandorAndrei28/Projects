namespace Bookstore
{
    partial class SingularBook
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
            BookCoverBox = new PictureBox();
            LogoBook = new PictureBox();
            TitleBoxB = new TextBox();
            NameLabelB = new Label();
            AuthorLabel = new Label();
            GenreLabel = new Label();
            PublicationLabel = new Label();
            PageLabel = new Label();
            PriceLabel = new Label();
            AuthorBox = new TextBox();
            GenreBox = new TextBox();
            PublicationBox = new TextBox();
            PageBox = new TextBox();
            PriceBox = new TextBox();
            StockBox = new TextBox();
            OrderButton = new Button();
            MainButtonB = new Button();
            labelStockSB = new Label();
            ((System.ComponentModel.ISupportInitialize)BookCoverBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoBook).BeginInit();
            SuspendLayout();
            // 
            // BookCoverBox
            // 
            BookCoverBox.Location = new Point(12, 131);
            BookCoverBox.Name = "BookCoverBox";
            BookCoverBox.Size = new Size(460, 654);
            BookCoverBox.TabIndex = 0;
            BookCoverBox.TabStop = false;
            // 
            // LogoBook
            // 
            LogoBook.Location = new Point(12, 12);
            LogoBook.Name = "LogoBook";
            LogoBook.Size = new Size(183, 100);
            LogoBook.TabIndex = 1;
            LogoBook.TabStop = false;
            // 
            // TitleBoxB
            // 
            TitleBoxB.Location = new Point(519, 131);
            TitleBoxB.Name = "TitleBoxB";
            TitleBoxB.ReadOnly = true;
            TitleBoxB.Size = new Size(191, 23);
            TitleBoxB.TabIndex = 2;
            // 
            // NameLabelB
            // 
            NameLabelB.AutoSize = true;
            NameLabelB.Location = new Point(519, 113);
            NameLabelB.Name = "NameLabelB";
            NameLabelB.Size = new Size(29, 15);
            NameLabelB.TabIndex = 3;
            NameLabelB.Text = "Title";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(519, 157);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(44, 15);
            AuthorLabel.TabIndex = 4;
            AuthorLabel.Text = "Author";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(519, 201);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(38, 15);
            GenreLabel.TabIndex = 5;
            GenreLabel.Text = "Genre";
            // 
            // PublicationLabel
            // 
            PublicationLabel.AutoSize = true;
            PublicationLabel.Location = new Point(519, 245);
            PublicationLabel.Name = "PublicationLabel";
            PublicationLabel.Size = new Size(94, 15);
            PublicationLabel.TabIndex = 6;
            PublicationLabel.Text = "Publication Date";
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Location = new Point(519, 289);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(101, 15);
            PageLabel.TabIndex = 7;
            PageLabel.Text = "Number Of Pages";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(520, 333);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 8;
            PriceLabel.Text = "Price";
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(519, 175);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.ReadOnly = true;
            AuthorBox.Size = new Size(191, 23);
            AuthorBox.TabIndex = 9;
            // 
            // GenreBox
            // 
            GenreBox.Location = new Point(519, 219);
            GenreBox.Name = "GenreBox";
            GenreBox.ReadOnly = true;
            GenreBox.Size = new Size(191, 23);
            GenreBox.TabIndex = 10;
            // 
            // PublicationBox
            // 
            PublicationBox.Location = new Point(519, 263);
            PublicationBox.Name = "PublicationBox";
            PublicationBox.ReadOnly = true;
            PublicationBox.Size = new Size(100, 23);
            PublicationBox.TabIndex = 11;
            // 
            // PageBox
            // 
            PageBox.Location = new Point(519, 307);
            PageBox.Name = "PageBox";
            PageBox.ReadOnly = true;
            PageBox.Size = new Size(100, 23);
            PageBox.TabIndex = 12;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(519, 351);
            PriceBox.Name = "PriceBox";
            PriceBox.ReadOnly = true;
            PriceBox.Size = new Size(100, 23);
            PriceBox.TabIndex = 13;
            // 
            // StockBox
            // 
            StockBox.Location = new Point(519, 395);
            StockBox.Name = "StockBox";
            StockBox.ReadOnly = true;
            StockBox.Size = new Size(100, 23);
            StockBox.TabIndex = 14;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(519, 448);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(100, 23);
            OrderButton.TabIndex = 15;
            OrderButton.Text = "Add To Cart";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // MainButtonB
            // 
            MainButtonB.Location = new Point(588, 12);
            MainButtonB.Name = "MainButtonB";
            MainButtonB.Size = new Size(122, 23);
            MainButtonB.TabIndex = 16;
            MainButtonB.Text = "Back To Main Page";
            MainButtonB.UseVisualStyleBackColor = true;
            MainButtonB.Click += MainButtonB_Click;
            // 
            // labelStockSB
            // 
            labelStockSB.AutoSize = true;
            labelStockSB.Location = new Point(520, 377);
            labelStockSB.Name = "labelStockSB";
            labelStockSB.Size = new Size(49, 15);
            labelStockSB.TabIndex = 17;
            labelStockSB.Text = "In Stock";
            // 
            // SingularBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 793);
            Controls.Add(labelStockSB);
            Controls.Add(MainButtonB);
            Controls.Add(OrderButton);
            Controls.Add(StockBox);
            Controls.Add(PriceBox);
            Controls.Add(PageBox);
            Controls.Add(PublicationBox);
            Controls.Add(GenreBox);
            Controls.Add(AuthorBox);
            Controls.Add(PriceLabel);
            Controls.Add(PageLabel);
            Controls.Add(PublicationLabel);
            Controls.Add(GenreLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(NameLabelB);
            Controls.Add(TitleBoxB);
            Controls.Add(LogoBook);
            Controls.Add(BookCoverBox);
            Name = "SingularBook";
            Text = "SingularBook";
            ((System.ComponentModel.ISupportInitialize)BookCoverBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BookCoverBox;
        private PictureBox LogoBook;
        private TextBox TitleBoxB;
        private Label NameLabelB;
        private Label AuthorLabel;
        private Label GenreLabel;
        private Label PublicationLabel;
        private Label PageLabel;
        private Label PriceLabel;
        private TextBox AuthorBox;
        private TextBox GenreBox;
        private TextBox PublicationBox;
        private TextBox PageBox;
        private TextBox PriceBox;
        private TextBox StockBox;
        private Button OrderButton;
        private Button MainButtonB;
        private Label labelStockSB;
    }
}