using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QuickStart.EntityFrameworkCore
{
    public static class QuickStartDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QuickStartDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QuickStartDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
