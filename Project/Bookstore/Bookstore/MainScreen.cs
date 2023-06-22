using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualStudio.Services.Organization.Client;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;

namespace Bookstore
{
    public partial class MainScreen : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();

        public MainScreen()
        {
            InitializeComponent();
            AddInBox();
            Logo.Image = Image.FromFile("Blackfeather Company logo.png");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BookService();
            getData();
        }
        public void BookService()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
        }
        public DataSet getData()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            DataSet wish = new DataSet();
            SqlDataAdapter awish = new SqlDataAdapter("SELECT * FROM Book", con);
            awish.Fill(wish, "Book");
            con.Close();
            return wish;
        }

        public void AddInBox()
        {
            DataSet data;
            data = getData();
            RecommList.Items.Clear();
            var gn = new List<string>();
            foreach (DataRow dr in data.Tables["Book"].Rows)
            {
                string name = dr.ItemArray.GetValue(1).ToString().Trim();
                RecommList.Items.Add(name);
                string gname = dr.ItemArray.GetValue(3).ToString().Trim();
                gn.Add(gname);
            }
            foreach (var item in gn.Distinct())
            {
                CategoryList.Items.Add(item);
            }
        }
        private static void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static void Logo_Click(object sender, EventArgs e)
        {

        }

        private void RecommList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = (string)RecommList.SelectedItem;
            pictureBox1.Image = Image.FromFile(name.Trim() + ".jpg");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search(SeachBar.Text);
            search.Show();
            this.Visible = false;
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart("");
            cart.Show();
            this.Visible = false;
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Visible = false;
        }

        private void BookSelectButton_Click(object sender, EventArgs e)
        {
            string selectname = (string)RecommList.SelectedItem;
            SingularBook singularBook = new SingularBook(selectname);
            singularBook.Show();
            this.Visible = false;
        }

        private void buttonGeanra_Click(object sender, EventArgs e)
        {
            string selectname = (string)CategoryList.SelectedItem;
            Search search = new Search(selectname);
            search.Show();
            this.Visible = false;
        }
    }
}