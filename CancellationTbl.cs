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
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MIPR0JC\sqlexpress;Initial Catalog=ado;Integrated Security=True");
        private void fillTicketId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Tid from TicketTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tid", typeof(string));
            dt.Load(rdr);
            TidCb.ValueMember = "Tid";
            TidCb.DataSource = dt;
            con.Close();
        }
        private void fetchfcode()
        {
            con.Open();
            string query = "select * from TicketTbl where Tid=" + TidCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               FcodeTb.Text = dr["Fcode"].ToString();
            }
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicketId();
            populate();
        }

        private void TidCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void deleteTicket()
        {
           
                try
                {
                    con.Open();
                    string query = "delete from TicketTbl where Tid=" + TidCb.SelectedValue.ToString() + ";";
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (Canid.Text == "" || FcodeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CancelTbl values(" + Canid.Text + "," + TidCb.SelectedValue.ToString() + ",'" + FcodeTb.Text +"','" + CancDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Canceled Successfully");
                    con.Close();
                    populate();
                    deleteTicket();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Canid.Text = "";
            FcodeTb.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
