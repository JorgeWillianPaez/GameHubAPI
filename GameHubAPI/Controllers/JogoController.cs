using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class JogoController : ControllerBase
{
    private GameHubAPIDbContext? _context;
    public JogoController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<JogoModel>>> Listar()
    {
        if (_context?.Jogo is null) return NotFound();
        return await _context.Jogo.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{id}")]
    public async Task<ActionResult<JogoModel>> Buscar([FromRoute] string id)
    {
        if (_context?.Jogo is null)
            return NotFound();
        JogoModel? jogo = await _context.Jogo.FindAsync(id);
        if (jogo is null)
            return NotFound();
        return jogo;
    }

    [HttpPost]
    [Route("inserir")]
    public ActionResult Inserir(JogoModel jogo)
    {
        _context?.Add(jogo);
        _context?.SaveChanges();
        return Created("", jogo);
    }
}
