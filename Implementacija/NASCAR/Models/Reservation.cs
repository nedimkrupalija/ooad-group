using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{

    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Pickup date")]
        [DataType(DataType.Date)]
        public string? PickUpDate { get; set; }

        [DisplayName("Return date")]
        [DataType(DataType.Date)]
        public string? DropDate { get; set; }

        [DisplayName("Total price")]
        [DataType(DataType.Text)]
        public string? Price { get; set; }

        [ForeignKey("RegisteredUser")]
        public string? RegisteredUserId { get; set;}
        public RegisteredUser? RegisteredUser { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        [ForeignKey("Discount")]
        public int? DiscountId { get; set; }
        public Discount? Discount { get; set; }

        [DisplayName("Payment type")]
        [EnumDataType(typeof(PaymentEnum))]
        public PaymentEnum? PaymentType { get; set; }

        public Reservation()
        {
        }

        

    }

}