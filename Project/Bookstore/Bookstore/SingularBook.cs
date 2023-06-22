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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookstore
{
    public partial class SingularBook : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public SingularBook(string selectname)
        {
            InitializeComponent();
            AddInBox(selectname);
            LogoBook.Image = Image.FromFile("Blackfeather Company logo.png");
            BookCoverBox.Image = Image.FromFile(selectname.Trim() + ".jpg");

        }
        public DataSet getData(string selectname)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            DataSet wish = new DataSet();
            SqlDataAdapter awish = new SqlDataAdapter("SELECT * FROM Book WHERE BookName = '" + selectname + "'", con);
            awish.Fill(wish, "Book");
            con.Close();
            return wish;
        }
        public void AddInBox(string selectname)
        {
            DataSet data;
            data = getData(selectname);
            TitleBoxB.Clear();
            foreach (DataRow dr in data.Tables["Book"].Rows)
            {
                string name = dr.ItemArray.GetValue(1).ToString();
                TitleBoxB.Text = name.Trim();
                string auth = dr.ItemArray.GetValue(2).ToString();
                AuthorBox.Text = auth.Trim();
                string gean = dr.ItemArray.GetValue(3).ToString();
                GenreBox.Text = gean.Trim();
                string rel = dr.ItemArray.GetValue(4).ToString();
                PublicationBox.Text = rel.Trim();
                string pag = dr.ItemArray.GetValue(5).ToString();
                PageBox.Text = pag.Trim();
                string stock = dr.ItemArray.GetValue(6).ToString();
                StockBox.Text = stock.Trim();
                string price = dr.ItemArray.GetValue(7).ToString();
                PriceBox.Text = price.Trim();
            }
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
        private void MainButtonB_Click(object sender, EventArgs e)
        {
            MainScreen form1 = new MainScreen();
            form1.Show();
            this.Visible = false;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            string selectname = (string)TitleBoxB.Text;
            Cart cart = new Cart(selectname);
            cart.Show();
            this.Visible = false;
        }
    }
}
