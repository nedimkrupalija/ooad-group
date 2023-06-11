using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{
    
    public abstract class Discount
    {
        [Key]
        public int Id { get; set; }

       
        public Double? DiscountPercent { get; set; }
        
        public Double? DiscountTotal { get; set; }

    }

}

