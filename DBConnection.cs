using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class DBConnection
    {
        public void DBCon()
        {

            using (SqlConnection con = new SqlConnection("connectionString"))
            {
                SqlCommand cmd = new SqlCommand("spValidateUserLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LoginID", user.UserID);
                cmd.Parameters.AddWithValue("@LoginPassword", user.Password);

                con.Open();
                string result = cmd.ExecuteScalar().ToString();
                con.Close();

                return result;
            }
        }
    }
}
