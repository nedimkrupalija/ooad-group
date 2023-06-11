using NASCAR.Models;

namespace NASCAR.Services
{
    public class SedanBuilder : VehicleBuilder
    {
        public SedanBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }


        public override void setCategory()
        {
            Category = (CategoryEnum?)0;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }
    }

    public class SportsBuilder : VehicleBuilder
    {
        public SportsBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)1;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }

    public class SUVBuilder : VehicleBuilder
    {
        public SUVBuilder() { }

        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)2;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }

    public class CoupeBuilder : VehicleBuilder
    {
        public CoupeBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)3;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }

    public class CrossoverBuilder : VehicleBuilder
    {
        public CrossoverBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)4;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }

    public class MiniVanBuilder : VehicleBuilder
    {
        public MiniVanBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)5;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }

    public class VanBuilder : VehicleBuilder
    {
        public VanBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)6;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }

    public class CabrioBuilder : VehicleBuilder
    {
        public CabrioBuilder() { }


        public override void SetDescription(string des)
        {
            Description = des;
        }

        public override void setDoors(int doors)
        {
            Doors = doors;
        }

        public override void SetMileage(double mileage)
        {
            Mileage = mileage;
        }

        public override void SetPicture(string url)
        {
            Picture = url;
        }

        public override void SetSeats(int seats)
        {
            Seats = seats;
        }

        public override void setName(string name)
        {
            Name = name;
        }

        public override void setModelYear(int year)
        {
            ModelYear = year;
        }

        public override void setTransmission(int transmission)
        {
            Transmission = (TransmissionEnum?)transmission;
        }

        public override void setReserved(bool reserved)
        {
            IsReserved = reserved;
        }

        public override void setColor(string color)
        {
            Color = color;
        }

        public override void setAddress(string street, string city)
        {
            Address = new VehicleAddress(street, city);
        }

        public override void setCategory()
        {
            Category = (CategoryEnum?)7;
        }

        public override void setPrice(double price)
        {
            Price = price;
        }
    }
}

