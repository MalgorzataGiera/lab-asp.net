using System.Reflection;

namespace laboratorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
            private int _nextId = 1;
            public int Add(Contact item)
        {
            //int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = _nextId++;
                //_contacts.Add(item.Id, item);
                _contacts[item.Id] = item;
                return item.Id;
        }

        public void Delete(int id)
        {
                if (_contacts.ContainsKey(id))
                {
                    _contacts.Remove(id);
                }
            }

        public Dictionary<int, Contact> FindAll()
        {
                return new Dictionary<int, Contact>(_contacts);
            }

        public Contact? FindById(int id)
        {
                _contacts.TryGetValue(id, out var contact);
                return contact;
            }

        public void Update(Contact item)
        {
                if (_contacts.ContainsKey(item.Id))
                {
                    _contacts[item.Id] = item;
                }
            }
    }
}
