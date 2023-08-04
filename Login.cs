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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
           
        }
        int counter = 0;
        int len = 0;
        string txt;


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100,0,0,0);
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";           
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The user Id and Password");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Wrong User Name or Password");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                 label1.Text = "";

            }
            else
                label1.Text = txt.Substring(0, counter);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }  

    }
}
