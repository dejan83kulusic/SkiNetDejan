
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContex : DbContext
    {
        public StoreContex(DbContextOptions<StoreContex> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }= default!;
    }
}