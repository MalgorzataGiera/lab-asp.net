using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace laboratorium_3___App.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz wspiać datę")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Musisz wpisać miasto")]
        public string City { get; set; }
        [Required(ErrorMessage = "Musisz podać adres")]
        public string Address { get; set; }

        public int Room { get; set; }
        [Required(ErrorMessage = "Musisz wpisać właściela")]
        public string Owner { get; set; }
        [Required(ErrorMessage = "Musisz wpisać cenę")]
        public decimal Price { get; set; }
    }

}
