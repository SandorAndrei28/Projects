namespace Bookstore
{
    partial class Register
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
            NameBoxR = new TextBox();
            EmailBoxR = new TextBox();
            PasswordBoxR = new TextBox();
            PasswordBoxR2 = new TextBox();
            NameLabelR = new Label();
            EmailLabelR = new Label();
            PasswordLabelR1 = new Label();
            PasswordLabelR2 = new Label();
            RegisterButtonR = new Button();
            LogoRegister = new PictureBox();
            buttonBack = new Button();
            checkBoxPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)LogoRegister).BeginInit();
            SuspendLayout();
            // 
            // NameBoxR
            // 
            NameBoxR.Location = new Point(85, 131);
            NameBoxR.Name = "NameBoxR";
            NameBoxR.Size = new Size(100, 23);
            NameBoxR.TabIndex = 0;
            // 
            // EmailBoxR
            // 
            EmailBoxR.Location = new Point(85, 188);
            EmailBoxR.Name = "EmailBoxR";
            EmailBoxR.Size = new Size(100, 23);
            EmailBoxR.TabIndex = 1;
            // 
            // PasswordBoxR
            // 
            PasswordBoxR.Location = new Point(85, 243);
            PasswordBoxR.Name = "PasswordBoxR";
            PasswordBoxR.Size = new Size(100, 23);
            PasswordBoxR.TabIndex = 2;
            // 
            // PasswordBoxR2
            // 
            PasswordBoxR2.Location = new Point(85, 298);
            PasswordBoxR2.Name = "PasswordBoxR2";
            PasswordBoxR2.Size = new Size(100, 23);
            PasswordBoxR2.TabIndex = 3;
            // 
            // NameLabelR
            // 
            NameLabelR.AutoSize = true;
            NameLabelR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabelR.Location = new Point(108, 107);
            NameLabelR.Name = "NameLabelR";
            NameLabelR.Size = new Size(55, 21);
            NameLabelR.TabIndex = 4;
            NameLabelR.Text = "Name:";
            // 
            // EmailLabelR
            // 
            EmailLabelR.AutoSize = true;
            EmailLabelR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabelR.Location = new Point(108, 164);
            EmailLabelR.Name = "EmailLabelR";
            EmailLabelR.Size = new Size(51, 21);
            EmailLabelR.TabIndex = 5;
            EmailLabelR.Text = "Email:";
            // 
            // PasswordLabelR1
            // 
            PasswordLabelR1.AutoSize = true;
            PasswordLabelR1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabelR1.Location = new Point(96, 219);
            PasswordLabelR1.Name = "PasswordLabelR1";
            PasswordLabelR1.Size = new Size(79, 21);
            PasswordLabelR1.TabIndex = 6;
            PasswordLabelR1.Text = "Password:";
            // 
            // PasswordLabelR2
            // 
            PasswordLabelR2.AutoSize = true;
            PasswordLabelR2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabelR2.Location = new Point(69, 274);
            PasswordLabelR2.Name = "PasswordLabelR2";
            PasswordLabelR2.Size = new Size(137, 21);
            PasswordLabelR2.TabIndex = 7;
            PasswordLabelR2.Text = "Confirm Password";
            // 
            // RegisterButtonR
            // 
            RegisterButtonR.Location = new Point(96, 366);
            RegisterButtonR.Name = "RegisterButtonR";
            RegisterButtonR.Size = new Size(75, 23);
            RegisterButtonR.TabIndex = 8;
            RegisterButtonR.Text = "Register";
            RegisterButtonR.UseVisualStyleBackColor = true;
            RegisterButtonR.Click += RegisterButtonR_Click;
            // 
            // LogoRegister
            // 
            LogoRegister.Location = new Point(44, 4);
            LogoRegister.Name = "LogoRegister";
            LogoRegister.Size = new Size(183, 100);
            LogoRegister.TabIndex = 9;
            LogoRegister.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(96, 396);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.Location = new Point(85, 327);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(108, 19);
            checkBoxPassword.TabIndex = 11;
            checkBoxPassword.Text = "Show Password";
            checkBoxPassword.UseVisualStyleBackColor = true;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 450);
            Controls.Add(checkBoxPassword);
            Controls.Add(buttonBack);
            Controls.Add(LogoRegister);
            Controls.Add(RegisterButtonR);
            Controls.Add(PasswordLabelR2);
            Controls.Add(PasswordLabelR1);
            Controls.Add(EmailLabelR);
            Controls.Add(NameLabelR);
            Controls.Add(PasswordBoxR2);
            Controls.Add(PasswordBoxR);
            Controls.Add(EmailBoxR);
            Controls.Add(NameBoxR);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)LogoRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBoxR;
        private TextBox EmailBoxR;
        private TextBox PasswordBoxR;
        private TextBox PasswordBoxR2;
        private Label NameLabelR;
        private Label EmailLabelR;
        private Label PasswordLabelR1;
        private Label PasswordLabelR2;
        private Button RegisterButtonR;
        private PictureBox LogoRegister;
        private Button buttonBack;
        private CheckBox checkBoxPassword;
    }
}