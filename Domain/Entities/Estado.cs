using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Estado : BaseEntity
{
    // public int Idestado { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
