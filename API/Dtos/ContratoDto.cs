using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class ContratoDto
    {
        public DateOnly? FechaContrato { get; set; }

        public DateOnly? FechaFin { get; set; }

        public int EstadoIdestado { get; set; }

        public int PersonaIdCliente { get; set; }

        public int PersonaIdEmpleado { get; set; }
    public int Id;

        public virtual Estado EstadoIdestadoNavigation { get; set; } = null!;
        public virtual Persona PersonaIdClienteNavigation { get; set; } = null!;
        public virtual Persona PersonaIdEmpleadoNavigation { get; set; } = null!;

        public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
    }
}