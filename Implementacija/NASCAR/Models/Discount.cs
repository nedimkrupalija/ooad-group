using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public Double DiscountPercent { get; set; }
        public Double DiscountTotal { get; set; }
    }
}

