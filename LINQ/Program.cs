using System;
using System.Data;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace hello
{
    class Program
    {
        public static void Main(string[] args)
        {
            // LINQ (Language integrated query)
            // ADO.NET -> Disconnected data architecture, means it connects to 
            // the database whenever you want to send or retrieve data from
            // database
            
            // two packages are required: System.Data and System.Data.SqlClient
            // two types of connections known as:
            // 1) SqlConnection - connects to SQL Server only, 70% faster than 2nd
            // 2) OleDbConnection - can connect to any backend.

            // DataAdapter: allows sending data to db and retrieving data from db
            // it has commands like: SelectCommand, InsertCommand, UpdateCommand, DeleteCommand


            // SqlConnection conn = new SqlConnection("Server=localhost;Database=sanket_database;User ID=root;Password=Sanket@2307;"");

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
