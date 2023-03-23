using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Net.Http;
using System.Security.Policy;

namespace hashing_test
{
    public partial class register : Form
    {
        public register(string name, string hash)
        {
            InitializeComponent();
        }

        public register()
        {
        }
        
        private void Accbtn_Click(object sender, EventArgs e)
        {
            if (Passtxb.Text == Conftxb.Text)
            {
                string name = Nametxb.Text;
                string NewPass = Passtxb.Text;
                byte[] source = ASCIIEncoding.ASCII.GetBytes(NewPass);

                byte[] hash = new MD5CryptoServiceProvider().ComputeHash(source);

                Form Form1 = new Form1( name, ByteArrayToString(hash));
                Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("bah bah try again");
            }
        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
