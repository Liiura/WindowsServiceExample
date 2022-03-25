using System.Data.Entity;
using WindowsServiceExample.Data.Models;

namespace WindowsServiceExample.Data.Contexts
{
    public class ProductsHttpContext : DbContext
    {
        public ProductsHttpContext() : base("ProductsHttpDB")
        {

        }
        public virtual DbSet<Product> Product { get; set; }
    }
}
