using Microsoft.EntityFrameworkCore;
using RentManagement.Domain.Models;

namespace RentManagement.Infrastructure.Contrct
{
    public class RentDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connecttionString = "Data Source=DESKTOP-H8JK0LS;Initial Catalog=TolateDba;User Id=sa;Password=abcd123!";
            optionsBuilder.UseSqlServer(connecttionString);
        }
    }
    
    
}