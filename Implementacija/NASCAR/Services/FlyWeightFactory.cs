using NASCAR.Models;

namespace NASCAR.Services
{
    public class FlyWeightFactory 
    {
        private List<Tuple<VehicleFlyweight, string>> flyweights = new List<Tuple<VehicleFlyweight, string>>();
        public FlyWeightFactory(params Vehicle[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<VehicleFlyweight, string>(new VehicleFlyweight(elem), this.getKey(elem)));
            }
        }


        public TransmissionEnum Transmission { get; set; } = 0;
        public CategoryEnum Category { get; set; }
        public int doors { get; set; } = 4;
        public int seats { get; set; } = 5;

        public string getKey(Vehicle key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Transmission.ToString());
            elements.Add(key.Category.ToString());
            elements.Add(key.Doors.ToString());
            elements.Add(key.Seats.ToString());

           

            elements.Sort();

            return string.Join("_", elements);
        }

        public VehicleFlyweight GetFlyweight(Vehicle sharedState)
        {
            string key = this.getKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<VehicleFlyweight, string>(new VehicleFlyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }
    }
}
