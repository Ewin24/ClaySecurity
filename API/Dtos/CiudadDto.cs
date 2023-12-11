using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class CiudadDto
    {
        public string? NombreCiudad { get; set; }
    public int Id;

        public int DepartamentoIdDepartamento { get; set; }

        public virtual Departamento DepartamentoIdDepartamentoNavigation { get; set; } = null!;

        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}