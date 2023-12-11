using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("estado");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idestado");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
        }
    }
}