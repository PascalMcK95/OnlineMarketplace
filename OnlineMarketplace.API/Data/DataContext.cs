using Microsoft.EntityFrameworkCore;
using OnlineMarketplace.API.Models;

namespace OnlineMarketplace.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){

        }

        public DbSet<Product> Products {get;set;}
    }
}