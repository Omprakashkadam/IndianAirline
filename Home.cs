using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndianAirline
{
    public partial class Home : Form
        
    {
        int x = 255, y = 1;
        public Home()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPassenger Pass = new AddPassenger();
            Pass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket Tick = new Ticket();
            Tick.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CancellationTbl Can = new CancellationTbl();
            Can.Show();
            this.Hide();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.SetBounds(x, y, 1, 1);
            x--;
            if (x <= 1)
            {
                x = 690;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(150, 0, 0, 0);
            label4.Text = "Welcome ASO Airline         Welcome ASO Airline       Welcome ASO Airline        Welcome ASO Airline  ";
            label4.Font = new Font("", 10, FontStyle.Bold);
            label4.ForeColor = Color.DarkGoldenrod;
            timer1.Interval = 5;
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
