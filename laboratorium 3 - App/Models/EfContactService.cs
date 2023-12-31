﻿using Data1;
using Data1.Entities;
using SQLitePCL;

namespace laboratorium_3___App.Models
{
    public class EfContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EfContactService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Contact contact)
        {
            var entity = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            int id = entity.Entity.Id;
            _context.SaveChanges();
            return id;
        }

        public void Delete(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            if(find != null)
            {
                _context.Contacts.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList();
        }


        public Contact? FindById(int id)
        {
            ContactEntity? find = _context.Contacts.Find(id);
            return find == null ? null : ContactMapper.FromEntity(find);
        }

        public void Update(Contact contact)
        {
            ContactEntity entity = ContactMapper.ToEntity(contact);
            _context.Update(entity);
            _context.SaveChanges();
        }


        public List<OrganizationEntity> FindAllOrganizationsForVieModel()
        {
            return _context.Organizations.ToList();
        }
    }
}
