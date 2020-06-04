using System;

namespace Garage
{
    public class LandRover : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Land Rover loudly rips through the city street. VROOOOOOM!!!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Land Rover hugs the road as it veers left around the corner.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Land Rover gently rolls to a stop!");
        }
    }
}