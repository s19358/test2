using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.Property(e => e.IdVolunteer).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Surname).IsRequired();
            builder.Property(e => e.Phone).IsRequired();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.StartingDate).IsRequired().HasColumnType("date");
        }
    }
}
