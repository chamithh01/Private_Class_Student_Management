using Microsoft.EntityFrameworkCore;

namespace Student_Management_System.Models
{
    public class StDbContext : DbContext
    {

        public StDbContext (DbContextOptions<StDbContext>options): base (options)
        {
        
        }

        public DbSet <Students> Students{ get; set; }
    }
}
