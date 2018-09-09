using SM.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Data.Account
{
    public class AccountData
    {
        public string VlaidateUser(UserLogin user)
        {

            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand("spLogin", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = user.UserName;
            sqlCommand.Parameters.Add("@UserPassword", SqlDbType.VarChar, 50).Value = user.UserPassword;

            conn.Open();

            SqlDataReader rd = sqlCommand.ExecuteReader();

            while (rd.Read())
            {
                return (rd["UserName"] == null) ? "" : rd["UserName"].ToString();
            }


            return "";

        }

        public AccountInfo GetAccountInfo(string username)
        {
            AccountInfo accountInfo = new AccountInfo();
            SqlConnection conn = new SqlConnection(Utility.GetConnectionString());
            SqlCommand sqlCommand = new SqlCommand("spAccountBalance", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = username;
            conn.Open();

            SqlDataReader rd = sqlCommand.ExecuteReader();

            while (rd.Read())
            {
                accountInfo.FirstName = rd.GetString(0);
                accountInfo.LastName = rd.GetString(1);
                accountInfo.AccoutBalance = rd.GetInt32(2);

            }

            return accountInfo;

        }
    }
}


