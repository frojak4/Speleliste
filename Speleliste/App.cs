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
            new Rock("Where Is My Mind?", "The Pixies", "03:55"),
            new Pop("Blinding Lights", "The Weeknd", "03:20"),
            new Pop("Levitating", "Dua Lipa", "03:23"),
            new HipHop("Sicko Mode", "Travis Scott", "05:12"),
            new HipHop("God's Plan", "Drake", "03:18"),
            new Rock("Smells Like Teen Spirit", "Nirvana", "05:01"),
            new Rock("Hotel California", "Eagles", "06:30"),
            new Pop("Bad Guy", "Billie Eilish", "03:14"),
            new Pop("Shape of You", "Ed Sheeran", "03:53"),
            new HipHop("HUMBLE.", "Kendrick Lamar", "02:57"),
            new HipHop("Lose Yourself", "Eminem", "05:26"),
            new Rock("Bohemian Rhapsody", "Queen", "05:55"),
            new Rock("Stairway to Heaven", "Led Zeppelin", "08:02"),
            new Pop("Uptown Funk", "Mark Ronson ft. Bruno Mars", "04:30"),
            new Pop("Firework", "Katy Perry", "03:48"),
            new HipHop("Juicy", "The Notorious B.I.G.", "05:02"),
            new HipHop("Hotline Bling", "Drake", "04:27"),
            new Rock("Sweet Child O' Mine", "Guns N' Roses", "05:56"),
            new Rock("Wonderwall", "Oasis", "04:18"),
            new Pop("Shake It Off", "Taylor Swift", "03:39"),
            new Pop("Rolling in the Deep", "Adele", "03:48"),
            new HipHop("N.Y. State of Mind", "Nas", "04:54"),
            new HipHop("Alright", "Kendrick Lamar", "03:39"),
            new Rock("Under the Bridge", "Red Hot Chili Peppers", "04:24"),
            new Rock("Back in Black", "AC/DC", "04:15")
        };
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sort by genre:");
                Console.WriteLine("1. Pop");
                Console.WriteLine("2. Hip-hop");
                Console.WriteLine("3. Rock");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("All Songs:");
                foreach (var song in Playlist)
                {
                    printSong(song);
                    
                }
                

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        foreach (var song in Playlist)
                        {
                            if (song is Pop)
                            {
                                printSong(song);
                            }
                        }

                        Console.ReadKey(true);
                        break;
                    case "2":
                        Console.Clear();
                        foreach (var song in Playlist)
                        {
                            if (song is HipHop)
                            {
                                printSong(song);
                            }
                        }
                        Console.ReadKey(true);
                        break;
                    case "3":
                        Console.Clear();
                        foreach (var song in Playlist)
                        {
                            if (song is Rock)
                            {
                                printSong(song);
                            }
                        }
                        Console.ReadKey(true);
                        break;
                }

                
            }
        }

        public void printSong(ISong song)
        {
            Console.Write($"{song.Name} - ");
            Console.Write($"{song.Artist} - ");
            Console.Write(song.Length);
            Console.WriteLine();
        }

        

        
    }
}
