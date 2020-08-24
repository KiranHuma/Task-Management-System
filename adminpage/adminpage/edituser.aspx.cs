using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Configuration;
using System.Text.RegularExpressions;

namespace adminpage
{
    public partial class edituser : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection("Data Source=MEERHAMZA;Initial Catalog=firstasp;Integrated Security=True");
        protected void gvbind()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT id,nam,designation,dte,tme,attndce,status,dayy,ltme,wrkinghrs FROM foradmin WHERE nam LIKE '%' + @nam + '%'");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@nam", txtSearch.Text.Trim());
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "No Records Found";
            }

        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.gvbind();
        }
        

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            gvbind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("lblID");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete FROM foradmin where id='" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()) + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();

        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gvbind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            //TextBox txtname=(TextBox)gr.cell[].control[];
            TextBox textName = (TextBox)row.Cells[1].Controls[0];
            TextBox textdesgntion = (TextBox)row.Cells[2].Controls[0];
            TextBox textdtee = (TextBox)row.Cells[3].Controls[0];
            TextBox texttme = (TextBox)row.Cells[4].Controls[0];
            TextBox textatnce = (TextBox)row.Cells[5].Controls[0];
            TextBox textstats = (TextBox)row.Cells[6].Controls[0];
            TextBox textdy = (TextBox)row.Cells[7].Controls[0];
            TextBox textltime = (TextBox)row.Cells[8].Controls[0];
            TextBox textwrkinghrs = (TextBox)row.Cells[9].Controls[0];
            //TextBox textadd = (TextBox)row.FindControl("txtadd");
            //TextBox textc = (TextBox)row.FindControl("txtc");
            GridView1.EditIndex = -1;
            conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);
            SqlCommand cmd = new SqlCommand("update foradmin set nam='" + textName.Text + "',designation='" + textdesgntion.Text + "',dte='" + textdtee.Text + "',tme='" + texttme.Text + "',attndce='" + textatnce.Text + "',status='" + textstats.Text + "',dayy='" + textdy.Text + "', ltme='" + textltime.Text + "',wrkinghrs='" + textwrkinghrs.Text + "' where id='" + userid + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
            //GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gvbind();
        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Text = Regex.Replace(e.Row.Cells[0].Text, txtSearch.Text.Trim(), delegate(Match match)
                {
                    return string.Format("<span style = 'background-color:#000066'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
        }
    }
}