using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "burcueda" && txtPassword.Text == "burcu123") 
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış,tekrar deneyiniz");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }
    }
}
