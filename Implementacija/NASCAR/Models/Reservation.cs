using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{

    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime PickUp { get; set; }
        public User User { get; set; }
        public Vehicle Vehicle { get; set; }

        public Discount Discount { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public Reservation()
        {
        }
    }

}