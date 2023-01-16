using bootstrap_travel_agency_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace bootstrap_travel_agency_MVC.Databeezu
{
    public class TravelContext:DbContext
    {

        public DbSet<Destinazione> Destinazioni { get; set; }
        public DbSet<Viaggio> Viaggi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ericchi.moe;Database=TravelAgency;User Id=SA;Password=DatabaseCaconeDegenerato;TrustServerCertificate=True");
        }
    }
}
