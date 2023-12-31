﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Data;

public partial class ProyectoDotnetContext : DbContext
{
    public ProyectoDotnetContext()
    {
    }

    public ProyectoDotnetContext(DbContextOptions<ProyectoDotnetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoriapersona> Categoriapersonas { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Contactopersona> Contactopersonas { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Direccionpersona> Direccionpersonas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Pais> Paises { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Programacion> Programacions { get; set; }

    public virtual DbSet<Tipocontacto> Tipocontactos { get; set; }

    public virtual DbSet<Tipodireccion> Tipodireccions { get; set; }

    public virtual DbSet<Tipopersona> Tipopersonas { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
