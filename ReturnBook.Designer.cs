namespace LMS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoffbtn = new System.Windows.Forms.Button();
            this.ninimizebtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stdCb = new System.Windows.Forms.ComboBox();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.stddepTb = new System.Windows.Forms.RichTextBox();
            this.StdNameTb = new System.Windows.Forms.RichTextBox();
            this.ReturnNumTb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IssueBookDGV = new System.Windows.Forms.DataGridView();
            this.bookCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnBookDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IssueBookForm = new System.Windows.Forms.Button();
            this.phoneTb = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.logoffbtn);
            this.panel1.Controls.Add(this.ninimizebtn);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 78);
            this.panel1.TabIndex = 1;
            // 
            // logoffbtn
            // 
            this.logoffbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoffbtn.ForeColor = System.Drawing.Color.Lime;
            this.logoffbtn.Location = new System.Drawing.Point(614, 3);
            this.logoffbtn.Name = "logoffbtn";
            this.logoffbtn.Size = new System.Drawing.Size(35, 23);
            this.logoffbtn.TabIndex = 4;
            this.logoffbtn.Text = "<-";
            this.logoffbtn.UseVisualStyleBackColor = true;
            this.logoffbtn.Click += new System.EventHandler(this.logoffbtn_Click);
            // 
            // ninimizebtn
            // 
            this.ninimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ninimizebtn.ForeColor = System.Drawing.Color.Yellow;
            this.ninimizebtn.Location = new System.Drawing.Point(655, 3);
            this.ninimizebtn.Name = "ninimizebtn";
            this.ninimizebtn.Size = new System.Drawing.Size(30, 23);
            this.ninimizebtn.TabIndex = 3;
            this.ninimizebtn.Text = "-";
            this.ninimizebtn.UseVisualStyleBackColor = true;
            this.ninimizebtn.Click += new System.EventHandler(this.ninimizebtn_Click);
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(691, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(279, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "RETURN BOOKS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(222, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "LIBRARY MANAGMENT SYSTEM";
            // 
            // stdCb
            // 
            this.stdCb.FormattingEnabled = true;
            this.stdCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.stdCb.Location = new System.Drawing.Point(186, 159);
            this.stdCb.Margin = new System.Windows.Forms.Padding(4);
            this.stdCb.Name = "stdCb";
            this.stdCb.Size = new System.Drawing.Size(167, 21);
            this.stdCb.TabIndex = 48;
            // 
            // IssueDate
            // 
            this.IssueDate.Location = new System.Drawing.Point(186, 356);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(200, 20);
            this.IssueDate.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Book:";
            // 
            // stddepTb
            // 
            this.stddepTb.Location = new System.Drawing.Point(186, 239);
            this.stddepTb.Margin = new System.Windows.Forms.Padding(4);
            this.stddepTb.Name = "stddepTb";
            this.stddepTb.Size = new System.Drawing.Size(167, 25);
            this.stddepTb.TabIndex = 45;
            this.stddepTb.Text = "";
            // 
            // StdNameTb
            // 
            this.StdNameTb.Location = new System.Drawing.Point(186, 196);
            this.StdNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.StdNameTb.Name = "StdNameTb";
            this.StdNameTb.Size = new System.Drawing.Size(167, 25);
            this.StdNameTb.TabIndex = 44;
            this.StdNameTb.Text = "";
            // 
            // ReturnNumTb
            // 
            this.ReturnNumTb.Location = new System.Drawing.Point(186, 116);
            this.ReturnNumTb.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnNumTb.Name = "ReturnNumTb";
            this.ReturnNumTb.Size = new System.Drawing.Size(167, 24);
            this.ReturnNumTb.TabIndex = 43;
            this.ReturnNumTb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Num:";
            // 
            // IssueBookDGV
            // 
            this.IssueBookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssueBookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueBookDGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssueBookDGV.Location = new System.Drawing.Point(421, 103);
            this.IssueBookDGV.Name = "IssueBookDGV";
            this.IssueBookDGV.RowHeadersWidth = 62;
            this.IssueBookDGV.RowTemplate.Height = 28;
            this.IssueBookDGV.Size = new System.Drawing.Size(291, 145);
            this.IssueBookDGV.TabIndex = 40;
            // 
            // bookCb
            // 
            this.bookCb.FormattingEnabled = true;
            this.bookCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.bookCb.Location = new System.Drawing.Point(186, 314);
            this.bookCb.Margin = new System.Windows.Forms.Padding(4);
            this.bookCb.Name = "bookCb";
            this.bookCb.Size = new System.Drawing.Size(167, 21);
            this.bookCb.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usn:";
            // 
            // ReturnBookDGV
            // 
            this.ReturnBookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnBookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnBookDGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnBookDGV.Location = new System.Drawing.Point(421, 271);
            this.ReturnBookDGV.Name = "ReturnBookDGV";
            this.ReturnBookDGV.RowHeadersWidth = 62;
            this.ReturnBookDGV.RowTemplate.Height = 28;
            this.ReturnBookDGV.Size = new System.Drawing.Size(291, 145);
            this.ReturnBookDGV.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "Books Returned";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(515, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "Books Issued";
            // 
            // IssueBookForm
            // 
            this.IssueBookForm.BackColor = System.Drawing.Color.Yellow;
            this.IssueBookForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookForm.Location = new System.Drawing.Point(154, 423);
            this.IssueBookForm.Margin = new System.Windows.Forms.Padding(4);
            this.IssueBookForm.Name = "IssueBookForm";
            this.IssueBookForm.Size = new System.Drawing.Size(82, 42);
            this.IssueBookForm.TabIndex = 53;
            this.IssueBookForm.Text = "Return Book";
            this.IssueBookForm.UseVisualStyleBackColor = false;
            this.IssueBookForm.Click += new System.EventHandler(this.IssueBookForm_Click);
            // 
            // phoneTb
            // 
            this.phoneTb.Location = new System.Drawing.Point(186, 272);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(167, 25);
            this.phoneTb.TabIndex = 54;
            this.phoneTb.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 273);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "Phone:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 356);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 24);
            this.label12.TabIndex = 56;
            this.label12.Text = "Issue:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(186, 394);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.ReturnDate.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Return:";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.IssueBookForm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ReturnBookDGV);
            this.Controls.Add(this.stdCb);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stddepTb);
            this.Controls.Add(this.StdNameTb);
            this.Controls.Add(this.ReturnNumTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IssueBookDGV);
            this.Controls.Add(this.bookCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoffbtn;
        private System.Windows.Forms.Button ninimizebtn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stdCb;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox stddepTb;
        private System.Windows.Forms.RichTextBox StdNameTb;
        private System.Windows.Forms.RichTextBox ReturnNumTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView IssueBookDGV;
        private System.Windows.Forms.ComboBox bookCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ReturnBookDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button IssueBookForm;
        private System.Windows.Forms.RichTextBox phoneTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label4;
    }
}