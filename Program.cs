using System;

namespace Song
{
    class Program
    {
        static void SingASong(string Title)
        {
            Console.WriteLine($"Let's sing {Title}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSong.Program.Main()");
            SingASong("Baby Shark!");
        }
    }
}
