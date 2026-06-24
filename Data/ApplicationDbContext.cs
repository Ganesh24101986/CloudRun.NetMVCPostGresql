using DotNetCoerMVCProjectCloudRUN.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoerMVCProjectCloudRUN.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
