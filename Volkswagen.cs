using System;

namespace Garage
{
    public class VolksWagen : Vehicle // Gas powered car
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Volkswagen drifts around the corner. SKRRRRRRRT!!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The headlights auto adjust as the {MainColor} Volkswagen makes a smooth turn around the bend.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Volkswagen gently rolls to a stop!");
        }
    }
}