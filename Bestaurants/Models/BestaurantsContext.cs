using Microsoft.EntityFrameworkCore;

namespace Bestaurants.Models
{
  public class BestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    // the function below is telling LINQ/Entity how to frame the data being retrieved from the database. It's saying " Turn this data into a DbSet of "Restaurant" objects named REstaurants.
    public DbSet<Restaurant> Restaurants { get; set; }

    public BestaurantsContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}