using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/conquista")]
public class ConquistaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public ConquistaController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("conquista/list")]
    public async Task<ActionResult<IEnumerable<ConquistaModel>>> List()
    {
        if (_context?.Conquista is null)
            return NotFound();
        return await _context.Conquista.ToListAsync();
    }

    [HttpGet()]
    [Route("conquista/find/{id}")]
    public async Task<ActionResult<ConquistaModel>> Find([FromRoute] string id)
    {
        if (_context?.Conquista is null)
            return NotFound();
        var conquista = await _context.Conquista.FindAsync(id);
        if (conquista is null)
            return NotFound();
        return conquista;
    }

    [HttpPost]
    [Route("conquista/create")]
    public IActionResult Create(ConquistaModel conquista)
    {
        _context?.Add(conquista);
        _context?.SaveChanges();
        return Created("", conquista);
    }
}