using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Direccionpersona : BaseEntity
{
    // public int IddireccionPersona { get; set; }

    public string? Direccion { get; set; }

    public int PersonaIdPersona { get; set; }

    public int TipoDireccionIdtipoDireccion { get; set; }

    public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;

    public virtual Tipodireccion TipoDireccionIdtipoDireccionNavigation { get; set; } = null!;
}
