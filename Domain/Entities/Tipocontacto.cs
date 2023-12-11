using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Tipocontacto : BaseEntity
{
    // public int IdtipoContacto { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Contactopersona> Contactopersonas { get; set; } = new List<Contactopersona>();
}
