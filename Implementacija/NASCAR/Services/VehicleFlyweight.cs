using NASCAR.Models;

namespace NASCAR.Services
{
     public class VehicleFlyweight
    {
        private Vehicle _sharedState;
       
        public VehicleFlyweight(Vehicle vehicle) {
            _sharedState = vehicle;
        }
    }
}
