using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCompany.Authorization.Roles;
using MyCompany.Authorization.Users;
using MyCompany.MultiTenancy;

namespace MyCompany.EntityFrameworkCore
{
    public class MyCompanyDbContext : AbpZeroDbContext<Tenant, Role, User, MyCompanyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyCompanyDbContext(DbContextOptions<MyCompanyDbContext> options)
            : base(options)
        {
        }
    }
}
