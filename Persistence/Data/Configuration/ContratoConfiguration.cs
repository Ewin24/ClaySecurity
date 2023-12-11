using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contrato");

            builder.HasIndex(e => e.PersonaIdCliente, "fk_contrato_Persona1_idx");

            builder.HasIndex(e => e.PersonaIdEmpleado, "fk_contrato_Persona2_idx");

            builder.HasIndex(e => e.EstadoIdestado, "fk_contrato_estado1_idx");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idcontrato");
            builder.Property(e => e.EstadoIdestado).HasColumnName("estado_idestado");
            builder.Property(e => e.FechaContrato).HasColumnName("fechaContrato");
            builder.Property(e => e.FechaFin).HasColumnName("fechaFin");
            builder.Property(e => e.PersonaIdCliente).HasColumnName("Persona_idCliente");
            builder.Property(e => e.PersonaIdEmpleado).HasColumnName("Persona_idEmpleado");

            builder.HasOne(d => d.EstadoIdestadoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.EstadoIdestado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contrato_estado1");

            builder.HasOne(d => d.PersonaIdClienteNavigation).WithMany(p => p.ContratoPersonaIdClienteNavigations)
                .HasForeignKey(d => d.PersonaIdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contrato_Persona1");

            builder.HasOne(d => d.PersonaIdEmpleadoNavigation).WithMany(p => p.ContratoPersonaIdEmpleadoNavigations)
                .HasForeignKey(d => d.PersonaIdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contrato_Persona2");
        }
    }
}