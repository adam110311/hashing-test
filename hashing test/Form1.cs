using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hashing_test
{
    public partial class Form1 : Form
    {
        public Form1(string name, string hash)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = hash;

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            Form register = new register();
            register.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string AccName = textBox1.Text;
            string Password = textBox2.Text;

            if (textBox2.Text != "")
            {
                byte[] source = ASCIIEncoding.ASCII.GetBytes(Password);

                byte[] hash = new MD5CryptoServiceProvider().ComputeHash(source);
            }
            else
            {
                MessageBox.Show("bah bah try again");
            }
        }
    }
}
