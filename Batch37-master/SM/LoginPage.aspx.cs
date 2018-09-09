using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn1 = new SqlConnection(@"Data Source = DESKTOP-MKI4C5K\SQLEXPRESS;Initial Catalog=INVENTORYMANAGEMENT;Integrated Security=True;");
        // SqlCommand cmd = new SqlCommand("insert into USerProfile values("+ txtUserId.Text + " ,'" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtStreet.Text + "','" + txtCity.Text + "'," + TxtZipCode.Text +")",conn);
        conn1.Open();
        SqlCommand cmd1 = new SqlCommand("[dbo].[ValidateUser]", conn1);
        cmd1.CommandType = System.Data.CommandType.StoredProcedure;
       
        cmd1.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20).Value = txtUserName.Text;
        cmd1.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 20).Value = txtPassword.Text;

        SqlDataReader rd = cmd1.ExecuteReader();
        string user = "";
        while (rd.Read())
        {
             user = rd.GetString(0);
        }
        if(user!="")
        {
            Response.Redirect("http://localhost:53680/Home.aspx");

        }
        else
        {
            lblError.Text = "Invalid User!!!";
        }

    }

    protected void btnSinup_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://localhost:53680/SignUp.aspx");
    }
}