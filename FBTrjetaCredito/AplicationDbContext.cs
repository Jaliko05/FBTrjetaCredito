using FBTrjetaCredito.Models;
using Microsoft.EntityFrameworkCore;

namespace FBTrjetaCredito
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; } 
        public AplicationDbContext(DbContextOptions <AplicationDbContext> options):base(options)
        {

        }

    }
}
