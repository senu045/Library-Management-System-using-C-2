namespace Library_app
{
    partial class ViewStudent
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            brnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtContactNo = new TextBox();
            txtFaculty = new TextBox();
            txtSName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 18);
            label1.Name = "label1";
            label1.Size = new Size(390, 73);
            label1.TabIndex = 0;
            label1.Text = "View Students";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 140);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 1;
            label2.Text = "Student Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(358, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 32);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(820, 134);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Pink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(967, 380);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(brnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContactNo);
            panel2.Controls.Add(txtFaculty);
            panel2.Controls.Add(txtSName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 601);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 249);
            panel2.TabIndex = 5;
            // 
            // brnCancel
            // 
            brnCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnCancel.Location = new Point(881, 180);
            brnCancel.Name = "brnCancel";
            brnCancel.Size = new Size(116, 29);
            brnCancel.TabIndex = 11;
            brnCancel.Text = "Cancel";
            brnCancel.UseVisualStyleBackColor = true;
            brnCancel.Click += brnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(742, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(600, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(685, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(312, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(685, 42);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(312, 27);
            txtContactNo.TabIndex = 7;
            // 
            // txtFaculty
            // 
            txtFaculty.Location = new Point(210, 102);
            txtFaculty.Name = "txtFaculty";
            txtFaculty.Size = new Size(312, 27);
            txtFaculty.TabIndex = 6;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(210, 44);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(312, 27);
            txtSName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(550, 102);
            label7.Name = "label7";
            label7.Size = new Size(56, 24);
            label7.TabIndex = 4;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(550, 42);
            label6.Name = "label6";
            label6.Size = new Size(104, 24);
            label6.TabIndex = 3;
            label6.Text = "Contact No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 102);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 1;
            label4.Text = "Faculty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 42);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1169, 622);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ViewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudent";
            Load += ViewStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button brnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtContactNo;
        private TextBox txtFaculty;
        private TextBox txtSName;
    }
}