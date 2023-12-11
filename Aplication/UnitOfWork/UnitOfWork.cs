using Aplication.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Data;
using Persistence.Entities;
namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ProyectoDotnetContext _context;
    public UnitOfWork(ProyectoDotnetContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }

    public ICategoriaPersona _categoriaPersonas;

    public ICategoriaPersona CategoriaPersonas
    {
        get
        {
            if (_categoriaPersonas == null)
            {
                _categoriaPersonas = new CategoriaPersonaRepository(_context);
            }
            return _categoriaPersonas;
        }
    }

    public ICiudad _ciudades;
    public ICiudad Ciudades
    {
        get
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context);
            }
            return _ciudades;
        }
    }

    public IContactoPersona _contactoPersonas;
    public IContactoPersona ContactoPersonas
    {
        get
        {
            if (_contactoPersonas == null)
            {
                _contactoPersonas = new ContactoPersonaRepository(_context);
            }
            return _contactoPersonas;
        }
    }

    public IContrato _contratos;
    public IContrato Contratos
    {
        get
        {
            if (_contratos == null)
            {
                _contratos = new ContratoRepository(_context);
            }
            return _contratos;
        }
    }

    public IDepartamento _departamentos;
    public IDepartamento Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }

    public IDireccionPersona _direccionPersonas;
    public IDireccionPersona DireccionPersonas
    {
        get
        {
            if (_direccionPersonas == null)
            {
                _direccionPersonas = new DireccionPersonaRepository(_context);
            }
            return _direccionPersonas;
        }
    }

    public IEstado _estados;
    public IEstado Estados
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }

    public IPais _paises;
    public IPais Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context);
            }
            return _paises;
        }
    }

    public IPersona _personas;
    public IPersona Personas
    {
        get
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(_context);
            }
            return _personas;
        }
    }

    public IProgramacion _programaciones;
    public IProgramacion Programaciones
    {
        get
        {
            if (_programaciones == null)
            {
                _programaciones = new ProgramacionRepository(_context);
            }
            return _programaciones;
        }
    }

    public ITipoContacto _tipoContactos;
    public ITipoContacto TipoContactos
    {
        get
        {
            if (_tipoContactos == null)
            {
                _tipoContactos = new TipoContactoRepository(_context);
            }
            return _tipoContactos;
        }
    }
    public ITipoDireccion _tipoDirecciones;
    public ITipoDireccion TipoDirecciones
    {
        get
        {
            if (_tipoDirecciones == null)
            {
                _tipoDirecciones = new TipoDireccionRepository(_context);
            }
            return _tipoDirecciones;
        }
    }

    public ITipoPersona _tipoPersonas;
    public ITipoPersona TipoPersonas
    {
        get
        {
            if (_tipoPersonas == null)
            {
                _tipoPersonas = new TipoPersonaRepository(_context);
            }
            return _tipoPersonas;
        }
    }

    public ITurno _turnos;
    public ITurno Turnos
    {
        get
        {
            if (_turnos == null)
            {
                _turnos = new TurnoRepository(_context);
            }
            return _turnos;
        }
    }

    public ITurno ITurnos => throw new NotImplementedException();

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public DbSet<T> Set<T>() where T : class
    {
        throw new NotImplementedException();
    }
}