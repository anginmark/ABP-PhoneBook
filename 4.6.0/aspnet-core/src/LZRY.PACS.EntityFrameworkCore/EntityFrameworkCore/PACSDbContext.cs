using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LZRY.PACS.Authorization.Roles;
using LZRY.PACS.Authorization.Users;
using LZRY.PACS.MultiTenancy;
using LZRY.PACS.PhoneBook.Persons;
using LZRY.PACS.PhoneBook.PhoneNumbers;

namespace LZRY.PACS.EntityFrameworkCore
{
    public class PACSDbContext : AbpZeroDbContext<Tenant, Role, User, PACSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PACSDbContext(DbContextOptions<PACSDbContext> options)
            : base(options)
        {
        }

        //获取数据集
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> Phones { get; set; }

        //将实体映射到指定的数据库表

    }
}
