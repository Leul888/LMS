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
            this.IssueBookDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnBookDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IssueBookForm = new System.Windows.Forms.Button();
            this.IssueIdtextbox = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.bookCb = new System.Windows.Forms.ComboBox();
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
            // IssueBookDGV
            // 
            this.IssueBookDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssueBookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueBookDGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssueBookDGV.Location = new System.Drawing.Point(334, 103);
            this.IssueBookDGV.Name = "IssueBookDGV";
            this.IssueBookDGV.RowHeadersWidth = 62;
            this.IssueBookDGV.RowTemplate.Height = 28;
            this.IssueBookDGV.Size = new System.Drawing.Size(378, 145);
            this.IssueBookDGV.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 120);
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
            this.ReturnBookDGV.Location = new System.Drawing.Point(334, 271);
            this.ReturnBookDGV.Name = "ReturnBookDGV";
            this.ReturnBookDGV.RowHeadersWidth = 62;
            this.ReturnBookDGV.RowTemplate.Height = 28;
            this.ReturnBookDGV.Size = new System.Drawing.Size(378, 145);
            this.ReturnBookDGV.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(465, 251);
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
            this.label9.Location = new System.Drawing.Point(465, 82);
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
            this.IssueBookForm.Location = new System.Drawing.Point(119, 415);
            this.IssueBookForm.Margin = new System.Windows.Forms.Padding(4);
            this.IssueBookForm.Name = "IssueBookForm";
            this.IssueBookForm.Size = new System.Drawing.Size(119, 42);
            this.IssueBookForm.TabIndex = 53;
            this.IssueBookForm.Text = "Return Book";
            this.IssueBookForm.UseVisualStyleBackColor = false;
            this.IssueBookForm.Click += new System.EventHandler(this.IssueBookForm_Click);
            // 
            // IssueIdtextbox
            // 
            this.IssueIdtextbox.Location = new System.Drawing.Point(119, 103);
            this.IssueIdtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.IssueIdtextbox.Name = "IssueIdtextbox";
            this.IssueIdtextbox.Size = new System.Drawing.Size(179, 41);
            this.IssueIdtextbox.TabIndex = 59;
            this.IssueIdtextbox.Text = "";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(518, 423);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(102, 42);
            this.Clear.TabIndex = 60;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
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
            this.bookCb.Location = new System.Drawing.Point(334, 252);
            this.bookCb.Margin = new System.Windows.Forms.Padding(4);
            this.bookCb.Name = "bookCb";
            this.bookCb.Size = new System.Drawing.Size(10, 21);
            this.bookCb.TabIndex = 37;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 478);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.IssueIdtextbox);
            this.Controls.Add(this.IssueBookForm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ReturnBookDGV);
            this.Controls.Add(this.IssueBookDGV);
            this.Controls.Add(this.bookCb);
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
        private System.Windows.Forms.DataGridView IssueBookDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ReturnBookDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button IssueBookForm;
        private System.Windows.Forms.RichTextBox IssueIdtextbox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox bookCb;
    }
}