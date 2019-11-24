using Microsoft.EntityFrameworkCore;

namespace Fx.Repository
{
    public class FxContext : DbContext
    {
        public DbSet<Price> Prices { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Candle> Candles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FxDB;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Fx;Trusted_Connection=True;");
        }
    }
}