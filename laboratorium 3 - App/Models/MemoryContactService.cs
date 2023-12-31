﻿using Data1;
using Data1.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace laboratorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private IDateTimeProvider _timeProvider;

        private readonly AppDbContext _context; //??????

        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public int Add(Contact item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            item.Created = _timeProvider.GetDateTime();
            
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            if(_items.ContainsKey(id))
                return _items[id];
            return null;
        }

        public void Update(Contact item)
        {
            _items[item.Id] = item;
        }

        public List<OrganizationEntity> FindAllOrganizationsForVieModel()
        {
            return _context.Organizations.ToList();
        }
    }
}
