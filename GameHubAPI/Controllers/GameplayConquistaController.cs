using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class GameplayConquistaController : ControllerBase
{
    private GameHubAPIDbContext? _context;
    public GameplayConquistaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<GameplayConquistaModel>>> Listar()
    {
        if (_context?.GameplayConquista is null) return NotFound();
        return await _context.GameplayConquista.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{id}")]
    public async Task<ActionResult<GameplayConquistaModel>> Buscar([FromRoute] string id)
    {
        if (_context?.Jogo is null)
            return NotFound();
        GameplayConquistaModel? gameplayConquista = await _context.GameplayConquista!.FindAsync(id);
        if (gameplayConquista is null)
            return NotFound();
        return gameplayConquista;
    }

    [HttpPost]
    [Route("inserir")]
    public ActionResult Inserir(JogoModel gameplayConquista)
    {
        _context?.Add(gameplayConquista);
        _context?.SaveChanges();
        return Created("", gameplayConquista);
    }
}
