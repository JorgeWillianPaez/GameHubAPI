using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class DesenvolvedoraController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public DesenvolvedoraController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<DesenvolvedoraModel>>> Listar()
    {
        if (_context?.Desenvolvedora is null)
            return NotFound();
        return await _context.Desenvolvedora.ToListAsync();
    }

    [HttpGet()]
    [Route("buscar/{id}")]
    public async Task<ActionResult<DesenvolvedoraModel>> Buscar([FromRoute] string id)
    {
        if (_context?.Desenvolvedora is null)
            return NotFound();
        var desenvolvedora = await _context.Desenvolvedora.FindAsync(id);
        if (desenvolvedora is null)
            return NotFound();
        return desenvolvedora;
    }

    [HttpPost]
    [Route("inserir")]
    public IActionResult Inserir(DesenvolvedoraModel desenvolvedora)
    {
        _context?.Add(desenvolvedora);
        _context?.SaveChanges();
        return Created("", desenvolvedora);
    }
}