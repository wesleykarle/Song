using System;

namespace Song
{
    //This is an example using overloads and optional parameters
    //intentionally confusing
    class Program
    {
        static void SingASong(string Title= "Norwegian Wood", string key = "D", int nrTimes = 3)
        {
            for (int i = 0; i < nrTimes; i++)
            {
                Console.WriteLine($"Sing {Title} in {key}");
            }
        }
        static void SingASong()
        {
            SingASong("Baby Shark!");
        }
        static void SingASong(string Title)
        {
            SingASong(Title, "C");
        }
        static void SingASong(string Title, string key)
        {
            SingASong(Title, key, 5);

        }
        //static void SingASong(string Title, string key, int nrTimes)
        //{
        //    for (int i = 0; i < nrTimes; i++)
        //    {
        //        Console.WriteLine($"Sing: {Title} (in {key})");
        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSong.Program.Main()");
            SingASong(Title: "Wheels on the Bus");
            //SingASong("Get Low");
            //SingASong("Happy Birthday", "B minor", 2);
        }
    }
}
