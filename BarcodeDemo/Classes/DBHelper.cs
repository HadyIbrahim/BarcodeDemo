using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DBHelper
/// </summary>
/// 
public class DBHelper
{
    private static DBHelper instance = null;
    private static readonly object objectlockCheck = new object();
    private static string strConnectionString = ConfigurationManager.ConnectionStrings["BarcodeDemo.Properties.Settings.BarcodeELARABYConnectionString"].ConnectionString;
    private SqlConnection conection;
	public DBHelper()
	{
		//
		// TODO: Add constructor logic here
		//
        conection = new SqlConnection(strConnectionString);
	}
    public static DBHelper Instance()
    {
        lock (objectlockCheck)
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

    }
    public SqlConnection SqlConnection
    {
        get { return conection; }
    }
    public void open_connection()
    {
        if (conection.State == ConnectionState.Closed)
            conection.Open();
    }
    public void close_connection()
    {
        if (conection.State == ConnectionState.Open)
            conection.Close();
    }
    public bool Insert(SqlCommand cmd)
    {
        cmd.Connection=conection;
        bool result = false;
        open_connection();
        int chk = cmd.ExecuteNonQuery();
        close_connection();
        if (chk >= 1)
        {
            result = true;
        }
        return result;
    }

    public bool Update(SqlCommand cmd)
    {
        cmd.Connection = conection;
        bool result = false;
        open_connection();
        int chk = cmd.ExecuteNonQuery();
        close_connection();
        if (chk >= 1)
        {
            result = true;
        }
        return result;
    }
    public bool Delete(SqlCommand cmd)
    {
        cmd.Connection = conection;
        bool result = false;
        open_connection();
        int chk = cmd.ExecuteNonQuery();
        close_connection();
        if (chk >= 1)
        {
            result = true;
        }
        return result;
    }

    public bool Execute_command_non(SqlCommand cmd)
    {
        cmd.Connection = conection;
        open_connection();
        int chk = cmd.ExecuteNonQuery();
        close_connection();
        bool result = false;
        if (chk >= 1)
        {
            result = true;
        }
        return result;
    }
    public DataTable Execute_command_dt(SqlCommand cmd)
    {
        cmd.Connection = conection;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        open_connection();
        da.Fill(dt);
        close_connection();
        return dt;

    }

    public int Execute_command_MaxID(SqlCommand cmd)
    {
        cmd.Connection = conection;
        open_connection();
        int chk = cmd.ExecuteNonQuery();
        close_connection();
        //bool result = false;
        //if (chk >= 1)
        //{
        //    result = true;
        //}

        int XXX = Convert.ToInt32(cmd.Parameters["@Maxid"].Value.ToString());
        return XXX;
    }


}
