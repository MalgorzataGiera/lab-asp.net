namespace laboratorium_3___App.Models
{
    public interface IContactService
    {
        int Add(Contact model);
        void Delete(int id);
        void Update(Contact model);
        Dictionary<int, Contact> FindAll();
        Contact? FindById(int id);
    }
}
