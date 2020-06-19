using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.Property(e => e.IdPet).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.isMale).IsRequired();
            builder.Property(e => e.DateRegistered).IsRequired().HasColumnType("date");
            builder.Property(e => e.ApprocimateDateOfBirth).IsRequired().HasColumnType("date");
     
        }

       
    }
}
