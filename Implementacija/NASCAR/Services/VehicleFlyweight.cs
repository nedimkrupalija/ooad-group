using NASCAR.Models;

namespace NASCAR.Services
{
    abstract public class VehicleFlyweight
    {
        public TransmissionEnum Transmission { get; set; } = 0;
        public CategoryEnum Category { get; set; }
        public int doors { get; set; } = 4;
        public int seats { get; set; } = 5;
        public VehicleFlyweight() { }
    }
}
