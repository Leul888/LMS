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
    public partial class IssueBook : Form ,ILibraryTransaction
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU\OneDrive - Dakota State University\Desktop\LMS PROJECT\LMS\Database1.mdf"";Integrated Security=True");

        public void ExecuteTransaction()
        {
            // Implementation of issuing a book

            // Get the selected book details
            string selectedBook = bookCb.SelectedValue.ToString();

            // Update the book quantity in the database
            UpdateBook();

            // Insert data into the IssueTbl
            string issueDate = IssueDate.Value.ToString("yyyy-MM-dd"); // Format the date
            Con.Open();
            SqlCommand cmd = new SqlCommand($"INSERT INTO IssueTbl (IssueNum, StdId, StdName, StdDep, StdPhone, BookName, IssueDate) " +
                                          $"VALUES ({IssueNumTb.Text}, {stdCb.SelectedValue}, '{stdnameTb.Text}', " +
                                          $"'{stddepTb.Text}', '{phoneTb.Text}', '{selectedBook}', '{issueDate}')", Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            // Refresh the UI
            populate();
        }

        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select Stdid from StudentTbl", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId",typeof(int));    
            dt.Load(rdr);
            stdCb.ValueMember = "StdId";
            stdCb.DataSource = dt;

            Con.Close();
        }

        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select BookName from BookTbl where Qty> "+0+"", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            bookCb.ValueMember = "BookName";
            bookCb.DataSource = dt;

            Con.Close();
        }

        private void fetchstdData()
        {
            Con.Open();
            string query = "select * from StudentTbl where StdId=  "+stdCb.SelectedValue.ToString()+"" ;
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stdnameTb.Text = dr["StdName"].ToString();
                stddepTb.Text = dr["StdDep"].ToString();
                phoneTb.Text = dr["StdPhone"].ToString();


            }

            Con.Close() ;

        }

        public void UpdateBook()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where Bookname= '" + bookCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty - 1;
                string query1="update BookTbl set Qty ="+newQty+"where BookName='"+bookCb.SelectedValue.ToString()+"';";
                SqlCommand cmd1=new SqlCommand(query1, Con);    
                cmd1.ExecuteNonQuery();

            }

            Con.Close();

        }


        public void UpdateBookCancel()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where Bookname= '" + bookCb.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty =" + newQty + "where BookName='" + bookCb.SelectedItem.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();

            }

            Con.Close();
           //stdCb.Clear();
            IssueNumTb.Clear();
            stdnameTb.Clear();
            stddepTb.Clear();
            phoneTb.Clear();

        }


        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IssuebookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }


        public IssueBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoffbtn_Click(object sender, EventArgs e)
        {
            AppBody obj1 = new AppBody();
            this.Hide();
            obj1.Show();
        }

        private void ninimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            populate();
        }

        private void stdCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void stdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstdData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueBookForm_Click(object sender, EventArgs e)
        {
            if (IssueNumTb.Text == "" || stdnameTb.Text == "" )
            {
                MessageBox.Show("Missing Info");

            }
            else
            {
                string issuedate=IssueDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into IssueTbl values(" + IssueNumTb.Text + "," + stdCb.SelectedValue.ToString()+ ",'" + stdnameTb.Text + "','" + stddepTb.Text + "','"+phoneTb.Text+"','"+bookCb.SelectedValue.ToString()+ "','"+issuedate+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Issued!");
                Con.Close();
                UpdateBook();   
                populate();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IssueNumTb.Text == "")
            {
                MessageBox.Show("Enter Issue Number");

            }
            else
            {
                Con.Open();
                string query = "delete from IssueTbl where IsuueNum = " + IssueNumTb.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("issue Canceled ");
                Con.Close();
                UpdateBookCancel();
                populate();
                



            }
        }
    }
}
