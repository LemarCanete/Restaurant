using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Midterm_Project
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(plainTextBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form newForm1 = new Form1();
            newForm1.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text.Trim();
                string password = Encrypt(textBox2.Text.Trim());

                // Set the username and password to check against
                string correctUsername = "admin";
                string correctPassword = Encrypt("password123");

                if (username == correctUsername && password == correctPassword)
                {
                    // Authentication successful
                    this.Hide();
                    Form adminHome = new AdminHome();
                    adminHome.Show();
                }
                else
                {
                    // Authentication failed
                    throw new Exception("Incorrect username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
