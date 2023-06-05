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

        [ForeignKey("RegisteredUser")]
        public string RegisteredUserId { get; set;}
        public RegisteredUser? RegisteredUser { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        [NotMapped]
        public Discount? Discount { get; set; }

        [DisplayName("Payment type")]
        [EnumDataType(typeof(PaymentEnum))]
        public PaymentEnum? PaymentType { get; set; }

        public Reservation()
        {
        }
    }

}