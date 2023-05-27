using System;

public class Reservation
{
    public int Id { get; set; }
    public DateTime pickUp { get; set; }
    public User user { get; set; }
    public Vehicle vehicle { get; set; }

    public Discount discount { get; set; }
    public PaymentTypeEnum returnTime { get; set; }
    public Reservation()
    {
    }
}