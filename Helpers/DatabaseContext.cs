using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public DatabaseContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = Configuration.GetConnectionString("DBConnection");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<User> Users { get; set; }
}