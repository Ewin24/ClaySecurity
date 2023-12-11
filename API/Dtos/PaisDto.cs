using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class PaisDto
    {
        public string? NombrePais { get; set; }
    public int Id;

        public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
    }
}