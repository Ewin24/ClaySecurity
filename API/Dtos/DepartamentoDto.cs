using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class DepartamentoDto
    {
        public string? NombreDepartamento { get; set; }
    public int Id;

        public int PaisIdPais { get; set; }

        public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

        public virtual Pais PaisIdPaisNavigation { get; set; } = null!;
    }
}