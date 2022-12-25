namespace Dictionary_WindowsFrom
{
    partial class Dictionary_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.lblmeaning = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.txtmeaning = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnInorder = new System.Windows.Forms.Button();
            this.btnPrintDictionary = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblNodeStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Dictionary";
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Location = new System.Drawing.Point(408, 24);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(204, 29);
            this.lblsubject.TabIndex = 7;
            this.lblsubject.Text = "Personal Dictionary";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Location = new System.Drawing.Point(45, 83);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(136, 29);
            this.lblword.TabIndex = 5;
            this.lblword.Text = "Enter Word :";
            // 
            // lblmeaning
            // 
            this.lblmeaning.AutoSize = true;
            this.lblmeaning.Location = new System.Drawing.Point(513, 83);
            this.lblmeaning.Name = "lblmeaning";
            this.lblmeaning.Size = new System.Drawing.Size(170, 29);
            this.lblmeaning.TabIndex = 6;
            this.lblmeaning.Text = "Enter Meaning :";
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(188, 81);
            this.txtword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(305, 37);
            this.txtword.TabIndex = 0;
            this.txtword.TextChanged += new System.EventHandler(this.txtword_TextChanged);
            this.txtword.Enter += new System.EventHandler(this.txtword_Enter);
            this.txtword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtword_KeyDown);
            // 
            // txtmeaning
            // 
            this.txtmeaning.Location = new System.Drawing.Point(687, 83);
            this.txtmeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmeaning.Name = "txtmeaning";
            this.txtmeaning.Size = new System.Drawing.Size(305, 37);
            this.txtmeaning.TabIndex = 1;
            this.txtmeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmeaning_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(63, 249);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 207);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(518, 248);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(429, 207);
            this.listBox2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnInorder);
            this.panel1.Controls.Add(this.btnPrintDictionary);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(50, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 87);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(782, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 58);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnInorder
            // 
            this.btnInorder.Location = new System.Drawing.Point(623, 11);
            this.btnInorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInorder.Name = "btnInorder";
            this.btnInorder.Size = new System.Drawing.Size(120, 58);
            this.btnInorder.TabIndex = 4;
            this.btnInorder.Text = "Inorder";
            this.btnInorder.UseVisualStyleBackColor = true;
            this.btnInorder.Click += new System.EventHandler(this.btnInorder_Click);
            // 
            // btnPrintDictionary
            // 
            this.btnPrintDictionary.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDictionary.Location = new System.Drawing.Point(468, 11);
            this.btnPrintDictionary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintDictionary.Name = "btnPrintDictionary";
            this.btnPrintDictionary.Size = new System.Drawing.Size(120, 58);
            this.btnPrintDictionary.TabIndex = 3;
            this.btnPrintDictionary.Text = "Print all Dictionary";
            this.btnPrintDictionary.UseVisualStyleBackColor = true;
            this.btnPrintDictionary.Click += new System.EventHandler(this.btnPrintDictionary_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(322, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 58);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 58);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 11);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 58);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Location = new System.Drawing.Point(58, 217);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(43, 29);
            this.lbllog.TabIndex = 6;
            this.lbllog.Text = "log";
            // 
            // lblNodeStatus
            // 
            this.lblNodeStatus.AutoSize = true;
            this.lblNodeStatus.Location = new System.Drawing.Point(513, 217);
            this.lblNodeStatus.Name = "lblNodeStatus";
            this.lblNodeStatus.Size = new System.Drawing.Size(142, 29);
            this.lblNodeStatus.TabIndex = 7;
            this.lblNodeStatus.Text = "Nodes Status";
            // 
            // Dictionary_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 479);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.lblNodeStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtmeaning);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.lblmeaning);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dictionary_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Dictionary_Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Label lblmeaning;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.TextBox txtmeaning;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnInorder;
        private System.Windows.Forms.Button btnPrintDictionary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblNodeStatus;
        private System.Windows.Forms.Label lbllog;
    }
}

