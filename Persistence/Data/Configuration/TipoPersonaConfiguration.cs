using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<Tipopersona>
    {
        public void Configure(EntityTypeBuilder<Tipopersona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipopersona");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idtipoPersona");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
        }
    }
}