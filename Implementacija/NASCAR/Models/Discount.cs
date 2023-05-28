using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }

        /*[ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }*/

        public Double? DiscountPercent { get; set; }
        public Double? DiscountTotal { get; set; }
    }
}

