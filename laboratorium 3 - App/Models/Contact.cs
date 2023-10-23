using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace laboratorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz wspiać imię")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imię, maksymalnie 100 znaków")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Musisz podać adres e-mail")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email, brak znaku @")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Niepoprawny numer telefonu, wpisz cytry!")]
        public string Phone { get; set; }

        public DateTime Birth { get; set; }
    }

}
