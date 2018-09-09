using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Data
{
   public class Utility
    {
        public static string GetConnectionString()
        {

            string conStr = @"Data Source=LAPTOP-32CRQJVH\SQLEXPRESS;Initial Catalog=SM;Integrated Security=True";

            return conStr;
        }


    }
}
