using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class NoticiaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public NoticiaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<NoticiaModel>>> Listar()
    {
        if (_context?.Noticia is null)
            return NotFound();
        return await _context.Noticia.ToListAsync();
    }

    [HttpGet()]
    [Route("buscar/{id}")]
    public async Task<ActionResult<NoticiaModel>> Buscar([FromRoute] string id)
    {
        if (_context?.Noticia is null)
            return NotFound();
        var noticia = await _context.Noticia.FindAsync(id);
        if (noticia is null)
            return NotFound();
        return noticia;
    }

    [HttpPost]
    [Route("inserir")]
    public IActionResult Inserir(NoticiaModel noticia)
    {
        _context?.Add(noticia);
        _context?.SaveChanges();
        return Created("", noticia);
    }
}