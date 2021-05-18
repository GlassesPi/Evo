using System;
using Flamecrest.Interfaces;

namespace Flamecrest.Vehicles
{
    public class Bike : IFactory
    {
        public void Drive(int speed)
        {
            Console.WriteLine("The speed of bike is {0} k/m", speed);
        }
    }
}