﻿namespace hashing_test
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
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Regbtn = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(56, 64);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Regbtn
            // 
            this.Regbtn.Location = new System.Drawing.Point(56, 93);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(75, 23);
            this.Regbtn.TabIndex = 3;
            this.Regbtn.Text = "Register";
            this.Regbtn.UseVisualStyleBackColor = true;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(12, 12);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(38, 13);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name:";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(12, 38);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(33, 13);
            this.Passlbl.TabIndex = 5;
            this.Passlbl.Text = "Pass:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 156);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Passlbl;
    }
}

