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
    public partial class CompleteBook : Form
    {
        public CompleteBook()
        {
            InitializeComponent();
        }

        private void CompleteBook_Load(object sender, EventArgs e)
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            // my sql query to load data
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT*FROM Newbook";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                cmd.CommandText = "SELECT*FROM Updatebook";
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                dataGridView2.DataSource = ds1.Tables[0];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Have Failed" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
