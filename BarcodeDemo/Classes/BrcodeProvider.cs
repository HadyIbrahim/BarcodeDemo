using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeDemo.Classes
{
    public class BrcodeProvider
    {

        public DataTable GetByID(int ID)
        {
            SqlCommand cmd = new SqlCommand("Sp_Get_Barcode");
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.CommandType = CommandType.StoredProcedure;
            return DBHelper.Instance().Execute_command_dt(cmd);

        }


        public DataTable GetMaxID()
        {
            SqlCommand cmd = new SqlCommand("Sp_BarcodeData_MaxID");
            cmd.CommandType = CommandType.StoredProcedure;
            return DBHelper.Instance().Execute_command_dt(cmd);

        }

        public DataTable GetMax_Serial()
        {
            SqlCommand cmd = new SqlCommand("Sp_BarcodeData_Max_Serial");
            cmd.CommandType = CommandType.StoredProcedure;
            return DBHelper.Instance().Execute_command_dt(cmd);

        }

        //public bool GenerateBarcode(string Day,string Month, string Year, string FactoryCode,string ProductionLine,string ShiftCode,string Serial,string Target,string MaterialCategory,int CreatedBY)
        //{
        //    SqlCommand cmd = new SqlCommand("Sp_BarcodeData_insert");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Day", Day);
        //    cmd.Parameters.AddWithValue("@Month", Month);
        //    cmd.Parameters.AddWithValue("@Year", Year);
        //    cmd.Parameters.AddWithValue("@FactoryCode", FactoryCode);
        //    cmd.Parameters.AddWithValue("@ProductionLine", ProductionLine);
        //    cmd.Parameters.AddWithValue("@ShiftCode", ShiftCode);
        //    cmd.Parameters.AddWithValue("@Serial", Serial);
        //    cmd.Parameters.AddWithValue("@Target", Target);
        //    cmd.Parameters.AddWithValue("@MaterialCategory", MaterialCategory);
        //    cmd.Parameters.AddWithValue("@CraetedON", DateTime.Now.ToShortTimeString());
        //    cmd.Parameters.AddWithValue("@CreatedBY", CreatedBY);

        //     return DBHelper.Instance().Execute_command_non(cmd);
        //}



        public int GenerateBarcode(string Day, string Month, string Year, string FactoryCode, string ProductionLine, string ShiftCode, string Serial, string Target, string MaterialCategory, int CreatedBY)
        {
            SqlCommand cmd = new SqlCommand("Sp_BarcodeData_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Day", Day);
            cmd.Parameters.AddWithValue("@Month", Month);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@FactoryCode", FactoryCode);
            cmd.Parameters.AddWithValue("@ProductionLine", ProductionLine);
            cmd.Parameters.AddWithValue("@ShiftCode", ShiftCode);
            cmd.Parameters.AddWithValue("@Serial", Serial);
            cmd.Parameters.AddWithValue("@Target", Target);
            cmd.Parameters.AddWithValue("@MaterialCategory", MaterialCategory);
            cmd.Parameters.AddWithValue("@CraetedON", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@CreatedBY", CreatedBY);
              cmd.Parameters.AddWithValue("@Maxid", SqlDbType.Int).Direction = ParameterDirection.Output;
            return DBHelper.Instance().Execute_command_MaxID(cmd);
        }


        //public int add_Loan_Header(int EmployeeID, double Total_Fee, int WageTypeID, DateTime CreatedON, string notes, DateTime DeductionDate)
        //{
        //    SqlCommand cmd = new SqlCommand("Sp_HR_Loans_insert_Header");
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@Total_Fee", Total_Fee);
        //    cmd.Parameters.AddWithValue("@CreatedON", CreatedON);

        //    cmd.Parameters.AddWithValue("@DeductionDate", DeductionDate);
        //    cmd.Parameters.AddWithValue("@EmployeeID ", EmployeeID);
        //    cmd.Parameters.AddWithValue("@WageTypeID ", WageTypeID);

        //    cmd.Parameters.AddWithValue("@notes ", notes);
        //    //cmd.Parameters["@Maxid", SqlDbType.Int).Direction = ParameterDirection.Output;
        //    cmd.Parameters.AddWithValue("@Maxid", SqlDbType.Int).Direction = ParameterDirection.Output;

        //    return DBHelper.Instance().Execute_command_MaxID(cmd);

        //}



    }

  
}



