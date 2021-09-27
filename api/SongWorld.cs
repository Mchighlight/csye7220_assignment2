using System;
using System.IO;

namespace api
{
    public class SongWorld
    {
        public string Songworld { get; set; }

        public SongWorld()
        {
            if (File.Exists("Song1.txt"))
            {
                Songworld = File.ReadAllText("Song1.txt");
            }
            else
            {
                Songworld = "??";
            }
        }
    }
}
