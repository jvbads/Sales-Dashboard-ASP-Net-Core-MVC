using Microsoft.EntityFrameworkCore;
using SalesDashboard.Models;

namespace SalesDashboard.Data
{
    public class SalesDashboardContext : DbContext
    {
        public SalesDashboardContext (DbContextOptions<SalesDashboardContext> options) : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
