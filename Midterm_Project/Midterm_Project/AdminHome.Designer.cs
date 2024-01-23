namespace Midterm_Project
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(491, 48);
            button2.Name = "button2";
            button2.Size = new Size(153, 23);
            button2.TabIndex = 13;
            button2.Text = "Connection Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(566, 169);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(650, 48);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 15;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(50, 24);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 16;
            label2.Text = "STARTERS";
            // 
            // button3
            // 
            button3.Location = new Point(628, 133);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 17;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(628, 219);
            button4.Name = "button4";
            button4.Size = new Size(112, 23);
            button4.TabIndex = 18;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(628, 177);
            button5.Name = "button5";
            button5.Size = new Size(112, 23);
            button5.TabIndex = 19;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(174, 385);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 22;
            label3.Text = "Meal Name: ";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(375, 385);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 24;
            label1.Text = "Description: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 382);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 23;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(577, 385);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 26;
            label4.Text = "Price: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(640, 385);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 25;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(51, 385);
            label5.Name = "label5";
            label5.Size = new Size(27, 23);
            label5.TabIndex = 28;
            label5.Text = "ID:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(83, 382);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(72, 23);
            textBox4.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(39, 32);
            panel1.TabIndex = 29;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.res_back3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Name = "AdminHome";
            Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Panel panel1;
    }
}