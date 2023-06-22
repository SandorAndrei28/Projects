using Microsoft.VisualBasic.Logging;
using Microsoft.VisualStudio.Services.Profile;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class Cart : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public Cart(string selectname)
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            LogoCart.Image = Image.FromFile("Blackfeather Company logo.png");
            textBox2.Text = "10";
            if (selectname == "")
            {
                StreamReader streamReader = new StreamReader(path: "session.txt");
                string text = streamReader.ReadLine();
                string[] bits = text.Split(' ');
                int id = int.Parse(bits[0]);
                AddInBoxCart(id);
                addPrice(selectname);
            }
            else
            {
                StreamReader streamReader = new StreamReader(path: "session.txt");
                string text = streamReader.ReadLine();
                string[] bits = text.Split(' ');
                int id = int.Parse(bits[0]);
                addBookCart(id, selectname, 1);
                AddInBoxCart(id);
                addPrice(selectname);
            }
        }
        public DataSet getDataCart(int id)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            var cmd = con.CreateCommand();
            DataSet wish = new DataSet();
            SqlDataAdapter awish = new SqlDataAdapter(@"SELECT * FROM Cart", con);
            cmd.Parameters.AddWithValue("@id", id);
            awish.Fill(wish, "Cart");
            con.Close();
            return wish;
        }
        public DataSet getPrice(string name)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            var cmd = con.CreateCommand();
            DataSet wish = new DataSet();
            SqlDataAdapter awish = new SqlDataAdapter("SELECT * FROM Book WHERE BookName = '" + name + "'", con);
            awish.Fill(wish, "Book");
            con.Close();
            return wish;
        }
        public void addPrice(string name)
        {
            DataSet data;
            data = getPrice(name);
            var gn = new List<string>();
            float total = 0;
            foreach (DataRow dr in data.Tables["Book"].Rows)
            {
                string x = dr.ItemArray.GetValue(7).ToString();
                float price = float.Parse(x);
                total += price;
            }
            textBox1.Text = total.ToString();
            float final = 10;
            final += total;
            TotalPriceBox.Text = total.ToString();
        }
        public void AddInBoxCart(int id)
        {
            DataSet data;
            data = getDataCart(id);
            CartList.Items.Clear();
            var gn = new List<string>();
            foreach (DataRow dr in data.Tables["Cart"].Rows)
            {
                string name = dr.ItemArray.GetValue(1).ToString().Trim();
                CartList.Items.Add(name);
            }
        }
        private void addBookCart(int id, string bookname, int nr)
        {
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO Cart(customerID, bookName, nrOrdered) VALUES (@id, @name, @nr)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", bookname);
                cmd.Parameters.AddWithValue("@nr", nr);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }
        private void Cart_Load(object sender, EventArgs e)
        {
        }

        private void CountryBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void order(string name, string country, string county, string city, string adress, int pNr)
        {
            using (StreamWriter File = new StreamWriter("currentorderadress.txt"))
            {
                File.WriteLine(name + " " + country + " " + city + " " + adress + " " + pNr + "\n");
            }
        }
        public DataSet getBooks(int id)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=desktop-75hq6cj;initial catalog=Bookstore; integrated security=true";
            con.Open();
            DataSet wish = new DataSet();
            SqlDataAdapter awish = new SqlDataAdapter("SELECT * FROM Cart WHERE customerID= '" + id + "'", con);
            awish.Fill(wish, "Cart");
            con.Close();
            return wish;
        }
        public void addOrder(int id)
        {
            DataSet data;
            data = getBooks(id);
            var gn = new List<string>();
            foreach (DataRow dr in data.Tables["Cart"].Rows)
            {
                string books = dr.ItemArray.GetValue(1).ToString().Trim();
                using (StreamWriter File = new StreamWriter("currentorder.txt"))
                {
                    File.WriteLine(books + "\n");
                }
            }
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            order(NameBox.Text, CountryBox.Text, CountyBox.Text, City.Text, Adress.Text, int.Parse(NumberBox.Text));
            StreamReader streamReader = new StreamReader(path: "session.txt");
            string text = streamReader.ReadLine();
            string[] bits = text.Split(' ');
            int id = int.Parse(bits[0]);
            addOrder(id);
            MessageBox.Show("Order has been placed!");
            MainScreen form1 = new MainScreen();
            form1.Show();
            this.Visible = false;
        }

        private void CartList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCartReturnMain_Click(object sender, EventArgs e)
        {
            MainScreen form1 = new MainScreen();
            form1.Show();
            this.Visible = false;
        }
        public void deleteBookCart(string name)
        {
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM Cart WHERE bookName=@name";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string dname = (string)CartList.SelectedItem;
            string delname = dname.Trim();
            StreamReader streamReader = new StreamReader(path: "session.txt");
            string text = streamReader.ReadLine();
            string[] bits = text.Split(' ');
            int id = int.Parse(bits[0]);
            deleteBookCart(delname);
            AddInBoxCart(id);
        }
    }
}
