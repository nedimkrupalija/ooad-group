using System;
using System.ComponentModel.DataAnnotations;

public class TransmissionEnum
{
    [Key]
    public int id {get;set;}
    public enum transmission {Manual,Automatic}
}