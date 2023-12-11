using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class CategoriaPersonaDto
    {
    public int Id;

        public string? NombreCategoria { get; set; }
        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}