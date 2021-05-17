using Flamecrest.Interfaces;
using Flamecrest.Vehicles;

namespace Flamecrest.Factory
{
    public class Factory : VehicleFactory
    {
        public override IFactory MakeVehicle(Types vehicleType)
        {
            switch (vehicleType)
            {
                case Types.Bike:
                    return new Bike();
                case Types.Car:
                    return new Car();
                case Types.Scooter:
                    return new Scooter();
                default:
                    return null;
            }
        }
    }
}