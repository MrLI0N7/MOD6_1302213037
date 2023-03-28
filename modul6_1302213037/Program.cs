using System.ComponentModel;

namespace modul6_1302213037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO TP MOD 6\n");

            SayaTubeUser User = new SayaTubeUser("Liyan");
            SayaTubeVideo Video1 = new SayaTubeVideo("Review Film Jurassic Farm oleh "+User.Username);
            SayaTubeVideo Video2 = new SayaTubeVideo("Review Film Star Peace oleh " + User.Username);
            SayaTubeVideo Video3 = new SayaTubeVideo("Review Film Planet Human oleh " + User.Username);
            SayaTubeVideo Video4 = new SayaTubeVideo("Review Film Itu oleh " + User.Username);
            SayaTubeVideo Video5 = new SayaTubeVideo("Review Film My Neighbor Roroto oleh " + User.Username);
            SayaTubeVideo Video6 = new SayaTubeVideo("Review Film Planet Human oleh " + User.Username);
            SayaTubeVideo Video7 = new SayaTubeVideo("Review Film Normal-Man oleh " + User.Username);
            SayaTubeVideo Video8 = new SayaTubeVideo("Review Film Jones Indiana oleh " + User.Username);
            SayaTubeVideo Video9 = new SayaTubeVideo("Review Film Brice de Nice oleh " + User.Username);
            SayaTubeVideo Video10 = new SayaTubeVideo("Review Film Slow n Calm oleh " + User.Username);
            User.AddVideo(Video1);
            User.AddVideo(Video2);
            User.AddVideo(Video3);  
            User.AddVideo(Video4);
            User.AddVideo(Video5);
            User.AddVideo(Video6);
            User.AddVideo(Video7);
            User.AddVideo(Video8);
            User.AddVideo(Video9);
            User.AddVideo(Video10);

            for (int i = 0; i < User.GetVideoList().Count; i++)
            {
                Random num = new Random();
                User.GetVideoList()[i].IncreasePlayCount(num.Next(0,1000));
                User.GetVideoList()[i].PrintVideoDetails();
            }

            User.PrintAllVideoPlaycount();

        }

    }
}
    
    