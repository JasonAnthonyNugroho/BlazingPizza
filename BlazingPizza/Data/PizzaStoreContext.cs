using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Data.Common;

namespace BlazingPizza.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions option) : base(option) { 
        
        }

        public DbSet<PizzaSpecial> Specials { get; set; }
    }
}
