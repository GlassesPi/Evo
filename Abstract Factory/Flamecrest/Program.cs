using System;
using Flamecrest.Factory;
using Flamecrest.Interfaces;
using Flamecrest.Vehicles;

namespace Flamecrest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            VehicleFactory factory = new Factory.Factory();

            IFactory bike = factory.MakeVehicle(Types.Bike);
            bike.Drive(60);

            IFactory scooter = factory.MakeVehicle(Types.Scooter);
            scooter.Drive(25);

            IFactory car = factory.MakeVehicle(Types.Car);
            car.Drive(120);

            Console.ReadKey();
        }
    }
}