namespace Exercise_4
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.subbtn = new System.Windows.Forms.Button();
            this.divbtn = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.mulbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(61, 88);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // subbtn
            // 
            this.subbtn.Location = new System.Drawing.Point(142, 88);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(75, 23);
            this.subbtn.TabIndex = 3;
            this.subbtn.Text = "-";
            this.subbtn.UseVisualStyleBackColor = true;
            this.subbtn.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // divbtn
            // 
            this.divbtn.Location = new System.Drawing.Point(304, 88);
            this.divbtn.Name = "divbtn";
            this.divbtn.Size = new System.Drawing.Size(75, 23);
            this.divbtn.TabIndex = 5;
            this.divbtn.Text = "/";
            this.divbtn.UseVisualStyleBackColor = true;
            this.divbtn.Click += new System.EventHandler(this.divbtn_Click);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(362, 37);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(37, 13);
            this.resultlbl.TabIndex = 6;
            this.resultlbl.Text = "Result";
            // 
            // mulbtn
            // 
            this.mulbtn.Location = new System.Drawing.Point(223, 88);
            this.mulbtn.Name = "mulbtn";
            this.mulbtn.Size = new System.Drawing.Size(75, 23);
            this.mulbtn.TabIndex = 7;
            this.mulbtn.Text = "*";
            this.mulbtn.UseVisualStyleBackColor = true;
            this.mulbtn.Click += new System.EventHandler(this.mulbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mulbtn);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.divbtn);
            this.Controls.Add(this.subbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.Button divbtn;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Button mulbtn;
    }
}

