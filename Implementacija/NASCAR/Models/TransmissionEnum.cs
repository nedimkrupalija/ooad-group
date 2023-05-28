using System;
using System.ComponentModel.DataAnnotations;

namespace NASCAR.Models
{
    public enum TransmissionEnum
    {
        Manual,
        Automatic
    }


    public class Transmission
    {
        public TransmissionEnum VehicleTransmission { get; set; }
    }
}