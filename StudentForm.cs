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
using System.Data.SqlClient;


namespace LMS
{
    public partial class StudentForm : Form
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU\OneDrive - Dakota State University\Desktop\LMS PROJECT\LMS\Database1.mdf"";Integrated Security=True");
        public StudentForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void label2_Click(object sender, EventArgs e)
        {

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
            AppBody obj1= new AppBody();
            this.Hide();
            obj1.Show();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AppBody obj1 = new AppBody();
            this.Hide();
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "" || StdName.Text == "" || StdDep.Text == "" || StdSem.SelectedItem == null || StdPhone.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                // Create an instance of the Student class
                Student student = new Student();
                student.StudentId = Convert.ToInt32(StdId.Text);
                student.StudentName = StdName.Text;
                student.Department = StdDep.Text;
                student.Semester = Convert.ToInt32(StdSem.SelectedItem.ToString());
                student.PhoneNumber = StdPhone.Text;

                // Use the instance to insert data into the database
                Con.Open();
                SqlCommand cmd = new SqlCommand($"Insert into StudentTbl values({student.StudentId},'{student.StudentName}','{student.Department}',{student.Semester},'{student.PhoneNumber}')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added Successfully");
                Con.Close();

                populate();
                StdName.Clear();
                StdId.Clear();
                StdPhone.Clear();
                StdDep.Clear();
                StdSem.ResetText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StdId.Text == "")
            {
                MessageBox.Show("Enter Student ID.");
            }
            else
            {
                Con.Open();
                string query = $"delete from StudentTbl where StdId={StdId.Text};";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student successfully deleted");
                Con.Close();

                populate();
                StdName.Clear();
                StdId.Clear();
                StdPhone.Clear();
                StdDep.Clear();
                StdSem.ResetText();
            }
        }
    }
}
