using System;
using System.ComponentModel.DataAnnotations;

public class PaymentTypeEnum
{
    [Key]
    public int id { get;set;}
    public enum payment { Cash,Card }
}
