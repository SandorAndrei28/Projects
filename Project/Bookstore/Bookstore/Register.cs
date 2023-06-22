using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookstore
{
    public partial class Register : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        private void Register_Load(object sender, EventArgs e)
        {
            PasswordBoxR.UseSystemPasswordChar = true;
            PasswordBoxR2.UseSystemPasswordChar = true;
        }
        public Register()
        {
            InitializeComponent();
            LogoRegister.Image = Image.FromFile("Blackfeather Company logo.png");
        }
        private void addCustomer( string name, string pass, string email)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO Customer(Name, Password, Email) VALUES (@name, @pass, @email)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }
        private void RegisterButtonR_Click(object sender, EventArgs e)
        {
            if(PasswordBoxR.Text == PasswordBoxR2.Text)
            {
                addCustomer(NameBoxR.Text, PasswordBoxR.Text, EmailBoxR.Text);
                MessageBox.Show("Register Complete!");
                MainScreen form1 = new MainScreen();
                form1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Passwords don't match!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Visible = false;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                PasswordBoxR.UseSystemPasswordChar = false;
                PasswordBoxR2.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBoxR.UseSystemPasswordChar = true;
                PasswordBoxR2.UseSystemPasswordChar = true;
            }
        }


    }
}
