using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/categoria")]
public class CategoriaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public CategoriaController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("categoria/list")]
    public async Task<ActionResult<IEnumerable<CategoriaModel>>> List()
    {
        if (_context?.Categoria is null)
            return NotFound();
        return await _context.Categoria.ToListAsync();
    }

    [HttpGet()]
    [Route("categoria/find/{id}")]
    public async Task<ActionResult<CategoriaModel>> Find([FromRoute] string id)
    {
        if (_context?.Categoria is null)
            return NotFound();
        var categoria = await _context.Categoria.FindAsync(id);
        if (categoria is null)
            return NotFound();
        return categoria;
    }

    [HttpPost]
    [Route("categoria/create")]
    public IActionResult Create(CategoriaModel categoria)
    {
        _context?.Add(categoria);
        _context?.SaveChanges();
        return Created("", categoria);
    }
}