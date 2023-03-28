using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213037
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            Random videoID = new Random();
            this.id = videoID.Next(10000, 999999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }
        public int GetPlayCount()
        {
            return this.playCount;
        }
        public string GetTitle() 
        { 
            return this.title;
        }
        public void PrintVideoDetails() 
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Video Title: " + title);
            Console.WriteLine("Video playCount: " + playCount);
        }
    }
}
