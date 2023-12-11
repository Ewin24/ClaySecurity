using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Pais : BaseEntity
{
    // public int IdPais { get; set; }

    public string? NombrePais { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
