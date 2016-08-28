using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\AHG\Desktop\WindowsFormsApplication1 (1)\WindowsFormsApplication1\WindowsFormsApplication1\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand com = new SqlCommand();
        SqlDataReader red;
        public Form1()
        {
            
            
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(splesh));
            t.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            t.Abort();
            
        }
        public void splesh()
        {
            Application.Run(new Form2());
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void գրանցամատյանToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

     

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox5.Show();
            groupBox6.Visible = false;
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox6.Show();
            groupBox5.Visible = false;


        }

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            panel1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;

            panel2.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                con.Open();
            com.Connection = con;
            
            com.CommandText = "insert into dasaxos (id,danun,dazganun,dhayr,dtari,dcnund,dser,dmas,dhamar,dmarz,dqaxaq,dgjux) values('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + maskedTextBox4.Text + "','" + comboBox5.SelectedIndex + "','" + textBox10.Text + "','" + maskedTextBox2.Text + "','" + comboBox8.SelectedIndex + "','" + comboBox7.SelectedIndex + "','" + comboBox6.SelectedIndex + "')";
           
            com.ExecuteNonQuery();
            MessageBox.Show("Բազայն հաջողությամբ գրանցվեց");
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
        }

        

        private void button20_Click_1(object sender, EventArgs e)
        {

            com.Connection = con;
            con.Open();
            com.CommandText = "select * from dasaxos where [id]='" + textBox14.Text + "'";
            red = com.ExecuteReader();


            if (red.Read())
            {

                textBox13.Text = red["danun"].ToString();
                textBox15.Text = red["dazganun"].ToString();
                textBox16.Text = red["dhayr"].ToString();
                textBox12.Text = red["dtari"].ToString();
                maskedTextBox5.Text = red["dcnund"].ToString();
                comboBox9.Text = comboBox5.Items[int.Parse(red["dser"].ToString())].ToString();
                textBox11.Text = red["dmas"].ToString();
                maskedTextBox6.Text = red["dhamar"].ToString();
                comboBox15.Text = comboBox8.Items[int.Parse(red["dmarz"].ToString())].ToString();
                comboBox14.Text = comboBox7.Items[int.Parse(red["dqaxaq"].ToString())].ToString();
                comboBox13.Text = comboBox6.Items[int.Parse(red["dgjux"].ToString())].ToString();
            }

            con.Close();

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;

            com.CommandText = "update  dasaxos  set id= '" + textBox4.Text + "' where('" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + maskedTextBox4.Text + "','" + comboBox5.SelectedIndex + "','" + textBox10.Text + "','" + maskedTextBox2.Text + "','" + comboBox8.SelectedIndex + "','" + comboBox7.SelectedIndex + "','" + comboBox6.SelectedIndex + "')";

            com.ExecuteNonQuery();
            MessageBox.Show("Բազայն հաջողությամբ գրանցվեց");
            con.Close();
        }

      
    }
}
