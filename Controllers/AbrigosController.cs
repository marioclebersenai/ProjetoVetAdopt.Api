using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoVetAdopt.Api.Data;
using ProjetoVetAdopt.Api.Models;
using ProjetoVetAdopt.Api.Models.DTOs;

namespace ProjetoVetAdopt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbrigosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AbrigosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CriarAbrigo(CriarAbrigoDto dto)
        {
            var novoAbrigo = new Abrigo
            {
                Cidade = dto.Cidade,
                Endereco = dto.Endereco,
                ChavePix = dto.ChavePix,
                Estado = dto.Estado,
                Nome = dto.Nome,
                Telefone = dto.Telefone
            };

            _context.Abrigos.Add(novoAbrigo);
            await _context.SaveChangesAsync();

            return Ok("Abrigo criado com sucesso");
        }
    }
}
