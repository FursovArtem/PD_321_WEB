using Microsoft.EntityFrameworkCore;

namespace BlazorAppPD_212.Data
{
    public class BlazorAppPD_212Context : DbContext
    {
        public BlazorAppPD_212Context(DbContextOptions<BlazorAppPD_212Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppPD_212.Models.Teacher> Teacher { get; set; } = default!;
    }
}
