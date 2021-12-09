using CrudHHF.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudHHF.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Partido> Partido { get; set; }

        public DbSet<Organizador> Organizador { get; set; }
        public DbSet<Jugador> Jugador { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entiy =>  entiy.ToTable(name: "Users"));
            builder.Entity<IdentityRole>(entiy =>  entiy.ToTable(name: "Roles"));
            builder.Entity<IdentityUserRole<string>>(entiy =>  entiy.ToTable(name: "UserRole"));
            builder.Entity<IdentityUserClaim<string>>(entiy =>  entiy.ToTable(name: "UserClaim"));
            builder.Entity<IdentityUserLogin<string>>(entiy =>  entiy.ToTable(name: "UserLogin"));
            builder.Entity<IdentityRoleClaim<string>>(entiy =>  entiy.ToTable(name: "RoleClaim"));
            builder.Entity<IdentityUserToken<string>>(entiy =>  entiy.ToTable(name: "UserToken")); //cambia nombre a las tablas
        }

    }


}
