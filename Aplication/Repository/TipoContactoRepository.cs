using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Repository;
using Domain.Interfaces;
using Persistence.Data;
using Persistence.Entities;

namespace Aplication.Repository
{
    public class TipoContactoRepository : GenericRepository<Tipocontacto>, ITipoContacto
    {
        private readonly ProyectoDotnetContext _context;

        public TipoContactoRepository(ProyectoDotnetContext context) : base(context)
        {
            _context = context;
        }
    }
}