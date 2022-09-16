using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Data
{
    public class ContactsAPIdbContext : DbContext //Base class
    {
        // constructor
        public ContactsAPIdbContext(DbContextOptions options) : base(options)
        {
        }
        // This is property that act as table <contact> important from models
        public DbSet<Contact> Contacts { get; set; }
    }
}