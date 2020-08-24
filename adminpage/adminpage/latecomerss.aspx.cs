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
    public partial class latecomerss : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;
        SqlConnection sqlcon = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = ("SELECT * FROM foradmin WHERE status ='Late'");
                    cmd.Connection = con;
                    // cmd.Parameters.AddWithValue("@designation", txtSearch.Text.Trim());
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }

        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }

    }
}