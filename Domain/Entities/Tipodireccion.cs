using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Tipodireccion: BaseEntity
{
    // public int IdtipoDireccion { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Direccionpersona> Direccionpersonas { get; set; } = new List<Direccionpersona>();
}
