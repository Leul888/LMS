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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU\OneDrive - Dakota State University\Desktop\LMS PROJECT\LMS\Database1.mdf"";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
 

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUsername_MouseEnter(object sender, EventArgs e)
        {
            if (UnameTb.Text == "Username")
            {
                UnameTb.Clear();
            }
        }

        private void textUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (UnameTb.Text == "Username")
            {
                UnameTb.Clear();
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(PassTb.Text == "Password")
            {
                PassTb.Clear();
                PassTb.PasswordChar = '*';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarianTbl where LibName='"+UnameTb.Text+"' and LibPassword='"+PassTb.Text+"'",Con);
            DataTable dt = new DataTable();
            sda .Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }
    }
}
