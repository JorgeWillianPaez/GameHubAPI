using GameHubAPI.Data;
using GameHubAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class UsuarioController : ControllerBase
{
    private GameHubAPIDbContext _context;
    public UsuarioController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Cadastrar(UsuarioModel usuario)
    {
        await _context.AddAsync(usuario);
        await _context.SaveChangesAsync();
        return Created("", usuario);
    }

    [HttpPut]
    [Route("")]
    public async Task<ActionResult> Alterar(UsuarioModel usuario)
    {
        _context.Usuario?.FindAsync(usuario);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<UsuarioModel>>> Listar()
    {
        if (_context.Usuario is null) return NotFound();
        return await _context.Usuario.ToListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<UsuarioModel>> Buscar(int id)
    {
        if (_context.Usuario is null) return NotFound();
        var usuario = await _context.Usuario.FindAsync(id);
        return usuario;
    }
}
