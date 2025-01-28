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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_app
{
    public partial class StuBook : Form
    {
        public StuBook()
        {
            InitializeComponent();
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string book = textBox1.Text;
                MySqlConnection conn;
                MySqlCommand cmd;
                conn = new MySqlConnection("Server = localhost; Port = 3306; Database = library; Uid = root; Pwd = 2001;");
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = "SELECT*FROM IRBook where bName LIKE '" + book + "%' AND bookreturnDate IS NULL";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
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
        }
    }
    
}
