using NASCAR.Code;
using NASCAR.Models;

namespace NASCAR.Code
{
    public interface IVehicle
    {
        void setDoors();
        void SetCategory();
        void SetSeats();

        void SetMileage();
        void SetDescription();
        void SetPicture();
        Vehicle GetProduct();
    }
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class Sedan : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }


        public void SetCategory()
        {
            objVehicle.Category = (Models.CategoryEnum?)1;
        }
        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }

    }
    public class Sports : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }
        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }

        public void SetCategory()
        {
            objVehicle.Category = (Models.CategoryEnum?)1;
        }

        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }

    }
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class SUV : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }
        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }

        public void SetCategory()
        {
            objVehicle.Category = (Models.CategoryEnum?)3;
        }

        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }
    
    }
    public class Coupe : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }

        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }
        public void SetCategory()
        {
            objVehicle.Category = (Models.CategoryEnum?)1;
        }

        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }

    }
    public class Crossover : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }
        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }
        public void SetCategory()
        {
            throw new NotImplementedException();
        }

        public void setDoors()
        {
            throw new NotImplementedException();
        }

        public void SetSeats()
        {
            throw new NotImplementedException();
        }


    }
    public class Minivan : IVehicle
    {
    NASCAR.Models.Vehicle objVehicle = new NASCAR.Models.Vehicle();

        public NASCAR.Models.Vehicle GetProduct()
        {
            return objVehicle;
        }
        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }

        public void SetCategory()
        {
            objVehicle.Category = (NASCAR.Models.CategoryEnum?)1;
        }

        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }

    Vehicle IVehicle.GetProduct()
    {
        throw new NotImplementedException();
    }
}

    public class Van : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }
        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }
        public Vehicle GetVehicle()
        {
            throw new NotImplementedException();
        }

        public void SetCategory()
        {
            objVehicle.Category = (Models.CategoryEnum?)1;
        }

        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }

    Vehicle IVehicle.GetProduct()
    {
        throw new NotImplementedException();
    }
}

    public class Cabrio : IVehicle
    {
        Models.Vehicle objVehicle = new Models.Vehicle();

        public Models.Vehicle GetProduct()
        {
            return objVehicle;
        }
        public void SetDescription()
        {
            objVehicle.Description = "";
        }


        public void SetMileage()
        {
            objVehicle.Mileage = 0;
        }

        public void SetPicture()
        {
            objVehicle.Picture = "";
        }
        public Vehicle GetVehicle()
        {
            throw new NotImplementedException();
        }

        public void SetCategory()
        {
            objVehicle.Category = (Models.CategoryEnum?)1;
        }

        public void setDoors()
        {
            objVehicle.Doors = 4;
        }

        public void SetSeats()
        {
            objVehicle.Seats = 5;
        }

    }




    public class VehicleCreator
    {
        private readonly IVehicle objBuilder;

        public VehicleCreator(IVehicle builder)
        {
            objBuilder = builder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetCategory();
            objBuilder.SetSeats();
            objBuilder.setDoors();
            objBuilder.SetDescription();
            objBuilder.SetMileage();
            objBuilder.SetPicture();

        }

        public Models.Vehicle GetVehicle()
        {
            return objBuilder.GetProduct();
        }
    }
}
