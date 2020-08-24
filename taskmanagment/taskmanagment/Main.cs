using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace taskmanagment
{
    public partial class Main : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
        public static string sendtext = "";

        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Hide();
            markattndce f = new markattndce();

            f.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Enabled = true;
            timer1.Interval = 4000;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
