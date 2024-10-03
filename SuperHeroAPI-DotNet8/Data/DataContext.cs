using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Data
{
    public class DataContext : DbContext // to get and store Data in the DataBase
    {
        // BoilerPlate code
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
