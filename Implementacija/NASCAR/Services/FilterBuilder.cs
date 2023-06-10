namespace NASCAR.Services
{
    public class FilterBuilder : IFilterBuilder
    {
        public string? city { get; private set; } = null;
        public int? price { get; private set; } = null;
        public string? carName { get; private set; } = null; 
        public string? year { get; private set; } = null;
        public Filter Build()
        {
            return new Filter(this);
        }

        public void SetCarName(string carName)
        {
            this.carName = carName;
            
        }

        public void SetCity(string City)
        {
            this.city = City;
            
       }

        public void SetPrice(int price)
        {
            if(price>0 && price <10000)
            this.price = price;
          
        }

        public void SetYear(string year)
        {
            try
            {
                if (Convert.ToInt32(year) > 1900 && Convert.ToInt32(year) < 2023)
                    this.year = year;
            }
            catch(Exception ex)
            {
                this.year = "0";
            }
            
        }

       
    }
}
