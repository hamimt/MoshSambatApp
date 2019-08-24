using Microsoft.EntityFrameworkCore;
using MoshApp.Models;

namespace MoshApp.Persistence
{
    public class SambatDbContext : DbContext
    {
        public SambatDbContext(DbContextOptions<SambatDbContext> options)
        : base(options)
        {}

        public DbSet<Make> Makes { get; set; }
    }
}