using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class ContactoPersonaDto
    {
        public string? Descripcion { get; set; }
        public int Id;

        public int PersonaIdPersona { get; set; }

        public int TipoContactoIdtipoContacto { get; set; }

        public virtual Persona PersonaIdPersonaNavigation { get; set; } = null!;

        public virtual Tipocontacto TipoContactoIdtipoContactoNavigation { get; set; } = null!;
    }
}