using NASCAR.Models;

namespace NASCAR.Code
{
    public interface IVehicleBuilder
    {
        void setName(string name);
        void setModelYear(int year);
        void setTransmission(int transmission);
        void setReserved(bool reserved);
        void setColor(string color);
        void setCategory();
        void setPrice(double  price);
        void setDoors(int doors);
        void SetSeats(int seats);
        void SetMileage(double mileage);
        void SetDescription(string des);
        void SetPicture(string url);

        void setAddress(string street, string city);
        Vehicle BuildVehicle();
    }
}
