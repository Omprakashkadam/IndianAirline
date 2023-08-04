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
    public partial class FlightTbl : Form
    {
        int x = 255, y = 1;
        public FlightTbl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MIPR0JC\sqlexpress;Initial Catalog=ado;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Fsrc.Text == "" || FDest.Text == "" || FDate.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into FlightTbl values('" +FcodeTb.Text + "','" + Fsrc.SelectedItem.ToString() + "','" + FDest.SelectedItem.ToString() + "','" + FDate.Value.ToString() + "'," +SeatNum.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewFlights viewflt = new ViewFlights();
            viewflt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {
            label8.Text = "Record New Flight Record New Flight Record New Flight Record New Flight Record New Flight Record New Flight Record New";
            label8.Font = new Font("", 8, FontStyle.Bold);
            label8.ForeColor = Color.DarkGoldenrod;
            timer1.Interval = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.SetBounds(x, y, 1, 1);
            x--;
            if (x<=1)
            {
                x = 550;
            }
        }

     
    }
}
