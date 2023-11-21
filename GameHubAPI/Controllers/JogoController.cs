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
    [Route("")]
    public async Task<ActionResult<IEnumerable<JogoModel>>> Listar()
    {
        if (_context?.Jogos is null) return NotFound();
        return await _context.Jogos.ToListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<JogoModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Jogos is null)
            return NotFound();
        JogoModel? jogo = await _context.Jogos.FindAsync(id);
        if (jogo is null)
            return NotFound();
        return jogo;
    }

    public async Task<ActionResult> Alterar(JogoModel jogo)
    {
        _context.Update(jogo);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Inserir(JogoModel jogo)
    {
        await _context.AddAsync(jogo);
        await _context.SaveChangesAsync();
        return Created("", jogo);
    }
}
