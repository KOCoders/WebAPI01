using Microsoft.EntityFrameworkCore;

namespace WebAPI_01.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options): base(options) { }

        #region DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(e => {
                e.ToTable("Order");
                e.HasKey(o => o.ID);
                e.Property(o=> o.OrderDate).HasDefaultValueSql("getutcdate()");
            });


            modelBuilder.Entity<OrderDetail>(e =>
            {
                e.ToTable("OrderDetail");
                e.HasKey(e => new { e.OrderID, e.ProductID });

                e.HasOne(e => e.Order)
                .WithMany(e => e.OrderDetails)
                .HasForeignKey(e => e.OrderID)
                .HasConstraintName("FK_OderDetail_Order");

                e.HasOne(e => e.Product)
               .WithMany(e => e.OrderDetails)
               .HasForeignKey(e => e.ProductID)
               .HasConstraintName("FK_OderDetail_Product");

            });
        }
    }
}
