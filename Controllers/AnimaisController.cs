using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoVetAdopt.Api.Data;
using ProjetoVetAdopt.Api.Models;
using ProjetoVetAdopt.Api.Models.DTOs;

namespace ProjetoVetAdopt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AnimaisController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CriarAnimal(CriarAnimalDto dto)
        {
            var novoAnimal = new Animal
            {
                Nome = dto.Nome,
                Especie = dto.Especie,
                Idade = dto.Idade,
                AbrigoId = dto.AbrigoId,
                Status = "Aguardando Avaliação Veterinária"
            };

            _context.Animais.Add(novoAnimal);
            await _context.SaveChangesAsync();

            return Ok("Animal criado com sucesso");
        }

        [HttpGet]
        public async Task<ActionResult<List<AnimalDto>>> GetAnimais()
        {
            var animais = await _context.Animais.
                                        Include(a => a.Abrigo)
                                        .Select(a => new AnimalDto
                                        {
                                            Nome = a.Nome,
                                            Especie = a.Especie,
                                            Idade = a.Idade,
                                            NomeAbrigo = a.Abrigo.Nome,
                                            Estado = a.Abrigo.Estado,
                                            Cidade = a.Abrigo.Cidade
                                        })
                                        .ToListAsync();

            return Ok(animais);

        }
    }
}
