

using Microsoft.EntityFrameworkCore;

namespace AperioIndia
{
#nullable disable
    public class DBAccessVM : DbContext
    {
        public DBAccessVM(DbContextOptions<DBAccessVM> options) : base(options) { }

        public virtual DbSet<AdminLogin> adminLogin { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }    
   
    }
}
