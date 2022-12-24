namespace Dictionary_WindowsFrom
{
    partial class Dictionary
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.txtmeaning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Dictionary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personal Dictionary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Word :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter Meaning :";
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(219, 97);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(346, 42);
            this.txtword.TabIndex = 0;
            // 
            // txtmeaning
            // 
            this.txtmeaning.Location = new System.Drawing.Point(801, 100);
            this.txtmeaning.Name = "txtmeaning";
            this.txtmeaning.Size = new System.Drawing.Size(355, 42);
            this.txtmeaning.TabIndex = 1;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 594);
            this.Controls.Add(this.txtmeaning);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.TextBox txtmeaning;
    }
}

