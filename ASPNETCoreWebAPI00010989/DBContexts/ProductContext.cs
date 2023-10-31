using ASPNETCoreWebAPI00010989.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPI00010989.DBContexts
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
