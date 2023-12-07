namespace LMS
{
    partial class StudentForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.ninimizebtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dep = new System.Windows.Forms.Label();
            this.Sem = new System.Windows.Forms.Label();
            this.StdId = new System.Windows.Forms.RichTextBox();
            this.StdName = new System.Windows.Forms.RichTextBox();
            this.StdDep = new System.Windows.Forms.RichTextBox();
            this.StdSem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StdPhone = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ninimizebtn);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 78);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(592, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "<-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ninimizebtn
            // 
            this.ninimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ninimizebtn.ForeColor = System.Drawing.Color.Yellow;
            this.ninimizebtn.Location = new System.Drawing.Point(637, 1);
            this.ninimizebtn.Name = "ninimizebtn";
            this.ninimizebtn.Size = new System.Drawing.Size(39, 27);
            this.ninimizebtn.TabIndex = 3;
            this.ninimizebtn.Text = "-";
            this.ninimizebtn.UseVisualStyleBackColor = true;
            this.ninimizebtn.Click += new System.EventHandler(this.ninimizebtn_Click);
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(682, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 27);
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
            this.label6.Location = new System.Drawing.Point(280, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "STUDENTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(207, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "LIBRARY MANAGMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dep
            // 
            this.Dep.AutoSize = true;
            this.Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep.Location = new System.Drawing.Point(26, 243);
            this.Dep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(123, 24);
            this.Dep.TabIndex = 3;
            this.Dep.Text = "Department:";
            // 
            // Sem
            // 
            this.Sem.AutoSize = true;
            this.Sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sem.Location = new System.Drawing.Point(26, 302);
            this.Sem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sem.Name = "Sem";
            this.Sem.Size = new System.Drawing.Size(104, 24);
            this.Sem.TabIndex = 4;
            this.Sem.Text = "Semester:";
            // 
            // StdId
            // 
            this.StdId.Location = new System.Drawing.Point(186, 112);
            this.StdId.Margin = new System.Windows.Forms.Padding(4);
            this.StdId.Name = "StdId";
            this.StdId.Size = new System.Drawing.Size(167, 39);
            this.StdId.TabIndex = 5;
            this.StdId.Text = "";
            // 
            // StdName
            // 
            this.StdName.Location = new System.Drawing.Point(186, 163);
            this.StdName.Margin = new System.Windows.Forms.Padding(4);
            this.StdName.Name = "StdName";
            this.StdName.Size = new System.Drawing.Size(167, 39);
            this.StdName.TabIndex = 6;
            this.StdName.Text = "";
            // 
            // StdDep
            // 
            this.StdDep.Location = new System.Drawing.Point(186, 228);
            this.StdDep.Margin = new System.Windows.Forms.Padding(4);
            this.StdDep.Name = "StdDep";
            this.StdDep.Size = new System.Drawing.Size(167, 39);
            this.StdDep.TabIndex = 7;
            this.StdDep.Text = "";
            // 
            // StdSem
            // 
            this.StdSem.FormattingEnabled = true;
            this.StdSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.StdSem.Location = new System.Drawing.Point(186, 303);
            this.StdSem.Margin = new System.Windows.Forms.Padding(4);
            this.StdSem.Name = "StdSem";
            this.StdSem.Size = new System.Drawing.Size(167, 26);
            this.StdSem.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(123, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDGV
            // 
            this.StudentDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDGV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentDGV.Location = new System.Drawing.Point(360, 85);
            this.StudentDGV.Name = "StudentDGV";
            this.StudentDGV.RowHeadersWidth = 62;
            this.StudentDGV.RowTemplate.Height = 28;
            this.StudentDGV.Size = new System.Drawing.Size(361, 289);
            this.StudentDGV.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(283, 420);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone:";
            // 
            // StdPhone
            // 
            this.StdPhone.Location = new System.Drawing.Point(186, 345);
            this.StdPhone.Margin = new System.Windows.Forms.Padding(4);
            this.StdPhone.Name = "StdPhone";
            this.StdPhone.Size = new System.Drawing.Size(167, 39);
            this.StdPhone.TabIndex = 15;
            this.StdPhone.Text = "";
            this.StdPhone.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 478);
            this.Controls.Add(this.StdPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StudentDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StdSem);
            this.Controls.Add(this.StdDep);
            this.Controls.Add(this.StdName);
            this.Controls.Add(this.StdId);
            this.Controls.Add(this.Sem);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Dep;
        private System.Windows.Forms.Label Sem;
        private System.Windows.Forms.RichTextBox StdId;
        private System.Windows.Forms.RichTextBox StdName;
        private System.Windows.Forms.RichTextBox StdDep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StdSem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button ninimizebtn;
        private System.Windows.Forms.DataGridView StudentDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox StdPhone;
    }
}