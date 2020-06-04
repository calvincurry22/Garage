using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("The vehicle made a smooth turn around the bend.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }
    }
}