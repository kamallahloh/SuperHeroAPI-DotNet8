using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Data
{
    public class DataContext : DbContext // to get and store Data in the DataBase
    {
        // BoilerPlate code

        // constructor with parameters from <> and call it options then run the base constructor with these options 
        public DataContext(DbContextOptions<DataContext> options) : base (options) // needed for migration
        {
            
        }

        // property DbSet of Type <> and Name ot the TABLE SuperHeroes
        public DbSet<SuperHero> SuperHeroes { get; set; } // SuperHero Type  // needed for migration

        // we also need a connection string that will be added to the appsettings.json
    }
}
