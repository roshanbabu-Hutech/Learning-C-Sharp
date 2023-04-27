using System.IO;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using Practice.Models;
using Dapper;
// using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
// using System.Collections;
// using System.Data.SqlClient;

namespace Practice{
    public class Program{
        public static void Main(string[] args){
            Computer obj = new Computer("Intel",16,true,true,new DateTime(2000,1,1),5000,"Nvidia");
            // Console.WriteLine($@"My Name is {obj.Name}
            // and my Age is {obj.Age}
            // and i'm working as a {obj.Job}");    

            string connectionString = "server = DESKTOP-SEQKU0P; database = DotNetCourseDatabase; Trusted_Connection = true; TrustServerCertificate = true";

            try{

            IDbConnection dbObject = new SqlConnection(connectionString);
            // Connecting to the database
            Console.WriteLine(dbObject);
           
            // connection successful
            string queryDate = "SELECT GETDATE()";
           DateTime date = dbObject.QuerySingle<DateTime>(queryDate);
           //  Getting date and Time from the database
           Console.WriteLine(date);
          
        //   inserting data in the database table
            string insertData = @"INSERT into TutorialAppSchema.Computer(
                MotherBoard,
                CpuCores,
                HasWifi,
                HasLte,
                ReleaseDate,
                Price,
                VideoCard
            )values('Intel','16','true','true',CONVERT(datetime,'2000-01-01',120),'5000','Nvidia')";

            int result = dbObject.Execute(insertData);

            Console.WriteLine(result);

            // Get records from the database

            string getRecords = @"SELECT *
            from TutorialAppSchema.Computer";

            IEnumerable<Computer> records = dbObject.Query<Computer>(getRecords);

            foreach (var record in records)
            {
                Console.WriteLine(record.MotherBoard + " " + record.CpuCores + " " + record.HasWifi + " " + record.HasLte + " " + record.ReleaseDate + " " + record.Price + " " + record.VideoCard );
            }

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            IEnumerable<int> enumerableNumbers = numbers;

            Console.WriteLine(enumerableNumbers);

            // Console.WriteLine(records);
            
            }catch(System.Exception ex){
                // Console.WriteLine(System.Exception);
                Console.WriteLine($@"There\'s an error ---> {ex.Message}");
                throw;
            }

            // Console.WriteLine(dbObject);
            // using StreamWriter log = new StreamWriter("log.txt",append:true);
            // JsonSerializerOptions
        }
    }
}
