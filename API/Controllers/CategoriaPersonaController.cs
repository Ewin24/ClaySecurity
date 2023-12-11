using API.Dtos;
using AutoMapper;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistence.Entities;

namespace API.Controllers
{
    [Authorize(Roles = "Employee")]
    public class CategoriaPersonaController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoriaPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CategoriaPersonaDto>>> Get11()
        {
            var CategoriaPersonas = await _unitOfWork.CategoriaPersonas.GetAllAsync();
            return _mapper.Map<List<CategoriaPersonaDto>>(CategoriaPersonas);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaPersonaDto>> Get(int id)
        {
            var Categoriapersona = await _unitOfWork.CategoriaPersonas.GetByIdAsync(id);
            if (Categoriapersona == null)
                return NotFound();

            return _mapper.Map<CategoriaPersonaDto>(Categoriapersona);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Categoriapersona>> Post(CategoriaPersonaDto CategoriaPersonaDto)
        {
            var Categoriapersona = _mapper.Map<Categoriapersona>(CategoriaPersonaDto);
            _unitOfWork.CategoriaPersonas.Add(Categoriapersona);
            await _unitOfWork.SaveAsync();
            if (Categoriapersona == null)
                return BadRequest();

            CategoriaPersonaDto.Id = Categoriapersona.Id;
            return CreatedAtAction(nameof(Post), new { id = CategoriaPersonaDto.Id }, CategoriaPersonaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoriaPersonaDto>> Put(int id, [FromBody] CategoriaPersonaDto CategoriaPersonaDto)
        {
            if (CategoriaPersonaDto == null)
                return NotFound();

            var CategoriaPersonaBd = await _unitOfWork.CategoriaPersonas.GetByIdAsync(id);
            if (CategoriaPersonaBd == null)
                return NotFound();

            var Categoriapersona = _mapper.Map<Categoriapersona>(CategoriaPersonaDto);
            _unitOfWork.CategoriaPersonas.Update(Categoriapersona);
            await _unitOfWork.SaveAsync();
            return CategoriaPersonaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Categoriapersona = await _unitOfWork.CategoriaPersonas.GetByIdAsync(id);
            if (Categoriapersona == null)
                return NotFound();

            _unitOfWork.CategoriaPersonas.Delete(Categoriapersona);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}