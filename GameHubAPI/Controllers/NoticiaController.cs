using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/noticia")]
public class NoticiaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public NoticiaController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("noticia/list")]
    public async Task<ActionResult<IEnumerable<NoticiaModel>>> List()
    {
        if (_context?.Noticia is null)
            return NotFound();
        return await _context.Noticia.ToListAsync();
    }

    [HttpGet()]
    [Route("noticia/find/{id}")]
    public async Task<ActionResult<NoticiaModel>> Find([FromRoute] string id)
    {
        if (_context?.Noticia is null)
            return NotFound();
        var noticia = await _context.Noticia.FindAsync(id);
        if (noticia is null)
            return NotFound();
        return noticia;
    }

    [HttpPost]
    [Route("noticia/create")]
    public IActionResult Create(NoticiaModel noticia)
    {
        _context?.Add(noticia);
        _context?.SaveChanges();
        return Created("", noticia);
    }
}