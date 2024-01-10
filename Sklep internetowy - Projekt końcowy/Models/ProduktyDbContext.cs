using Microsoft.EntityFrameworkCore;
using Produkty.Models;
namespace Sklep_internetowy___Projekt_końcowy.Models
{
    public class ProduktyDbContext : DbContext
    {
        public ProduktyDbContext(DbContextOptions<ProduktyDbContext> options) : base(options)
        {

        }
        public DbSet<Produkt> Produkty { get; set; }
    }
}
