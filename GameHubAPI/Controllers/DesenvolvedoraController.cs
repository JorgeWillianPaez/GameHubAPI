using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/desenvolvedora")]
public class DesenvolvedoraController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public DesenvolvedoraController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("desenvolvedora/list")]
    public async Task<ActionResult<IEnumerable<DesenvolvedoraModel>>> List()
    {
        if (_context?.Desenvolvedora is null)
            return NotFound();
        return await _context.Desenvolvedora.ToListAsync();
    }

    [HttpGet()]
    [Route("desenvolvedora/find/{id}")]
    public async Task<ActionResult<DesenvolvedoraModel>> Find([FromRoute] string id)
    {
        if (_context?.Desenvolvedora is null)
            return NotFound();
        var desenvolvedora = await _context.Desenvolvedora.FindAsync(id);
        if (desenvolvedora is null)
            return NotFound();
        return desenvolvedora;
    }

    [HttpPost]
    [Route("desenvolvedora/create")]
    public IActionResult Create(DesenvolvedoraModel desenvolvedora)
    {
        _context?.Add(desenvolvedora);
        _context?.SaveChanges();
        return Created("", desenvolvedora);
    }
}