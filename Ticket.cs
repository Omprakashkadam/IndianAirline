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
    public partial class Ticket : Form
    {
        
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MIPR0JC\sqlexpress;Initial Catalog=ado;Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillpassenger()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassID from Airline", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassID", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PassID";
            PIdCb.DataSource = dt;
            con.Close();
        }
        private void fillFlightCode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
            FCodeCb.DataSource = dt;
            con.Close();
        }
        string pname, ppass, pnat;
        
        private void fetchpassenger()
        {
            con.Open();
            string query = "select * from Airline where PassID=" + PIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;
                
            }
            con.Close();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillpassenger();
            fillFlightCode();
            populate();

        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpassenger();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into TicketTbl values(" + Tid.Text + ",'" + FCodeCb.SelectedValue.ToString() +"',"+PIdCb.SelectedValue.ToString()+",'" + PNameTb.Text+ "','" +PPassTb.Text + "','"+ PNatTb.Text+"'," + PAmtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
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
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAmtTb.Text = "";
            Tid.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OMprintPreviewDialog1.Document = OMprintDocument1;
            OMprintPreviewDialog1.ShowDialog();
        }

        private void OMprintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Mob.+919009996575", new Font("Arial", 11, FontStyle.Bold), Brushes.Navy, new Point(10, 10));
            e.Graphics.DrawString("ASO Airline", new Font("Stencil", 28, FontStyle.Bold), Brushes.Brown, new Point(300, 10));
            e.Graphics.DrawString("Shop No.4 , Shahu Chowk , Latur 413512", new Font("Arial", 15, FontStyle.Bold), Brushes.Blue, new Point(230, 55));
            e.Graphics.DrawString("Ticket", new Font("Cambria", 28, FontStyle.Bold), Brushes.Black, new Point(370, 80));
            e.Graphics.DrawString("Date: 26/06/2021  ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, 15));
            e.Graphics.DrawString("Ticket ID: "+Tid.Text, new Font ("Arial",18,FontStyle.Regular),Brushes.Black,new Point(100,180));
            e.Graphics.DrawString("Name: "+PNameTb.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(450, 180));
            e.Graphics.DrawString("Flight Code: "+FCodeCb.SelectedValue.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(100,300));
            e.Graphics.DrawString("Passenger ID: "+PIdCb.SelectedValue.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("Passport: "+PPassTb.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(100, 420));
            e.Graphics.DrawString("Nationality: "+PNatTb.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(450, 420));
            e.Graphics.DrawString("Addhar Number: " + AddharTb.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(100, 540));
            e.Graphics.DrawString("Amount: "+PAmtTb.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Red, new Point(625,700 ));
            e.Graphics.DrawString("Thank You", new Font("Engravers MT", 22, FontStyle.Bold), Brushes.Black, new Point(300, 830));
        }

        private void toolStripButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        

        

       

       
        
       
        
    }
}
