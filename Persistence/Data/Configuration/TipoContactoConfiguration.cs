using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class TipoContactoConfiguration : IEntityTypeConfiguration<Tipocontacto>
    {
        public void Configure(EntityTypeBuilder<Tipocontacto> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipocontacto");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idtipoContacto");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
        }
    }
}