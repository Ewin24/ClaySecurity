using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class DireccionPersonaDto
    {
        public string? Direccion { get; set; }
    public int Id;

        public int PersonaIdPersona { get; set; }

        public int TipoDireccionIdtipoDireccion { get; set; }

        public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;

        public virtual Tipodireccion TipoDireccionIdtipoDireccionNavigation { get; set; } = null!;
    }
}