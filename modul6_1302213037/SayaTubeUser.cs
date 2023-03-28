using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213037
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            Random UserID = new Random();
            this.id = UserID.Next(10000, 999999);
            this.uploadedVideos= new List<SayaTubeVideo>();

        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < this.uploadedVideos.Count; i++)
            {
                int A = uploadedVideos[i].GetPlayCount();
                total += total + A;
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + Username);
            for(int i = 0;i < uploadedVideos.Count;i++)
            {
                Console.WriteLine("Video "+ (i + 1) +": " + uploadedVideos[i].GetTitle());

            }
            
            
        }
        public List<SayaTubeVideo> GetVideoList()
        {
            return uploadedVideos;
        }
    }
}
