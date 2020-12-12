using System;

namespace Lab14.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<Category> categories;
        private IRepository<Contact> contacts;

        public UnitOfWork(ContactContext ctx) => context = ctx;

        public IRepository<Category> Categories
        {
            get
            {
                if (categories == null) categories = new Repository<Category>(context);
                return categories;
            }
        }

        public IRepository<Contact> Contacts
        {
            get
            {
                if (contacts == null) contacts = new Repository<Contact>(context);
                return contacts;
            }
        }

        private ContactContext context { get; set; }

        public void Save() => context.SaveChanges();
    }
}