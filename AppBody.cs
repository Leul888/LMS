using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public AppBody()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ninimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoffbtn_Click(object sender, EventArgs e)
        {
            Form1 obj =new Form1();
            this.Hide();
            obj.Show();
            
        }

        private void titlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Librarian obj4 = new Librarian();
            this.Hide();
            obj4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Show();
            StudentForm obj2 = new StudentForm();
            this.Hide();
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book obj3 = new Book();
            this.Hide();
            obj3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBook ojb5 = new IssueBook();
            this.Hide();
            ojb5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnBook obj6 = new ReturnBook();
            this.Hide(); 
            obj6.Show();
            
        }
    }
}
