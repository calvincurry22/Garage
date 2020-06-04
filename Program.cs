using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tesla mkz = new Tesla();
            VolksWagen Arteon = new VolksWagen();
            LandRover Defender = new LandRover();

            mkz.MainColor = "White";
            Arteon.MainColor = "Kurkuma Yellow";
            Defender.MainColor = "Smoke Grey";

            Arteon.Drive();
            Arteon.Turn();
            Arteon.Stop();
            Console.WriteLine();
            mkz.Drive();
            mkz.Turn();
            mkz.Stop();
            Console.WriteLine();
            Defender.Drive();
            Defender.Turn();
            Defender.Stop();
        }
    }
}