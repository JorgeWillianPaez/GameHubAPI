using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class CategoriaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public CategoriaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<CategoriaModel>>> Listar()
    {
        if (_context?.Categoria is null)
            return NotFound();
        return await _context.Categoria.ToListAsync();
    }

    [HttpGet()]
    [Route("buscar/{id}")]
    public async Task<ActionResult<CategoriaModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Categoria is null)
            return NotFound();
        var categoria = await _context.Categoria.FindAsync(id);
        if (categoria is null)
            return NotFound();
        return categoria;
    }

    [HttpPost]
    [Route("inserir")]
    public IActionResult Inserir(CategoriaModel categoria)
    {
        _context?.Add(categoria);
        _context?.SaveChangesAsync();
        return Created("", categoria);
    }
}