using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("departamento");

            builder.HasIndex(e => e.PaisIdPais, "fk_Departamento_Pais1_idx");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idDepartamento");
            builder.Property(e => e.NombreDepartamento)
                .HasMaxLength(45)
                .HasColumnName("nombreDepartamento");
            builder.Property(e => e.PaisIdPais).HasColumnName("Pais_IdPais");

            builder.HasOne(d => d.PaisIdPaisNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.PaisIdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Departamento_Pais1");
        }
    }
}