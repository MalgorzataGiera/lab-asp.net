using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace laboratorium_3___App.Models
{
    public class Contact
    {
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Musisz wspiać imię")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imię, maksymalnie 100 znaków")]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Musisz podać adres e-mail")]
        [EmailAddress(ErrorMessage = "Niepoprawny adres email, brak znaku @")]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        [Phone(ErrorMessage = "Niepoprawny numer telefonu, wpisz cytry!")]
        public string Phone { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime Birth { get; set; }
    }

}
