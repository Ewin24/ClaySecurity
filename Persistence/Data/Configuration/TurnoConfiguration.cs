using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class TurnoConfiguration : IEntityTypeConfiguration<Turno>
    {
        public void Configure(EntityTypeBuilder<Turno> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("turnos");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("idturnos");
            builder.Property(e => e.HoraTurnoFin)
                .HasColumnType("time")
                .HasColumnName("horaTurnoFin");
            builder.Property(e => e.HoraTurnoInicio)
                .HasColumnType("time")
                .HasColumnName("horaTurnoInicio");
            builder.Property(e => e.NombreTurno)
                .HasMaxLength(45)
                .HasColumnName("nombreTurno");
        }
    }
}