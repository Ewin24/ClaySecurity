using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Contrato : BaseEntity
{
    // public int Idcontrato { get; set; }

    public DateOnly? FechaContrato { get; set; }

    public DateOnly? FechaFin { get; set; }

    public int EstadoIdestado { get; set; }

    public int PersonaIdCliente { get; set; }

    public int PersonaIdEmpleado { get; set; }

    public virtual Estado EstadoIdestadoNavigation { get; set; } = null!;

    public virtual Persona PersonaIdClienteNavigation { get; set; } = null!;

    public virtual Persona PersonaIdEmpleadoNavigation { get; set; } = null!;

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
