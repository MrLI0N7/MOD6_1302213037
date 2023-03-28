using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title.Length <= 200);
            Contract.Assert(title != null);

            this.title = title;
            Random videoID = new Random();
            this.id = videoID.Next(10000, 999999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Contract.Requires(playCount <= 25000000);
            Contract.Assert(playCount > 0);

            try
            {
                checked
                {
                    this.playCount += playCount;
                }

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

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
            Console.WriteLine();
        }
    }
}
