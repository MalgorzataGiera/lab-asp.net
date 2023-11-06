using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace laboratorium_3___App.Models
{
    public enum Rooms
    {
        [Display(Name = "Room 1")]
        Room1 = 1,

        [Display(Name = "Room 2")]
        Room2 = 2,

        [Display(Name = "Room 3")]
        Room3 = 3,

        [Display(Name = "Room 4")]
        Room4 = 4,

        [Display(Name = "Room 5")]
        Room5 = 5
    }
}
