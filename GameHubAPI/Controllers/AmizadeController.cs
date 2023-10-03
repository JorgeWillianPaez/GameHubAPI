using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class AmizadeController : ControllerBase
{
    private GameHubAPIDbContext _context;
    public AmizadeController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Inserir(AmizadeController amizade)
    {
        await _context.AddAsync(amizade);
        await _context.SaveChangesAsync();
        return Created("", amizade);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> Excluir(int id)
    {
        var amizade = await _context.Amizade!.FindAsync(id);
        if (amizade is null) return NotFound();
        _context.Amizade.Remove(amizade);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<AmizadeModel>>> Listar()
    {
        if (_context.Amizade is null) return NotFound();
        return await _context.Amizade.ToListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<AmizadeModel>> Buscar(int id)
    {
        if (_context.Amizade is null) return NotFound();
        var amizade = await _context.Amizade.FindAsync(id);
        return amizade!;
    }
}
