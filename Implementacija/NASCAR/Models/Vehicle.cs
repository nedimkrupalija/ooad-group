using System;

public class Vehicle
{
    int vehicleId;
    String name;
    int price;
    int modelYear;
    Boolean isReserved;
    TransmissionEnum transmission;
    Decimal mileage;
    FuelTypeEnum fuelType;
    String picture;
    String color;
    int seatsNo;
    int doorsNo;

    public int VehicleId { get => vehicleId; set => vehicleId = value; }
    public String Name { get => name; set => name = value; }
    public int Price { get => price; set => price = value; }
    public int ModelYear { get => modelYear; set => modelYear = value; }
    public bool IsReserved { get => isReserved; set => isReserved = value; }
    public TransmissionEnum Transmission { get => transmission; set => transmission = value; }  
    public Decimal Mileage { get => mileage; set => mileage = value; }  
    public FuelTypeEnum FuelType { get => fuelType; set => fuelType = value; }  
    public String Picture { get => picture; set => picture = value; }   
    public String Color { get => color; set => color = value; } 
    public int SeatsNo { get => seatsNo; set => seatsNo = value; }  
    public int DoorsNo { get => doorsNo; set => doorsNo = value; }  


    public Vehicle()
	{
	}
}
