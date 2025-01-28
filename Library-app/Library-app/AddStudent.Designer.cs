namespace Library_app
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSName = new TextBox();
            txtSId = new TextBox();
            txtFaculty = new TextBox();
            txtContactNo = new TextBox();
            txtEmail = new TextBox();
            btnRefresh = new Button();
            btnSave = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 81);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(123, 0);
            label7.Name = "label7";
            label7.Size = new Size(341, 73);
            label7.TabIndex = 0;
            label7.Text = "Add Student";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lavender;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(727, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 137);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 1;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 187);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 2;
            label2.Text = "Student Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 237);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 3;
            label3.Text = "Faculty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 287);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 4;
            label4.Text = "Contact No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 337);
            label5.Name = "label5";
            label5.Size = new Size(127, 24);
            label5.TabIndex = 5;
            label5.Text = "Srudent Email";
            // 
            // txtSName
            // 
            txtSName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSName.Location = new Point(220, 134);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(328, 32);
            txtSName.TabIndex = 7;
            // 
            // txtSId
            // 
            txtSId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSId.Location = new Point(220, 184);
            txtSId.Name = "txtSId";
            txtSId.Size = new Size(328, 32);
            txtSId.TabIndex = 8;
            // 
            // txtFaculty
            // 
            txtFaculty.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFaculty.Location = new Point(220, 238);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(328, 32);
            txtFaculty.TabIndex = 9;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(220, 291);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(328, 32);
            txtContactNo.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(220, 341);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(328, 32);
            txtEmail.TabIndex = 11;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(248, 411);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 38);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(386, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(537, 411);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 38);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1055, 506);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNo);
            Controls.Add(txtFaculty);
            Controls.Add(txtSId);
            Controls.Add(txtSName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSName;
        private TextBox txtSId;
        private TextBox txtFaculty;
        private TextBox txtContactNo;
        private TextBox txtEmail;
        private Label label7;
        private Button btnRefresh;
        private Button btnSave;
        private Button btnExit;
    }
}