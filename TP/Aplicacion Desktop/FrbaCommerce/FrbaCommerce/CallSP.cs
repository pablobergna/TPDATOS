using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

public class CallSP
{
    public bool RunSP(string SPName, string parameters)
    {
        SqlConnection conn = null;
        SqlDataReader rdr = null;

        try
        {
            conn = new SqlConnection("Server=(local);Database=GD1C2014;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SPName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch
        { 
        }
        return true;
    }
}