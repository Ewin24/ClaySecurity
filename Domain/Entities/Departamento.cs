using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Departamento : BaseEntity
{
    // public int IdDepartamento { get; set; }

    public string? NombreDepartamento { get; set; }

    public int PaisIdPais { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Pais PaisIdPaisNavigation { get; set; } = null!;
}
