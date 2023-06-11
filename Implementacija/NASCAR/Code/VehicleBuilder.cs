using NASCAR.Code;
using NASCAR.Models;

namespace NASCAR.Code
{

    public abstract class VehicleBuilder : IVehicleBuilder
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Mileage { get; set; }
        public string? Picture { get; set; }
        public int? Seats { get; set; }
        public string? Color { get; set; }
        public double? Price { get; set; }
        public VehicleAddress? Address { get; set; }
        public bool? IsReserved { get; set; }
        public TransmissionEnum? Transmission { get; set; }
        public CategoryEnum? Category { get; set; }
        public int? ModelYear { get; set; }
        public int? Doors { get; set; }


        public Vehicle BuildVehicle()
        {
            return new Vehicle(this);
        }

        abstract public void SetDescription(string des);

        abstract public void setDoors(int doors);

        abstract public void SetMileage(double mileage);
        abstract public void SetPicture(string url);
        abstract public void SetSeats(int seats);

        abstract public void setName(string name);

        abstract public void setModelYear(int year);

        abstract public void setTransmission(int transmission);

        abstract public void setReserved(bool reserved);

        abstract public void setColor(string color);

        abstract public void setCategory();

        abstract public void setPrice(double price);
        public abstract void setAddress(string street, string city);
    }
  
}
