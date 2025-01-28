namespace Library_app
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtbookName = new TextBox();
            txtauthorName = new TextBox();
            txtpublication = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            savebtn = new Button();
            cancelbtn = new Button();
            txtdate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 415);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Location = new Point(1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 57);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(290, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 54);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 10);
            label1.Name = "label1";
            label1.Size = new Size(92, 24);
            label1.TabIndex = 1;
            label1.Text = "Add Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 76);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(312, 125);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 4;
            label3.Text = "Book Author Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(312, 174);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 5;
            label4.Text = "Book Publication";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(312, 226);
            label5.Name = "label5";
            label5.Size = new Size(151, 21);
            label5.TabIndex = 6;
            label5.Text = "Book Parchase Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(312, 283);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 7;
            label6.Text = "Book Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(312, 337);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 8;
            label7.Text = "Book Quantity";
            // 
            // txtbookName
            // 
            txtbookName.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbookName.Location = new Point(485, 73);
            txtbookName.Name = "txtbookName";
            txtbookName.Size = new Size(250, 28);
            txtbookName.TabIndex = 9;
            // 
            // txtauthorName
            // 
            txtauthorName.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtauthorName.Location = new Point(485, 123);
            txtauthorName.Name = "txtauthorName";
            txtauthorName.Size = new Size(250, 28);
            txtauthorName.TabIndex = 10;
            // 
            // txtpublication
            // 
            txtpublication.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpublication.Location = new Point(485, 178);
            txtpublication.Name = "txtpublication";
            txtpublication.Size = new Size(250, 28);
            txtpublication.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(485, 282);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 28);
            txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(485, 343);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 28);
            txtQuantity.TabIndex = 13;
            // 
            // savebtn
            // 
            savebtn.FlatStyle = FlatStyle.Popup;
            savebtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(457, 395);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(113, 38);
            savebtn.TabIndex = 14;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.FlatStyle = FlatStyle.Popup;
            cancelbtn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbtn.Location = new Point(596, 395);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(111, 38);
            cancelbtn.TabIndex = 15;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // txtdate
            // 
            txtdate.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdate.Location = new Point(485, 226);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(250, 26);
            txtdate.TabIndex = 17;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(778, 461);
            Controls.Add(txtdate);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtpublication);
            Controls.Add(txtauthorName);
            Controls.Add(txtbookName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtbookName;
        private TextBox txtauthorName;
        private TextBox txtpublication;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button savebtn;
        private Button cancelbtn;
        private DateTimePicker txtdate;
    }
}