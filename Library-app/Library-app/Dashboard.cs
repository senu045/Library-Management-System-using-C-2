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
    public partial class Dashboard : Form
    {
        private bool isAddBookFormOpen = false;
        private AddBook addBookForm;
        private ViewBook viewBook;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You ant to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //If the Message Dialog Box have the value of Yes then we got as the 
                Application.Exit();
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (addBookForm == null || addBookForm.IsDisposed)
            {
                addBookForm = new AddBook();
                addBookForm.Show();
            }
            else
            {
                addBookForm.BringToFront();
            }
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewBook == null || viewBook.IsDisposed)
            {
                viewBook = new ViewBook();
                viewBook.Show();
            }
            else
            {
                viewBook.BringToFront();
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks issues = new IssueBooks();
            issues.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBook completeBook = new CompleteBook();
            completeBook.Show();
        }

        private void studentIssedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuBook student = new StuBook();
            student.Show();
        }

        private void bookStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuBook student = new StuBook();
            student.Show();
        }
    }
}
