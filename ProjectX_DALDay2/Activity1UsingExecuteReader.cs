using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX_DALDay2
{
    public class Activity1UsingExecuteReader
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

        public int Insert(string Name, string Psnumber, string Emailid, string choice, out int rowsAffected)
        {
            sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString());
            sqlCmdObj = new SqlCommand("dbo.usp_faculty", sqlConObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlConObj.Open();

            sqlCmdObj.Parameters.AddWithValue("@NAME", SqlDbType.VarChar).Value = Name;
            sqlCmdObj.Parameters.AddWithValue("@PSNUMBER", SqlDbType.VarChar).Value = Psnumber;
            sqlCmdObj.Parameters.AddWithValue("@EMAILID", SqlDbType.VarChar).Value = Emailid;
            sqlCmdObj.Parameters.AddWithValue("@CHOICE", SqlDbType.VarChar).Value = choice;

          

            try
            {

                SqlParameter status = new SqlParameter("@returnValue", System.Data.SqlDbType.Int);
                status.Direction = System.Data.ParameterDirection.ReturnValue;

                sqlCmdObj.Parameters.Add(status);

                SqlDataReader dr = sqlCmdObj.ExecuteReader();
                rowsAffected = dr.RecordsAffected;
                int returnValue = (int)status.Value;
                return returnValue;

                
                //Console.WriteLine(status);
                // return value;
                //return rowsAffected;
            }


            catch (Exception ex)
            {
                Console.WriteLine("Something went Wrong !");
                rowsAffected = 0;
                return rowsAffected;
            }


            finally
            {
                sqlConObj.Close();
         
            }

        }


        
            




    }
}
