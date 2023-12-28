using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace dropdown
{
    public partial class Dropdown : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["drop"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@gender", txt_gender.Text);
            cmd.Parameters.AddWithValue("@country", txt_country.Text);
            cmd.Parameters.AddWithValue("@education", txt_education.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Add Success fully");
            }
            else
            {
                Response.Write("Failure");

            }
            con.Close();
        }

        protected void btn_fetch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection (constr);
            con.Open ();
            SqlCommand cmd = new SqlCommand("sp_fetch",con);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            con.Close();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@gender", txt_gender.Text);
            cmd.Parameters.AddWithValue("@country", txt_country.Text);
            cmd.Parameters.AddWithValue("@education", txt_education.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("update Success fully");
            }
            else
            {
                Response.Write("Failure");

            }
            con.Close();
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
           
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
               
                Response.Write("<script>alert('delete Success fully') </ script>");
            }
            else
            {
                Response.Write("Failure");

            }
            con.Close();
        }
    }
}