namespace hashing_test
{
    partial class register
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
            this.Nametxb = new System.Windows.Forms.TextBox();
            this.Passtxb = new System.Windows.Forms.TextBox();
            this.Conftxb = new System.Windows.Forms.TextBox();
            this.Accbtn = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.Conflbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nametxb
            // 
            this.Nametxb.Location = new System.Drawing.Point(131, 38);
            this.Nametxb.Name = "Nametxb";
            this.Nametxb.Size = new System.Drawing.Size(100, 20);
            this.Nametxb.TabIndex = 0;
            // 
            // Passtxb
            // 
            this.Passtxb.Location = new System.Drawing.Point(131, 64);
            this.Passtxb.Name = "Passtxb";
            this.Passtxb.Size = new System.Drawing.Size(100, 20);
            this.Passtxb.TabIndex = 1;
            // 
            // Conftxb
            // 
            this.Conftxb.Location = new System.Drawing.Point(131, 90);
            this.Conftxb.Name = "Conftxb";
            this.Conftxb.Size = new System.Drawing.Size(100, 20);
            this.Conftxb.TabIndex = 2;
            // 
            // Accbtn
            // 
            this.Accbtn.Location = new System.Drawing.Point(131, 117);
            this.Accbtn.Name = "Accbtn";
            this.Accbtn.Size = new System.Drawing.Size(99, 23);
            this.Accbtn.TabIndex = 3;
            this.Accbtn.Text = "create account";
            this.Accbtn.UseVisualStyleBackColor = true;
            this.Accbtn.Click += new System.EventHandler(this.Accbtn_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(34, 38);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(38, 13);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name:";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(34, 64);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(56, 13);
            this.Passlbl.TabIndex = 5;
            this.Passlbl.Text = "Password:";
            // 
            // Conflbl
            // 
            this.Conflbl.AutoSize = true;
            this.Conflbl.Location = new System.Drawing.Point(34, 90);
            this.Conflbl.Name = "Conflbl";
            this.Conflbl.Size = new System.Drawing.Size(93, 13);
            this.Conflbl.TabIndex = 6;
            this.Conflbl.Text = "Confirm password:";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 189);
            this.Controls.Add(this.Conflbl);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Accbtn);
            this.Controls.Add(this.Conftxb);
            this.Controls.Add(this.Passtxb);
            this.Controls.Add(this.Nametxb);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nametxb;
        private System.Windows.Forms.TextBox Passtxb;
        private System.Windows.Forms.TextBox Conftxb;
        private System.Windows.Forms.Button Accbtn;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Label Conflbl;
    }
}