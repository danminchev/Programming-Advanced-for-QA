using System.Security.Cryptography.X509Certificates;

namespace _01._Songs
{
    public class Song
    {
        private string typeList;
        private string name;
        private string time;


        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songComponents = Console.ReadLine().Split("_");
                string tupeList = songComponents[0];
                string name = songComponents[1];
                string time = songComponents[2];

                Song currentSong = new Song
                {
                    Name = name,
                    TypeList = tupeList,
                    Time = time,
                };

                songs.Add(currentSong);
            }
            
            string typeComand = Console.ReadLine();

            if (typeComand != "all")
            {
                songs = songs.Where(x => x.TypeList == typeComand).ToList();
            }
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }

            //if (typeComand == "all")
            //{
            //    foreach (Song song in songs)
            //    {
            //        Console.WriteLine(song.Name);
            //    }
            //}
            //else
            //{
            //    List<Song> filteredSongs = songs
            //        .Where(x => x.TypeList == typeComand)
            //        .ToList();

            //    foreach (Song song in filteredSongs)
            //    {
            //        Console.WriteLine(song.Name);
            //    }
            //}
        }
    }
}
