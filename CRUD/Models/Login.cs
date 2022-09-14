using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUD.Models
{
    public class Login
    {
        public int P_Id { get; set; }
        public string Path { get; set; }
        public string Username { get; set; }
        public string Userid { get; set; }
        public string Password { get; set; }
        public static bool C { get; set; }

        public bool Check()
        {            
            return Userid == "123" && Password == "abc";            
        }

        public void Add()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Login (Username, Path) VALUES('" + Username + "', '" + Path + "')", Connection.GetConnection);
            cmd.ExecuteNonQuery();
        }
    }
}