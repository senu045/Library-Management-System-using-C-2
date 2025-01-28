namespace Library_app
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            btnCancel = new Button();
            Delete = new Button();
            Update = new Button();
            txtDate = new DateTimePicker();
            txtquantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtbauthorName = new TextBox();
            txtbName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
            textBox2 = new TextBox();
            Refresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -284);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 144);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(634, 34);
            label1.Name = "label1";
            label1.Size = new Size(298, 73);
            label1.TabIndex = 1;
            label1.Text = "View Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(407, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, -141);
            panel2.Name = "panel2";
            panel2.Size = new Size(1215, 50);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(818, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 15);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 0;
            label2.Text = "Book Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Thistle;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1187, 349);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(Delete);
            panel3.Controls.Add(Update);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(txtquantity);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(txtPublication);
            panel3.Controls.Add(txtbauthorName);
            panel3.Controls.Add(txtbName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 558);
            panel3.Name = "panel3";
            panel3.Size = new Size(1187, 308);
            panel3.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(971, 226);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Delete
            // 
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Location = new Point(845, 226);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 13;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.FlatStyle = FlatStyle.Flat;
            Update.Location = new Point(718, 226);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 12;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(807, 28);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(268, 27);
            txtDate.TabIndex = 11;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(807, 149);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(268, 27);
            txtquantity.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(807, 87);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(268, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(215, 145);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(268, 27);
            txtPublication.TabIndex = 8;
            // 
            // txtbauthorName
            // 
            txtbauthorName.Location = new Point(215, 83);
            txtbauthorName.Name = "txtbauthorName";
            txtbauthorName.Size = new Size(268, 27);
            txtbauthorName.TabIndex = 7;
            // 
            // txtbName
            // 
            txtbName.Location = new Point(215, 24);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(268, 27);
            txtbName.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(600, 149);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 5;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 87);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 27);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 3;
            label6.Text = "Book Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 145);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 2;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 83);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 1;
            label4.Text = "Book Author Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 23);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1207, 130);
            panel4.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.MenuHighlight;
            label10.Location = new Point(631, 25);
            label10.Name = "label10";
            label10.Size = new Size(298, 73);
            label10.TabIndex = 2;
            label10.Text = "View Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(366, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(230, 139);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 5;
            label11.Text = "Book Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Refresh
            // 
            Refresh.FlatStyle = FlatStyle.Popup;
            Refresh.Location = new Point(794, 134);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(94, 29);
            Refresh.TabIndex = 7;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += button5_Click;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.PapayaWhip;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1211, 568);
            Controls.Add(Refresh);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtquantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtbauthorName;
        private TextBox txtbName;
        private Button btnCancel;
        private Button Delete;
        private Button Update;
        private DateTimePicker txtDate;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label9;
        private Label label11;
        private TextBox textBox2;
        private Button Refresh;
    }
}