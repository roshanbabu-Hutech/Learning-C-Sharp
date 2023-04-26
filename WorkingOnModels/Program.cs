// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using Project.Models;

namespace Project{
    public class Program{
        public static void Main(string[] args){

            Computer myComputer = new Computer("Intel", 16, true, true, new DateTime(2000,01,01), 3000, "RTX 3050");
            
            Console.WriteLine(@$"My Computer has {myComputer.MotherBoard} motherboard and 
            it's {myComputer.CpuCores} cores, 
            also it has builtin {myComputer.HasWifi}, {myComputer.HasLte} and 
            it's release date is {myComputer.ReleaseDate}
            it's price is {myComputer.Price} finally it's a Nvidia {myComputer.VideoCard}");
            // Computer.MotherBoard = "amd";
            // Console.WriteLine(Computer.MotherBoard);
        }
    }
}