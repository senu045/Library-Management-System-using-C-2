namespace Library_app
{
    partial class ReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSeach = new Button();
            txtstuid = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtReturn = new DateTimePicker();
            btnCancel = new Button();
            btnReturn = new Button();
            txtIssue = new TextBox();
            txtBName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSeach);
            panel1.Controls.Add(txtstuid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(11, 23);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 481);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnExit.Location = new Point(173, 382);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnRefresh.Location = new Point(50, 382);
            btnRefresh.Margin = new Padding(2, 3, 2, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 32);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSeach
            // 
            btnSeach.FlatStyle = FlatStyle.Flat;
            btnSeach.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnSeach.Location = new Point(76, 315);
            btnSeach.Margin = new Padding(2, 3, 2, 3);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(158, 39);
            btnSeach.TabIndex = 3;
            btnSeach.Text = "Search Student";
            btnSeach.UseVisualStyleBackColor = true;
            btnSeach.Click += btnSeach_Click;
            // 
            // txtstuid
            // 
            txtstuid.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtstuid.Location = new Point(50, 269);
            txtstuid.Margin = new Padding(2, 3, 2, 3);
            txtstuid.Name = "txtstuid";
            txtstuid.Size = new Size(212, 32);
            txtstuid.TabIndex = 2;
            txtstuid.TextChanged += txtstuid_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(108, 238);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 1;
            label1.Text = "Student Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 24);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 23);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1032, 481);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(txtReturn);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(txtIssue);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(362, 524);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 186);
            panel2.TabIndex = 2;
            // 
            // txtReturn
            // 
            txtReturn.Font = new Font("Calibri", 12F);
            txtReturn.Location = new Point(200, 129);
            txtReturn.Margin = new Padding(2, 3, 2, 3);
            txtReturn.Name = "txtReturn";
            txtReturn.Size = new Size(327, 32);
            txtReturn.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Calibri", 12F);
            btnCancel.Location = new Point(614, 125);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Calibri", 12F);
            btnReturn.Location = new Point(614, 63);
            btnReturn.Margin = new Padding(2, 3, 2, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(85, 41);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtIssue
            // 
            txtIssue.Font = new Font("Calibri", 12F);
            txtIssue.Location = new Point(200, 74);
            txtIssue.Margin = new Padding(2, 3, 2, 3);
            txtIssue.Name = "txtIssue";
            txtIssue.Size = new Size(327, 32);
            txtIssue.TabIndex = 4;
            // 
            // txtBName
            // 
            txtBName.Font = new Font("Calibri", 12F);
            txtBName.Location = new Point(200, 22);
            txtBName.Margin = new Padding(2, 3, 2, 3);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(327, 32);
            txtBName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(32, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 24);
            label4.TabIndex = 2;
            label4.Text = "Book Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(32, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 1;
            label3.Text = "Book Issue Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(32, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1417, 557);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSeach;
        private TextBox txtstuid;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtIssue;
        private Button btnCancel;
        private Button btnReturn;
        private DateTimePicker txtReturn;
        private TextBox txtBName;
    }
}