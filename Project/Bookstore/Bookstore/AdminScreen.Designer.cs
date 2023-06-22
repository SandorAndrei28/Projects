namespace Bookstore
{
    partial class AdminScreen
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
            LogoAdminScreen = new PictureBox();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxGenre = new TextBox();
            textBoxPublicationDate = new TextBox();
            textBoxPages = new TextBox();
            textBoxStock = new TextBox();
            textBoxPrice = new TextBox();
            textBoxID = new TextBox();
            listBooks = new ListBox();
            labelAdminMode = new Label();
            labelID = new Label();
            labelName = new Label();
            labelAuthor = new Label();
            labelGenre = new Label();
            labelPublication = new Label();
            labelPages = new Label();
            labelStock = new Label();
            labelPrice = new Label();
            buttonAdd = new Button();
            textBoxDeleteID = new TextBox();
            labelDeleteID = new Label();
            buttonDelete = new Button();
            buttonAddStock = new Button();
            buttonUpdate = new Button();
            textBoxStockID = new TextBox();
            labelIDStock = new Label();
            textBoxAddedStock = new TextBox();
            labelNrStockAdd = new Label();
            labelCurrentBooks = new Label();
            buttonReturnMainAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoAdminScreen).BeginInit();
            SuspendLayout();
            // 
            // LogoAdminScreen
            // 
            LogoAdminScreen.Location = new Point(12, 12);
            LogoAdminScreen.Name = "LogoAdminScreen";
            LogoAdminScreen.Size = new Size(183, 100);
            LogoAdminScreen.TabIndex = 0;
            LogoAdminScreen.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(838, 194);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(838, 223);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(100, 23);
            textBoxAuthor.TabIndex = 2;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(838, 252);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(100, 23);
            textBoxGenre.TabIndex = 3;
            // 
            // textBoxPublicationDate
            // 
            textBoxPublicationDate.Location = new Point(838, 281);
            textBoxPublicationDate.Name = "textBoxPublicationDate";
            textBoxPublicationDate.Size = new Size(100, 23);
            textBoxPublicationDate.TabIndex = 4;
            // 
            // textBoxPages
            // 
            textBoxPages.Location = new Point(838, 310);
            textBoxPages.Name = "textBoxPages";
            textBoxPages.Size = new Size(100, 23);
            textBoxPages.TabIndex = 5;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(838, 339);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(100, 23);
            textBoxStock.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(838, 368);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 7;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(838, 165);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 8;
            // 
            // listBooks
            // 
            listBooks.FormattingEnabled = true;
            listBooks.ItemHeight = 15;
            listBooks.Location = new Point(12, 154);
            listBooks.Name = "listBooks";
            listBooks.ScrollAlwaysVisible = true;
            listBooks.Size = new Size(707, 439);
            listBooks.TabIndex = 9;
            // 
            // labelAdminMode
            // 
            labelAdminMode.AutoSize = true;
            labelAdminMode.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdminMode.Location = new Point(201, 12);
            labelAdminMode.Name = "labelAdminMode";
            labelAdminMode.Size = new Size(216, 46);
            labelAdminMode.TabIndex = 10;
            labelAdminMode.Text = "Admin Mode";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(814, 168);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 15);
            labelID.TabIndex = 11;
            labelID.Text = "ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(793, 197);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 12;
            labelName.Text = "Name";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(788, 226);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(44, 15);
            labelAuthor.TabIndex = 13;
            labelAuthor.Text = "Author";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(794, 255);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(38, 15);
            labelGenre.TabIndex = 14;
            labelGenre.Text = "Genre";
            // 
            // labelPublication
            // 
            labelPublication.AutoSize = true;
            labelPublication.Location = new Point(765, 284);
            labelPublication.Name = "labelPublication";
            labelPublication.Size = new Size(67, 15);
            labelPublication.TabIndex = 15;
            labelPublication.Text = "Publication";
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Location = new Point(731, 313);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(101, 15);
            labelPages.TabIndex = 16;
            labelPages.Text = "Number Of Pages";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(796, 342);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(36, 15);
            labelStock.TabIndex = 17;
            labelStock.Text = "Stock";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(799, 371);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 18;
            labelPrice.Text = "Price";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(852, 397);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 19;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxDeleteID
            // 
            textBoxDeleteID.Location = new Point(1077, 165);
            textBoxDeleteID.Name = "textBoxDeleteID";
            textBoxDeleteID.Size = new Size(100, 23);
            textBoxDeleteID.TabIndex = 20;
            // 
            // labelDeleteID
            // 
            labelDeleteID.AutoSize = true;
            labelDeleteID.Location = new Point(1053, 168);
            labelDeleteID.Name = "labelDeleteID";
            labelDeleteID.Size = new Size(18, 15);
            labelDeleteID.TabIndex = 21;
            labelDeleteID.Text = "ID";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1090, 194);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddStock
            // 
            buttonAddStock.Location = new Point(1090, 310);
            buttonAddStock.Name = "buttonAddStock";
            buttonAddStock.Size = new Size(75, 23);
            buttonAddStock.TabIndex = 23;
            buttonAddStock.Text = "Set Stock";
            buttonAddStock.UseVisualStyleBackColor = true;
            buttonAddStock.Click += buttonAddStock_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(852, 426);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 24;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxStockID
            // 
            textBoxStockID.Location = new Point(1077, 252);
            textBoxStockID.Name = "textBoxStockID";
            textBoxStockID.Size = new Size(100, 23);
            textBoxStockID.TabIndex = 26;
            // 
            // labelIDStock
            // 
            labelIDStock.AutoSize = true;
            labelIDStock.Location = new Point(1053, 255);
            labelIDStock.Name = "labelIDStock";
            labelIDStock.Size = new Size(18, 15);
            labelIDStock.TabIndex = 27;
            labelIDStock.Text = "ID";
            labelIDStock.Click += labelIDStock_Click;
            // 
            // textBoxAddedStock
            // 
            textBoxAddedStock.Location = new Point(1077, 281);
            textBoxAddedStock.Name = "textBoxAddedStock";
            textBoxAddedStock.Size = new Size(100, 23);
            textBoxAddedStock.TabIndex = 28;
            // 
            // labelNrStockAdd
            // 
            labelNrStockAdd.AutoSize = true;
            labelNrStockAdd.Location = new Point(982, 284);
            labelNrStockAdd.Name = "labelNrStockAdd";
            labelNrStockAdd.Size = new Size(89, 15);
            labelNrStockAdd.TabIndex = 29;
            labelNrStockAdd.Text = "Number Added";
            // 
            // labelCurrentBooks
            // 
            labelCurrentBooks.AutoSize = true;
            labelCurrentBooks.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentBooks.Location = new Point(12, 121);
            labelCurrentBooks.Name = "labelCurrentBooks";
            labelCurrentBooks.Size = new Size(151, 30);
            labelCurrentBooks.TabIndex = 36;
            labelCurrentBooks.Text = "Current Books";
            // 
            // buttonReturnMainAdmin
            // 
            buttonReturnMainAdmin.Location = new Point(1097, 18);
            buttonReturnMainAdmin.Name = "buttonReturnMainAdmin";
            buttonReturnMainAdmin.Size = new Size(87, 40);
            buttonReturnMainAdmin.TabIndex = 37;
            buttonReturnMainAdmin.Text = "Return To Main Screen";
            buttonReturnMainAdmin.UseVisualStyleBackColor = true;
            buttonReturnMainAdmin.Click += buttonReturnMainAdmin_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 730);
            Controls.Add(buttonReturnMainAdmin);
            Controls.Add(labelCurrentBooks);
            Controls.Add(labelNrStockAdd);
            Controls.Add(textBoxAddedStock);
            Controls.Add(labelIDStock);
            Controls.Add(textBoxStockID);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAddStock);
            Controls.Add(buttonDelete);
            Controls.Add(labelDeleteID);
            Controls.Add(textBoxDeleteID);
            Controls.Add(buttonAdd);
            Controls.Add(labelPrice);
            Controls.Add(labelStock);
            Controls.Add(labelPages);
            Controls.Add(labelPublication);
            Controls.Add(labelGenre);
            Controls.Add(labelAuthor);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Controls.Add(labelAdminMode);
            Controls.Add(listBooks);
            Controls.Add(textBoxID);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPages);
            Controls.Add(textBoxPublicationDate);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxName);
            Controls.Add(LogoAdminScreen);
            Name = "AdminScreen";
            Text = "AdminScreen";
            ((System.ComponentModel.ISupportInitialize)LogoAdminScreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoAdminScreen;
        private TextBox textBoxName;
        private TextBox textBoxAuthor;
        private TextBox textBoxGenre;
        private TextBox textBoxPublicationDate;
        private TextBox textBoxPages;
        private TextBox textBoxStock;
        private TextBox textBoxPrice;
        private TextBox textBoxID;
        private ListBox listBooks;
        private Label labelAdminMode;
        private Label labelID;
        private Label labelName;
        private Label labelAuthor;
        private Label labelGenre;
        private Label labelPublication;
        private Label labelPages;
        private Label labelStock;
        private Label labelPrice;
        private Button buttonAdd;
        private TextBox textBoxDeleteID;
        private Label labelDeleteID;
        private Button buttonDelete;
        private Button buttonAddStock;
        private Button buttonUpdate;
        private TextBox textBoxStockID;
        private Label labelIDStock;
        private TextBox textBoxAddedStock;
        private Label labelNrStockAdd;
        private Label labelCurrentBooks;
        private Button buttonReturnMainAdmin;
    }
}