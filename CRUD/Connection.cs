using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUD
{
    public class Connection
    {
        public static SqlConnection con;

        public static SqlConnection GetConnection
        {
            get
            {
                if(con == null)
                {
                    con = new SqlConnection();
                    con.ConnectionString = @"Data Source=LAB2-PC4; Initial Catalog=users; Integrated Security=true";
                }
                return con;
            }
        }
    }
}