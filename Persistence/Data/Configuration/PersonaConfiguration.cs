using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            {
                builder.HasKey(e => e.Id).HasName("PRIMARY");

                builder.ToTable("persona");

                builder.HasIndex(e => e.CiudadIdCiudad, "fk_Persona_Ciudad1_idx");

                builder.HasIndex(e => e.CategoriaPersonaIdcategoriaPersona, "fk_Persona_categoriaPersona1_idx");

                builder.HasIndex(e => e.TipoPersonaIdtipoPersona, "fk_Persona_tipoPersona1_idx");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("idPersona");
                builder.Property(e => e.CategoriaPersonaIdcategoriaPersona).HasColumnName("categoriaPersona_idcategoriaPersona");
                builder.Property(e => e.CiudadIdCiudad).HasColumnName("Ciudad_idCiudad");
                builder.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
                builder.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .HasColumnName("nombre");
                builder.Property(e => e.TipoPersonaIdtipoPersona).HasColumnName("tipoPersona_idtipoPersona");

                builder.HasOne(d => d.CategoriaPersonaIdcategoriaPersonaNavigation).WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CategoriaPersonaIdcategoriaPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Persona_categoriaPersona1");

                builder.HasOne(d => d.CiudadIdCiudadNavigation).WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CiudadIdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Persona_Ciudad1");

                builder.HasOne(d => d.TipoPersonaIdtipoPersonaNavigation).WithMany(p => p.Personas)
                    .HasForeignKey(d => d.TipoPersonaIdtipoPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Persona_tipoPersona1");
            }
        }
    }
}