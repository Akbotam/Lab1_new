using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationWindows
{
    public partial class Form1 : Form
    {
        public string l;
        public string p;
        public Form1()
        {
            InitializeComponent();
           

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            string s;
            string ss;
            s = "amautkazy";
            ss = "Bmautkazy";
            a = Password.Text;
            Button btn = sender as Button;
            if (Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Error", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (a.Length < 8)
            {
                MessageBox.Show("Error", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (Login.Text == "amautkazy" && Password.Text == "Bmautkazy")
            {
                MessageBox.Show("Success", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (Login.Text != "amautkazy" || Password.Text != "Bmautkazy")
            {
                MessageBox.Show("Error", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
