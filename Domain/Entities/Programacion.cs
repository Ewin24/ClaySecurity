using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Programacion : BaseEntity
{
    // public int Idprogramacion { get; set; }

    public int TurnosIdturnos { get; set; }

    public int PersonaIdEmpleado { get; set; }

    public int ContratoIdcontrato { get; set; }

    public virtual Contrato ContratoIdcontratoNavigation { get; set; } = null!;

    public virtual Persona PersonaIdEmpleadoNavigation { get; set; } = null!;

    public virtual Turno TurnosIdturnosNavigation { get; set; } = null!;
}
