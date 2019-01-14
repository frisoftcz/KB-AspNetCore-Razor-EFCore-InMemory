using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KB_AspNetCore_Razor_EFCore_InMemory.Model
{
  public class InMemoryDbContext : DbContext
  {
    public DbSet<EntFyzOsoba> EntFyzOsoba { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseInMemoryDatabase(databaseName: "DbParty");
    }

    public void Seed(int numberOfEntities1 = 10)
    {
      if (!this.EntFyzOsoba.Any())
      {
        this.EntFyzOsoba.Add(new EntFyzOsoba {
          ID = "20190114222300000001",
          FYZOSOBA_PRIJMENI = "Ducháček",
          FYZOSOBA_JMENO = "Jan",
          FYZOSOBA_DATUM_NAROZENI = DateTime.Parse("21.5.1931"),
          POZNAMKA = "Bez něj by to nešlo" });
        this.EntFyzOsoba.Add(new EntFyzOsoba
        {
          ID = "20190114222300000002",
          FYZOSOBA_PRIJMENI = "Faukner",
          FYZOSOBA_JMENO = "Jiří",
          FYZOSOBA_DATUM_NAROZENI = DateTime.Parse("1.8.1939"),
          POZNAMKA = "Zamilovaný strážce majáku"
        });
        this.SaveChanges();
      }
    }
  }
}
