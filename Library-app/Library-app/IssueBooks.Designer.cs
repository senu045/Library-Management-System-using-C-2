namespace Library_app
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            label2 = new Label();
            txtstuid = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSName = new TextBox();
            panel3 = new Panel();
            txtbid = new TextBox();
            label10 = new Label();
            btnIssue = new Button();
            label9 = new Label();
            txtBName = new ComboBox();
            txtBDate = new DateTimePicker();
            txtEmail = new TextBox();
            txtContactNo = new TextBox();
            txtFaculty = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 123);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(698, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 28);
            label1.Name = "label1";
            label1.Size = new Size(323, 73);
            label1.TabIndex = 0;
            label1.Text = "Issue Books";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtstuid);
            panel2.Controls.Add(pictureBox2);
            panel2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(7, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 571);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(225, 487);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(44, 487);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(55, 394);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(264, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 266);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 2;
            label2.Text = "Student Id";
            // 
            // txtstuid
            // 
            txtstuid.Location = new Point(62, 306);
            txtstuid.Name = "txtstuid";
            txtstuid.Size = new Size(257, 32);
            txtstuid.TabIndex = 1;
            txtstuid.TextChanged += txtstuid_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 218);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(95, 70);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 2;
            label3.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(95, 120);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 3;
            label4.Text = "Faculty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(95, 170);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 4;
            label5.Text = "ContactNo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(95, 220);
            label6.Name = "label6";
            label6.Size = new Size(127, 24);
            label6.TabIndex = 5;
            label6.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(95, 320);
            label7.Name = "label7";
            label7.Size = new Size(103, 24);
            label7.TabIndex = 6;
            label7.Text = "Books ISBN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(95, 370);
            label8.Name = "label8";
            label8.Size = new Size(143, 24);
            label8.TabIndex = 7;
            label8.Text = "Book Issue Date";
            // 
            // txtSName
            // 
            txtSName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSName.Font = new Font("Calibri", 12F);
            txtSName.Location = new Point(303, 66);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(351, 32);
            txtSName.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(txtbid);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnIssue);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtBName);
            panel3.Controls.Add(txtBDate);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContactNo);
            panel3.Controls.Add(txtFaculty);
            panel3.Controls.Add(txtSName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(460, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 571);
            panel3.TabIndex = 9;
            // 
            // txtbid
            // 
            txtbid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtbid.Font = new Font("Calibri", 12F);
            txtbid.Location = new Point(300, 320);
            txtbid.Name = "txtbid";
            txtbid.Size = new Size(351, 32);
            txtbid.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(95, 270);
            label10.Name = "label10";
            label10.Size = new Size(114, 24);
            label10.TabIndex = 16;
            label10.Text = "Books Name";
            // 
            // btnIssue
            // 
            btnIssue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIssue.BackColor = Color.Thistle;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Location = new Point(419, 416);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(221, 52);
            btnIssue.TabIndex = 15;
            btnIssue.Text = "Issue Book";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(170, 533);
            label9.Name = "label9";
            label9.Size = new Size(553, 35);
            label9.TabIndex = 14;
            label9.Text = "Maximum 3 Books Can be ISSUED to 1 Student";
            // 
            // txtBName
            // 
            txtBName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBName.Font = new Font("Calibri", 12F);
            txtBName.FormattingEnabled = true;
            txtBName.Location = new Point(300, 270);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(349, 32);
            txtBName.TabIndex = 13;
            txtBName.SelectedIndexChanged += txtBName_SelectedIndexChanged;
            // 
            // txtBDate
            // 
            txtBDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBDate.Font = new Font("Calibri", 12F);
            txtBDate.Location = new Point(300, 370);
            txtBDate.Name = "txtBDate";
            txtBDate.Size = new Size(354, 32);
            txtBDate.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Calibri", 12F);
            txtEmail.Location = new Point(303, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(351, 32);
            txtEmail.TabIndex = 11;
            // 
            // txtContactNo
            // 
            txtContactNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContactNo.Font = new Font("Calibri", 12F);
            txtContactNo.Location = new Point(303, 163);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(351, 32);
            txtContactNo.TabIndex = 10;
            // 
            // txtFaculty
            // 
            txtFaculty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFaculty.Font = new Font("Calibri", 12F);
            txtFaculty.Location = new Point(303, 113);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(351, 32);
            txtFaculty.TabIndex = 9;
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1205, 747);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearch;
        private Label label2;
        private TextBox txtstuid;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSName;
        private Panel panel3;
        private DateTimePicker txtBDate;
        private TextBox txtEmail;
        private TextBox txtContactNo;
        private TextBox txtFaculty;
        private Button btnIssue;
        private Label label9;
        private ComboBox txtBName;
        private TextBox txtbid;
        private Label label10;
    }
}