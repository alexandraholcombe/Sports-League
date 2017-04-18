using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportsLeague.Models
{
    public class SportsLeagueContext : DbContext
    {
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SportsLeague;integrated security=True");
        }
    }
}
