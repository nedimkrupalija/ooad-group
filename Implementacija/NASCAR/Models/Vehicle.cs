using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        [DisplayName("Model year")]
        public int? ModelYear { get; set; }
        public bool? IsReserved { get; set; }
        [EnumDataType(typeof(TransmissionEnum))]
        public TransmissionEnum? Transmission { get; set; }
        public double? Mileage { get; set; }
        [EnumDataType(typeof(CategoryEnum))]
        public CategoryEnum? Category { get; set; }
        public string? Description { get; set; }
        public string? Picutre { get; set; }
        public string? Color { get; set; }
        public int? Seats { get; set; }
        public int? Doors { get; set; }

        public Vehicle()
        {
        }
    }
}
