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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            // Creating My Sql connection
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM newstudent";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Have Failed" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        string sid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    sid = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                ViewStudent_Load(sender, e);
                return;
            }


            panel2.Visible = true;
            MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM newstudent where stuid='" + sid + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtFaculty.Text = ds.Tables[0].Rows[0][2].ToString();
                txtContactNo.Text = ds.Tables[0].Rows[0][3].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                // there are need to start
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // hello//
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Update", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string student_Name = txtSName.Text;
                string student_Email = txtEmail.Text;
                string student_faculty = txtFaculty.Text;
                string student_contactNo = txtContactNo.Text;
                MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE newstudent SET sname=@sname ,faculty=@faculty , contactNo=@contactNo ,email=@email where stuid='" + sid + "'";
                    cmd.Parameters.AddWithValue("@sname", student_Name);
                    cmd.Parameters.AddWithValue("@faculty", student_faculty);
                    cmd.Parameters.AddWithValue("@contactNo", student_contactNo);
                    cmd.Parameters.AddWithValue("@email", student_Email);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student Infomation Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //btn delete on Action
            if (MessageBox.Show("Are you sure want to Delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = "DELETE FROM newstudent where stuid='" + sid + "'";

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Student Infomation Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            ViewStudent_Load(sender, e);
            panel2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sid = textBox1.Text;
                MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT*FROM newstudent where stuid LIKE '" + sid + "%'";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            ViewStudent_Load(sender, e);
        }
    }
}
