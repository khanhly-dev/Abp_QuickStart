using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using QuickStart.Configuration;
using QuickStart.Web;

namespace QuickStart.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class QuickStartDbContextFactory : IDesignTimeDbContextFactory<QuickStartDbContext>
    {
        public QuickStartDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QuickStartDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            QuickStartDbContextConfigurer.Configure(builder, configuration.GetConnectionString(QuickStartConsts.ConnectionStringName));

            return new QuickStartDbContext(builder.Options);
        }
    }
}
