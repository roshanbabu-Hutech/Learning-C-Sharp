// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using Project.Models;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;


namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string connectionString = "server = DESKTOP-SEQKU0P; database = DotNetCourseDatabase; TrustServerCertificate = true; Trusted_Connection = true";

            // Connecting...To the database

            IDbConnection dbConnectionObject = new SqlConnection(connectionString);

            string sqlQuery = "SELECT GETDATE()";

            // after connection established from the database execute a query command on tables

            DateTime rightNow = dbConnectionObject.QuerySingle<DateTime>(sqlQuery);

            string sqlQuery1 = "SELECT * from TutorialAppSchema.Computer";

            Console.WriteLine(dbConnectionObject);

            // var records = dbConnectionObject.QuerySingle<ArrayList>(sqlQuery1);

            // var records = dbConnectionObject.QuerySingle<List<object>>(sqlQuery1);

            // var records = dbConnectionObject.execute<Computer>(sqlQuery1);

            // Console.WriteLine(records);

            Console.WriteLine(rightNow);

            Computer myComputer = new Computer("Intel", 16, true, true, new DateTime(2000, 01, 01), 3000, "RTX 3050");

            // Console.WriteLine(@$"My Computer has {myComputer.MotherBoard} motherboard and 
            // it's {myComputer.CpuCores} cores, 
            // also it has builtin {myComputer.HasWifi}, {myComputer.HasLte} and 
            // it's release date is {myComputer.ReleaseDate}
            // it's price is {myComputer.Price} finally it's a Nvidia {myComputer.VideoCard}");
            // // Computer.MotherBoard = "amd";
            // Console.WriteLine(Computer.MotherBoard);

            int[] numbers = {10, 20, 30, 40, 50, 60};

            IEnumerator numerator = numbers.GetEnumerator();

            while(numerator.MoveNext()){
                Console.WriteLine(numerator.Current);
            }
        }
    }
}