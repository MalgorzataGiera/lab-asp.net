using Data1.Entities;
using System.Numerics;
using System.Xml.Linq;

namespace laboratorium_3___App.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                Name = model.Name,
                Email = model.Email,
                Birth = model.Birth,
                Phone = model.Phone,
                Id = model.Id
            };
        }

        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Name = entity.Name,
                Email = entity.Email,
                Birth = entity.Birth,
                Phone = entity.Phone,
                Id = entity.Id
            };
                
        }
    }
}
