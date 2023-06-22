namespace Bookstore
{
    partial class Account
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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            UserLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            RegisterButton = new Button();
            LogoAccount = new PictureBox();
            AdminLogButton = new Button();
            buttonAccountBack = new Button();
            checkPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)LogoAccount).BeginInit();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(64, 162);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(121, 23);
            UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(64, 235);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(121, 23);
            PasswordBox.TabIndex = 1;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLabel.Location = new Point(89, 126);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(81, 21);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(89, 201);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(76, 21);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(90, 314);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(89, 343);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 5;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LogoAccount
            // 
            LogoAccount.Location = new Point(38, 23);
            LogoAccount.Name = "LogoAccount";
            LogoAccount.Size = new Size(183, 100);
            LogoAccount.TabIndex = 6;
            LogoAccount.TabStop = false;
            // 
            // AdminLogButton
            // 
            AdminLogButton.Location = new Point(64, 372);
            AdminLogButton.Name = "AdminLogButton";
            AdminLogButton.Size = new Size(121, 23);
            AdminLogButton.TabIndex = 7;
            AdminLogButton.Text = "Login As Admin";
            AdminLogButton.UseVisualStyleBackColor = true;
            AdminLogButton.Click += AdminLogButton_Click;
            // 
            // buttonAccountBack
            // 
            buttonAccountBack.Location = new Point(89, 401);
            buttonAccountBack.Name = "buttonAccountBack";
            buttonAccountBack.Size = new Size(75, 23);
            buttonAccountBack.TabIndex = 8;
            buttonAccountBack.Text = "Back";
            buttonAccountBack.UseVisualStyleBackColor = true;
            buttonAccountBack.Click += buttonAccountBack_Click;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.Location = new Point(64, 264);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(108, 19);
            checkPassword.TabIndex = 9;
            checkPassword.Text = "Show Passowrd";
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 477);
            Controls.Add(checkPassword);
            Controls.Add(buttonAccountBack);
            Controls.Add(AdminLogButton);
            Controls.Add(LogoAccount);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLabel);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            ((System.ComponentModel.ISupportInitialize)LogoAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label UserLabel;
        private Label PasswordLabel;
        private Button LoginButton;
        private Button RegisterButton;
        private PictureBox LogoAccount;
        private Button AdminLogButton;
        private Button buttonAccountBack;
        private CheckBox checkPassword;
    }
}