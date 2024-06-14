using Microsoft.EntityFrameworkCore;
using PersonApp.Models;

namespace PersonApp.Data
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
    }
}