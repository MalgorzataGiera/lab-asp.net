using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace laboratorium_3___App.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Musisz wspiać datę")]
        public DateTime Date { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Musisz wpisać miasto")]
        public string City { get; set; }
         
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Musisz podać adres")]
        public string Address { get; set; }

        [Display(Name = "Room")]
        [Required(ErrorMessage = "Musisz podać numer pokoju")]
        public Rooms Room { get; set; }

        [Display(Name = "Owner")]
        [Required(ErrorMessage = "Musisz wpisać właściela")]
        public string Owner { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Musisz wpisać cenę")]
        public decimal Price { get; set; }
    }

}
