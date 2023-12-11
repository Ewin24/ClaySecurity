using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Persona : BaseEntity
{
    // public int IdPersona { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int CiudadIdCiudad { get; set; }

    public int CategoriaPersonaIdcategoriaPersona { get; set; }

    public int TipoPersonaIdtipoPersona { get; set; }

    public virtual Categoriapersona CategoriaPersonaIdcategoriaPersonaNavigation { get; set; } = null!;

    public virtual Ciudad CiudadIdCiudadNavigation { get; set; } = null!;

    public virtual ICollection<Contactopersona> Contactopersonas { get; set; } = new List<Contactopersona>();

    public virtual ICollection<Contrato> ContratoPersonaIdClienteNavigations { get; set; } = new List<Contrato>();

    public virtual ICollection<Contrato> ContratoPersonaIdEmpleadoNavigations { get; set; } = new List<Contrato>();

    public virtual ICollection<Direccionpersona> Direccionpersonas { get; set; } = new List<Direccionpersona>();

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();

    public virtual Tipopersona TipoPersonaIdtipoPersonaNavigation { get; set; } = null!;
}
