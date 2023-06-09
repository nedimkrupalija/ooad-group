using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
    public enum PaymentEnum
    {
        Cash,
        Card
    }

public class PaymentTypeEnum
    {
        [Key]
        public int Id { get; set; }
        public PaymentEnum PaymentType { get; set; }
    }
}
