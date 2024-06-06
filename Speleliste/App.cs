using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speleliste
{
    internal class App
    {
        public List<ISong> Playlist = new List<ISong>()
        {
            new Pop("Cops and Robbers", "Underscores", "04:25"),
            new Pop("Call Me Maybe", "Carly Rae Jepsen", "03:13"),
            new HipHop("Through the Wire", "Kanye West", "03:41"),
            new HipHop("Not Like Us", "Kendrick Lamar", "04:34"),
            new Rock("Lost in the Supermarket", "The Clash", "03:37"),
            new Rock("Where Is My Mind?", "The Pixies", "03:55")
        };
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All Songs:");
                foreach (var song in Playlist)
                {
                    Console.Write($"{song.Name}\t\t");
                    Console.Write($"{song.Artist}\t\t");
                    Console.Write(song.Length);
                    Console.WriteLine();
                    
                }
                Console.WriteLine();
                Console.WriteLine("Sort by genre:");
                Console.WriteLine("1. Pop");
                Console.WriteLine("2. Hip-hop");
                Console.WriteLine("3. Rock");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        sortByPop();
                        break;
                    case "2":
                        sortByHiphop();
                        break;
                    case "3":
                        sortByRock();
                        break;
                }

                
            }
        }

        public void sortByPop()
        {
            Console.Clear();
            foreach (var song in Playlist)
            {
                if (song is Pop)
                {
                    Console.Write($"{song.Name}\t\t");
                    Console.Write($"{song.Artist}\t\t");
                    Console.Write(song.Length);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        public void sortByHiphop()
        {
            Console.Clear();
            foreach (var song in Playlist)
            {
                if (song is HipHop)
                {
                    Console.Write($"{song.Name}\t\t");
                    Console.Write($"{song.Artist}\t\t");
                    Console.Write(song.Length);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        public void sortByRock()
        {
            Console.Clear();
            foreach (var song in Playlist)
            {
                if (song is Rock)
                {
                    Console.Write($"{song.Name}\t\t");
                    Console.Write($"{song.Artist}\t\t");
                    Console.Write(song.Length);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
