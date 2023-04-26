using System;

namespace Project{
    public class Computer{
        private string MotherBoard {get; set; }
        private int CpuCores {get; set;}
        private bool HasWifi {get; set;}
        private bool HasLte {get; set;}
        private DateTime ReleaseDate {get; set;}
        private decimal Price {get; set;}
        private string VideoCard {get; set;}

        public Computer(string MotherBoard, int CpuCores, bool HasWifi, bool HasLte, DateTime ReleaseDate, decimal Price, string VideoCard){
            this.MotherBoard = MotherBoard;
            this.CpuCores = CpuCores;
            this.HasWifi = HasWifi;
            this.HasLte = HasLte;
            this.ReleaseDate = ReleaseDate;
            this.Price = Price;
            this.VideoCard = VideoCard;
        }
    }
    public class Program{
        public static void Main(string[] args){

            Computer myComputer = new Computer("Intel", 16, true, true, "12-12-2023", 3000, "RTX 3050");
            Console.WriteLine($"My Computer has {Intel} motherboard and it's {CpuCores} cores, also it has builtin {HasWifi}, {HsLte} and it's release date is {ReleaseDate}\n it's price is {Price} finally it's a Nvidia {VideoCard}");
        }
    }
}