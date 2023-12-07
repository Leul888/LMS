namespace LMS
{
    partial class IssueBook
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
            this.button3 = new System.Windows.Forms.Button();
            this.IssuebookDGV = new System.Windows.Forms.DataGridView();
            this.IssueBookForm = new System.Windows.Forms.Button();
            this.bookCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IssueNumTb = new System.Windows.Forms.RichTextBox();
            this.stdnameTb = new System.Windows.Forms.RichTextBox();
            this.stddepTb = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.stdCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phoneTb = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssuebookDGV)).BeginInit();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoffbtn
            // 
            this.logoffbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoffbtn.ForeColor = System.Drawing.Color.Lime;
            this.logoffbtn.Location = new System.Drawing.Point(619, 3);
            this.logoffbtn.Name = "logoffbtn";
            this.logoffbtn.Size = new System.Drawing.Size(30, 23);
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
            this.label6.Location = new System.Drawing.Point(302, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "ISSUE BOOKS";
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(522, 396);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 50);
            this.button3.TabIndex = 25;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IssuebookDGV
            // 
            this.IssuebookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssuebookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuebookDGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssuebookDGV.Location = new System.Drawing.Point(405, 98);
            this.IssuebookDGV.Name = "IssuebookDGV";
            this.IssuebookDGV.RowHeadersWidth = 62;
            this.IssuebookDGV.RowTemplate.Height = 28;
            this.IssuebookDGV.Size = new System.Drawing.Size(289, 263);
            this.IssuebookDGV.TabIndex = 24;
            // 
            // IssueBookForm
            // 
            this.IssueBookForm.BackColor = System.Drawing.Color.Yellow;
            this.IssueBookForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookForm.Location = new System.Drawing.Point(136, 386);
            this.IssueBookForm.Margin = new System.Windows.Forms.Padding(4);
            this.IssueBookForm.Name = "IssueBookForm";
            this.IssueBookForm.Size = new System.Drawing.Size(107, 60);
            this.IssueBookForm.TabIndex = 23;
            this.IssueBookForm.Text = "Issue Book";
            this.IssueBookForm.UseVisualStyleBackColor = false;
            this.IssueBookForm.Click += new System.EventHandler(this.IssueBookForm_Click);
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
            this.bookCb.Location = new System.Drawing.Point(183, 264);
            this.bookCb.Margin = new System.Windows.Forms.Padding(4);
            this.bookCb.Name = "bookCb";
            this.bookCb.Size = new System.Drawing.Size(167, 21);
            this.bookCb.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Num:";
            // 
            // IssueNumTb
            // 
            this.IssueNumTb.Location = new System.Drawing.Point(183, 98);
            this.IssueNumTb.Margin = new System.Windows.Forms.Padding(4);
            this.IssueNumTb.Name = "IssueNumTb";
            this.IssueNumTb.Size = new System.Drawing.Size(167, 24);
            this.IssueNumTb.TabIndex = 27;
            this.IssueNumTb.Text = "";
            // 
            // stdnameTb
            // 
            this.stdnameTb.Location = new System.Drawing.Point(183, 178);
            this.stdnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.stdnameTb.Name = "stdnameTb";
            this.stdnameTb.Size = new System.Drawing.Size(167, 25);
            this.stdnameTb.TabIndex = 28;
            this.stdnameTb.Text = "";
            // 
            // stddepTb
            // 
            this.stddepTb.Location = new System.Drawing.Point(183, 221);
            this.stddepTb.Margin = new System.Windows.Forms.Padding(4);
            this.stddepTb.Name = "stddepTb";
            this.stddepTb.Size = new System.Drawing.Size(167, 25);
            this.stddepTb.TabIndex = 29;
            this.stddepTb.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 294);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Phone:";
            // 
            // IssueDate
            // 
            this.IssueDate.Location = new System.Drawing.Point(183, 337);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(200, 20);
            this.IssueDate.TabIndex = 31;
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
            this.stdCb.Location = new System.Drawing.Point(183, 141);
            this.stdCb.Margin = new System.Windows.Forms.Padding(4);
            this.stdCb.Name = "stdCb";
            this.stdCb.Size = new System.Drawing.Size(167, 21);
            this.stdCb.TabIndex = 32;
            this.stdCb.SelectionChangeCommitted += new System.EventHandler(this.stdCb_SelectionChangeCommitted);
            this.stdCb.SelectedValueChanged += new System.EventHandler(this.stdCb_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Book:";
            // 
            // phoneTb
            // 
            this.phoneTb.Location = new System.Drawing.Point(183, 293);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(167, 25);
            this.phoneTb.TabIndex = 34;
            this.phoneTb.Text = "";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 478);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stdCb);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stddepTb);
            this.Controls.Add(this.stdnameTb);
            this.Controls.Add(this.IssueNumTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.IssuebookDGV);
            this.Controls.Add(this.IssueBookForm);
            this.Controls.Add(this.bookCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssuebookDGV)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView IssuebookDGV;
        private System.Windows.Forms.Button IssueBookForm;
        private System.Windows.Forms.ComboBox bookCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox IssueNumTb;
        private System.Windows.Forms.RichTextBox stdnameTb;
        private System.Windows.Forms.RichTextBox stddepTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.ComboBox stdCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox phoneTb;
    }
}