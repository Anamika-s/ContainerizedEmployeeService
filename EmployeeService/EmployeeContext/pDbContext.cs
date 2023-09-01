using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Context
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> context)
            : base(context) { }
        public DbSet<Employee>  Employees { get; set; }
    }
}
