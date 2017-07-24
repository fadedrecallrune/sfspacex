using System.ComponentModel.DataAnnotations;

namespace ShittyFakeSpaceX.Models
{
    public class Flight
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Planet { get; set; }
        [Required]
        public string Station { get; set; }
        public string Terminal { get; set; }
        public string FlightNumber { get; set; }
        public string Time { get; set; }
        [Required]
        public Status Status { get; set; }


    }
    public enum Status
    {
        Arrived,
        Delayed,
        Departed,
        CheckIn,
        OnTime
    }
}
