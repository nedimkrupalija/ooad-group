using System;

public class Vehicle
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double price { get; set; }
    public int modelYear { get; set; }
    public bool isReserved { get; set; }
    public TransmissionEnum transmission { get; set; }
    public double mileage { get; set; }
    public CategoryEnum category { get; set; }
    public string description { get; set; }
    public string picture { get; set; }
    public string color { get; set; }
    public int seats { get; set; }
    public int doors { get; set; }

    public Vehicle()
	{
	}
}
