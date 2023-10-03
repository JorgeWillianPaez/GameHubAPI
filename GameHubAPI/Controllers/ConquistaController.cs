using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class ConquistaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public ConquistaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<ConquistaModel>>> Listar()
    {
        if (_context?.Conquista is null)
            return NotFound();
        return await _context.Conquista.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<ConquistaModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Conquista is null)
            return NotFound();
        var conquista = await _context.Conquista.FindAsync(id);
        if (conquista is null)
            return NotFound();
        return conquista;
    }

    [HttpPost]
    [Route("")]
    public IActionResult Inserir(ConquistaModel conquista)
    {
        _context?.Add(conquista);
        _context?.SaveChanges();
        return Created("", conquista);
    }
}