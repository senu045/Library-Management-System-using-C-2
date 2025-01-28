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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }
        private void IssueBooks_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT bName FROM newbook;";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txtBName.DataSource = ds.Tables[0];
                txtBName.DisplayMember = "bName";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error" + ex, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSName.Text))
            {
                // issue Book table set //
                if (txtBName.SelectedIndex != -1 && count <= 2)
                {
                    string st_name = txtSName.Text;
                    string st_faculty = txtFaculty.Text;
                    string st_contactNo = txtContactNo.Text;
                    string st_email = txtEmail.Text;
                    string bo_name = txtBName.Text;
                    string issue_date = txtBDate.Text;
                    int book_id = int.Parse(txtbid.Text);

                    MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;Database=library;Uid=root;Pwd=2001;");
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    try
                    {
                        conn.Open();

                        // Use parameterized query to prevent SQL injection
                        cmd.CommandText = "SELECT bQuan FROM updatebook WHERE bid = @bid";
                        cmd.Parameters.AddWithValue("@bid", txtbid.Text);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        int qty = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                        if (qty > 0)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO IRBook(stuid, sname, faculty, contactNo, email, bName, bIssueDate, bid) VALUES (@stuid, @sname, @faculty, @contactNo, @email, @bName, @bIssueDate, @bid)";
                            cmd.Parameters.AddWithValue("@stuid", sid);
                            cmd.Parameters.AddWithValue("@sname", st_name);
                            cmd.Parameters.AddWithValue("@faculty", st_faculty);
                            cmd.Parameters.AddWithValue("@contactNo", st_contactNo);
                            cmd.Parameters.AddWithValue("@email", st_email);
                            cmd.Parameters.AddWithValue("@bName", bo_name);
                            cmd.Parameters.AddWithValue("@bIssueDate", issue_date);
                            cmd.Parameters.AddWithValue("@bid", book_id);

                            int inserted = cmd.ExecuteNonQuery();
                            if (inserted > 0)
                            {
                                MessageBox.Show("Book Issue has been Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                qty--;
                                cmd.Parameters.Clear();
                                cmd.CommandText = "UPDATE updatebook SET bQuan = @qty WHERE bid = @bid";
                                cmd.Parameters.AddWithValue("@qty", qty);
                                cmd.Parameters.AddWithValue("@bid", txtbid.Text);
                                cmd.ExecuteNonQuery();
                                btnRefresh_Click(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log error for debugging
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("Failed to issue the book. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Ensure connection is always closed
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You cannot get more than 3 books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter student details before issuing a book.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        string sid;
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // btn click for search student
            if (txtstuid.Text != null)
            {
                sid = txtstuid.Text;
                MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {

                    conn.Open();
                    cmd.CommandText = "SELECT*FROM newstudent where stuid='" + sid + "'";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    //--------------------------------------------------------------------------------------------------
                    // Code to count how many book has been issed on this enrollement number

                    cmd.CommandText = "select count(stuid) from IRBook where stuid='" + sid + "' and bookreturndate is null";
                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    count = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);

                    if (count >= 3)
                    {
                        MessageBox.Show("You Must Return Books Before get New One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //-------------------------------------------------------------------------------------------------



                    txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtFaculty.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtContactNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();

                }
                catch (IndexOutOfRangeException exp)
                {
                    MessageBox.Show("No Such Student Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtstuid.Clear();
            txtSName.Clear();
            txtFaculty.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtBName.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void txtstuid_TextChanged(object sender, EventArgs e)
        {
            if (txtstuid.Text == "")
            {
                txtSName.Clear();
                txtFaculty.Clear();
                txtContactNo.Clear();
                txtEmail.Clear();
                txtBName.SelectedIndex = 0;

            }
        }

        private void txtBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBName.SelectedIndex >=0)
            {
             MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
             MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT bid FROM newbook where bName='"+txtBName.Text+"'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txtbid.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Error" + ex, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }catch(Exception ex)
                {
                    Console.WriteLine("Its's error");
                }
            finally
            {
                conn.Close();
            }
            }
           
        }
    }
}
