using System;
using System.Data;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace hello
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=sanket_database1;User ID=root;Password=Sanket@2307;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");
                    SqlDataAdapter ad = new SqlDataAdapter("select*from customer",conn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds,"customer");
                    foreach(DataRow dr in ds.Tables["customer"].Rows){
                        Console.WriteLine(" id :" + dr["id"]);
                        Console.WriteLine(" name :" + dr["name1"]);
                        Console.WriteLine(" phone number :" + dr["phone_number"]);
                    }    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}







