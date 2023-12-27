using Microsoft.EntityFrameworkCore;

namespace RazorPages.Models
{
    /// <summary>
    /// Create a session with the database for querying and storing instances of entities.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
