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
using System.Collections;


namespace LMS
{
    public partial class ReturnBook : Form 
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU\OneDrive - Dakota State University\Desktop\LMS PROJECT\LMS\Database1.mdf"";Integrated Security=True");

        

        public ReturnBook()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IssueBookDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        public void populatereturn()
        {
            Con.Open();
            string query = "select * from ReturnTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnBookDGV.DataSource = ds.Tables[0];
            Con.Close();

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

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select BookName from BookTbl where Qty> " + 0 + "", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            bookCb.ValueMember = "BookName";
            bookCb.DataSource = dt;

            Con.Close();
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            populate();
            populatereturn();
            FillBook();
        }

        private void IssueBookForm_Click(object sender, EventArgs e)
        {
            if (ReturnNumTb.Text == "" || StdNameTb.Text == "")
            {
                MessageBox.Show("Missing Info");

            }
            else
            {
                string issuedate = IssueDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();
                string returndate = ReturnDate.Value.Day.ToString() + "/" + IssueDate.Value.Month.ToString() + "/" + IssueDate.Value.Year.ToString();

                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into ReturnTbl values(" + ReturnNumTb.Text + "," + stdCb.SelectedItem.ToString() + ",'" + StdNameTb.Text + "','" + stddepTb.Text + "','" + phoneTb.Text + "','" + bookCb.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Returned!");
                Con.Close();
                UpdateBook();
                populate();
                populatereturn();

            }
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
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty =" + newQty + "where BookName='" + bookCb.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();

            }

            Con.Close();

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
