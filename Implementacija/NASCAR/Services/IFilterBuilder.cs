namespace NASCAR.Services
{
    public interface IFilterBuilder
    {
        public Filter Build();
        public void SetPrice(int price);
        public void SetCity(string City);
        public void SetYear(string year);
        public void SetCarName(string carName);
    }
}
