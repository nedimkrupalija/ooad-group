using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{
    
    public class Discount 
    {
        [Key]
        public int Id { get; set; }

       
        public Double? DiscountPercent { get; set; }
        
        public Double? DiscountTotal { get; set; }

        public Discount(double? discountPercent, double? discountTotal)
        {
         
            DiscountPercent = discountPercent;
            DiscountTotal = discountTotal;
        }
    }

}

