using System;
using System.ComponentModel.DataAnnotations;

public class CategoryEnum
{
    [Key]
    public int Id { get; set; }
    public enum transmission { Sedan, Sports, SUV, Coupe, Crossover, Minivan, Van, Cabrio };
}
