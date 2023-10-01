using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class PromocaoController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public PromocaoController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("list")]
    public async Task<ActionResult<IEnumerable<PromocaoModel>>> Listar()
    {
        if (_context?.Promocao is null)
            return NotFound();
        return await _context.Promocao.ToListAsync();
    }

    [HttpGet()]
    [Route("find/{id}")]
    public async Task<ActionResult<PromocaoModel>> Buscar([FromRoute] string id)
    {
        if (_context?.Promocao is null)
            return NotFound();
        var promocao = await _context.Promocao.FindAsync(id);
        if (promocao is null)
            return NotFound();
        return promocao;
    }

    [HttpPost]
    [Route("create")]
    public IActionResult Inserir(PromocaoModel promocao)
    {
        _context?.Add(promocao);
        _context?.SaveChanges();
        return Created("", promocao);
    }
}