using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm_Project
{

    public partial class Home : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public Home()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }
        private void LoadComboBox1Data()
        {

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");
            myConn.Open();
            string query = "SELECT * FROM Starters";
            OleDbCommand cmd = new OleDbCommand(query, myConn);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string fieldValue = reader["MealName"].ToString();
                comboBox1.Items.Add(fieldValue);

            }
            reader.Close();
            myConn.Close();

            labelMealName.Visible = false;
            labelDescription.Visible = false;
            labelPrice.Visible = false;
        }
        private void LoadComboBox2Data()
        {

            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");
            myConn.Open();
            string query = "SELECT * FROM Soups";
            OleDbCommand cmd = new OleDbCommand(query, myConn);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string fieldValue = reader["MealName"].ToString();
                comboBox2.Items.Add(fieldValue);

            }
            reader.Close();
            myConn.Close();

            labelMealName.Visible = false;
            labelDescription.Visible = false;
            labelPrice.Visible = false;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadComboBox1Data();
            LoadComboBox2Data();
            //LoadComboBox3Data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelMealName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMealName.Visible = true;
            labelDescription.Visible = true;
            labelPrice.Visible = true;
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");
            myConn.Open();
            string selectedValue = comboBox1.SelectedItem.ToString();
            string query = "SELECT * FROM Starters WHERE MealName = @MealName";
            OleDbCommand cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@MealName", selectedValue);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labelMealName.Text = selectedValue;
                labelDescription.Text = reader["Description"].ToString();
                labelPrice.Text = "₱" + reader["Price"].ToString();
            }
            reader.Close();
            myConn.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newForm1 = new Form1();
            newForm1.Show();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            labelMealName.Visible = true;
            labelDescription.Visible = true;
            labelPrice.Visible = true;
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");
            myConn.Open();
            string selectedValue = comboBox2.SelectedItem.ToString();
            string query = "SELECT * FROM Soups WHERE MealName = @MealName";
            OleDbCommand cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@MealName", selectedValue);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labelMealName.Text = selectedValue;
                labelDescription.Text = reader["Description"].ToString();
                labelPrice.Text = "₱" + reader["Price"].ToString();
            }
            reader.Close();
            myConn.Close();
        }
    }
}
