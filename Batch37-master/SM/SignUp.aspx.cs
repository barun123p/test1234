using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-MKI4C5K\SQLEXPRESS;Initial Catalog=INVENTORYMANAGEMENT;Integrated Security=True;");
        // SqlCommand cmd = new SqlCommand("insert into USerProfile values("+ txtUserId.Text + " ,'" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtStreet.Text + "','" + txtCity.Text + "'," + TxtZipCode.Text +")",conn);

        SqlCommand cmd = new SqlCommand("AddUser", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = Convert.ToInt32(txtUserId.Text);
        cmd.Parameters.Add("@FIRSTNAME", SqlDbType.VarChar, 20).Value = txtFirstName.Text;
        cmd.Parameters.Add("@LASTNAME", SqlDbType.VarChar, 20).Value = txtLastName.Text;
        cmd.Parameters.Add("@STREET", SqlDbType.VarChar, 20).Value = txtStreet.Text;
        cmd.Parameters.Add("@CITY", SqlDbType.VarChar, 20).Value = txtCity.Text;
        cmd.Parameters.Add("@ZIPCODE", SqlDbType.Int).Value = Convert.ToInt32(TxtZipCode.Text);
        conn.Open();
        cmd.ExecuteNonQuery();
        
   
         cmd = new SqlCommand("LoginPage", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = Convert.ToInt32(txtUserId.Text);
        cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20).Value = txtUserName.Text;
        cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 20).Value = txtPassword.Text;
        cmd.Parameters.Add("@CLIENTID", SqlDbType.Int).Value = Convert.ToInt32(txtClientId.Text);
       // conn.Open();
        cmd.ExecuteNonQuery();

        Response.Redirect("http://localhost:53680/LoginPage.aspx");
    }

}
