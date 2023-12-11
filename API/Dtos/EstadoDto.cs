using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Entities;

namespace API.Dtos
{
    public class EstadoDto
    {
        public string? Descripcion { get; set; }
    public int Id;

        public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
    }
}