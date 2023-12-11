using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    DbSet<T> Set<T>() where T : class;
    ICategoriaPersona CategoriaPersonas { get; }
    ICiudad Ciudades { get; }
    IContactoPersona ContactoPersonas { get; }
    IContrato Contratos { get; }
    IDepartamento Departamentos { get; }
    IDireccionPersona DireccionPersonas { get; }
    IEstado Estados { get; }
    IPais Paises { get; }
    IPersona Personas { get; }
    IProgramacion Programaciones { get; }
    ITipoContacto TipoContactos { get; }
    ITipoDireccion TipoDirecciones { get; }
    ITipoPersona TipoPersonas { get; }
    ITurno ITurnos { get; }
    Task<int> SaveAsync();
}

