using Microsoft.EntityFrameworkCore;
using StemApp.API.Models;

namespace StemApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Values> Values { get; set; }

    }
}