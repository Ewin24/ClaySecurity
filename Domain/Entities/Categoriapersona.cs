using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Categoriapersona : BaseEntity
{
    // public int IdcategoriaPersona { get; set; }

    public string? NombreCategoria { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
