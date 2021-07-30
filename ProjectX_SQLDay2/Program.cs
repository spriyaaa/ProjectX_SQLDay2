using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectX_DALDay2;


namespace ProjectX_SQLDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity1 obj = new Activity1();
            /*           //int result = (obj.Insert("Patrick", "44004924", "patrick@gmail.com","insert"));
                       //int result = (obj.Insert("Patrick", "PS104", "demo4@gmail.com", "insert"));
                       //int result = (obj.Insert("demo", "PS106", "demo6@gmail.com", "insert"));
                       //int result = (obj.Insert("Tripti", "PS107", "demo7@gmail.com", "insert"));
                       //int result = obj.Insert("abc","PS109", "abc@gmail.com", "insert", out int rowsAffected);
                       //int result = obj.Insert("def", "PS110", "def@gmail.com", "insert", out int rowsAffected)
                       int result = obj.Insert("sim", "PS111", "sim@gmail.com", "insert", out int rowsAffected);
                       Console.WriteLine($"Returned Value =" + result);
                       Console.WriteLine(rowsAffected + " row affected");*/



            /*            //obj.Delete("44004924", out int rowsAffected);
                        //int result1= obj.Delete("44004924", out rowsAffected);
                        //int result1 = obj.Delete("PS111", out int rowsAffected);
                        //int result1 = obj.Delete("PS110", out int rowsAffected);
                        //int result1 = obj.Delete("PS109", out int rowsAffected);
                        //int result1 = obj.Delete("PS108", out int rowsAffected);
                        //int result1 = obj.Delete("PS107", out int rowsAffected);
                        Console.WriteLine($"Returned Value =" + result1);
                        Console.WriteLine(" Row Affected:" + rowsAffected);
            */


            int value = obj.UpdateFaculty( "Patrick", "PS106", out int rowsAffected);
            Console.WriteLine($"Returned Value =" + value);
            Console.WriteLine(" row affected"+ rowsAffected);



           /* Activity1UsingAdaptor obj1 = new Activity1UsingAdaptor();

            *//*          int result1 = (obj1.Insert("Tripti", "PS107", "demo7@gmail.com", "insert", out int rowsAffected));
                      Console.WriteLine($"Returned Value =" + result1);
                      Console.WriteLine(" row affected"+ rowsAffected );*//*

            int result1 = obj.Delete("PS110", out int rowsAffected);
            Console.WriteLine($"Returned Value =" + result1);
            Console.WriteLine(" row affected" + rowsAffected);*/




            /*            Activity1UsingExecuteReader obj2 = new Activity1UsingExecuteReader();

                        int result2 = obj2.Insert("sim", "PS111", "sim@gmail.com", "insert", out int rowsAffected);
                        Console.WriteLine($"Returned Value =" + result2);
                        Console.WriteLine(" row affected"+ rowsAffected );*/
        }
    }
}
