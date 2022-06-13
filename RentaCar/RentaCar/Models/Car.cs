using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public int SeatCount { get; set; }
        public string Luggage { get; set; }
        public bool Transmission { get; set; }
        public bool AirConditioning { get; set; }
        public int MinAge { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}
