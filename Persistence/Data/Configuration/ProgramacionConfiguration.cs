using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Infrastructure.Data.Configuration
{
    public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
    {
        public void Configure(EntityTypeBuilder<Programacion> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("programacion");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.ContratoIdcontratoNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("programacion_ibfk_1");

            builder.HasOne(d => d.PersonaIdEmpleadoNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("programacion_ibfk_3");

            builder.HasOne(d => d.TurnosIdturnosNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("programacion_ibfk_2");
        }
    }
}