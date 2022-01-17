﻿using Microsoft.EntityFrameworkCore;

namespace EntityFramework_pamoka.Models
{
    public class PavyzdinisDbContext : DbContext
    {
        public PavyzdinisDbContext(DbContextOptions<PavyzdinisDbContext> options): base(options) { }


        public DbSet<Savininkas> Savininkai { get; set;}
        public DbSet<Daiktas> Daiktai { get; set;}
        public DbSet<Automobilis> Automobiliai { get; set; }
        public DbSet<Mopedas> Mopedai { get; set; }
        public DbSet<Vartotojas> Vartotojai { get; set; }

    }
}
