using Microsoft.EntityFrameworkCore;

namespace WebAPI_01.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options): base(options) { }

        #region DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        #endregion
    }
}
