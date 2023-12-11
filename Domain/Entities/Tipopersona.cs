using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Tipopersona : BaseEntity
{
    // public int IdtipoPersona { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
