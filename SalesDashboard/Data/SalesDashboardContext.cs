using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesDashboard.Models;

namespace SalesDashboard.Data
{
    public class SalesDashboardContext : DbContext
    {
        public SalesDashboardContext (DbContextOptions<SalesDashboardContext> options)
            : base(options)
        {
        }

        public DbSet<SalesDashboard.Models.Departments> Departments { get; set; }
    }
}
