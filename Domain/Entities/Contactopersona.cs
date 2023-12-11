using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Contactopersona : BaseEntity
{
    // public int IdcontactoPersona { get; set; }

    public string? Descripcion { get; set; }

    public int PersonaIdPersona { get; set; }

    public int TipoContactoIdtipoContacto { get; set; }

    public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;

    public virtual Tipocontacto TipoContactoIdtipoContactoNavigation { get; set; } = null!;
}
