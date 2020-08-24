﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace taskmanagment
{
    public partial class markattndce : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;

        DataTable dt = new DataTable();
        DataRow dr;
        public static string sendtext = "";
        public static string senddtext = "";
        public markattndce()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            //gridview1();
            timechk();
        
          // edit();
            
           // insertwrkinhrs();
            // insertlate(); 
        }

        private void markattndce_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("MM-dd-yyyy ");
            TxtBox3.Text = Main.sendtext;
            TextBox2.Text = DateTime.Today.ToString("dddd");
            TextBox3.Text = DateTime.Now.ToString("MM-dd-yyyy");



            Label5.Text = DateTime.Today.ToString("dddd");
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Date");
            dt.Columns.Add("Arrival Time");
            dt.Columns.Add("Attendce");
            dt.Columns.Add("Status");
            dt.Columns.Add("Day");
            dt.Columns.Add("Leave Time");
            dt.Columns.Add("Working Hours");
        }
        public void filltme()
        {
            SqlConnection con = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
            //var cmdd = new SqlCommand("SELECT tme,CAST(tme AS time) FROM empattendnce", con);
            con.Open();
            cmd.CommandText = "select tme,nam,designation,status,attndce from empattendnce where id=" + iid.Text.Trim();
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                Label2.Text = rdr["tme"].ToString();
                nm.Text = rdr["nam"].ToString();
                designtion.Text = rdr["designation"].ToString();
                Label4.Text = rdr["status"].ToString();
                Label3.Text = rdr["attndce"].ToString();
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");

            con.Close();

            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from empattendnce", con);
            da.Fill(ds, "empattendnce");
            con.Close();
        }

        public void gridview1()
        {
            
                        dr = dt.NewRow();
                        dr["ID"] = iid.Text;
                        dr["Name"] = nm.Text;
                        dr["Designation"] = designtion.Text;
                        dr["Date"] = Label1.Text;
                        dr["Arrival Time"] = Label2.Text;
                        dr["Attendce"] = Label3.Text;
                        dr["Status"] = Label4.Text;
                        dr["Day"] = Label5.Text;
                        dr["Leave Time"] = Label7.Text;
                        dr["Working Hours"] = Label8.Text;
                        dt.Rows.Add(dr);
                        dataGridView1.DataSource = dt;
                       
                    }

        public void insertwrkinhrs()
        {
            SqlConnection connection = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
            connection.Open();
            // Label8.Text = DateTime.Now.ToString("h:mm");
            // Label8.Text = DateTime.Now.ToString("h:mm");
            // filltme();
            // Label7.Text = "";
            fillLeavetme();/////////////leave time jo edit wala function ma update hva usko papulate krta ha
            wrkinghours();///////////wrking hrs calculate hva
            string sqlquery = ("Update empattendnce set wrkinghrs=@wrkinghrs where id=@idd");
            SqlCommand command = new SqlCommand(sqlquery, connection);
            command.Parameters.AddWithValue("@idd", iid.Text);
            command.Parameters.AddWithValue("@wrkinghrs", Label8.Text);
            // command.Parameters.AddWithValue("@wrkinghrs", Label8.Text);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void insert()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
                connection.Open();

                string useriid = iid.Text;
                string llogin = nm.Text;
                string pwdd = designtion.Text;
                string dtte = Label1.Text;
                string tmee = Label2.Text;
                string attndce = Label3.Text;
                string Stats = Label4.Text;
                string dy = Label5.Text;
                string ltmee = Label7.Text;
                string wrkinghrs = Label8.Text;


                string sqlquery = ("insert into foradmin(id,nam,designation,dte,tme,attndce,status,dayy,ltme,wrkinghrs)values('" + iid.Text + "','" + nm.Text + "','" + designtion.Text + "','" + Label1.Text + "','" + Label2.Text + "','" + Label3.Text + "','" + Label4.Text + "','" + Label5.Text + "','" + Label7.Text + "','" + Label8.Text + "')");
                SqlCommand command = new SqlCommand(sqlquery, connection);

                command.Parameters.AddWithValue("id", useriid);
                command.Parameters.AddWithValue("nam", llogin);
                command.Parameters.AddWithValue("designation", pwdd);
                command.Parameters.AddWithValue("dte", dtte);
                command.Parameters.AddWithValue("tme", tmee);
                command.Parameters.AddWithValue("attndce", attndce);
                command.Parameters.AddWithValue("status", Stats);
                command.Parameters.AddWithValue("dayy", dy);
                command.Parameters.AddWithValue("ltme", ltmee);
                command.Parameters.AddWithValue("wrkinghrs", wrkinghrs);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Label6.Text = "You already mark your attendence";
            }
        }

        public void fillLeavetme()
        {
            SqlConnection con = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
            //var cmdd = new SqlCommand("SELECT tme,CAST(tme AS time) FROM empattendnce", con);
            con.Open();
            cmd.CommandText = "select ltme from empattendnce where id=" + iid.Text.Trim();
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                Label9.Text = rdr["ltme"].ToString();
                // nm.Text = rdr["nam"].ToString();
                // designtion.Text = rdr["designation"].ToString();
                // Label4.Text = rdr["status"].ToString();
                // Label4.Text = rdr["status"].ToString();
                //Label4.Text = rdr.GetString(6);
                //textBox1.Text = rdr.GetString(0);
                // nm.Text = rdr.GetString(2);
                // designtion.Text = rdr.GetString(3);
                // Label3.Text = "Present";
                //textBox4.Text = rdr.GetString(3);
                //textBox5.Text = rdr.GetString(4);
                //textBox6.Text = rdr.GetString(5);
                //textBox7.Text = rdr.GetString(6);
                //textBox8.Text = rdr.GetString(7);
                //textBox9.Text = rdr.GetString(8);
                //textBox10.Text = rdr.GetString(9);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");

            con.Close();

            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from empattendnce", con);
            da.Fill(ds, "empattendnce");
            con.Close();
        }

        public void edit()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
                TimeSpan start = new TimeSpan(8, 0, 0); //9 o'clock
                TimeSpan end = new TimeSpan(22, 0, 0); //12 o'clock
                TimeSpan ltime = new TimeSpan(23, 0, 0); //12 o'clock
                TimeSpan now = DateTime.Now.TimeOfDay;
                //leave time agr time 4 sa oper hva tu ye run hoga
                if (now > ltime)
                {

                    connection.Open();

                    Label7.Text = DateTime.Now.ToString("h:mm");
                    // Label8.Text = DateTime.Now.ToString("h:mm");
                    // fillinfo();
                    filltme();////////populate krta ha arrival time designation name etc ko

                    //Label2.Text = "";
                    string sqlquery = ("Update empattendnce set nam=@name,designation=@designation,ltme=@ltime where id=@idd");
                    SqlCommand command = new SqlCommand(sqlquery, connection);
                    command.Parameters.AddWithValue("@idd", iid.Text);
                    command.Parameters.AddWithValue("@name", nm.Text);
                    command.Parameters.AddWithValue("@designation", designtion.Text);
                    // command.Parameters.AddWithValue("@dyy", Label5.Text);
                    command.Parameters.AddWithValue("@ltime", Label7.Text);
                    //command.Parameters.AddWithValue("@wrkinghrs", Label8.Text);
                    command.ExecuteNonQuery();
                    insertwrkinhrs();//////////working hrs ko update krta r calculate
                    gridview1();
                    insert();/////////////admin ma values insert krta ha

                }
                else
                {
                    //arrival time r agr 9 bje sa opr hva time tu ye run kra ga
                    if ((now > start) && (now < end)||(now < start))
                    {
                        

                        Label2.Text = DateTime.Now.ToString("h:mm");
                        // Label8.Text = DateTime.Now.ToString("h:mm");
                        fillinfo();
                        gridview1();
                        Label7.Enabled = false;
                        Label8.Enabled = false;
                        connection.Open();
                        string useriid = iid.Text;
                        string llogin = nm.Text;
                        string pwdd = designtion.Text;
                        string dtte = Label1.Text;
                        string tmee = Label2.Text;
                        string attndce = Label3.Text;
                        string Stats = Label4.Text;
                        string dy = Label5.Text;
                        string ltmee = Label7.Text;
                        // string wrkinghrs= Label8.Text;
                        string sqlquery = ("insert into empattendnce(id,nam,designation,dte,tme,attndce,status,dayy,ltme)values('" + iid.Text + "','" + nm.Text + "','" + designtion.Text + "','" + Label1.Text + "','" + Label2.Text + "','" + Label3.Text + "','" + Label4.Text + "','" + Label5.Text + "','" + Label7.Text + "')");
                        SqlCommand command = new SqlCommand(sqlquery, connection);
                        command.Parameters.AddWithValue("id", useriid);
                        command.Parameters.AddWithValue("nam", llogin);
                        command.Parameters.AddWithValue("designation", pwdd);
                        command.Parameters.AddWithValue("dte", dtte);
                        command.Parameters.AddWithValue("tme", tmee);
                        command.Parameters.AddWithValue("attndce", attndce);
                        command.Parameters.AddWithValue("status", Stats);
                        command.Parameters.AddWithValue("dayy", dy);
                        command.Parameters.AddWithValue("ltme", ltmee);
                        // command.Parameters.AddWithValue("wrkinghrs", wrkinghrs);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        Label2.Text = "00:00";
                    }


                }
            }
            catch (Exception ex)
            {
                Label6.Text = "You already mark your attendence";
               // MessageBox.Show("DataBase not connected due to the reason because " & ex.Message);
              //  MessageBox.Show("not found");
                MessageBox.Show(ex.Message);
            }
        }

                  public void fillinfo()
        {
            SqlConnection con = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
            con.Open();
            cmd.CommandText = "select * from auth where id=" + iid.Text.Trim();
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                //textBox1.Text = rdr.GetString(0);
                nm.Text = rdr.GetString(1);
                designtion.Text = rdr.GetString(3);
                Label3.Text = "Present";
                
                //textBox4.Text = rdr.GetString(3);
                //textBox5.Text = rdr.GetString(4);
                //textBox6.Text = rdr.GetString(5);
                //textBox7.Text = rdr.GetString(6);
                //textBox8.Text = rdr.GetString(7);
                //textBox9.Text = rdr.GetString(8);
                //textBox10.Text = rdr.GetString(9);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");

            con.Close();

            con.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from auth", con);
            da.Fill(ds, "auth");
            con.Close();
        }
         public void wrkinghours()
        {
            TimeSpan ts1 = TimeSpan.Parse(Label9.Text); //"1:35"leave time
            TimeSpan ts2 = TimeSpan.Parse(Label2.Text); //"3:30"arrival time

            Label8.Text = (ts1- ts2).ToString();

        }

          public void timechk()
        {
            TimeSpan start = new TimeSpan(8, 0, 0); //9 o'clock
            TimeSpan end = new TimeSpan(23, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            // if ((now > start) && (now < end))
            if ((now > start) && (now < end))
            {
                Label4.Text = "Late";//label Late text chal jy
                button1.Visible = true;
                if (Label4.Text == "Late")//label late k equal hoga tu
                {
                    if (TxtBox3.Text == String.Empty)//chk kra txtbox3(hidden ha) empty ha tu nxt wala mmean reson wala pg pa chala jy..
                    {
                        Label6.Text = "Please enter your ID above";
                  //  correct krna ha   ///// Response.Redirect("~/reasonlate.aspx?val1=" + iid.Text);

                        richTextBox1.Visible = true;
                       // Response.Redirect("reasonlate.aspx?val6=" + nm.Text);
                       // Response.Redirect("~/reasonlate.aspx");
                    }
                }

            }
            else
            {
                if (now < start)
                {
                    button2.Visible = true;
                    button2.Enabled= true;
                    Button.Visible = false;
                    Button.Enabled = false;
                    button1.Visible = false;
                    Label4.Text = "ON Time";
                    // Label7.Visible = false;
                }
                else
                {
                    button2.Visible = true;
                    button2.Enabled = true;
                    Button.Visible = false;
                    Button.Enabled = false;
                    button1.Visible = false;
                    Label4.Text = "nothing";
                }

            }
           
        }
          public void timechk4()
        {
            TimeSpan start = new TimeSpan(8, 0, 0); //9 o'clock
            TimeSpan end = new TimeSpan(23, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            // if ((now > start) && (now < end))
            if ((now > start) && (now < end))
            {
                button2.Visible = true;
                button2.Enabled = true;
                Button.Visible = false;
                Button.Enabled = false;

            }
            else
            {
                if (now < start)
                {
                    button2.Visible = true;
                    Button.Visible = false;
                    Button.Enabled = false;
                    button1.Visible = false;
                    Label4.Text = "ON Time";
                    // Label7.Visible = false;
                }
                else
                {

                }
            }

            }
          public void insertlate()
          {
              try
              {
                  SqlConnection connection = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
                  connection.Open();

                  string useriid = iid.Text;

                  string dtee = TextBox3.Text;
                  string dy = TextBox2.Text;
                  string reasn = richTextBox1.Text;

                  string sqlquery = ("insert into latecomers(id,dte,reason,dayy)values('" + iid.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + richTextBox1.Text + "')");
                  SqlCommand command = new SqlCommand(sqlquery, connection);

                  command.Parameters.AddWithValue("id", useriid);

                  command.Parameters.AddWithValue("dte", dtee);
                  command.Parameters.AddWithValue("reason", reasn);
                  command.Parameters.AddWithValue("dayy", dy);


                  command.ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                  Label1.Text = "Error";
              }
          }

          private void button1_Click(object sender, EventArgs e)
          {
              if (string.IsNullOrWhiteSpace(richTextBox1.Text))
              {

                  MessageBox.Show("Please enter ticket number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  richTextBox1.Focus();
              }

              else
              {

                  insertlate();
                  TxtBox3.Text = "Late";
                  button2.Visible = true;
                  Button.Visible = false;
                 
                  richTextBox1.Visible = true;
                  button1.Visible = false;
                 
              }
          }

          private void button2_Click(object sender, EventArgs e)
          {
              edit();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void button3_Click(object sender, EventArgs e)
          {
              this.Close();
          }


    }
}