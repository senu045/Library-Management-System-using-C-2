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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        string sid;
        private void btnSeach_Click(object sender, EventArgs e)
        {
            sid = txtstuid.Text;

            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM IRBook where stuid='" + sid + "' and bookreturnDate IS NULL";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("Invalid ID or No Book Issued", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel2.Visible=false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection has been Failed", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                btnRefresh_Click(sender, e);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string bname;
        string bdate;
        Int64 rowid;
        Int64 bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
            }
            txtBName.Text = bname;
            txtIssue.Text = bdate;


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            MySqlCommand cmd = new MySqlCommand();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                // connection have been opened then
                cmd.CommandText = "UPDATE IRBook SET bookreturnDate='" + txtReturn.Text + "' where stuid='" + sid + "' and id=" + rowid;
                int isUpdated = cmd.ExecuteNonQuery();
                if (isUpdated > 0)
                {
                   
                    
                    cmd.CommandText = "UPDATE updatebook SET bQuan=bQuan+1 where bid="+bid;
                    int result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                      MessageBox.Show("Have been Returned one book", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    btnSeach_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Have been Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtstuid_TextChanged(object sender, EventArgs e)
        {
            if (txtstuid.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            txtstuid.Clear();
            panel2.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to Exit","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
