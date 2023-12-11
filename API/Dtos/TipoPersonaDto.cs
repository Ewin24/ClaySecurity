using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class TipoPersonaDto
    {
        public string? Descripcion { get; set; }
    public int Id;

        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}