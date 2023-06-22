namespace Bookstore
{
    partial class Search
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
            SearchList = new ListBox();
            SearchResultLabel = new Label();
            SearchPictureBox = new PictureBox();
            LogoSearch = new PictureBox();
            MainButton = new Button();
            AddBookSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)SearchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoSearch).BeginInit();
            SuspendLayout();
            // 
            // SearchList
            // 
            SearchList.FormattingEnabled = true;
            SearchList.ItemHeight = 15;
            SearchList.Location = new Point(31, 156);
            SearchList.Name = "SearchList";
            SearchList.Size = new Size(258, 364);
            SearchList.TabIndex = 1;
            SearchList.SelectedIndexChanged += SearchList_SelectedIndexChanged;
            // 
            // SearchResultLabel
            // 
            SearchResultLabel.AutoSize = true;
            SearchResultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchResultLabel.Location = new Point(31, 132);
            SearchResultLabel.Name = "SearchResultLabel";
            SearchResultLabel.Size = new Size(111, 21);
            SearchResultLabel.TabIndex = 2;
            SearchResultLabel.Text = "Search Results";
            SearchResultLabel.Click += label1_Click;
            // 
            // SearchPictureBox
            // 
            SearchPictureBox.Location = new Point(319, 30);
            SearchPictureBox.Name = "SearchPictureBox";
            SearchPictureBox.Size = new Size(460, 654);
            SearchPictureBox.TabIndex = 3;
            SearchPictureBox.TabStop = false;
            SearchPictureBox.Click += SearchPictureBox_Click;
            // 
            // LogoSearch
            // 
            LogoSearch.Location = new Point(12, 12);
            LogoSearch.Name = "LogoSearch";
            LogoSearch.Size = new Size(183, 100);
            LogoSearch.TabIndex = 4;
            LogoSearch.TabStop = false;
            LogoSearch.Click += LogoSearch_Click;
            // 
            // MainButton
            // 
            MainButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainButton.Location = new Point(92, 563);
            MainButton.Name = "MainButton";
            MainButton.Size = new Size(122, 32);
            MainButton.TabIndex = 5;
            MainButton.Text = "Main page";
            MainButton.UseVisualStyleBackColor = true;
            MainButton.Click += MainButton_Click;
            // 
            // AddBookSearch
            // 
            AddBookSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookSearch.Location = new Point(92, 526);
            AddBookSearch.Name = "AddBookSearch";
            AddBookSearch.Size = new Size(122, 31);
            AddBookSearch.TabIndex = 6;
            AddBookSearch.Text = "Select Book";
            AddBookSearch.UseVisualStyleBackColor = true;
            AddBookSearch.Click += AddBookSearch_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 737);
            Controls.Add(AddBookSearch);
            Controls.Add(MainButton);
            Controls.Add(LogoSearch);
            Controls.Add(SearchPictureBox);
            Controls.Add(SearchResultLabel);
            Controls.Add(SearchList);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)SearchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox SearchList;
        private Label SearchResultLabel;
        private PictureBox SearchPictureBox;
        private PictureBox LogoSearch;
        private Button MainButton;
        private Button AddBookSearch;
    }
}