using NASCAR.Code;
using NASCAR.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NASCAR.Models
{
    public class Vehicle
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double? Price { get; set; }
        [DisplayName("Model year")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Please enter valid year")]
        [Required]
        public int? ModelYear { get; set; }

        public bool? IsReserved { get; set; } = false;

        [Required]
        [EnumDataType(typeof(TransmissionEnum))]
        public TransmissionEnum? Transmission { get; set; }
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numbers allowed")]
        [Required]
        public double? Mileage { get; set; }

        [DisplayName("Address ID")]
        [ForeignKey("VehicleAddress")]
        [Required]
        public int VehicleAddressId { get; set; }
        public VehicleAddress? VehicleAddress { get; set; }
        //public ICollection<Reservation>? Reservations { get; set; } = new List<Reservation>();

        [EnumDataType(typeof(CategoryEnum))]
        [DisplayName("Category")]
        [Required]
        public CategoryEnum? Category { get; set; }

        public string? Description { get; set; }
        [Required]
        public string? Picture { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No digits allowed")]
        [Required]
        public string? Color { get; set; }
        [RegularExpression(@"^[1-7]$", ErrorMessage = "Numbers 1-7")]
        [Required]
        public int? Seats { get; set; }
        [RegularExpression(@"^[1-5]$", ErrorMessage = "Numbers 1-5")]
        [Required]
        public int? Doors { get; set; }


       

        public Vehicle()
        {
        }

        public Vehicle(VehicleBuilder builder)
        {
            Name = builder.Name;
            Price = builder.Price;
            ModelYear = builder.ModelYear;
            IsReserved = builder.IsReserved;
            Transmission = builder.Transmission;
            Mileage = builder.Mileage;
            Category = builder.Category;
            Description = builder.Description;
            Picture = builder.Picture;
            Color = builder.Color;
            Seats = builder.Seats;
            Doors = builder.Doors;
            VehicleAddress = builder.Address;
        }
       

    }
}
