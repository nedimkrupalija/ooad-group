using NASCAR.Models;

namespace NASCAR.Services
{
    public class Filter
    {
        private string? city = null;
        private int? price = null;
        private string? carName = null;
        private string? year = null;
        public Filter() { }
        public Filter(FilterBuilder builder) {
            city = builder.city;
            price = builder.price;
            carName = builder.carName;
            year = builder.year;
        }

        public List<Vehicle> GetVehicles(List<Vehicle> vehicles)
        {
            for (int i=0;i< vehicles.Count; i++) {
                var vehicle = vehicles[i];
                if(carName!=null && !vehicle.Name.Contains(carName, StringComparison.OrdinalIgnoreCase))
                {
                    vehicles.Remove(vehicle);
                    i--;
                    continue;
                }
                if(price!=null && vehicle.Price > price)
                {
                    vehicles.Remove(vehicle);
                    i--;
                    continue;
                }
                if(year!=null && Convert.ToInt32(vehicle.ModelYear) < Convert.ToInt32(year))
                {
                    vehicles.Remove(vehicle);
                    i--;
                    continue;
                }
                if(city!="All" && city!=null && !vehicle.VehicleAddress.City.Contains(city, StringComparison.OrdinalIgnoreCase))
                {
                    vehicles.Remove(vehicle);
                    i--;
                    continue;
                }

            }
            return vehicles;
        }

    }
}
