using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LZRY.PACS.EntityFrameworkCore
{
    public static class PACSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PACSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PACSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
