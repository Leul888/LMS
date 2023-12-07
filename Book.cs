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


namespace LMS
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU\OneDrive - Dakota State University\Desktop\LMS PROJECT\LMS\Database1.mdf"";Integrated Security=True");


        public void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void logoffbtn_Click(object sender, EventArgs e)
        {
            AppBody obj1 = new AppBody();
            this.Hide();
            obj1.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ninimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookTbl_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bookbox.Text == "" || Author.Text == "" || Publisher.Text == "" || Price.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                // Create an instance of the BookItem class
                BookItem bookItem = new BookItem();
                bookItem.BookName = bookbox.Text;
                bookItem.Author = Author.Text;
                bookItem.Publisher = Publisher.Text;
                bookItem.Price = Convert.ToDecimal(Price.Text);
                bookItem.Quantity = Convert.ToInt32(Quantity.Text);

                // Use the instance to insert data into the database
                Con.Open();
                SqlCommand cmd = new SqlCommand($"Insert into BookTbl values('{bookItem.BookName}'," +
                    $"'{bookItem.Author}','{bookItem.Publisher}'," +
                    $"{bookItem.Price},{bookItem.Quantity})", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
                Con.Close();

                populate();
                bookbox.Clear();
                Author.Clear();
                Publisher.Clear();
                Price.Clear();
                Quantity.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bookbox.Text == "")
            {
                MessageBox.Show("Enter Book Name.");
            }
            else
            {
                Con.Open();
                string query = $"delete from BookTbl where BookName= '{bookbox.Text}';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book successfully deleted ");
                Con.Close();

                populate();
                bookbox.Clear();
                Author.Clear();
                Publisher.Clear();
                Price.Clear();
                Quantity.Clear();
            }
        }

    }
}
