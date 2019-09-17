using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvvmDemo.Data
{
    public class DataStoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItemOption> OrderItemOptions { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Id) // Client must set the ID.
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
