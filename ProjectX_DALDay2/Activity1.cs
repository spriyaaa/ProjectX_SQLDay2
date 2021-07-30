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
    public class Activity1
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

/*        public int Insert(string Name, string Psnumber, string Emailid,string choice, out int rowsAffected)
        {
            sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString());
            sqlCmdObj = new SqlCommand("dbo.usp_faculty", sqlConObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlConObj.Open();
            
            sqlCmdObj.Parameters.AddWithValue("@NAME", SqlDbType.VarChar).Value = Name;
            sqlCmdObj.Parameters.AddWithValue("@PSNUMBER", SqlDbType.VarChar).Value = Psnumber;
            sqlCmdObj.Parameters.AddWithValue("@EMAILID", SqlDbType.VarChar).Value = Emailid;
            sqlCmdObj.Parameters.AddWithValue("@CHOICE", SqlDbType.VarChar).Value = choice;

            rowsAffected = sqlCmdObj.ExecuteNonQuery();

            try
            { 
                //return 1;
                //sqlConObj.Open();

                SqlParameter status = new SqlParameter("@returnValue", System.Data.SqlDbType.Int);
                status.Direction = System.Data.ParameterDirection.ReturnValue;

                sqlCmdObj.Parameters.Add(status);

                int value = sqlCmdObj.ExecuteNonQuery();
                //Console.WriteLine(status);
               // return value;
                return rowsAffected;

            } 


            catch (Exception ex)
            {
                Console.WriteLine("Something went Wrong !");
                rowsAffected = -1;
                return rowsAffected;
            }


            finally
            {
                sqlConObj.Close();
                //return rowsAffected;
            }

        }*/

        public int Delete(string Psnumber, out int rowsAffected)
        {
            sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString());

            sqlConObj.Open();
            sqlCmdObj = new SqlCommand(@"Delete from faculty where Psnumber = '" + @Psnumber + "'", sqlConObj);
            rowsAffected = sqlCmdObj.ExecuteNonQuery();



            Console.WriteLine(rowsAffected);

            try
            {
                //sqlConObj.Open();
                //rowsAffected = sqlCmdObj.ExecuteNonQuery();
     
                SqlParameter status = new SqlParameter("@returnValue", System.Data.SqlDbType.Int);
                status.Direction = System.Data.ParameterDirection.ReturnValue;

                sqlCmdObj.Parameters.Add(status);

                //int rowsAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)status.Value;
                return returnValue;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Something went Wrong !");
                rowsAffected = -1;
                return rowsAffected;
            }


            finally
            {
                sqlConObj.Close();
                //return rowsAffected;
            }



        }


        public int UpdateFaculty(string Name, string Psnumber, out int rowsAffected)
        {

            sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["MiniProjectConStr"].ToString());

            sqlConObj.Open();
           
            //rowsAffected = sqlCmdObj.ExecuteNonQuery();

            
            sqlCmdObj = new SqlCommand("dbo.usp_Faculty", sqlConObj);
            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            

            sqlCmdObj.Parameters.AddWithValue("@NAME", SqlDbType.VarChar).Value = Name;
            sqlCmdObj.Parameters.AddWithValue("@PSNUMBER", SqlDbType.VarChar).Value = Psnumber;
            sqlConObj.Close();
        
            try
            {
                sqlConObj.Open();
                //int rowsAffected = sqlCmdObj.ExecuteNonQuery();

                SqlParameter status = new SqlParameter("@returnValue", System.Data.SqlDbType.Int);
                status.Direction = System.Data.ParameterDirection.ReturnValue;

                sqlCmdObj.Parameters.Add(status);

                rowsAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)status.Value;
                return returnValue;

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);
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



