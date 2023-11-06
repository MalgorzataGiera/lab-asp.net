namespace laboratorium_3___App.Models
{
    public interface IReservationService
    {
        int Add(Reservation book);
        void Delete(int id);
        void Update(Reservation book);
        List<Reservation> FindAll();
        Reservation? FindById(int id);
    }
}
