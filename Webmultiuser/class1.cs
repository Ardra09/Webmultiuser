﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Webmultiuser
{
    public class class1
    {

        SqlConnection con;
        SqlCommand cmd;
        public class1()
        {
            con = new SqlConnection(@"server=DESKTOP-DID7AQD\SQLEXPRESS;database=Dbmultiuser;Integrated Security=true");
        }

        public int Fn_nonquery(string sql)//select,delete,update
        {           
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fn_scalar(string sql)//scalar function
        {          
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}