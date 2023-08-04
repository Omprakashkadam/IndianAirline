using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IndianAirline
{
    public partial class AddPassenger : Form
    {
        int x = 255, y = 1;
        public AddPassenger()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MIPR0JC\sqlexpress;Initial Catalog=ado;Integrated Security=True");

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassID.Text == "" || lable6.Text == "" || PassName.Text == "" || PassportNo.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query="insert into Airline values("+PassID.Text+",'"+PassName.Text+"','"+PassportNo.Text+"','"+PassAd.Text+"','"+NationalityCb.SelectedItem.ToString()+"','"+GenderCb.SelectedItem.ToString()+"','"+PhoneTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    con.Close();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {
            label6.Text = "Record Passenger Record Passenger Record Passenger Record Passenger Record Passenger Record Passenger";
            label6.Font = new Font("", 8, FontStyle.Bold);
            label6.ForeColor = Color.DarkGoldenrod;
            timer1.Interval = 5;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.SetBounds(x, y, 1, 1);
            x--;
            if (x <= 1)
            {
                x = 550;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
    }
}
