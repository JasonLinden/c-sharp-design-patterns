using _03___Builder.Vehicle.Builder;

namespace _03___Builder.Vehicle.Director_Engineer
{
    class VehicleClass
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
