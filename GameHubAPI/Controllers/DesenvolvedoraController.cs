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
    [Route("")]
    public async Task<ActionResult<IEnumerable<DesenvolvedoraModel>>> Listar()
    {
        if (_context?.Desenvolvedoras is null)
            return NotFound();
        return await _context.Desenvolvedoras.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<DesenvolvedoraModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Desenvolvedoras is null)
            return NotFound();
        var desenvolvedora = await _context.Desenvolvedoras.FindAsync(id);
        if (desenvolvedora is null)
            return NotFound();
        return desenvolvedora;
    }

    [HttpPost]
    [Route("")]
    public IActionResult Inserir(DesenvolvedoraModel desenvolvedora)
    {
        _context?.Add(desenvolvedora);
        _context?.SaveChanges();
        return Created("", desenvolvedora);
    }
}