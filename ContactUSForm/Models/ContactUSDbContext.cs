
using Microsoft.EntityFrameworkCore;

namespace ContactUSForm.Models
{
    public class ContactUSDbContext : DbContext
    {
        public ContactUSDbContext(DbContextOptions<ContactUSDbContext> options) : base(options)
        {

        }
        public DbSet<ContactUSFormModel> ContactUsForms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   
        }
    }
}
