using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QuickStart.Authorization.Roles;
using QuickStart.Authorization.Users;
using QuickStart.MultiTenancy;
using QuickStart.City;
using QuickStart.District;
using QuickStart.CardInfo;

namespace QuickStart.EntityFrameworkCore
{
    public class QuickStartDbContext : AbpZeroDbContext<Tenant, Role, User, QuickStartDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<CityEntity> Citys { get; set; }
        public DbSet<DistrictEntity> Districts { get; set; }
        public DbSet<CardInfoEntity> CardInfos { get; set; }

        public QuickStartDbContext(DbContextOptions<QuickStartDbContext> options)
            : base(options)
        {
        }
    }
}
