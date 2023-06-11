using NASCAR.Models;

namespace NASCAR.Code
{
    public class FlyWeightFactory : VehicleFlyweight
    {
        public FlyWeightFactory() { }

        public Vehicle getFlyWeight()
        {
            Vehicle vehicle = new SedanBuilder().BuildVehicle();
            vehicle.Transmission = Transmission;
            vehicle.Category = Category;
            vehicle.Doors = doors;
            vehicle.Seats = seats;

            return vehicle;
        }
    }
}
