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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private string getUserName()
        {
            conn.Open();
            String syntax = "SELECT Value FROM systemTable where Property ='UserName'";
            cmd = new SqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();   
            dr.Read();
            String temp = dr[0].ToString();
            conn.Close();
            return temp;

        }

        private string getpassword()
        {
            conn.Open();
            String syntax = "SELECT Value FROM systemTable where Property ='Password'";
            cmd = new SqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();
            dr.Read(); 
            String temp = dr[0].ToString();
            conn.Close();
            return temp;

        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUsername_MouseEnter(object sender, EventArgs e)
        {
            if (textUsername.Text == "Username")
            {
                textUsername.Clear();
            }
        }

        private void textUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUsername.Text == "Username")
            {
                textUsername.Clear();
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(textPassword.Text == "Password")
            {
                textPassword.Clear();
                textPassword.PasswordChar = '*';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            String Uname = getUserName(), Upass = getpassword(), name, pass;
            name=textUsername.Text;
            pass = textPassword.Text;
            if(name.Equals(Uname)&& pass.Equals(Upass))
            {
                //login
                //MessageBox.Show("Login Success");
                AppBody obj=new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //login failed
                MessageBox.Show("Login Failed");
            }
        }
    }
}
