using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class ProgressoConquistaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public ProgressoConquistaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<ProgressoConquistaModel>>> Listar()
    {
        if (_context?.ProgressoConquista is null)
            return NotFound();
        return await _context.ProgressoConquista.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<ProgressoConquistaModel>> Buscar([FromRoute] int id)
    {
        if (_context?.ProgressoConquista is null)
            return NotFound();
        ProgressoConquistaModel progressoConquista = await _context.ProgressoConquista.FindAsync(id);
        if (progressoConquista is null)
            return NotFound();
        return progressoConquista;
    }

    [HttpPost]
    [Route("")]
    public IActionResult Inserir(ProgressoConquistaModel progressoConquista)
    {
        _context?.Add(progressoConquista);
        _context?.SaveChanges();
        return Created("", progressoConquista);
    }
}
