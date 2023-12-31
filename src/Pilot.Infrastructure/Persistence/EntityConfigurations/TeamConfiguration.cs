using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pilot.Domain.Entities;

namespace Pilot.Infrastructure.Persistence.EntityConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("TEAM");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .ValueGeneratedNever();

            builder.Property(x => x.Name)
            .HasColumnName("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Country)
            .HasColumnName("varchar(50)")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x => x.Competitions)
            .HasColumnName("varchar(100)")
            .HasMaxLength(100)
            .IsRequired();


        }
    }
}