using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace BarCodeGenerator
{
    

   
  public  class LoginProvider
    {

       public DataTable CheckLogin(string UserName, string Password)
      {
          SqlCommand cmd = new SqlCommand("Sp_Login_Check");
          cmd.Parameters.AddWithValue("@UserName", UserName);
          cmd.Parameters.AddWithValue("@Password", Password);
          cmd.CommandType = CommandType.StoredProcedure;
          return DBHelper.Instance().Execute_command_dt(cmd);

      }

    }





}
