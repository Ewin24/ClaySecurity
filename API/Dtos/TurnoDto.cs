using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class TurnoDto
    {
        public string? NombreTurno { get; set; }
    public int Id;

        public TimeOnly? HoraTurnoInicio { get; set; }

        public TimeOnly? HoraTurnoFin { get; set; }

        public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
    }
}