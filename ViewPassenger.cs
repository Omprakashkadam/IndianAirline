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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MIPR0JC\sqlexpress;Initial Catalog=ado;Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "select * from Airline";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
          con.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PassengerDGV.Rows[e.RowIndex];

                PidTb.Text = row.Cells["PassID"].Value.ToString();
                PnameTb.Text = row.Cells["PassName"].Value.ToString();
                PpassTb.Text = row.Cells["Passport"].Value.ToString();
                PaddTb.Text = row.Cells["PassAd"].Value.ToString();
                natcb.SelectedItem = row.Cells["PassNat"].Value.ToString();
                GendCb.SelectedItem = row.Cells["PassGend"].Value.ToString();
                PphoneTb.Text = row.Cells["PassPhone"].Value.ToString();
            }
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PnameTb.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Airline  where PassName='" + PnameTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            natcb.SelectedItem = "";
            GendCb.SelectedItem = "";
            PphoneTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Airline set PassName='" + PnameTb.Text + "',Passport='" + PpassTb.Text + "',PassAd='" + PaddTb.Text + "',PassNat='" + natcb.SelectedItem.ToString() + "',PassGend='" + GendCb.SelectedItem.ToString() + "',PassPhone='" + PphoneTb.Text + "' where PassId="+PidTb.Text+"";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Update Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception )
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}
