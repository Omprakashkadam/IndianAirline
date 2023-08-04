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
    public partial class ViewFlights : Form
    {
        int x = 255, y = 1;
        public ViewFlights()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MIPR0JC\sqlexpress;Initial Catalog=ado;Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.FlightDGV.Rows[e.RowIndex];

                FcodeTb.Text = row.Cells["Fcode"].Value.ToString();
                SeatNum.Text = row.Cells["Fcap"].Value.ToString();
                DstCb.Text = row.Cells["FDest"].Value.ToString();
                SrcCb.SelectedItem = row.Cells["Fsrc"].Value.ToString();
            }
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
            label8.Text = "View Flight View Flight View Flight View Flight View Flight View Flight View Flight View Flight View Flight";
            label8.Font = new Font("", 8, FontStyle.Bold);
            label8.ForeColor = Color.DarkGoldenrod;
            timer1.Interval = 5;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlightTbl Addf1 = new FlightTbl();
            Addf1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from FlightTbl where Fcode='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || SeatNum.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "',FDest='" +DstCb.SelectedItem.ToString()+ "',FDate='" +FDate.Value.Date.ToString() + "',FCap=" + SeatNum.Text + " where Fcode='"+ FcodeTb.Text +"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flights Update Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception )
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.SetBounds(x, y, 1, 1);
            x--;
            if (x <= 1)
            {
                x = 550;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
