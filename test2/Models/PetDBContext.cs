using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Configurations;

namespace test2.Models
{
    public class PetDBContext : DbContext
    {

        //dbsets

        public DbSet<BreedType> BreedType { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Volunteer_Pet> Volunteer_Pet { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public PetDBContext()
        {

        }
        public PetDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BreedTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder.ApplyConfiguration(new Volunteer_PetConfiguration());
            modelBuilder.ApplyConfiguration(new VolunteerConfiguration());

          
        }
    }
}
