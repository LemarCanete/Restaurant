using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Midterm_Project
{
    public partial class AdminHome : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public AdminHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hppro\\Documents\\Restaurant.accdb");

            da = new OleDbDataAdapter("SELECT *FROM Meals", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Meals");
            dataGridView1.DataSource = ds.Tables["Meals"];
            myConn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "Insert into Meals (MealName, MealDescription, MealPrice) values(@MealName, @Description, @Price)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@MealName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Description", textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", textBox3.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox4.Text = row.Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "Delete From Meals Where ID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "Update Meals Set MealName = @MealName, MealDescription = @Description, MealPrice = @Price Where ID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@MealName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Description", textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox3.Text));
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox4.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form newForm1 = new Form1();
            newForm1.ShowDialog();
            this.Close();
        }
    }
}
