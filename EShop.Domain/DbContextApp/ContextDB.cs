using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShop.Domain.DbContextApp
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options): base(options) { }

        #region DbSet

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        #endregion
    }
}
