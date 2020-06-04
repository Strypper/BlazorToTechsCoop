using Microsoft.EntityFrameworkCore;
using ToTechsDotNet.Data;

namespace ToTechsDotNet.Database{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Post> Posts { get; set; }
    }
}