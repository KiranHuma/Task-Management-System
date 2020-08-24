using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace adminpage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            count();
        }
        public void count()
        {
            SqlConnection conn = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM foradmin", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count > 0)
            {
                Label1.Text = Convert.ToString(count.ToString()); //For example a Label
            }
            else
            {
                Label1.Text = "0";
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
            connection.Open();

            string useriid = iid.Text;
            string llogin = login.Text;
            string pwdd = pwd.Text;
            string degnation = nam.Text;
            string agee = age.Text;
            string sexx = sex.Text;
            string cntcnbmr = contactno.Text;
            string usrtypee = userrtype.Text;
            string sqlquery = ("insert into auth(id,login,password,designation,age,gendr,contactno,UserType)values('" + iid.Text + "','" + login.Text + "','" + pwd.Text + "','" + nam.Text + "','" + age.Text + "','" + sex.Text + "','" + contactno.Text + "','" + userrtype.Text + "')");
            SqlCommand command = new SqlCommand(sqlquery, connection);
            command.Parameters.AddWithValue("id", useriid);
            command.Parameters.AddWithValue("login", llogin);
            command.Parameters.AddWithValue("password", pwdd);
            command.Parameters.AddWithValue("designation", degnation);
            command.Parameters.AddWithValue("age", agee);
            command.Parameters.AddWithValue("gendr", sexx);
            command.Parameters.AddWithValue("contactno", cntcnbmr);
            command.Parameters.AddWithValue("UserType", usrtypee);
            command.ExecuteNonQuery();
            
                
        }
    }
}