using Microsoft.VisualBasic.Logging;
using Microsoft.VisualStudio.Services.Organization.Client;
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

namespace Bookstore
{
    public partial class Search : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public Search(string selectname)
        {
            InitializeComponent();
            AddInBox(selectname);
            LogoSearch.Image = Image.FromFile("Blackfeather Company logo.png");
        }
        public DataSet getData(string selectname)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            DataSet wish = new DataSet();
            SqlDataAdapter awish = new SqlDataAdapter("SELECT * FROM Book WHERE BookName = '" + selectname + "'", con);
            awish.Fill(wish, "Book");
            SqlDataAdapter bwish = new SqlDataAdapter("SELECT * FROM Book WHERE Author = '" + selectname + "'", con);
            bwish.Fill(wish, "Book");
            SqlDataAdapter cwish = new SqlDataAdapter("SELECT * FROM Book WHERE Geanra = '" + selectname + "'", con);
            cwish.Fill(wish, "Book");
            con.Close();
            return wish;
        }

        public void AddInBox(string selectname)
        {
            DataSet data;
            data = getData(selectname);
            SearchList.Items.Clear();
            foreach (DataRow dr in data.Tables["Book"].Rows)
            {
                string name = dr.ItemArray.GetValue(1).ToString();
                SearchList.Items.Add(name);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            string name = (string)SearchList.SelectedItem;
            SearchPictureBox.Image = Image.FromFile(name + ".jpg");
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            MainScreen form1 = new MainScreen();
            form1.Show();
            this.Visible = false;
        }

        private void LogoSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = (string)SearchList.SelectedItem;
            SearchPictureBox.Image = Image.FromFile(name.Trim() + ".jpg");
        }

        private void SearchPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AddBookSearch_Click(object sender, EventArgs e)
        {
            string name = (string)SearchList.SelectedItem;
            SingularBook singularBook = new SingularBook(name);
            singularBook.Show();
            this.Visible = false;
        }
    }
}
