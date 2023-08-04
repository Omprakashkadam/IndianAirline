namespace IndianAirline
{
    partial class Ticket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketID = new System.Windows.Forms.Label();
            this.Tid = new System.Windows.Forms.TextBox();
            this.FlightCode = new System.Windows.Forms.Label();
            this.PassengerID = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.FCodeCb = new System.Windows.Forms.ComboBox();
            this.PIdCb = new System.Windows.Forms.ComboBox();
            this.Passport = new System.Windows.Forms.Label();
            this.PPassTb = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.Label();
            this.PNatTb = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.PAmtTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TicketDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OMprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.OMprintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Addhar = new System.Windows.Forms.Label();
            this.AddharTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(974, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(388, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 44);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ticket Booking";
            // 
            // TicketID
            // 
            this.TicketID.AutoSize = true;
            this.TicketID.BackColor = System.Drawing.Color.Transparent;
            this.TicketID.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketID.ForeColor = System.Drawing.Color.Silver;
            this.TicketID.Location = new System.Drawing.Point(178, 153);
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(89, 22);
            this.TicketID.TabIndex = 42;
            this.TicketID.Text = "Ticket ID";
            // 
            // Tid
            // 
            this.Tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tid.Location = new System.Drawing.Point(308, 150);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(190, 27);
            this.Tid.TabIndex = 41;
            // 
            // FlightCode
            // 
            this.FlightCode.AutoSize = true;
            this.FlightCode.BackColor = System.Drawing.Color.Transparent;
            this.FlightCode.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightCode.ForeColor = System.Drawing.Color.Silver;
            this.FlightCode.Location = new System.Drawing.Point(549, 153);
            this.FlightCode.Name = "FlightCode";
            this.FlightCode.Size = new System.Drawing.Size(107, 22);
            this.FlightCode.TabIndex = 44;
            this.FlightCode.Text = "Flight Code";
            // 
            // PassengerID
            // 
            this.PassengerID.AutoSize = true;
            this.PassengerID.BackColor = System.Drawing.Color.Transparent;
            this.PassengerID.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerID.ForeColor = System.Drawing.Color.Silver;
            this.PassengerID.Location = new System.Drawing.Point(178, 205);
            this.PassengerID.Name = "PassengerID";
            this.PassengerID.Size = new System.Drawing.Size(124, 22);
            this.PassengerID.TabIndex = 46;
            this.PassengerID.Text = "Passenger ID";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.BackColor = System.Drawing.Color.Transparent;
            this.Namelbl.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.Color.Silver;
            this.Namelbl.Location = new System.Drawing.Point(549, 202);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(60, 22);
            this.Namelbl.TabIndex = 48;
            this.Namelbl.Text = "Name";
            // 
            // PNameTb
            // 
            this.PNameTb.Enabled = false;
            this.PNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameTb.Location = new System.Drawing.Point(662, 203);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(190, 28);
            this.PNameTb.TabIndex = 47;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FCodeCb
            // 
            this.FCodeCb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCodeCb.FormattingEnabled = true;
            this.FCodeCb.Location = new System.Drawing.Point(662, 150);
            this.FCodeCb.Name = "FCodeCb";
            this.FCodeCb.Size = new System.Drawing.Size(190, 29);
            this.FCodeCb.TabIndex = 49;
            // 
            // PIdCb
            // 
            this.PIdCb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIdCb.FormattingEnabled = true;
            this.PIdCb.Location = new System.Drawing.Point(308, 203);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(190, 29);
            this.PIdCb.TabIndex = 50;
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // Passport
            // 
            this.Passport.AutoSize = true;
            this.Passport.BackColor = System.Drawing.Color.Transparent;
            this.Passport.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passport.ForeColor = System.Drawing.Color.Silver;
            this.Passport.Location = new System.Drawing.Point(178, 265);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(88, 22);
            this.Passport.TabIndex = 52;
            this.Passport.Text = "Passport";
            // 
            // PPassTb
            // 
            this.PPassTb.Enabled = false;
            this.PPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPassTb.Location = new System.Drawing.Point(308, 262);
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.Size = new System.Drawing.Size(190, 28);
            this.PPassTb.TabIndex = 51;
            this.PPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Nationality
            // 
            this.Nationality.AutoSize = true;
            this.Nationality.BackColor = System.Drawing.Color.Transparent;
            this.Nationality.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nationality.ForeColor = System.Drawing.Color.Silver;
            this.Nationality.Location = new System.Drawing.Point(549, 261);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(107, 22);
            this.Nationality.TabIndex = 54;
            this.Nationality.Text = "Nationality";
            // 
            // PNatTb
            // 
            this.PNatTb.Enabled = false;
            this.PNatTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNatTb.Location = new System.Drawing.Point(662, 261);
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.Size = new System.Drawing.Size(190, 28);
            this.PNatTb.TabIndex = 53;
            this.PNatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.BackColor = System.Drawing.Color.Transparent;
            this.Amount.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.Silver;
            this.Amount.Location = new System.Drawing.Point(549, 324);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(79, 22);
            this.Amount.TabIndex = 58;
            this.Amount.Text = "Amount";
            // 
            // PAmtTb
            // 
            this.PAmtTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAmtTb.Location = new System.Drawing.Point(662, 320);
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.Size = new System.Drawing.Size(190, 28);
            this.PAmtTb.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Firebrick;
            this.label12.Location = new System.Drawing.Point(390, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 33);
            this.label12.TabIndex = 59;
            this.label12.Text = "Ticket Booking";
            // 
            // TicketDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TicketDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TicketDGV.BackgroundColor = System.Drawing.Color.White;
            this.TicketDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TicketDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TicketDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TicketDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TicketDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TicketDGV.EnableHeadersVisualStyles = false;
            this.TicketDGV.GridColor = System.Drawing.Color.DarkGray;
            this.TicketDGV.Location = new System.Drawing.Point(16, 465);
            this.TicketDGV.Name = "TicketDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TicketDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TicketDGV.RowHeadersVisible = false;
            this.TicketDGV.RowTemplate.Height = 24;
            this.TicketDGV.Size = new System.Drawing.Size(979, 247);
            this.TicketDGV.TabIndex = 60;
            this.TicketDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(590, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 42);
            this.button3.TabIndex = 63;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(458, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 42);
            this.button4.TabIndex = 62;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(322, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 42);
            this.button2.TabIndex = 61;
            this.button2.Text = "Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OMprintPreviewDialog1
            // 
            this.OMprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.OMprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.OMprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.OMprintPreviewDialog1.Enabled = true;
            this.OMprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("OMprintPreviewDialog1.Icon")));
            this.OMprintPreviewDialog1.Name = "OMprintPreviewDialog1";
            this.OMprintPreviewDialog1.Visible = false;
            // 
            // OMprintDocument1
            // 
            this.OMprintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OMprintDocument1_PrintPage);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1015, 27);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(123, 24);
            this.toolStripButton1.Text = "PrintOptions";
            this.toolStripButton1.ButtonClick += new System.EventHandler(this.toolStripButton1_ButtonClick);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.printToolStripMenuItem.Text = "PrintPreview";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem1.Image")));
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.printToolStripMenuItem1.Text = "Print";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 47);
            this.label1.TabIndex = 66;
            this.label1.Text = "Airlines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(364, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 47);
            this.label7.TabIndex = 65;
            this.label7.Text = "ASO";
            // 
            // Addhar
            // 
            this.Addhar.AutoSize = true;
            this.Addhar.BackColor = System.Drawing.Color.Transparent;
            this.Addhar.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addhar.ForeColor = System.Drawing.Color.Silver;
            this.Addhar.Location = new System.Drawing.Point(153, 326);
            this.Addhar.Name = "Addhar";
            this.Addhar.Size = new System.Drawing.Size(149, 22);
            this.Addhar.TabIndex = 68;
            this.Addhar.Text = "Addhar Number";
            // 
            // AddharTb
            // 
            this.AddharTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddharTb.Location = new System.Drawing.Point(308, 322);
            this.AddharTb.Name = "AddharTb";
            this.AddharTb.Size = new System.Drawing.Size(190, 28);
            this.AddharTb.TabIndex = 67;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1015, 724);
            this.Controls.Add(this.Addhar);
            this.Controls.Add(this.AddharTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.FCodeCb);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.PassengerID);
            this.Controls.Add(this.FlightCode);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TicketID;
        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.Label FlightCode;
        private System.Windows.Forms.Label PassengerID;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.ComboBox FCodeCb;
        private System.Windows.Forms.ComboBox PIdCb;
        private System.Windows.Forms.Label Passport;
        private System.Windows.Forms.TextBox PPassTb;
        private System.Windows.Forms.Label Nationality;
        private System.Windows.Forms.TextBox PNatTb;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox PAmtTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView TicketDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog OMprintPreviewDialog1;
        private System.Drawing.Printing.PrintDocument OMprintDocument1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Addhar;
        private System.Windows.Forms.TextBox AddharTb;
    }
}