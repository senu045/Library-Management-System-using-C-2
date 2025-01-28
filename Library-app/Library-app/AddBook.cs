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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtbookName.Text == "" || txtauthorName.Text=="" || txtpublication.Text==""  || txtPrice.Text=="" || txtQuantity.Text=="")
            {
                MessageBox.Show("Please fill columns","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string bname = txtbookName.Text;
            string bauthor = txtauthorName.Text;
            string publication = txtpublication.Text;
            string bdate = txtdate.Text;
            double price=0;
            Int64 quan=0;
            try
            {
              price = Convert.ToDouble(txtPrice.Text);
              quan = Convert.ToInt64(txtQuantity.Text);
            }catch(Exception exe)
            {
                MessageBox.Show("Please fill The form correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            //Connection setup In MySQL in the context of the //
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("Server=localhost;Port=3306;Database=library;Uid=root;Pwd=2001;");
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            try
            {


                conn.Open();
                cmd.CommandText = "INSERT INTO NewBook (bName, bAuthor, bPubl, bDate, bPrice,bQuan) VALUES (@bName, @bAuthor, @bPubl, @bDate, @bPrice,@bQuan)";
               
                cmd.Parameters.AddWithValue("@bName", bname);
                cmd.Parameters.AddWithValue("@bAuthor", bauthor);
                cmd.Parameters.AddWithValue("@bPubl", publication);
                cmd.Parameters.AddWithValue("@bDate", bdate);
                cmd.Parameters.AddWithValue("@bPrice", price);
                cmd.Parameters.AddWithValue("@bQuan", quan);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO UpdateBook (bName, bAuthor, bPubl, bDate, bPrice,bQuan) VALUES (@bName, @bAuthor, @bPubl, @bDate, @bPrice,@bQuan)";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Have Been Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // set all blank
                txtbookName.ResetText();
                txtauthorName.ResetText();
                txtdate.ResetText();
                txtPrice.ResetText();
                txtQuantity.ResetText();
                txtpublication.ResetText();
                // Done with the Reset
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to cancel","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        
        }
    }
}