using System;
using Flamecrest.Interfaces;

namespace Flamecrest.Vehicles
{
    public class Scooter : IFactory
    {
        public void Drive(int speed)
        {
            Console.WriteLine("The speed of Scooter is {0} k/m", speed);
        }
    }
}