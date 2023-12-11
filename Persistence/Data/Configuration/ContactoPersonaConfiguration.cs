using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class ContactoPersonaConfiguration : IEntityTypeConfiguration<Contactopersona>
    {
        public void Configure(EntityTypeBuilder<Contactopersona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contactopersona");

            builder.HasIndex(e => e.PersonaIdPersona, "fk_contactoPersona_Persona1_idx");

            builder.HasIndex(e => e.TipoContactoIdtipoContacto, "fk_contactoPersona_tipoContacto1_idx");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idcontactoPersona");
            builder.Property(e => e.Descripcion)
                .HasMaxLength(45)
                .HasColumnName("descripcion");
            builder.Property(e => e.PersonaIdPersona).HasColumnName("Persona_idPersona");
            builder.Property(e => e.TipoContactoIdtipoContacto).HasColumnName("tipoContacto_idtipoContacto");

            builder.HasOne(d => d.PersonaIdPersonaNavigation).WithMany(p => p.Contactopersonas)
                .HasForeignKey(d => d.PersonaIdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contactoPersona_Persona1");

            builder.HasOne(d => d.TipoContactoIdtipoContactoNavigation).WithMany(p => p.Contactopersonas)
                .HasForeignKey(d => d.TipoContactoIdtipoContacto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contactoPersona_tipoContacto1");
        }
    }
}