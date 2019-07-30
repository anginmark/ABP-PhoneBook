using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LZRY.PACS.Configuration;
using LZRY.PACS.Web;

namespace LZRY.PACS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PACSDbContextFactory : IDesignTimeDbContextFactory<PACSDbContext>
    {
        public PACSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PACSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PACSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PACSConsts.ConnectionStringName));

            return new PACSDbContext(builder.Options);
        }
    }
}
