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
    public partial class Librarian : Form
    {
        SqlConnection Con = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DSU\OneDrive - Dakota State University\Desktop\LMS PROJECT\LMS\Database1.mdf"";Integrated Security=True");

        public Librarian()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from LibrarianTbl";
            SqlDataAdapter da= new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDGV.DataSource = ds.Tables[0];
            Con.Close();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppBody obj1 = new AppBody();
            this.Hide();
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Librarian_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void LibrarianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            LibId.Text = LibrarianDGV.SelectedRows[0].Cells[0].Value.ToString();
            LibName.Text = LibrarianDGV.SelectedRows[0].Cells[1].Value.ToString();
            LibPass.Text = LibrarianDGV.SelectedRows[0].Cells[2].Value.ToString();
            LibPhone.Text = LibrarianDGV.SelectedRows[0].Cells[3].Value.ToString();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || LibPass.Text == "" || LibPhone.Text == "")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                // Create an instance of the LibrarianItem class
                LibrarianItem librarianItem = new LibrarianItem();
                librarianItem.LibrarianId = Convert.ToInt32(LibId.Text);
                librarianItem.LibrarianName = LibName.Text;
                librarianItem.LibrarianPassword = LibPass.Text;
                librarianItem.LibrarianPhone = LibPhone.Text;

                // Use the instance to insert data into the database
                Con.Open();
                SqlCommand cmd = new SqlCommand($"Insert into LibrarianTbl values({librarianItem.LibrarianId},'{librarianItem.LibrarianName}','{librarianItem.LibrarianPassword}','{librarianItem.LibrarianPhone}')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Added Successfully");
                Con.Close();

                populate();
                LibName.Clear();
                LibPass.Clear();
                LibPhone.Clear();
                LibId.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "")
            {
                MessageBox.Show("Enter librarian ID.");
            }
            else
            {
                // Create an instance of the LibrarianItem class
                LibrarianItem deletedLibrarianItem = new LibrarianItem();
                deletedLibrarianItem.LibrarianId = Convert.ToInt32(LibId.Text);

                
                Con.Open();
                string query = $"delete from LibrarianTbl where LibId={deletedLibrarianItem.LibrarianId};";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian successfully deleted ");
                Con.Close();

                populate();
                LibName.Clear();
                LibPass.Clear();
                LibPhone.Clear();
                LibId.Clear();
            }
        }





        private void button5_Click(object sender, EventArgs e)
        {
            if (LibId.Text == "" || LibName.Text == "" || LibPass.Text == "" || LibPhone.Text == "")
            {
                MessageBox.Show("missing Information.");

            }
            else
            {
                Con.Open();
                string query = "update LibrarianTbl set LibName='" + LibName.Text + "',LibPassword='" + LibPass.Text + "',LibPhone='" + LibPhone.Text + "'where LibId=" + LibId.Text + ";";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian succesfully Updated ");
                Con.Close();
                populate();
                    
            }


        }

    }
}
