using Microsoft.VisualBasic.Logging;
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
using System.Xml.Linq;
using System.IO;
using static System.Windows.Forms.DataFormats;

namespace Bookstore
{
    public partial class Account : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();

        private void Account_Load(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
        }
        public Account()
        {
            InitializeComponent();
            LogoAccount.Image = Image.FromFile("Blackfeather Company logo.png");
        }

        private void session(string data)
        {
            using (StreamWriter File = new StreamWriter("session.txt"))
            {
                File.WriteLine(data);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Visible = false;
        }
        private void trylogin(string name, string pass)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            try
            {
                bool valid = false;
                string loginSQL = "Select * FROM Customer WHERE Name = '" + name + "' AND Password = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(loginSQL, con);
                try
                {
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (rowCount >= 1)
                    {
                        valid = true;
                    }
                    else if (rowCount <= 0)
                    {
                        valid = false;
                    }
                }
                catch
                {
                }
                if (valid == true)
                {
                    MessageBox.Show("Login successful!");
                    MainScreen form1 = new MainScreen();
                    form1.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorect data!");
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            trylogin(UsernameBox.Text, PasswordBox.Text);
        }

        private void tryloginAdmin(string name, string pass)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            try
            {
                bool valid = false;
                string loginSQL = "Select * FROM Admin WHERE name = '" + name + "' AND password = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(loginSQL, con);
                try
                {
                    int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (rowCount >= 1)
                    {
                        valid = true;
                    }
                    else if (rowCount <= 0)
                    {
                        valid = false;
                    }
                }
                catch
                {
                }
                if (valid == true)
                {
                    MessageBox.Show("Login successful!");
                    AdminScreen formAdmin = new AdminScreen();
                    formAdmin.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorect data!");
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }

        private void AdminLogButton_Click(object sender, EventArgs e)
        {
            tryloginAdmin(UsernameBox.Text, PasswordBox.Text);
        }

        private void buttonAccountBack_Click(object sender, EventArgs e)
        {
            MainScreen form1 = new MainScreen();
            form1.Show();
            this.Visible = false;
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPassword.Checked)
            {
                PasswordBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
