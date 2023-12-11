using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class TipoDireccionDto
    {
        public string? Descripcion { get; set; }
    public int Id;

        public virtual ICollection<Direccionpersona> Direccionpersonas { get; set; } = new List<Direccionpersona>();
    }
}