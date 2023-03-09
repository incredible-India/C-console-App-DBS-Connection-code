using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-89M2005\\BCDEMO;Initial Catalog=\"Demo Database BC (14-0)\";Inte" +
            "grated Security=True");

                con.Open();
                Console.WriteLine(con);
                Console.WriteLine("Dbs Connected successfully..");
              //  use[Demo Database BC(14 - 0)]


                SqlDataReader reader = new SqlCommand("select* from [CRONUS International Ltd_$Student];", con).ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["First Name"]} {reader["Last Name"]} and Phone Number {reader["Phone"]}");
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                reader.Close();

                
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
