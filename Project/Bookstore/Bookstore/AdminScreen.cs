using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bookstore
{
    public partial class AdminScreen : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable table = new DataTable();

        public AdminScreen()
        {
            InitializeComponent();
            AddInBox();
            LogoAdminScreen.Image = Image.FromFile("Blackfeather Company logo.png");
        }
        public void AddInBox()
        {
            DataSet data;
            data = getData();
            listBooks.Items.Clear();
            foreach (DataRow dr in data.Tables["Book"].Rows)
            {
                string name = dr.ItemArray.GetValue(0).ToString().Trim() + " " +
                dr.ItemArray.GetValue(1).ToString().Trim() + " " +
                dr.ItemArray.GetValue(2).ToString().Trim() + " " +
                dr.ItemArray.GetValue(3).ToString().Trim() + " " +
                dr.ItemArray.GetValue(4).ToString().Trim() + " " +
                dr.ItemArray.GetValue(5).ToString().Trim() + " " +
                dr.ItemArray.GetValue(6).ToString().Trim() + " " +
                dr.ItemArray.GetValue(7).ToString().Trim();
                listBooks.Items.Add(name);
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
        private void addBook(int id, string name, string genre, string author, int release, float price, int pages, int stock)
        {
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO Book(bookID, BookName, Author, Geanra, Released, Pages, Stock, Price) VALUES (@Id, @name, @author, @genre, @release, @pages, @stock, @price)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@release", release);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@pages", pages);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }

        private void labelIDStock_Click(object sender, EventArgs e)
        {

        }
        private void update(int id, string name, string genre, string author, int release, float price, int pages, int stock)
        {
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"UPDATE Book SET BookName=@name, Author=@author, Geanra=@genre, Released=@release, Pages=@pages, Stock=@stock, Price=@price WHERE bookID=@Id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@release", release);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@pages", pages);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addBook(int.Parse(textBoxID.Text), textBoxName.Text, textBoxGenre.Text, textBoxAuthor.Text, int.Parse(textBoxPublicationDate.Text), float.Parse(textBoxPrice.Text), int.Parse(textBoxPages.Text), int.Parse(textBoxStock.Text));
            AddInBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            update(int.Parse(textBoxID.Text), textBoxName.Text, textBoxGenre.Text, textBoxAuthor.Text, int.Parse(textBoxPublicationDate.Text), float.Parse(textBoxPrice.Text), int.Parse(textBoxPages.Text), int.Parse(textBoxStock.Text));
            AddInBox();
        }
        public void deleteBook(int id)
        {
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM Book WHERE bookID=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteBook(int.Parse(textBoxDeleteID.Text));
            AddInBox();
        }
        public void addStock(int id, int stock)
        {
            con.Open();
            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = @"UPDATE Book SET Stock=@stock WHERE bookID=@Id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                con.Close();
            }
            con.Close();
        }
        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            addStock(int.Parse(textBoxStockID.Text), int.Parse(textBoxAddedStock.Text));
            AddInBox();
        }
        public void checkStock(int id)
        {
        }

        private void buttonCheckStock_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonReturnMainAdmin_Click(object sender, EventArgs e)
        {
            MainScreen form1 = new MainScreen();
            form1.Show();
            this.Visible = false;
        }
    }
}
