using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Turno : BaseEntity
{
    // public int Idturnos { get; set; }

    public string? NombreTurno { get; set; }

    public TimeOnly? HoraTurnoInicio { get; set; }

    public TimeOnly? HoraTurnoFin { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
