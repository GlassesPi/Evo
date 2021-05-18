using System;
using Flamecrest.Interfaces;
using Flamecrest.Vehicles;

namespace Flamecrest.Factory
{
    public abstract class VehicleFactory
    {
        public abstract IFactory MakeVehicle(Types vehicleType);
    }
}