using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_app
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSId.Clear();
            txtSName.Clear();
            txtFaculty.Clear();
            txtEmail.Clear();
            txtContactNo.Clear();
            // all the clear so we can do a fresh student add //

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string student_Id = txtSId.Text;
            string student_Name = txtSName.Text;
            string  faculty = txtFaculty.Text;
            string email = txtEmail.Text;
            string contactNo = txtContactNo.Text;

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server=localhost;Port=3306;Database=library;Uid=root;Pwd=2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {


                conn.Open();
                cmd.CommandText = "INSERT INTO NewStudent(stuid,sname,faculty,contactNo,email) VALUES(@stuid,@sname,@faculty,@contactNo,@email)";
                cmd.Parameters.AddWithValue("@stuid",student_Id);
                cmd.Parameters.AddWithValue("@sname", student_Name);
                cmd.Parameters.AddWithValue("@faculty", faculty);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);
                cmd.Parameters.AddWithValue("@email", email);
                int result =cmd.ExecuteNonQuery();
                if(result>0)
                {
                   MessageBox.Show("Student Have Have Been Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Svaing data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit btn
            if(MessageBox.Show("Are you sure want to exit?","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();   
            }
        }
    }
}
