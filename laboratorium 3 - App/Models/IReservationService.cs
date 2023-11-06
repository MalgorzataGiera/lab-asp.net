namespace laboratorium_3___App.Models
{
    public interface IReservationService
    {
        int Add(Contact book);
        void Delete(int id);
        void Update(Contact book);
        List<Contact> FindAll();
        Contact? FindById(int id);
    }
}
