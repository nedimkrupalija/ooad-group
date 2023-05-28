using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{

    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public string? PickUpDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        [ForeignKey("Discount")]
        public int DiscountId { get; set; } 
        public Discount? Discount { get; set; }
        public PaymentEnum? PaymentType { get; set; }
        public Reservation()
        {
        }
    }

}