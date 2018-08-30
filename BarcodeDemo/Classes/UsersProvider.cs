using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BarcodeDemo.Classes
{
    class UsersProvider
    {

        public DataTable CheckLogin(string UserName, string Password)
        {
            SqlCommand cmd = new SqlCommand("Sp_Login_Check");
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.CommandType = CommandType.StoredProcedure;
            return DBHelper.Instance().Execute_command_dt(cmd);
          }
        public bool Create_User(string UserName, string Password, string FullName, int ProductionLineID)
        {

            SqlCommand cmd = new SqlCommand("Sp_Login_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", @Password);
            cmd.Parameters.AddWithValue("@FullName", FullName);
            cmd.Parameters.AddWithValue("@ProductionLineID", ProductionLineID);
           
            cmd.Parameters.AddWithValue("@CreatedON", DateTime.Now.ToShortDateString()+"/"+ DateTime.Now.ToShortTimeString());
            //cmd.Parameters.AddWithValue("@CreatedBY", CreatedBY);

            return DBHelper.Instance().Execute_command_non(cmd);
        }

    }
}
