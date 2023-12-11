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
    public class TipoDireccionRepository : GenericRepository<Tipodireccion>, ITipoDireccion
    {
        private readonly ProyectoDotnetContext _context;

        public TipoDireccionRepository(ProyectoDotnetContext context) : base(context)
        {
            _context = context;
        }
    }
}