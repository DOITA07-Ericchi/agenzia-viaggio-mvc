﻿using bootstrap_travel_agency_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace bootstrap_travel_agency_MVC.Databeezu
{
    public class TravelContext:DbContext
    {

        DbSet<Destinazione> Destinazioni { get; set; }
        DbSet<Viaggio> Viaggi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=TravelDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
