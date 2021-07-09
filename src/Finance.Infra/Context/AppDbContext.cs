using Finance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Finance.Infra.Context
{
    public class AppDbContext : DbContext
    {
        //private static readonly ILoggerFactory _logger = LoggerFactory.Create(x => x.AddFilter());
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            //.UseLoggerFactory()
            .UseSqlServer("Data Source=localhost;Initial Catalog=Finances;User Id=SA;Password=desenv@12345;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

    }
}