using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blue.Hammerhead.Data
{
    public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<StoreContext>();

            optionsBuilder.UseSqlite(
                "Data Source=BlueHammerhead.sqlite",
                b => b.MigrationsAssembly("Blue.Hammerhead.Api")
            );

            return new StoreContext(optionsBuilder.Options);
        }
    }
}