using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers
{

    [ApiController]
    [Route("[usuario]")]
    public class UsuarioController : ControllerBase
    {
        private GameHubAPIDbContext _context;
        public UsuarioController(GameHubAPIDbContext gameHub)
        {
            _context = gameHub;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<ActionResult> Cadastrar(UsuarioModel usuario)
        {
            await _context.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return Created("", usuario);
        }

        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult> Alterar(UsuarioModel usuario)
        {
            _context.Usuario.FindAsync(usuario);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<UsuarioModel>>> Listar()
        {
            if (_context.Usuario is null) return NotFound();
            return await _context.Usuario.ToListAsync();
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public async Task<ActionResult<UsuarioModel>> Buscar(int id)
        {
            if (_context.Usuario is null) return NotFound();
            var usuario = await _context.Usuario.FindAsync(id);
            return usuario;
        }
    }
}
