using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class BibliotecaController : ControllerBase
{
    private GameHubAPIDbContext _context;
    public BibliotecaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpPost]
    [Route("inserir")]
    public async Task<ActionResult> Inserir(BibliotecaModel biblioteca)
    {
        await _context.AddAsync(biblioteca);
        await _context.SaveChangesAsync();
        return Created("", biblioteca);
    }

    [HttpPut]
    [Route("alterar")]
    public async Task<ActionResult> Alterar(BibliotecaModel biblioteca)
    {
        _context.Biblioteca?.FindAsync(biblioteca);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("excluir")]
    public async Task<ActionResult> Excluir(int id)
    {
        var biblioteca = _context.Biblioteca!.FindAsync(id);
        if(_context.Biblioteca is null) return NotFound();
        _context.Remove(biblioteca);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<BibliotecaModel>>> Listar()
    {
        if (_context.Biblioteca is null) return NotFound();
        return await _context.Biblioteca.ToListAsync();
    }


    [HttpGet]
    [Route("buscar/{id}")]
    public async Task<ActionResult<BibliotecaModel>> Buscar(int id)
    {
        if (_context.Biblioteca is null) return NotFound();
        var biblioteca = await _context.Biblioteca.FindAsync(id);
        return biblioteca!;
    }
}
