using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class TipoContactoDto
    {
        public int TurnosIdturnos { get; set; }
        public int Id;

        public int PersonaIdEmpleado { get; set; }

        public int ContratoIdcontrato { get; set; }

        public virtual Contrato ContratoIdcontratoNavigation { get; set; } = null!;

        public virtual Persona PersonaIdEmpleadoNavigation { get; set; } = null!;

        public virtual Turno TurnosIdturnosNavigation { get; set; } = null!;
    }
}