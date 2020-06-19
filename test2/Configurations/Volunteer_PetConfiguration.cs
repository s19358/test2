using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class Volunteer_PetConfiguration : IEntityTypeConfiguration<Volunteer_Pet>
    {
        public void Configure(EntityTypeBuilder<Volunteer_Pet> en)
        {
            en.HasKey(e => new { e.IdVolunteer, e.IdPet });
            en.Property(e => e.DateAccepted).IsRequired().HasColumnType("date");
        }
    }
}
