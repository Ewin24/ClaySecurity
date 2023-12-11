using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class CategoriaPersonaConfiguration : IEntityTypeConfiguration<Categoriapersona>
    {
        public void Configure(EntityTypeBuilder<Categoriapersona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("categoriapersona");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idcategoriaPersona");
            builder.Property(e => e.NombreCategoria)
                .HasMaxLength(45)
                .HasColumnName("nombreCategoria");
        }
    }
}