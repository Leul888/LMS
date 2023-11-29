using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
