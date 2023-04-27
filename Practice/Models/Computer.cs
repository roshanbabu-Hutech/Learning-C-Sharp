using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Computer
    {
        public string MotherBoard {get; set;}
        public int CpuCores {get; set;}
        public bool HasWifi {get; set;}
        public bool HasLte {get; set;}
        public DateTime ReleaseDate  {get; set;}

        public int Price {get; set;}

        public string VideoCard {get; set;}

            public Computer() { } // parameterless constructor

        public Computer(string MotherBoard, int CpuCores, bool HasWifi, bool HasLte, DateTime ReleaseDate, int Price, string VideoCard){
            this.MotherBoard = MotherBoard;
            this.CpuCores = CpuCores;
            this.HasWifi = HasWifi;
            this.HasLte = HasLte;
            this.ReleaseDate = ReleaseDate;
            this.Price = Price;
            this.VideoCard = VideoCard;
        }
    }
}
