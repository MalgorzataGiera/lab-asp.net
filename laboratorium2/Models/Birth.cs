using System.ComponentModel.DataAnnotations;

namespace laboratorium2.Models
{
    public class Birth
    {
        public string? Imie { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataUrodzenia { get; set; }

        private DateTime dzisiaj = DateTime.Now;

        public bool IsValid()
        {
            return Imie != null && DataUrodzenia < dzisiaj;
        }

        public int Wiek()
        {
            int wynik;
            wynik = dzisiaj.Year - DataUrodzenia.Year;

            if (dzisiaj.Month < DataUrodzenia.Month)
                return wynik - 1;
            else if (dzisiaj.Month == DataUrodzenia.Month && dzisiaj.Day < DataUrodzenia.Day)
                return wynik - 1;
            else
                return wynik;
        }
    }

    
}
