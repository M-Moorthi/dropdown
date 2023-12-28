using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dropdown
{
    public partial class checkbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EDMJOBDI\SQLEXPRESS;Initial Catalog=checkbox;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@graduation", CheckBoxList1.Text);
            int i=cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Response.Write("saved sucessfully");
            }
            else {
                Response.Write("failed");
            }
            con.Close();
        }


           
        }
    }
