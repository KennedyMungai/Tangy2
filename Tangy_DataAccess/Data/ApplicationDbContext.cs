using Microsoft.EntityFrameworkCore;

namespace Tangy_DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}