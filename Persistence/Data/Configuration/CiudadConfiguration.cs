using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {


        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("ciudad");

            builder.HasIndex(e => e.DepartamentoIdDepartamento, "fk_Ciudad_Departamento1_idx");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idCiudad");
            builder.Property(e => e.DepartamentoIdDepartamento).HasColumnName("Departamento_idDepartamento");
            builder.Property(e => e.NombreCiudad).HasMaxLength(45);

            builder.HasOne(d => d.DepartamentoIdDepartamentoNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.DepartamentoIdDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Ciudad_Departamento1");
        }
    }
}