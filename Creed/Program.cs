using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Creed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a List, named goodSongs, that will hold instances of Song.
            List<Song> goodSongs = new List<Song>();
            var femaleRap = new Song("CardiB", "Money");
            var maleRap = new Song("Drake", "God's Plan");
            var femalecountry = new Song("Shania Twain", "Dance");
            var malecountry = new Song("Lil NasX", "Old Town Road");
            var femalerock = new Song("Gwen Stephanie", "Bananas");
            var malerock = new Song("Creed", "Oldie");
            var femalepop = new Song("Taylor Swift", "Shake It Off");
            var femaleRB = new Song("Beyonce", "Halo");
            var maleRB = new Song("Usher","Confessions");
            var malepop = new Song("Justin TimberLake", "Sexy Back");
            var femaleNeoSoul = new Song("India Arie", "Steady Love");
            var maleNeoSoul = new Song("Musiq Soulchild", "Love You");

            //Define a List, named allSongs, that contains 12 instances of Song.
            List<Song> allSongs = new List<Song>() 
            {
                femaleRap,
                maleRap,
                femalecountry,
                malecountry,
                femalerock,
                malerock,
                femalepop,
                femaleRB,
                maleRB,
                malepop,
                femaleNeoSoul,
                maleNeoSoul
            };


            //use Linq to filter the allSongs list for songs where the artist is not Creed. Set goodSongs equal to the filtered result.
            goodSongs = allSongs.Where(Song => Song.Artist != "Creed").ToList();
            Console.WriteLine($"The top artist and song in all generes:");
           
            //Loop to print out all the good songs:
            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}
