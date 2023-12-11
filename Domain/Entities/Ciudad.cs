using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Ciudad : BaseEntity
{
    // public int IdCiudad { get; set; }

    public string? NombreCiudad { get; set; }

    public int DepartamentoIdDepartamento { get; set; }

    public virtual Departamento DepartamentoIdDepartamentoNavigation { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
