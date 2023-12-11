using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class DireccionPersona : IEntityTypeConfiguration<Direccionpersona>
    {
        public void Configure(EntityTypeBuilder<Direccionpersona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("direccionpersona");

            builder.HasIndex(e => e.PersonaIdPersona, "fk_direccionPersona_Persona1_idx");

            builder.HasIndex(e => e.TipoDireccionIdtipoDireccion, "fk_direccionPersona_tipoDireccion1_idx");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("iddireccionPersona");
            builder.Property(e => e.Direccion)
                .HasMaxLength(45)
                .HasColumnName("direccion");
            builder.Property(e => e.PersonaIdPersona).HasColumnName("Persona_idPersona");
            builder.Property(e => e.TipoDireccionIdtipoDireccion).HasColumnName("tipoDireccion_idtipoDireccion");

            builder.HasOne(d => d.PersonaIdPersonaNavigation).WithMany(p => p.Direccionpersonas)
                .HasForeignKey(d => d.PersonaIdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_direccionPersona_Persona1");

            builder.HasOne(d => d.TipoDireccionIdtipoDireccionNavigation).WithMany(p => p.Direccionpersonas)
                .HasForeignKey(d => d.TipoDireccionIdtipoDireccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_direccionPersona_tipoDireccion1");
        }
    }
}