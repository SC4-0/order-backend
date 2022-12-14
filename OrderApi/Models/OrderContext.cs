using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace OrderApi.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; } = null!;
    }
}