using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class GameplayController : ControllerBase
{
    private GameHubAPIDbContext? _context;
    public GameplayController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<GameplayModel>>> Listar()
    {
        if (_context?.Gameplay is null) return NotFound();
        return await _context.Gameplay.ToListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<GameplayModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Gameplay is null)
            return NotFound();
        GameplayModel? gameplay = await _context.Gameplay.FindAsync(id);
        if (gameplay is null)
            return NotFound();
        return gameplay;
    }

    [HttpPost]
    [Route("")]
    public ActionResult Inserir(GameplayModel gameplay)
    {
        _context?.Add(gameplay);
        _context?.SaveChanges();
        return Created("", gameplay);
    }
}
