using ECommerce.Data.Entiry.Masters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CategoryMaster> CategoryMaster { get; set; }
        public DbSet<DepartmentMaster> DepartmentMaster { get; set; }
        public DbSet<ItemMaster> ItemMaster { get; set; }
        public DbSet<ItemsDiscountDetails> ItemsDiscountDetails { get; set; }
        public DbSet<ItemsImagesDetails> ItemsImagesDetails { get; set; }
        public DbSet<UnitMaster> UnitMaster { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

    }
}
