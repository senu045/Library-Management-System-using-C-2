using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_app
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            //creating mysql connection
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT*FROM Newbook";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // we can get the connection 

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
           }catch(Exception ex)
            {
                ViewBook_Load(sender, e);
                return;
            }
            panel3.Visible = true;
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT*FROM Newbook where bid=" + bid;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                txtbName.Text = ds.Tables[0].Rows[0][1].ToString();
                txtbauthorName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
                txtDate.Text = ds.Tables[0].Rows[0][4].ToString();
                txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
                txtquantity.Text = ds.Tables[0].Rows[0][6].ToString();

                // their need to start //

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string book = textBox2.Text;
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT*FROM Newbook where bName LIKE '" + book + "%'";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    txtbName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtbauthorName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtquantity.Text = ds.Tables[0].Rows[0][6].ToString();

                    // their need to start //

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Books avaliable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                ViewBook_Load(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel3.Visible = false;
            ViewBook_Load(sender, e);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string bname = txtbName.Text;
                string author_name = txtbauthorName.Text;
                string publisher_name = txtPublication.Text;
                string datepub = txtDate.Text;
                double price = int.Parse(txtPrice.Text);
                double quantity = int.Parse(txtquantity.Text);
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Newbook SET bName=@bname, bAuthor=@author_name, bPubl=@publisher_name, bDate=@datepub, bPrice=@price, bQuan=@quantity WHERE bid=@bid";
                    cmd.Parameters.AddWithValue("@bname", bname);
                    cmd.Parameters.AddWithValue("@author_name", author_name);
                    cmd.Parameters.AddWithValue("@publisher_name", publisher_name);
                    cmd.Parameters.AddWithValue("@datepub", datepub);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@bid", bid);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Updatebook SET bName=@bname, bAuthor=@author_name, bPubl=@publisher_name, bDate=@datepub, bPrice=@price, bQuan=@quantity WHERE bid=@bid";
                  

                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // we can get the connection 
                    ViewBook_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Have Failed" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn?.Close();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandText = "DELETE  FROM Newbook Where bid="+bid;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM Updatebook Where bid=" + bid;
                
                int rowaffected = cmd.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // we can get the connection 
                ViewBook_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Have Failed" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // there are situations when connection get failed somehow

            }
            finally{
                conn.Close();
            }
        }
    }
}
