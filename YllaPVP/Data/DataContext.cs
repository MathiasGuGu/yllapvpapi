using Microsoft.EntityFrameworkCore;

namespace YllaPVP.Data;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
}