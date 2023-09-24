using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers
{
    
    [ApiController]
    [Route("[compra]")]
    public class CompraController : ControllerBase
    {
        private GameHubAPIDbContext _context;
        public CompraController(GameHubAPIDbContext gameHub)
        {
            _context = gameHub;
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<ActionResult> Inserir(CompraModel compra)
        {
            await _context.AddAsync(compra);
            await _context.SaveChangesAsync();
            return Created("", compra);
        }

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<IEnumerable<CompraModel>>> Listar()
        {
            if (_context.Compra is null) return NotFound();
            return await _context.Compra.ToListAsync();
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public async Task<ActionResult<CompraModel>> Buscar(int id)
        {
            if (_context.Compra is null) return NotFound();
            var compra = await _context.Compra.FindAsync(id);
            return compra;
        }
    }
}
